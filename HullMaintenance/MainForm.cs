using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        #region Event
        private void MainForm_Resize(object sender, EventArgs e)
        {
            this.metroTabControl.Width = this.Width - 47;
            this.metroTabControl.Height = this.Height - 50;
        }


        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void metroTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
