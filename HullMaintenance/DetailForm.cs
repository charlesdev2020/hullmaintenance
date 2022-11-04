using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HullMaintenance
{
    public partial class DetailForm : MetroForm
    {
        #region Properties
        public int Index { get; set; }
        public string Customer { get; set; }
        #endregion

        #region Constructor
        public DetailForm()
        {
            InitializeComponent();
        }

        public DetailForm(DataTable dt)
        {
            InitializeComponent();
        }
        #endregion

    }
}
