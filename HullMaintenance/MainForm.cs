using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace HullMaintenance
{
    public partial class MainForm : MetroForm
    {
        public DataTable DataTableAll { get; set; }

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            InitStyle();
            LoadIni();
            GetDatabase();
            LoadDataTables();
        }

        #region Event
        private void MainForm_Resize(object sender, EventArgs e)
        {
            this.tabControl.Width = this.Width - 47;
            this.tabControl.Height = this.Height - 50;
        }

        private void metroTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                    SqlDataReader adr = scm.ExecuteReader();
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

        private void metroGrid1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewColumn selCol = metroGrid1.Columns[e.ColumnIndex];

            if (selCol.Tag == "ASC")
            {
                metroGrid1.Sort(selCol, ListSortDirection.Descending);
                selCol.Tag = "DESC";
            }
            else
            {
                metroGrid1.Sort(selCol, ListSortDirection.Ascending);
                selCol.Tag = "ASC";
            }
        }
        #endregion

        #region Method
        private void InitStyle()
        {
            // size of TabControl's tabs
            //metroTabControl.ItemSize = new Size(
            //metroTabControl.Width / metroTabControl.TabPages.Count - 1,
            //metroTabControl.ItemSize.Height);
            //metroTabControl.SelectedIndex = 0;
        }

        private void GetDatabase()
        {
            string result = "Wait...";
            this.lbDBStatus.Text = result;


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
                    SqlDataReader adr = scm.ExecuteReader();
                    this.DataTableAll = new DataTable();
                    this.DataTableAll.Load(adr);
                    this.DataTableAll.Columns.Add("document_name");
                    foreach (DataRow row in this.DataTableAll.Rows)
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
            catch (Exception)
            {
                result = "Failed!";
                tabControl.SelectedIndex = 3;
            }
            finally
            {
                this.lbDBStatus.Text = result;
            }
        }

        private void LoadDataTables()
        {
            metroGrid1.DataSource = null;

            DataTable dt = DataTableAll.DefaultView.ToTable(false, new string[] { colId.DataPropertyName, colType.DataPropertyName, colStatus.DataPropertyName, colSummaryKr.DataPropertyName, colDueDate.DataPropertyName, colUpdateDate.DataPropertyName, colDocumentLink.DataPropertyName, colCustomer.DataPropertyName }).Select("customer = '이마바리'").CopyToDataTable();
            metroGrid1.DataSource = dt;

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
        }

        private void LoadIni()
        {
            string iniPath = String.Format(@"{0}\Option.ini", Environment.CurrentDirectory);
			INIHelper iniHelper = new INIHelper(iniPath);

            this.tbDbServer.Text = iniHelper.GetPrivateProfileString("Database", "Server", "localhost");
            this.tbDbId.Text = iniHelper.GetPrivateProfileString("Database", "LoginId", "spis");
            this.tbDbPw.Text = iniHelper.GetPrivateProfileString("Database", "LoginPw", "spishull");
            this.tbDbName.Text = iniHelper.GetPrivateProfileString("Database", "DBName", "HULLDB");
            this.tbPath1.Text = iniHelper.GetPrivateProfileString("File", "Path1", "");
            this.tbPath2.Text = iniHelper.GetPrivateProfileString("File", "Path2", "");
            this.tbPath3.Text = iniHelper.GetPrivateProfileString("File", "Path3", "");
        }
        #endregion
    }
}
