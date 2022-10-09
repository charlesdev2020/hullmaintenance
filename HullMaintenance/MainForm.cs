using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace HullMaintenance
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();

            InitStyle();
            LoadIni();
            GetDatabase();
        }

        #region Event
        private void MainForm_Resize(object sender, EventArgs e)
        {
            this.metroTabControl.Width = this.Width - 47;
            this.metroTabControl.Height = this.Height - 50;
        }


        private void MainForm_Load(object sender, EventArgs e)
        {

            this.metroTabControl.SelectedIndex = 3;
        }

        private void metroTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region Method
        private void InitStyle()
        {
            // size of TabControl's tabs
            //metroTabControl.ItemSize = new Size(
            //    metroTabControl.Width / metroTabControl.TabPages.Count - 1,
            //    metroTabControl.ItemSize.Height);
            //metroTabControl.SelectedIndex = 0;
        }

        private void GetDatabase()
        {
            string result = "Wait...";
            this.lbDBStatus.Text = result;


            string connString = String.Format(@"Data Source={0}; Initial Catalog={1}; User ID={2}; Password={3}; Persist Security Info=True;",
                                                this.tbDbServer.Text, this.tbDbName, this.tbDbId, this.tbDbPw);

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
                result = "OK";
            }
            catch (Exception)
            {
                result = "Failed";
            }
            finally
            {
                this.lbDBStatus.Text = result;
            }
        }
        private void LoadIni()
        {
            string iniPath = String.Format(@"{0}\Option.ini", Environment.CurrentDirectory);
        }
        #endregion
    }
}
