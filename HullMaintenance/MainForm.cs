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
using System.Windows.Forms;

namespace HullMaintenance
{
    public partial class MainForm : MetroForm
    {
        #region Members
        #endregion

        #region Properties
		public string ConnString { get; private set; }
        public DataTable StdDt { get; private set; }
        public DataTable SmhDt { get; private set; }
		public string stdTableName { get; private set; }
		public string smhTableName { get; private set; }
		public string Customer { get; private set; }
        public string Period { get; private set; }
        public int ThemeIdx { get; private set; }
        public int StyleIdx { get; private set; }
        public string SearchColumns { get; private set; }
        public string StaticSearchQuery { get; private set; }
        public string DynamicSearchQuery { get; private set; }
        public Dictionary<string, string> StatusColorDic { get; private set; }
        public string ActivateTableName { get; set; }
        public int ActivateIndex { get; set; }
		#endregion

        public MainForm()
        {
            InitializeComponent();
        }

        #region Event
        private void OnLoadMainForm(object sender, EventArgs e)
        {
            LoadINI();

            this.ConnString = GetDatabaseConnection();

            this.StdDt = DbHelper.GetDataTableFromDB(stdTableName);
            this.SmhDt = DbHelper.GetDataTableFromDB(smhTableName);

            LoadGridDataTable(this.ui_gridStd, this.StdDt);
            LoadGridDataTable(this.ui_gridSmh, this.SmhDt);

            LoadConditionList(this.ui_cbStdCustomer, this.ui_cbStdPeriod, this.StdDt, this.Customer, this.Period);
            LoadConditionList(this.ui_cbSmhCustomer, this.ui_cbSmhPeriod, this.SmhDt, this.Customer, this.Period);

            InitStyle();
        }

        private void OnChangeDataTable(object sender, EventArgs e)
        {
            DataTable dataTable = sender as DataTable;

            if (dataTable.TableName.Contains("smart"))
            {
                LoadGridDataTable(this.ui_gridSmh, this.SmhDt);
                LoadConditionList(this.ui_cbSmhCustomer, this.ui_cbSmhPeriod, this.SmhDt, this.Customer, this.Period);
            }
            else
            {
                LoadGridDataTable(this.ui_gridStd, this.StdDt);
                LoadConditionList(this.ui_cbStdCustomer, this.ui_cbStdPeriod, this.StdDt, this.Customer, this.Period);
            }
        }

