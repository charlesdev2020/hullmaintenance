using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace HullMaintenance
{
	public partial class MainForm : MetroForm
    {
        #region Members
        string spisHullDbName = "";
        string smartHullDbName = "";
        string customer = "";
        #endregion

        #region Properties
        public string ConnString { get; private set; }
        public DataTable DtSpisHull { get; private set; }
        public DataTable DtSmartHull { get; private set; }
        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        #region Event
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadIni();
            this.ConnString = GetDatabaseConnection();
            this.DtSpisHull = GetDataTable(spisHullDbName);
            this.DtSmartHull = GetDataTable(smartHullDbName);
            LoadDataTables(this.customer);
            InitStyle();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            //this.tabControl.Width = this.Width - 47;
            //this.tabControl.Height = this.Height - 50;
        }

        private void metroTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //DataGridViewColumn selCol = metroGrid1.Columns[e.ColumnIndex];

            //if (selCol.Tag as string == "ASC")
            //{
            //    metroGrid1.Sort(selCol, ListSortDirection.Descending);
            //    selCol.Tag = "DESC";
            //}
            //else
            //{
            //    metroGrid1.Sort(selCol, ListSortDirection.Ascending);
            //    selCol.Tag = "ASC";
            //}
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string result = "Wait...";

            string connString = String.Format(@"Data Source={0}; Initial Catalog={1}; User ID={2}; Password={3}; Persist Security Info=True;",
                                               this.tbDbServer.Text, this.tbDbName.Text, this.tbDbId.Text, this.tbDbPw.Text);

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
                this.lbDBStatus.Text = result;
            }
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            MetroButton mBtn = sender as MetroButton;

            string tag = mBtn.Tag.ToString();
            MetroTextBox tbPath = this.tabPage3.Controls.Find(tag, false).FirstOrDefault() as MetroTextBox;

            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            folderDialog.SelectedPath = tbPath.Text;
            if (folderDialog.ShowDialog(this) == DialogResult.OK)
            {
                tbPath.Text = folderDialog.SelectedPath;
            }
        }

        private void btnPathOpen_Click(object sender, EventArgs e)
        {
            MetroButton mBtn = sender as MetroButton;

            string tag = mBtn.Tag.ToString();
            MetroTextBox tbPath = this.tabPage3.Controls.Find(tag, false).FirstOrDefault() as MetroTextBox;

            if (Directory.Exists(tbPath.Text) == true)
            {
                Process.Start(tbPath.Text);
            }
        }

        private void tabControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.F)
            {

                if (tabControl.SelectedIndex == 0)
                {
                    if (collapsibleSmhPanel.Visible == false)
                    {
                        collapsibleSmhPanel.Visible = true;
                    }
                    else
                    {
                        collapsibleSmhPanel.Visible = false;
                    }
                }
                else if (tabControl.SelectedIndex == 1)
                {
                    if (collapsibleStdPanel.Visible == false)
                    {
                        collapsibleStdPanel.Visible = true;
                    }
                    else
                    {
                        collapsibleStdPanel.Visible = false;
                    }
                }
            }
        }

        private void btnTheme_Click(object sender, EventArgs e)
        {
            styleMgr.Theme = styleMgr.Theme == MetroThemeStyle.Light ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
        }

        private void btnStyle_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            int next = rnd.Next(0, 13);
            styleMgr.Style = (MetroColorStyle)next;
        }
        #endregion

        #region Method
        private void InitStyle()
        {
            // size of TabControl's tabs
            //metroTabControl.ItemSize = new Size(
            //metroTabControl.Width / metroTabControl.TabPages.Count - 1,
            //metroTabControl.ItemSize.Height);
            tabControl.SelectedIndex = 1;
        }

        private string  GetDatabaseConnection()
        {
            string connString = String.Format(@"Data Source={0}; Initial Catalog={1}; User ID={2}; Password={3}; Persist Security Info=True;",
                                              this.tbDbServer.Text, this.tbDbName.Text, this.tbDbId.Text, this.tbDbPw.Text);

            return connString;
        }

        /// <summary>
        /// Get 
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        private DataTable GetDataTable(string tableName)
        {
            DataTable dt = new DataTable();
            string result = "Wait...";
            this.lbDBStatus.Text = result;

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
                tabControl.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                result = "Failed!";
                tabControl.SelectedIndex = 3;
            }
            finally
            {
                this.lbDBStatus.Text = result;
            }

            return dt;
        }

        /// <summary>
        /// Load DataTable 
        /// </summary>
        private void LoadDataTables(string customer)
        {
            //metroGrid1.DataSource = null;
            DataTable stdDt = null;
            DataTable smhDt = null;
            if (DtSpisHull.DefaultView.Table.Rows.Count > 0)
            {
                stdDt = this.DtSpisHull.DefaultView.ToTable(false, new string[] {
                    colId.DataPropertyName, colType.DataPropertyName, colStatus.DataPropertyName, colSummaryKr.DataPropertyName,
                    colDueDate.DataPropertyName, colUpdateDate.DataPropertyName, colDocumentLink.DataPropertyName, colCustomer.DataPropertyName }).
                    Select(String.Format("customer = '{0}'", customer)).CopyToDataTable();
                stdGrid.DataSource = stdDt;
            }
            
            //metroGrid1.DataSource = dt;

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
        /// Load INI
        /// </summary>
        private void LoadIni()
        {
            string iniPath = String.Format(@"{0}\Option.ini", Environment.CurrentDirectory);
            INIHelper iniHelper = new INIHelper(iniPath);

            this.tbDbServer.Text = iniHelper.GetPrivateProfileString("Database", "Server", "localhost");
            this.tbDbId.Text = iniHelper.GetPrivateProfileString("Database", "LoginId", "");
            this.tbDbPw.Text = iniHelper.GetPrivateProfileString("Database", "LoginPw", "");
            this.tbDbName.Text = iniHelper.GetPrivateProfileString("Database", "DBName", "");
            spisHullDbName = iniHelper.GetPrivateProfileString("Database", "StdTableName", "");
            smartHullDbName = iniHelper.GetPrivateProfileString("Database", "SmhTableName", "");
            customer = iniHelper.GetPrivateProfileString("Database", "Customer", "");
            this.tbPath1.Text = iniHelper.GetPrivateProfileString("File", "Path1", "");
            this.tbPath2.Text = iniHelper.GetPrivateProfileString("File", "Path2", "");
            this.tbPath3.Text = iniHelper.GetPrivateProfileString("File", "Path3", "");
        }
        #endregion
    }
}
