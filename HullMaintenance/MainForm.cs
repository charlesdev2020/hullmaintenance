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

            this.StdDt = GetDataTable(stdTableName);
            this.SmhDt = GetDataTable(smhTableName);

            LoadGridDataTable(this.ui_gridStd, this.StdDt);
            LoadGridDataTable(this.ui_gridSmh, this.SmhDt);

            LoadConditionList(this.ui_cbStdCustomer, this.ui_cbStdPeriod, this.StdDt, this.Customer, this.Period);
            LoadConditionList(this.ui_cbSmhCustomer, this.ui_cbSmhPeriod, this.SmhDt, this.Customer, this.Period);

            //LoadPeriodList(this.ui_cbStdCustomer, this.StdDt, this.Customer);
            //LoadPeriodList(this.ui_cbSmhCustomer, this.SmhDt, this.Customer);

            InitStyle();
        }

        private void OnGridDataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            MetroGrid grid = sender as MetroGrid;

            DateTime dateTime;
            bool isCheck;
            int count;

            foreach (DataGridViewRow row in grid.Rows)
            {
                grid.Rows[row.Index].HeaderCell.Value = (row.Index + 1).ToString();
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

        private void OnClickBtnSearch(object sender, EventArgs e)
		{
			MetroButton mBtn = sender as MetroButton;
			string tag = mBtn.Tag.ToString();
			ComboBox cbox = mBtn.Parent.Controls.Find(tag, true).FirstOrDefault() as ComboBox;
			string searchText = cbox.Text;

			if (String.IsNullOrWhiteSpace(searchText) == false)
			{
				cbox.Items.Add(searchText);
			}
        }

        private void OnClickBtnSearchHistoryClear(object sender, EventArgs e)
        {
            MetroButton mBtn = sender as MetroButton;
            string tag = mBtn.Tag.ToString();
            ComboBox cbox = mBtn.Parent.Controls.Find(tag, true).FirstOrDefault() as ComboBox;
            cbox.Text = "";
            cbox.Items.Clear();
        }

        private void OnClickBtnAddItem(object sender, EventArgs e)
        {
            MetroButton mBtn = sender as MetroButton;

            if (mBtn.Tag.ToString() == "ui_gridStd")
            {

            }
            else
            {

            }
        }

        private void OnTabControlSelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void OnSeachTextChanged(object sender, EventArgs e)
        {
            ComboBox cBox = sender as ComboBox;
            string searchText = cBox.Text;

            if (cBox.Tag.ToString() == "ui_gridStd")
            {
                (ui_gridStd.DataSource as DataTable).DefaultView.RowFilter = String.Format("summary_kr LIKE '%{0}%' OR document_name LIKE '%{0}%'", searchText);
            }
            else
            {
                (ui_gridSmh.DataSource as DataTable).DefaultView.RowFilter = String.Format("summary_kr LIKE '%{0}%' OR document_name LIKE '%{0}%'", searchText);
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

        private void OnConditionSelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cBox = sender as ComboBox;
            string customer = cBox.Text;
            string filterQuery = "";

            if (customer.Equals("ALL") == true)
            {
                filterQuery = String.Empty;
            }
            else
            {
                filterQuery = String.Format("customer = '{0}'", customer);
            }

            if (cBox.Tag.ToString() == "ui_gridStd")
            {
                (ui_gridStd.DataSource as DataTable).DefaultView.RowFilter = filterQuery;
            }
            else
            {
                (ui_gridSmh.DataSource as DataTable).DefaultView.RowFilter = filterQuery;
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
				ComboBox cbox = sender as ComboBox;
				string searchText = cbox.Text;

				if (String.IsNullOrWhiteSpace(searchText) == false)
				{
					cbox.Items.Add(searchText);
				}
			}
		}

        //private void OnSelected
        #endregion

        #region Method
        /// <summary>
        /// Load INI
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
            this.ui_styleMgr.Style = (MetroColorStyle)int.Parse(iniHelper.GetPrivateProfileString("Design", "StartStyleIdx", "4"));
            this.ui_tbColorWorking.Text = String.Format("#{0}", iniHelper.GetPrivateProfileString("ColorCode", "Working", ""));
            this.ui_tbColorWorkDone.Text = String.Format("#{0}", iniHelper.GetPrivateProfileString("ColorCode", "WorkDone", ""));
            this.ui_tbColorPartialDone.Text = String.Format("#{0}", iniHelper.GetPrivateProfileString("ColorCode", "PartialDone", ""));
            this.ui_tbColorComplete.Text = String.Format("#{0}", iniHelper.GetPrivateProfileString("ColorCode", "Complete", ""));
            this.ui_tbColorPending.Text = String.Format("#{0}", iniHelper.GetPrivateProfileString("ColorCode", "Pending", ""));
            this.ui_tbColorWaiting.Text = String.Format("#{0}", iniHelper.GetPrivateProfileString("ColorCode", "Waiting", ""));
            this.ui_tbColorError.Text = String.Format("#{0}", iniHelper.GetPrivateProfileString("ColorCode", "Error", ""));
            this.ui_tbColorCancel.Text = String.Format("#{0}", iniHelper.GetPrivateProfileString("ColorCode", "Cancel", ""));
            this.ui_tbColorImpossible.Text = String.Format("#{0}", iniHelper.GetPrivateProfileString("ColorCode", "Impossible", ""));
            this.ui_tbColorD1.Text = String.Format("#{0}", iniHelper.GetPrivateProfileString("ColorCode", "D-1", ""));
            this.ui_tbColorD3.Text = String.Format("#{0}", iniHelper.GetPrivateProfileString("ColorCode", "D-3", ""));
            this.ui_tbColorD7.Text = String.Format("#{0}", iniHelper.GetPrivateProfileString("ColorCode", "D-7", ""));
        }

        /// <summary>
        /// Create DB Connection String
        /// </summary>
        /// <returns></returns>
        private string  GetDatabaseConnection()
        {
            string connString = String.Format(@"Data Source={0}; Initial Catalog={1}; User ID={2}; Password={3}; Persist Security Info=True;",
                                              this.ui_tbDbServer.Text, this.ui_tbDbName.Text, this.ui_tbDbId.Text, this.ui_tbDbPw.Text);

            return connString;
        }

        /// <summary>
        /// Get DataTable from DB
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        private DataTable GetDataTable(string tableName)
        {
            DataTable dt = new DataTable();
            string result = "Wait...";
            this.ui_lbDBStatus.Text = result;

            string query = String.Format("SELECT * FROM {0} ORDER BY id DESC", tableName);

            try
            {
                using (SqlConnection conn = new SqlConnection(this.ConnString))
                {
                    conn.Open();

                    SqlDataAdapter sda = new SqlDataAdapter();
                    SqlCommand scm = new SqlCommand(query, conn);
                    SqlDataReader adr = scm.ExecuteReader();

                    dt.Load(adr);
                    dt.Columns.Add("document_name");
                    foreach (DataRow row in dt.Rows)
                    {
                        string file = row["document_file"].ToString();

                        if (String.IsNullOrEmpty(file) == true)
                        {
                            continue;
                        }

                        file = file.Split(Path.DirectorySeparatorChar).Last();
                        row["document_name"] = file;
                    }
                }
                result = "OK!";
                ui_tabControl.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                result = "Failed!";
                ui_tabControl.SelectedIndex = 3;
            }
            finally
            {
                this.ui_lbDBStatus.Text = result;
            }

            return dt;
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

            cbCustmer.Items.Insert(0, "All Customer");
            cbPeriod.Items.Insert(0, "All Period");

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
        /// Load DataTable 
        /// </summary>
        private void LoadGridDataTable(MetroGrid grid, DataTable dt)
        {
            grid.DataSource = dt.DefaultView.ToTable(false, new string[] {
                "id", "type", "status", "summary_kr", "due_date", "update_date", "document_name", "customer" }).Select().CopyToDataTable();

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
        }
        #endregion
    }
}