        private void OnActivatedMainForm(object sender, EventArgs e)
        {
            TabPage page = ui_tabControl.SelectedTab;
            if (String.IsNullOrWhiteSpace(page.Tag.ToString()))
            {
                return;
            }

            string tableName = page.Tag.ToString();
            MetroGrid grid;
            DataTable dt;
            ComboBox cBox;

            if (tableName.Contains("smart"))
            {
                grid = ui_gridSmh;
                dt = this.SmhDt;
                cBox = ui_cbSmhCustomer;
            }
            else
            {
                grid = ui_gridStd;
                dt = this.StdDt;
                cBox = ui_cbStdCustomer;
            }

            dt = DbHelper.GetDataTableFromDB(tableName);

            if (dt.TableName.Contains("smart"))
            {
                this.SmhDt = dt;
            }
            else
            {
                this.StdDt = dt;
            }

            LoadGridDataTable(grid, dt);
            OnConditionSelectedValueChanged(cBox, null);
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
                            if (dr[column].ToString().Contains(searchText) == true)
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

        private void OnClickBtnAddItem(object sender, EventArgs e)
        {
            MetroButton mBtn = sender as MetroButton;
            ComboBox cBox = null;
            DataTable dt;
            if (mBtn.Tag.ToString().ToLower().Contains("std") == true)
            {
                dt = this.StdDt;
                cBox = ui_cbStdCustomer;
            }
            else
            {
                dt = this.SmhDt;
                cBox = ui_cbSmhCustomer;
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
            view.StartPosition = FormStartPosition.CenterParent;
            //view.FormClosed += OnClosedDetailForm;
            view.Show();
        }

        private void OnGridCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MetroGrid grid = sender as MetroGrid;
            DataGridViewRow row = grid.Rows[e.RowIndex];
            DataGridViewCellCollection cells = grid.Rows[e.RowIndex].Cells;
            DataTable dt;
            int id = 0;
            string customer = "";

            if (grid.Name.ToString().ToLower().Contains("std") == true)
            {
                dt = this.StdDt;
                id = Convert.ToInt32(cells["stdColId"].Value.ToString());
                customer = cells["stdColCustomer"].Value.ToString();
            }
            else
            {
                dt = this.SmhDt;
                id = Convert.ToInt32(cells["smhColId"].Value.ToString());
                customer = cells["smhColCustomer"].Value.ToString();
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
            view.Index = Convert.ToInt32(id.ToString());
            view.Customer = customer.Contains("ALL") ? "ALL" : customer;
            view.StartPosition = FormStartPosition.CenterParent;
            //view.FormClosed += OnClosedDetailForm;
            view.Show();
        }

        //private void OnClosedDetailForm(object sender, FormClosedEventArgs e)
        //{
        //    DetailForm view = sender as DetailForm;
        //    string tableName = view.Dt.TableName;
        //    MetroGrid grid;
        //    DataTable dt;
        //    ComboBox cBox;

        //    if (tableName.Contains("smart"))
        //    {
        //        grid = ui_gridSmh;
        //        dt = this.SmhDt;
        //        cBox = ui_cbSmhCustomer;
        //    }
        //    else
        //    {
        //        grid = ui_gridStd;
        //        dt = this.StdDt;
        //        cBox = ui_cbStdCustomer;
        //    }

        //    foreach (TabPage page in ui_tabControl.TabPages)
        //    {
        //        if (page.Text.ToLower().Contains(tableName))
        //        {
        //            ui_tabControl.SelectedTab = page;
        //            break;
        //        }
        //    }

        //    dt = DbHelper.GetDataTableFromDB(view.Dt.TableName);

        //    if (dt.TableName.Contains("smart"))
        //    {
        //        this.SmhDt = dt;
        //    }
        //    else
        //    {
        //        this.StdDt = dt;
        //    }

        //    LoadGridDataTable(grid, dt);
        //    OnConditionSelectedValueChanged(cBox, null);
        //}

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

        private void OnTabControlSelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void OnConditionSelectedValueChanged(object sender, EventArgs e)
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
            else
            {
                (grid.DataSource as DataTable).Clear();
            }
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
					if (ui_panelStdcollapsible.Visible == false)
					{
						ui_panelStdcollapsible.Visible = true;
					}
					else
					{
						ui_panelStdcollapsible.Visible = false;
					}
				}
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
        #endregion

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
            string iniPath = String.Format(@"{0}\Option.ini", Environment.CurrentDirectory);
            INIHelper iniHelper = new INIHelper(iniPath);

            this.ui_tbDbServer.Text = iniHelper.GetPrivateProfileString("Database", "Server", "localhost");
            this.ui_tbDbId.Text = iniHelper.GetPrivateProfileString("Database", "LoginId", "");
            this.ui_tbDbPw.Text = iniHelper.GetPrivateProfileString("Database", "LoginPw", "");
            this.ui_tbDbName.Text = iniHelper.GetPrivateProfileString("Database", "DBName", "");
            this.stdTableName = iniHelper.GetPrivateProfileString("Database", "StdTableName", "");
            this.smhTableName = iniHelper.GetPrivateProfileString("Database", "SmhTableName", "");
            this.Customer = iniHelper.GetPrivateProfileString("Condition", "Customer", "ALL");
            this.Period = iniHelper.GetPrivateProfileString("Condition", "Period", "ALL");
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
        private string  GetDatabaseConnection()
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
            ComboBox periodBox;
            MetroGrid grid;
            DataTable dt;

            if (tag.ToLower().Contains("std") == true)
            {
                grid = ui_gridStd;
                customerBox = ui_cbStdCustomer;
                periodBox = ui_cbStdPeriod;
                dt = this.StdDt;
            }
            else
            {
                grid = ui_gridSmh;
                customerBox = ui_cbSmhCustomer;
                periodBox = ui_cbSmhPeriod;
                dt = this.SmhDt;
            }

            string customer = customerBox.Text;
            string period = periodBox.Text;

            tempDt = dt.Copy();

            try
            {
                if (customer.Contains("ALL") == false)
                {
                    tempDt = tempDt.Select(String.Format("customer = '{0}'", customer)).CopyToDataTable();
                }

                if (String.IsNullOrEmpty(period) == false && period.Contains("ALL") == false)
                {
                    tempDt = tempDt.Select().Where(x => x["receive_date"].ToString().StartsWith(period)).CopyToDataTable();
                }
            }
            catch (Exception ex)
            {
                tempDt.Rows.Clear();
            }

            return grid;
        }

        /// <summary>
        /// Load Customer List from DataTable
        /// </summary>
        /// <param name="combo"></param>
        /// <param name="dt"></param>
        /// <param name="customer"></param>
        private void LoadConditionList(ComboBox cbCustmer, ComboBox cbPeriod, DataTable dt, string customer, string period)
        {
            if (dt.Rows.Count > 0)
            {
                List<string> customerList = dt.Select().Select(x => x["customer"]).Cast<string>().Distinct().ToList();
                List<string> periodList = new List<string>();
                var dtList = dt.Select().Select(x => x["receive_date"]).ToList();

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

                customerList = customerList.OrderByDescending(x => x).ToList();
                periodList = periodList.OrderByDescending(x => x).ToList();

                customerList.ForEach(x => cbCustmer.Items.Add(x));
                periodList.ForEach(x => cbPeriod.Items.Add(x));
            }

            cbCustmer.Items.Insert(0, "ALL Customer");
            cbPeriod.Items.Insert(0, "ALL Period");

            customer = customer.Replace("ALL", "ALL Customer");
            period = period.Replace("ALL", "ALL Period");

            if (String.IsNullOrWhiteSpace(customer) == false && cbCustmer.Items.Contains(customer) == true)
            {
                cbCustmer.SelectedItem = customer;
            }
            else
            {
                cbCustmer.SelectedIndex = 0;
            }

            if (String.IsNullOrWhiteSpace(period) == false && cbPeriod.Items.Contains(period) == true)
            {
                cbPeriod.SelectedItem = period;
            }
            else
            {
                cbPeriod.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Load DataTable Into Grid
        /// </summary>
        private void LoadGridDataTable(MetroGrid grid, DataTable dt)
        {
            if (dt.Rows.Count > 0 )
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
        /// Initialize for UI Style
        /// </summary>
        private void InitStyle()
        {
            // size of TabControl's tabs
            //metroTabControl.ItemSize = new Size(
            //metroTabControl.Width / metroTabControl.TabPages.Count - 1,
            //metroTabControl.ItemSize.Height);
            ui_tabControl.SelectedIndex = 1;
            
            Version version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            ui_lbMainVersion.Text = String.Format("version={0}", version.ToString());
        }
        #endregion
    }
}
