using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace HullMaintenance
{
    public partial class MainForm : MetroForm
    {
        #region Members
        #endregion

        #region Properties
		public string ConnString { get; private set; }
        public string OptionPath { get; private set; }
        public DataTable StdDt { get; private set; }
        public DataTable SmhDt { get; private set; }
        public Dictionary<string, DataTable> DtDic { get; private set; }
		public string StdTableName { get; private set; }
		public string SmhTableName { get; private set; }
        public int ThemeIdx { get; private set; }
        public int StyleIdx { get; private set; }
        public string SearchColumns { get; private set; }
        public string StaticSearchQuery { get; private set; }
        public string DynamicSearchQuery { get; private set; }
        public Dictionary<string, string> StatusColorDic { get; private set; }
        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        #region Method
        /// <summary>
        /// Check the deadline.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="module"></param>
        private void CheckDueDateCell(DataGridViewRow row, string module)
        {
            DateTime dateTime;
            bool isUpdate = false;
            double days;

            DataGridViewCell statusCell = row.Cells[String.Format("{0}ColStatus", module)];
            DataGridViewCell dueDateCell = row.Cells[String.Format("{0}ColDueDate", module)];
            DataGridViewCell updateDateCell = row.Cells[String.Format("{0}ColUpdateDate", module)];

            if (DateTime.TryParse(updateDateCell.Value.ToString(), out dateTime))
            {
                isUpdate = true;
            }
            else
            {
                isUpdate = false;
            }

            if (DateTime.TryParse(dueDateCell.Value.ToString(), out dateTime) == false || isUpdate == true ||
                (statusCell.Value.ToString() != "" && row.Cells[String.Format("{0}ColStatus", module)].Value.ToString() != "진행중"))
            {
                return;
            }

            try
            {
                // due_date가 현재보다 미래
                if (DateTime.Now.CompareTo(dateTime) == -1)
                {
                    days = Math.Truncate((dateTime - DateTime.Now).TotalDays);

                    if (days <= 7 && days > 3)      // 7일 이내
                    {
                        dueDateCell.Style.BackColor = ColorTranslator.FromHtml(this.ui_tbColorD7.Text);
                        dueDateCell.Style.ForeColor = Color.White;
                    }
                    else if (days <= 3 && days > 1) // 3일 이내
                    {
                        dueDateCell.Style.BackColor = ColorTranslator.FromHtml(this.ui_tbColorD3.Text);
                        dueDateCell.Style.ForeColor = Color.White;
                    }
                    else if (days <= 1)             // 1일 남음
                    {
                        dueDateCell.Style.BackColor = ColorTranslator.FromHtml(this.ui_tbColorD1.Text);
                        dueDateCell.Style.ForeColor = Color.White;
                    }
                }
                else
                {
                    // 납기일 초과
                    dueDateCell.Style.BackColor = ColorTranslator.FromHtml(this.ui_tbColorD1.Text);
                    dueDateCell.Style.ForeColor = Color.White;
                }
            }
            catch (Exception ex)
            {
            }
        }

        /// <summary>
        /// Check th status.
        /// </summary>
        /// <param name="row"></param>
        /// <param name="module"></param>
        private void CheckStatusCell(DataGridViewRow row, string module)
        {
            DateTime dateTime;

            DataGridViewCell statusCell = row.Cells[String.Format("{0}ColStatus", module)];
            DataGridViewCell endDateCell = row.Cells[String.Format("{0}ColEndDate", module)];
            DataGridViewCell verifyDateCell = row.Cells[String.Format("{0}ColVerificationDate", module)];
            DataGridViewCell updateDateCell = row.Cells[String.Format("{0}ColUpdateDate", module)];

            try
            {
                if (StatusColorDic.ContainsKey(statusCell.Value.ToString()) == true)
                {
                    string status = statusCell.Value.ToString();

                    if (status == "진행중" || status == "보류" || status == "대기" || status == "처리불가" || status == "취소")
                    {
                        statusCell.Style.BackColor = ColorTranslator.FromHtml(StatusColorDic[statusCell.Value.ToString()]);

                        if (status == "처리불가" || status == "취소")
                        {
                            statusCell.Style.ForeColor = Color.White;
                        }
                    }
                    else if (status == "처리완료" && DateTime.TryParse(endDateCell.Value.ToString(), out dateTime) == true)
                    {
                        statusCell.Style.BackColor = ColorTranslator.FromHtml(StatusColorDic[statusCell.Value.ToString()]);
                    }
                    else if (status == "부분완료" && DateTime.TryParse(updateDateCell.Value.ToString(), out dateTime) == true)
                    {
                        statusCell.Style.BackColor = ColorTranslator.FromHtml(StatusColorDic[statusCell.Value.ToString()]);
                    }
                    else if (status == "완료" && DateTime.TryParse(updateDateCell.Value.ToString(), out dateTime) == true)
                    {
                        statusCell.Style.BackColor = ColorTranslator.FromHtml(StatusColorDic[statusCell.Value.ToString()]);
                    }
                    else if ((status == "처리완료" && DateTime.TryParse(endDateCell.Value.ToString(), out dateTime) == false) ||
                             (status == "부분완료" && DateTime.TryParse(updateDateCell.Value.ToString(), out dateTime) == false) ||
                             (status == "완료" && DateTime.TryParse(updateDateCell.Value.ToString(), out dateTime) == false) ||
                             (status == "업데이트" && DateTime.TryParse(verifyDateCell.Value.ToString(), out dateTime) == false))
                    {
                        statusCell.Style.BackColor = ColorTranslator.FromHtml(StatusColorDic["오류"]);
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        /// <summary>
        /// Load INI & Initialize
        /// </summary>
        private void LoadINI()
        {
            string iniPath = String.Format(@"D:\HullMaintenance.ini");

            if (File.Exists(iniPath) == false)
            {
                iniPath = String.Format(@"{0}\HullMaintenance.ini", Environment.CurrentDirectory);
            }

            this.OptionPath = iniPath;

            INIHelper iniHelper = new INIHelper(iniPath);

            this.ui_tbDbServer.Text = iniHelper.GetPrivateProfileString("Database", "Server", "localhost");
            this.ui_tbDbId.Text = iniHelper.GetPrivateProfileString("Database", "LoginId", "");
            this.ui_tbDbPw.Text = iniHelper.GetPrivateProfileString("Database", "LoginPw", "");
            this.ui_tbDbName.Text = iniHelper.GetPrivateProfileString("Database", "DBName", "");
            this.StdTableName = iniHelper.GetPrivateProfileString("Database", "StdTableName", "");
            this.SmhTableName = iniHelper.GetPrivateProfileString("Database", "SmhTableName", "");
            this.ui_tbSmhDocPath.Text = iniHelper.GetPrivateProfileString("FilePath", "SmhDocPath", "");
            this.ui_tbSmhSamplePath.Text = iniHelper.GetPrivateProfileString("FilePath", "SmhSamplePath", "");
            this.ui_tbStdDocPath.Text = iniHelper.GetPrivateProfileString("FilePath", "StdDocPath", "");
            this.ui_tbStdSamplePath.Text = iniHelper.GetPrivateProfileString("FilePath", "StdSamplePath", "");
            this.ui_styleMgr.Theme = (MetroThemeStyle)int.Parse(iniHelper.GetPrivateProfileString("Design", "StartThemeIdx", "1"));
            this.ui_styleMgr.Style = (MetroColorStyle)int.Parse(iniHelper.GetPrivateProfileString("Design", "StartStyleIdx", "7"));
            this.ui_tbColorWorking.Text = String.Format("#{0}", iniHelper.GetPrivateProfileString("ColorCode", "Working", ""));
            this.ui_tbColorWorkDone.Text = String.Format("#{0}", iniHelper.GetPrivateProfileString("ColorCode", "WorkDone", ""));
            this.ui_tbColorPartialDone.Text = String.Format("#{0}", iniHelper.GetPrivateProfileString("ColorCode", "PartialDone", ""));
            this.ui_tbColorComplete.Text = String.Format("#{0}", iniHelper.GetPrivateProfileString("ColorCode", "Complete", ""));
            this.ui_tbColorPending.Text = String.Format("#{0}", iniHelper.GetPrivateProfileString("ColorCode", "Pending", ""));
            this.ui_tbColorError.Text = String.Format("#{0}", iniHelper.GetPrivateProfileString("ColorCode", "Error", ""));
            this.ui_tbColorCancel.Text = String.Format("#{0}", iniHelper.GetPrivateProfileString("ColorCode", "Cancel", ""));
            this.ui_tbColorImpossible.Text = String.Format("#{0}", iniHelper.GetPrivateProfileString("ColorCode", "Impossible", ""));
            this.ui_tbColorD1.Text = String.Format("#{0}", iniHelper.GetPrivateProfileString("ColorCode", "D-1", ""));
            this.ui_tbColorD3.Text = String.Format("#{0}", iniHelper.GetPrivateProfileString("ColorCode", "D-3", ""));
            this.ui_tbColorD7.Text = String.Format("#{0}", iniHelper.GetPrivateProfileString("ColorCode", "D-7", ""));

            this.SearchColumns = iniHelper.GetPrivateProfileString("Search", "Columns", "summary_kr,document_file");
            this.StaticSearchQuery = CreateSearchQuery(this.SearchColumns);
            this.DynamicSearchQuery = "summary_kr LIKE '%{0}%' OR document_name LIKE '%{0}%'";

            StatusColorDic = new Dictionary<string, string>();
            StatusColorDic.Add("진행중", this.ui_tbColorWorking.Text);
            StatusColorDic.Add("처리완료", this.ui_tbColorWorkDone.Text);
            StatusColorDic.Add("부분완료", this.ui_tbColorPartialDone.Text);
            StatusColorDic.Add("완료", this.ui_tbColorComplete.Text);
            StatusColorDic.Add("보류", this.ui_tbColorPending.Text);
            StatusColorDic.Add("대기", this.ui_tbColorPending.Text);
            StatusColorDic.Add("오류", this.ui_tbColorError.Text);
            StatusColorDic.Add("취소", this.ui_tbColorCancel.Text);
            StatusColorDic.Add("처리불가", this.ui_tbColorImpossible.Text);
        }

        /// <summary>
        /// Create Query for Searching
        /// </summary>
        /// <param name="columns"></param>
        /// <returns></returns>
        private string CreateSearchQuery(string columns)
        {
            StringBuilder builder = new StringBuilder();

            string[] splitColumns = columns.Trim().Split(',');

            for (int i = 0; i < splitColumns.Length; i++)
            {
                string column = splitColumns[i];
                column = column.Replace("document_file", "document_name");
                builder.Append(String.Format("{0} LIKE '%{1}%'", column, "{0}"));

                if (i < splitColumns.Length - 1)
                {
                    builder.Append(" OR ");
                }
            }

            return builder.ToString();
        }

        /// <summary>
        /// Create DB Connection String
        /// </summary>
        /// <returns></returns>
        private string GetDatabaseConnection()
        {
            string connString = DbHelper.CreateDatabaseConnection(this.ui_tbDbServer.Text, this.ui_tbDbName.Text, this.ui_tbDbId.Text, this.ui_tbDbPw.Text);

            return connString;
        }

        /// <summary>
        /// Get Filtered DataTable
        /// </summary>
        /// <param name="tag">Controls Tag</param>
        /// <param name="tempDt">Reference DataTable</param>
        /// <returns>MetroGrid</returns>
        private MetroGrid GetDataTable(string tag, ref DataTable tempDt)
        {
            ComboBox customerBox;
            ComboBox subConditionBox;
            MetroGrid grid;
            DataTable dt;
            string colName = "";

            if (tag.ToLower().Contains("std") == true)
            {
                grid = ui_gridStd;
                customerBox = ui_cbStdCustomer;
                subConditionBox = ui_cbStdPeriod;
                dt = this.StdDt;
                colName = "receive_date";
            }
            else
            {
                grid = ui_gridSmh;
                customerBox = ui_cbSmhCustomer;
                subConditionBox = ui_cbSmhSite;
                dt = this.SmhDt;
                colName = "site";
            }

            string customer = customerBox.Text;
            string subCondition = subConditionBox.Text;

            tempDt = dt.Copy();

            try
            {
                if (customer.Contains("ALL") == false)
                {
                    tempDt = tempDt.Select(String.Format("customer = '{0}'", customer)).CopyToDataTable();
                }

                if (subCondition.Contains("ALL") == false)
                {
                    if (colName == "site")
                    {
                        tempDt = tempDt.Select().Where(x => x[colName].ToString().Equals(subCondition)).CopyToDataTable();
                    }
                    else if (colName == "receive_date")
                    {
                        tempDt = tempDt.Select().Where(x => x[colName].ToString().StartsWith(subCondition)).CopyToDataTable();
                    }
                }
            }
            catch (Exception ex)
            {
                tempDt.Rows.Clear();
            }

            return grid;
        }

        /// <summary>
        /// Load Customer List from DataTable - Std 전용
        /// </summary>
        /// <param name="combo"></param>
        /// <param name="dt"></param>
        /// <param name="customer"></param>
        private void LoadConditionList(ComboBox cbCustmer, DataTable dt)
        {
            if (dt.Rows.Count > 0)
            {
                List<string> customerList = dt.Select().Select(x => x["customer"]).Cast<string>().Distinct().ToList();

                customerList = customerList.OrderByDescending(x => x).ToList();

                customerList.ForEach(x => cbCustmer.Items.Add(x));
            }

            cbCustmer.Items.Insert(0, "ALL Customer");

            cbCustmer.SelectedIndex = 0;
        }

        /// <summary>
        /// Load Customer List from DataTable - Smh 전용
        /// </summary>
        /// <param name="cbCustmer"></param>
        /// <param name="cbPeriod"></param>
        /// <param name="dtDic"></param>
        /// <param name="customer"></param>
        private void LoadCustomerList(ComboBox cbCustmer, Dictionary<string, DataTable> dtDic, string customer)
        {
            foreach (string tableName in dtDic.Keys)
            {
                cbCustmer.Items.Add(tableName);
            }

            DataTable dt = dtDic[this.SmhTableName];

            if (cbCustmer.Items.Contains(customer) == true)
            {
                cbCustmer.SelectedItem = customer;
            }
            else
            {
                cbCustmer.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Load DataTable Into Grid
        /// </summary>
        private void LoadGridDataTable(MetroGrid grid, DataTable dt)
        {
            if (dt.Rows.Count > 0)
            {
                grid.DataSource = dt.DefaultView.ToTable(false, new string[] { "id", "customer", "type", "status", "summary_kr",
                                                                               "receive_date", "due_date", "start_date", "end_date",
                                                                               "verification_date", "update_date", "document_name" }).Select().CopyToDataTable();
            }

            #region Test
            //dt = this.DtSmartHull.DefaultView.ToTable(false, new string[] { colId.DataPropertyName, colType.DataPropertyName, colStatus.DataPropertyName, colSummaryKr.DataPropertyName, colDueDate.DataPropertyName, colUpdateDate.DataPropertyName, colDocumentLink.DataPropertyName, colCustomer.DataPropertyName }).Select("customer = '이마바리'").CopyToDataTable();
            //var querySpisIma = (from dt in this.DataTableAll.AsEnumerable()
            //                   where dt.Field<string>("customer") == "이마바리"
            //                   select new
            //                   {
            //                       id = dt.Field<int>("id"),
            //                       type = dt.Field<string>("type"),
            //                       status = dt.Field<string>("status"),
            //                       summary_kr = dt.Field<string>("summary_kr"),
            //                       due_date = dt.Field<Nullable<DateTime>>("due_date"),
            //                       update_date = dt.Field<Nullable<DateTime>>("update_date"),
            //                       document_name = dt.Field<string>("document_name")
            //                   }).ToList();
            //metroGrid1.DataSource = querySpisIma;
            #endregion
        }

        /// <summary>
        /// Initialize After Load
        /// </summary>
        private void AfterLoad()
        {
            // size of TabControl's tabs
            //metroTabControl.ItemSize = new Size(
            //metroTabControl.Width / metroTabControl.TabPages.Count - 1,
            //metroTabControl.ItemSize.Height);

            Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            ui_lbMainVersion.Text = String.Format("version={0}", version.ToString());

            string dbInfo = String.Format("Database : {0}\tServer: {1}\tLogin ID : {2}", DbHelper.DbName, DbHelper.DbServer, DbHelper.DbUserId);
            ui_lbBottomInfo.Text = String.Format("Option Path : {0}\t{1}", this.OptionPath, dbInfo).Replace("\t", "   ");

            FileInfo fi = new FileInfo(String.Format(@"{0}\HullMaintenance.ini", Environment.CurrentDirectory));

            if (fi.Exists)
            {
                fi.CopyTo(String.Format(@"{0}\HullMaintenance.ini.bak", fi.DirectoryName), true);
            }

            File.Copy(this.OptionPath, String.Format(@"{0}\HullMaintenance.ini", Environment.CurrentDirectory), true);
#if DEBUG

#else
            ui_tabControl.Controls.RemoveByKey(stdPage.Name);
#endif
        }

        /// <summary>
        /// Open linked document file
        /// </summary>
        /// <param name="gridName"></param>
        /// <param name="fileName"></param>
        /// <param name="idx"></param>
        private void OpenLinkedDocument(string gridName, string fileName, int idx)
        {
            if (idx == 0)
            {
                return;
            }

            DataTable dt;
            string filePath = "";

            if (gridName.ToLower().Contains("smh") == true)
            {
                dt = this.SmhDt;
                filePath = ui_tbSmhDocPath.Text;
            }
            else
            {
                dt = this.StdDt;
                filePath = ui_tbStdDocPath.Text;
            }

            DataRow row = dt.Select().Where(x => x["id"].ToString().Equals(idx.ToString()) == true).FirstOrDefault();

            if (row == null)
            {
                return;
            }

            string fileFullPath = String.Format(@"{0}\{1}", filePath, row["document_file"]).ToString();

            try
            {
                FileInfo fi = new FileInfo(fileFullPath);

                if (fi.Exists == true)
                {
                    Process.Start(fileFullPath);
                }
                else
                {
                    MetroMessageBox.Show(this, "", "File doesn't exist.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Error Opening File", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Excel 파일 읽기
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="worksheetName"></param>
        /// <param name="HeaderLine"></param>
        /// <param name="ColumnStart"></param>
        /// <returns></returns>
        public DataTable ReadExcelToDatatble(string filePath, string worksheetName, int HeaderLine, int ColumnStart, object obj = null)
        {
            BackgroundWorker worker = obj as BackgroundWorker;
            DataTable dataTable = new DataTable();
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook excelworkBook;
            Microsoft.Office.Interop.Excel.Worksheet excelSheet;
            Microsoft.Office.Interop.Excel.Range range;

            try
            {
                // Get Application object.
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;

                // Creation a new Workbook
                excelworkBook = excel.Workbooks.Open(filePath);

                // Workk sheet
                excelSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelworkBook.Worksheets.Item[worksheetName];
                range = excelSheet.UsedRange;

                int colCount = range.Columns.Count;
                // loop through each row and add values to our sheet
                int rowCount = range.Rows.Count; ;

                //create the header of table
                for (int j = ColumnStart; j <= colCount; j++)
                {
                    dataTable.Columns.Add(Convert.ToString(range.Cells[HeaderLine, j].Value), typeof(string));
                }

                //filling the table from excel file
                for (int i = HeaderLine + 1; i <= rowCount; i++)
                {
                    DataRow dr = dataTable.NewRow();

                    for (int j = ColumnStart; j <= colCount; j++)
                    {
                        if (j > 3 && j < 10)
                        {
                            string strVal = Convert.ToString(range.Cells[i, j].Value2);
                            double doubleVal;

                            if (Double.TryParse(strVal, out doubleVal) == true)
                            {
                                DateTime dateTime = DateTime.FromOADate(doubleVal);
                                dr[j - ColumnStart] = dateTime.ToString("yyyy-MM-dd");
                            }
                        }
                        else
                        {
                            dr[j - ColumnStart] = Convert.ToString(range.Cells[i, j].Value2);
                        }
                    }

                    double percent = (double)i / (double)rowCount * 100.0;
                    worker.ReportProgress((int)percent, String.Format("{0} / {1}", i, rowCount));

                    dataTable.Rows.InsertAt(dr, dataTable.Rows.Count + 1);
                }

                //now close the workbook and make the function return the data table
                excelworkBook.Close();
                excel.Quit();

                return dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                excelSheet = null;
                range = null;
                excelworkBook = null;
            }
        }
        #endregion

        #region Event
        private void OnLoadMainForm(object sender, EventArgs e)
        {
            LoadINI();

            GetDatabaseConnection();

            // DB 테이블 목록 가져오기
            List<string> tableList = DbHelper.GetTableListFromDB();

            if (tableList.Contains(this.StdTableName) == true)
            {
                tableList.Remove(this.StdTableName);
            }

            // 테이블 딕셔너리
            this.DtDic = DbHelper.GetDataTableDictionary(tableList);

            if (this.DtDic.ContainsKey(this.SmhTableName))
            {
                this.SmhDt = DtDic[this.SmhTableName];
            }
            else
            {
                this.SmhDt = new DataTable();
            }

            this.StdDt = DbHelper.GetDataTableFromDB(this.StdTableName);

            LoadGridDataTable(this.ui_gridSmh, this.SmhDt);
            LoadCustomerList(this.ui_cbSmhCustomer, this.DtDic, this.SmhTableName);

            LoadGridDataTable(this.ui_gridStd, this.StdDt);
            LoadConditionList(this.ui_cbStdCustomer, this.StdDt);

            AfterLoad();
        }

        private void OnUpdateMainForm(object sender, EventArgs e)
        {
            TabPage page = ui_tabControl.SelectedTab;
            if (String.IsNullOrWhiteSpace(page.Tag.ToString()))
            {
                return;
            }
            MetroGrid grid;
            DataTable dt;
            ComboBox cbBox;

            if (page.Tag.ToString().Contains("smart") == true)
            {
                grid = ui_gridSmh;
                cbBox = ui_cbSmhCustomer;

                List<string> tableList = DbHelper.GetTableListFromDB();

                if (tableList.Contains(this.StdTableName) == true)
                {
                    tableList.Remove(this.StdTableName);
                }

                this.DtDic = DbHelper.GetDataTableDictionary(tableList);

                if (this.DtDic.ContainsKey(this.SmhTableName))
                {
                    this.SmhDt = DtDic[this.SmhTableName];
                }
                else
                {
                    this.SmhDt = new DataTable();
                }

                dt = this.SmhDt;
            }
            else
            {
                grid = ui_gridStd;
                cbBox = ui_cbStdCustomer;
                this.StdDt = DbHelper.GetDataTableFromDB(this.StdTableName);
                dt = this.StdDt;
            }

            string module = grid.Name.ToLower().Contains("std") == true ? "std" : "smh";

            LoadGridDataTable(grid, dt);

            if (module == "smh")
            {
                OnCustomerSelectedValueChanged(cbBox, null);
            }
            else
            {
                OnConditionSelectedValueChanged(cbBox, null);
            }

            DataGridViewRow row = grid.Rows.Cast<DataGridViewRow>()
                                  .Where(r => r.Cells[String.Format("{0}ColId", module)].Value.ToString().Equals((sender as DetailForm).Index.ToString()))
                                  .FirstOrDefault();

            int focusIndex = 0;

            if (row != null)
            {
                focusIndex = row.Index;
            }

            grid.Rows[focusIndex].Selected = true;
            grid.FirstDisplayedScrollingRowIndex = focusIndex;
        }

        private void OnGridDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            MetroGrid grid = sender as MetroGrid;
            string module = grid.Name.ToLower().Contains("std") == true ? "std" : "smh";

            foreach (DataGridViewRow row in grid.Rows)
            {
                grid.Rows[row.Index].HeaderCell.Value = (row.Index + 1).ToString();

                CheckDueDateCell(row, module);

                CheckStatusCell(row, module);
            }
        }

        private void OnClickBtnConnect(object sender, EventArgs e)
        {
            string result = "Wait...";

            string connString = String.Format(@"Data Source={0}; Initial Catalog={1}; User ID={2}; Password={3}; Persist Security Info=True;",
                                               this.ui_tbDbServer.Text, this.ui_tbDbName.Text, this.ui_tbDbId.Text, this.ui_tbDbPw.Text);

            string query = "SELECT * FROM spis ORDER BY id DESC";
            try
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter();
                    SqlCommand scm = new SqlCommand(query, conn);
                    scm.CommandTimeout = 5;	// Default = 30s
                    //SqlDataReader adr = scm.ExecuteReader();
                }
                result = "OK!";
            }
            catch (Exception ex)
            {
                result = "Failed!";
            }
            finally
            {
                this.ui_lbDBStatus.Text = result;
            }
        }

        private void OnClickBtnPath(object sender, EventArgs e)
        {
            MetroButton mBtn = sender as MetroButton;

            string tag = mBtn.Tag.ToString();
            MetroTextBox tbPath = this.settingPage.Controls.Find(tag, true).FirstOrDefault() as MetroTextBox;

            FolderBrowserDialog folderDialog = new FolderBrowserDialog();

            if (tbPath != null && Directory.Exists(tbPath.Text) == true)
            {
                folderDialog.SelectedPath = tbPath.Text;
            }

            if (folderDialog.ShowDialog(this) == DialogResult.OK)
            {
                tbPath.Text = folderDialog.SelectedPath;
            }
        }

        private void OnClickBtnPathOpen(object sender, EventArgs e)
        {
            MetroButton mBtn = sender as MetroButton;

            string tag = mBtn.Tag.ToString();
            MetroTextBox tbPath = this.settingPage.Controls.Find(tag, true).FirstOrDefault() as MetroTextBox;

            if (tbPath != null && Directory.Exists(tbPath.Text) == true)
            {
                Process.Start(tbPath.Text);
            }
        }

        private void OnClickBtnTheme(object sender, EventArgs e)
        {
            ui_styleMgr.Theme = ui_styleMgr.Theme == MetroThemeStyle.Light ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
        }

        private void OnClickBtnStyle(object sender, EventArgs e)
        {
            var rnd = new Random();
            int next = rnd.Next(0, 13);
            ui_styleMgr.Style = (MetroColorStyle)next;
        }

        private void OnClickBtnSearchTextClear(object sender, EventArgs e)
		{
			Button mBtn = sender as Button;
			string tag = mBtn.Tag.ToString();
			ComboBox cbox = mBtn.Parent.Controls.Find(tag, true).FirstOrDefault() as ComboBox;
			cbox.Text = "";
		}

        private void OnClickBtnSearchHistoryClear(object sender, EventArgs e)
        {
            MetroButton mBtn = sender as MetroButton;
            string tag = mBtn.Tag.ToString();
            ComboBox cbox = mBtn.Parent.Controls.Find(tag, true).FirstOrDefault() as ComboBox;
            cbox.Text = "";
            cbox.Items.Clear();
        }

        private void OnSeachTextChanged(object sender, EventArgs e)
        {
            ComboBox cBox = sender as ComboBox;
            string searchText = cBox.Text;

            if (cBox.Tag.ToString().ToLower().Contains("std") == true)
            {
                (ui_gridStd.DataSource as DataTable).DefaultView.RowFilter = String.Format(this.DynamicSearchQuery, searchText);
            }
            else
            {
                (ui_gridSmh.DataSource as DataTable).DefaultView.RowFilter = String.Format(this.DynamicSearchQuery, searchText);
            }
        }

        private void OnSearchTexKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ComboBox cBox = sender as ComboBox;
                string searchText = cBox.Text;

                if (String.IsNullOrWhiteSpace(searchText) == false)
                {
                    if (cBox.Items.Contains(searchText) == false)
                    {
                        cBox.Items.Add(searchText);
                    }

                    DataTable tempDt = new DataTable();
                    MetroGrid grid = GetDataTable(cBox.Tag.ToString(), ref tempDt);

                    List<string> idxList = new List<string>();

                    if (String.IsNullOrEmpty(searchText) == false)
                    {
                        foreach (string column in this.SearchColumns.Trim().Split(','))
                        {
                            foreach (DataRow dr in tempDt.Rows)
                            {
                                if (dr[column].ToString().ToLower().Contains(searchText.ToLower()) == true)
                                {
                                    if (idxList.Contains(dr["id"].ToString()) == false)
                                    {
                                        idxList.Add(dr["id"].ToString());
                                    }
                                }
                            }
                        }
                    }

                    if (idxList.Count > 0)
                    {
                        (grid.DataSource as DataTable).DefaultView.RowFilter = String.Format("id IN ({0})", String.Join(",", idxList));
                    }
                    else
                    {
                        (grid.DataSource as DataTable).DefaultView.RowFilter = String.Format("id = -1");
                    }
                }
            }
        }

        private void OnClickBtnSearch(object sender, EventArgs e)
        {
            MetroButton mBtn = sender as MetroButton;
            string tag = mBtn.Tag.ToString();
            ComboBox cBox = mBtn.Parent.Controls.Find(tag, true).FirstOrDefault() as ComboBox;
            string searchText = cBox.Text;

            if (String.IsNullOrWhiteSpace(searchText) == false)
            {
                if (cBox.Items.Contains(searchText) == false)
                {
                    cBox.Items.Add(searchText);
                }

                DataTable tempDt = new DataTable();
                MetroGrid grid = GetDataTable(cBox.Tag.ToString(), ref tempDt);

                List<string> idxList = new List<string>();

                if (String.IsNullOrEmpty(searchText) == false)
                {
                    foreach (string column in this.SearchColumns.Trim().Split(','))
                    {
                        foreach (DataRow dr in tempDt.Rows)
                        {
                            if (dr[column].ToString().ToLower().Contains(searchText.ToLower()) == true)
                            {
                                if (idxList.Contains(dr["id"].ToString()) == false)
                                {
                                    idxList.Add(dr["id"].ToString());
                                }
                            }
                        }
                    }
                }

                if (idxList.Count > 0)
                {
                    (grid.DataSource as DataTable).DefaultView.RowFilter = String.Format("id IN ({0})", String.Join(",", idxList));
                }
                else
                {
                    (grid.DataSource as DataTable).DefaultView.RowFilter = String.Format("id = -1");
                }
            }
        }

        private void OnClickBtnCellContent(object sender, DataGridViewCellEventArgs e)
        {
            MetroGrid grid = sender as MetroGrid;

            if (grid.Columns[e.ColumnIndex] is DataGridViewLinkColumn && e.RowIndex != -1)
            {
                string fileName = grid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                if (String.IsNullOrEmpty(fileName) == false)
                {
                    //int rowId = grid.SelectedCells[0].RowIndex;
                    int id = 0;
                    if (grid.SelectedCells[1].Value != null)
                    {
                        id = (int)grid.SelectedCells[1].Value;
                        OpenLinkedDocument(grid.Name.ToString(), fileName, id);
                    }
                }
            }
        }

        private void OnClickBtnAddItem(object sender, EventArgs e)
        {
            MetroButton mBtn = sender as MetroButton;
            ComboBox cBox = null;
            DataTable dt;
            string docPath = "";

            if (mBtn.Tag.ToString().ToLower().Contains("std") == true)
            {
                dt = this.StdDt;
                cBox = ui_cbStdCustomer;
                docPath = ui_tbStdDocPath.Text;
            }
            else
            {
                dt = this.SmhDt;
                cBox = ui_cbSmhCustomer;
                docPath = ui_tbSmhDocPath.Text;
            }

            foreach (Form form in Application.OpenForms)
            {
                // 열려 있는 폼이 있을때
                if (form.GetType() == typeof(DetailForm))
                {
                    form.Close();
                    break;
                }
            }

            DetailForm view = new DetailForm(dt);
            view.Index = 0;
            view.Customer = cBox.Text.Contains("ALL") ? "ALL" : cBox.Text;
            view.DocPath = docPath;
            view.StartPosition = FormStartPosition.CenterParent;
            view.MdiChildActivate += OnUpdateMainForm;
            view.Show();
        }

        private void OnGridCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            MetroGrid grid = sender as MetroGrid;
            DataGridViewRow row = grid.Rows[e.RowIndex];
            DataGridViewCellCollection cells = grid.Rows[e.RowIndex].Cells;
            DataTable dt;
            int id = 0;
            string customer = "";
            string docPath = "";

            if (grid.Name.ToString().ToLower().Contains("std") == true)
            {
                dt = this.StdDt;
                id = Convert.ToInt32(cells["stdColId"].Value.ToString());
                customer = cells["stdColCustomer"].Value.ToString();
                docPath = ui_tbStdDocPath.Text;
            }
            else
            {
                dt = this.SmhDt;
                id = Convert.ToInt32(cells["smhColId"].Value.ToString());
                customer = cells["smhColCustomer"].Value.ToString();
                docPath = ui_tbSmhDocPath.Text;
            }

            foreach (Form form in Application.OpenForms)
            {
                // 열려 있는 폼이 있을때
                if (form.GetType() == typeof(DetailForm))
                {
                    form.Close();
                    break;
                }
            }

            DetailForm view = new DetailForm(dt);
            view.RowIndex = e.RowIndex;
            view.Index = Convert.ToInt32(id.ToString());
            view.Customer = customer.Contains("ALL") ? "ALL" : customer;
            view.DocPath = docPath;
            view.StartPosition = FormStartPosition.CenterParent;
            view.MdiChildActivate += OnUpdateMainForm;
            view.Show();
        }

        private void OnTabControlSelectedIndexChanged(object sender, EventArgs e)
        {
            TabControl tabControl = sender as TabControl;
            TabPage tabPage = tabControl.SelectedTab;

            string dbInfo = String.Format("Database : {0}\tServer: {1}\tLogin ID : {2}", DbHelper.DbName, DbHelper.DbServer, DbHelper.DbUserId);

            if (tabPage.Name.Contains("smh") == true)
            {
                ui_lbBottomInfo.Text = String.Format("Option Path : {0}\t{1}\tTableName : {2}", this.OptionPath, dbInfo, this.SmhTableName).Replace("\t", "   ");
            }
            else if (tabPage.Name.Contains("std") == true)
            {
                ui_lbBottomInfo.Text = String.Format("Option Path : {0}\t{1}\tTableName : {2}", this.OptionPath, dbInfo, this.StdTableName).Replace("\t", "   ");
            }
            else
            {
                ui_lbBottomInfo.Text = String.Format("Option Path : {0}\t{1}", this.OptionPath, dbInfo).Replace("\t", "   ");
            }
        }

        private void OnColorCodeTextChanged(object sender, EventArgs e)
        {
            MetroTextBox mtb = sender as MetroTextBox;

            try
            {
                mtb.BackColor = ColorTranslator.FromHtml(mtb.Text);
            }
            catch (Exception ex) { }
        }

        private void OnTabControlKeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control && e.KeyCode == Keys.F)
			{
				if (ui_tabControl.SelectedIndex == 0)
				{
					if (ui_panelSmhCollapsible.Visible == false)
					{
						ui_panelSmhCollapsible.Visible = true;
					}
					else
					{
						ui_panelSmhCollapsible.Visible = false;
					}
				}
				else if (ui_tabControl.SelectedIndex == 1)
				{
					if (ui_panelStdCollapsible.Visible == false)
					{
						ui_panelStdCollapsible.Visible = true;
					}
					else
					{
						ui_panelStdCollapsible.Visible = false;
					}
				}
			}
		}

        private void OnMouseEnter(object sender, EventArgs e)
        {
            if (Application.OpenForms.Cast<object>().ToList().Any(x => x.GetType() == typeof(DetailForm)) == false)
            {
                this.Activate();
            }
        }

        private void OnCustomerSelectedValueChanged(object sender, EventArgs e)
        {
            DataTable filteredDt = new DataTable();

            string customer = ui_cbSmhCustomer.Text;
            this.SmhTableName = customer;

            this.SmhDt = this.DtDic[customer];
            filteredDt = this.SmhDt.Copy();

            ui_cbSmhSite.Items.Clear();
            ui_cbSmhSite.Items.Insert(0, "ALL Site");

            if (filteredDt.Rows.Count > 0)
            {
                List<string> siteList = filteredDt.Select().Select(x => x["site"]).Cast<string>().Distinct().ToList();
                siteList = siteList.OrderByDescending(x => x).ToList();
                siteList.ForEach(x => ui_cbSmhSite.Items.Add(x));

                filteredDt = filteredDt.Select("", "id DESC").CopyToDataTable();

                ui_gridSmh.DataSource = filteredDt.DefaultView.ToTable(false, new string[] { "id", "customer", "type", "status", "summary_kr",
                                                                                       "receive_date", "due_date", "start_date", "end_date",
                                                                                       "verification_date", "update_date", "document_name" }).Select().CopyToDataTable();
            }
            else if (ui_gridSmh.DataSource != null)
            {
                (ui_gridSmh.DataSource as DataTable).Clear();
            }

            ui_cbSmhSite.SelectedIndex = 0;
        }

        private void OnConditionSelectedValueChanged(object sender, EventArgs e)
        {
            DataTable filteredDt = new DataTable();

            string customer = ui_cbStdCustomer.Text;
            filteredDt = this.StdDt.Copy();

            if (customer.Contains("ALL") == false)
            {
                if (filteredDt.Select(String.Format("customer = '{0}'", customer)).Count() != 0)
                {
                    filteredDt = filteredDt.Select(String.Format("customer = '{0}'", customer)).CopyToDataTable();
                }
            }

            ui_cbStdPeriod.Items.Clear();
            ui_cbStdPeriod.Items.Insert(0, "ALL Period");

            if (filteredDt.Rows.Count > 0)
            {
                List<string> periodList = new List<string>();
                var dtList = filteredDt.Select().Select(x => x["receive_date"]).ToList();

                foreach (var date in dtList)
                {
                    if ((date as DateTime?).HasValue == false)
                    {
                        continue;
                    }

                    DateTime? nullDate = date as DateTime?;
                    string strDate = nullDate.Value.Year.ToString();
                    int year;
                    if (int.TryParse(strDate, out year) == true && periodList.Contains(strDate) == false)
                    {
                        periodList.Add(strDate);
                    }
                }

                periodList = periodList.OrderByDescending(x => x).ToList();
                periodList.ForEach(x => ui_cbStdPeriod.Items.Add(x));

                filteredDt = filteredDt.Select("", "id DESC").CopyToDataTable();

                ui_gridStd.DataSource = filteredDt.DefaultView.ToTable(false, new string[] { "id", "customer", "type", "status", "summary_kr",
                                                                                       "receive_date", "due_date", "start_date", "end_date",
                                                                                       "verification_date", "update_date", "document_name" }).Select().CopyToDataTable();
            }
            else if (ui_gridStd.DataSource != null)
            {
                (ui_gridStd.DataSource as DataTable).Clear();
            }

            ui_cbStdPeriod.SelectedIndex = 0;
        }

        private void OnSubConditionSelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cBox = sender as ComboBox;

            DataTable filteredDt = new DataTable();

            MetroGrid grid = GetDataTable(cBox.Tag.ToString(), ref filteredDt);

            if (filteredDt.Rows.Count > 0)
            {
                filteredDt = filteredDt.Select("", "id DESC").CopyToDataTable();

                grid.DataSource = filteredDt.DefaultView.ToTable(false, new string[] { "id", "customer", "type", "status", "summary_kr",
                                                                                       "receive_date", "due_date", "start_date", "end_date",
                                                                                       "verification_date", "update_date", "document_name" }).Select().CopyToDataTable();
            }
            else if (grid.DataSource != null)
            {
                (grid.DataSource as DataTable).Clear();
            }
        }

        private void OnClickLoadExcel(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Load File",
                CheckFileExists = true,
                CheckPathExists = true,
                DefaultExt = "xlsx",
                Filter = "Excel Files (*.xlsx;*.xls;*.csv)|*.xlsx;*.xls;*.csv",
                FilterIndex = 1,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDlg.FileName;

                ui_btnLoadExcel.Enabled = false;
                ui_btnClearExcel.Enabled = false;
                ui_btnImportExcel.Enabled = false;
                ui_progressBar.Width = 0;
                ui_progressBar.Visible = true;
                ui_panelHelper.Cursor = Cursors.WaitCursor;

                BackgroundWorker worker = new BackgroundWorker();
                worker.DoWork += Worker_DoWork;
                worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
                worker.ProgressChanged += Worker_ProgressChanged;
                worker.WorkerReportsProgress = true;
                worker.RunWorkerAsync(filePath);
            }
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //Console.WriteLine(e.UserState.ToString());
            //ui_progressBar.Value = e.ProgressPercentage;
            ui_progressBar.Width = (int)(e.ProgressPercentage / 100.0 * ui_panelHelperCollapsible.Width);
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ui_btnLoadExcel.Enabled = true;
            ui_btnClearExcel.Enabled = true;
            ui_btnImportExcel.Enabled = true;
            ui_panelHelper.Cursor = Cursors.Default;

            MetroGrid metroGrid = e.Result as MetroGrid;
            ui_panelHelper.Controls.Add(metroGrid);
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            string filePath = e.Argument as string;

            DataTable dt = ReadExcelToDatatble(filePath, "개발사양", 6, 2, sender);

            MetroGrid excelGrid = new MetroGrid();
            excelGrid.Name = "gridExcel";
            excelGrid.DataSource = dt;
            excelGrid.Dock = DockStyle.Fill;

            e.Result = excelGrid;
        }

        private void OnClickClearExcel(object sender, EventArgs e)
        {
            ui_progressBar.Visible = false;
            ui_panelHelper.Controls.RemoveByKey("gridExcel");
        }

        private void OnClickImport(object sender, EventArgs e)
        {
            MetroGrid excelGrid = null;
            foreach (Control ctrl in ui_panelHelper.Controls.Find("gridExcel", true))
            {
                excelGrid = ctrl as MetroGrid;
                break;
            }

            if (excelGrid == null)
            {
                return;
            }

            DataTable excelDt = excelGrid.DataSource as DataTable;
            DataTable tempDt = excelDt.Clone();
            tempDt.Columns[2].DataType = typeof(DateTime);

            foreach (DataRow dr in excelDt.Rows)
            {
                tempDt.ImportRow(dr);
            }

            tempDt.AcceptChanges();

            // 시작일을 기준으로 정렬
            tempDt.DefaultView.Sort = String.Format("{0} ASC", tempDt.Columns[2]);
            DataTable sortedDt = tempDt.DefaultView.ToTable();

            using (SqlConnection conn = new SqlConnection(DbHelper.DbConnectionString))
            {
                conn.Open();

                double val;
                DateTime dateTime;
                SqlTransaction tran = conn.BeginTransaction();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.Transaction = tran;

                try
                {
                    cmd.CommandText = DbHelper.GetInsertQuery(this.SmhTableName);

                    foreach (DataRow row in sortedDt.Rows)
                    {
                        cmd.Parameters.AddWithValue("@customer", String.Format("{0}{1}", char.ToUpper(this.SmhTableName[0]), this.SmhTableName.ToLower().Substring(1)));
                        cmd.Parameters.AddWithValue("@category1", row[0].ToString());   // 종류
                        cmd.Parameters.AddWithValue("@category2", row[1].ToString());   // 내용

                        if (DateTime.TryParse(row[2].ToString(), out dateTime)) // 시작 또는 접수
                        {
                            cmd.Parameters.AddWithValue("@startDate", dateTime);
                            cmd.Parameters.AddWithValue("@receiveDate", dateTime);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@startDate", DBNull.Value);
                            cmd.Parameters.AddWithValue("@receiveDate", DBNull.Value);
                        }

                        if (DateTime.TryParse(row[4].ToString(), out dateTime)) // 완료 또는 처리완료
                        {
                            cmd.Parameters.AddWithValue("@endDate", dateTime);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@endDate", DBNull.Value);
                        }

                        if (DateTime.TryParse(row[5].ToString(), out dateTime)) // 검증
                        {
                            cmd.Parameters.AddWithValue("@verificationDate", dateTime);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@verificationDate", DBNull.Value);
                        }

                        if (DateTime.TryParse(row[6].ToString(), out dateTime)) // 업데이트
                        {
                            cmd.Parameters.AddWithValue("@updateDate", dateTime);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@updateDate", DBNull.Value);
                        }

                        if (DateTime.TryParse(row[7].ToString(), out dateTime)) // 희망납기일
                        {
                            cmd.Parameters.AddWithValue("@dueDate", dateTime);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@dueDate", DBNull.Value);
                        }

                        cmd.Parameters.AddWithValue("@site", row[8].ToString().Trim()); // 현장

                        if (Double.TryParse(row[9].ToString(), out val) == true)    // 시수(일)
                        {
                            cmd.Parameters.AddWithValue("@workTime", row[9].ToString().Trim());
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@workTime", DBNull.Value);
                        }

                        cmd.Parameters.AddWithValue("@worker", row[10].ToString().Trim());  // 담당자
                        cmd.Parameters.AddWithValue("@type", row[11].ToString().Trim());    // 타입
                        cmd.Parameters.AddWithValue("@status", row[12].ToString()); // 상태 또는 상황

                        string details = row[13].ToString().Replace("\n", "\r\n");  // 비고

                        string[] splitSeperator = new string[] { "\r\n" };
                        if (String.IsNullOrEmpty(details) == false && details.Split(splitSeperator, StringSplitOptions.None).Count() > 0)
                        {
                            string title = details.Split(splitSeperator, StringSplitOptions.None)[0];

                            cmd.Parameters.AddWithValue("@summaryKr", title.TrimEnd(' '));
                            cmd.Parameters.AddWithValue("@details", details);
                        }
                        else if (String.IsNullOrEmpty(details) == false)
                        {
                            cmd.Parameters.AddWithValue("@summaryKr", details);
                            cmd.Parameters.AddWithValue("@details", DBNull.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@summaryKr", DBNull.Value);
                            cmd.Parameters.AddWithValue("@details", DBNull.Value);
                        }

                        cmd.Parameters.AddWithValue("@priority", row[14].ToString().Trim());    // 우선

                        if (String.IsNullOrEmpty(row[15].ToString()) == false)  // 참고 문서 또는 참고문서
                        {
                            cmd.Parameters.AddWithValue("@documentFile", row[15].ToString());
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@documentFile", DBNull.Value);
                        }

                        if (this.SmhTableName.ToLower() == "imabari")
                        {
                            if (String.IsNullOrEmpty(row[17].ToString()) == false)    // 답변
                            {
                                cmd.Parameters.AddWithValue("@mailFile", row[17].ToString());
                            }
                            else if (String.IsNullOrEmpty(row[16].ToString()) == false) // 메일
                            {
                                cmd.Parameters.AddWithValue("@mailFile", row[16].ToString());
                            }
                            else
                            {
                                cmd.Parameters.AddWithValue("@mailFile", DBNull.Value);
                            }
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@mailFile", DBNull.Value);
                        }

                        cmd.Parameters.AddWithValue("@sampleFile", DBNull.Value);
                        cmd.Parameters.AddWithValue("@summaryJp", DBNull.Value);
                        cmd.Parameters.AddWithValue("@writer", Environment.UserName);
                        cmd.Parameters.AddWithValue("@saveDate", DateTime.Now);

                        cmd.ExecuteNonQuery();
                        cmd.Parameters.Clear();
                    }

                    tran.Commit();  // Transaction Commit
                }
                catch (Exception ex)
                {
                    tran.Rollback();    // 에러 발생 시, RollBack 처리
                    MetroMessageBox.Show(this, ex.ToString(), "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            List<string> tableList = DbHelper.GetTableListFromDB();

            if (tableList.Contains(this.StdTableName) == true)
            {
                tableList.Remove(this.StdTableName);
            }

            this.DtDic = DbHelper.GetDataTableDictionary(tableList);

            if (this.DtDic.ContainsKey(this.SmhTableName))
            {
                this.SmhDt = DtDic[this.SmhTableName];
            }
            else
            {
                this.SmhDt = new DataTable();
            }

            this.StdDt = DbHelper.GetDataTableFromDB(this.StdTableName);

            LoadGridDataTable(this.ui_gridSmh, this.SmhDt);

            this.ui_cbSmhCustomer.SelectedText = this.SmhTableName;

            AfterLoad();

            MetroMessageBox.Show(this, "", "Import Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
