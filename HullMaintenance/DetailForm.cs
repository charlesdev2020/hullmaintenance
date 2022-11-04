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
        public DataTable Dt { get; private set; }
        #endregion

        #region Constructor
        public DetailForm()
        {
            InitializeComponent();
        }

        public DetailForm(DataTable dt)
        {
            InitializeComponent();

            this.Dt = dt;
        }

        private void OnLoadDetailForm(object sender, EventArgs e)
        {
            LoadCustomerList(this.Dt);

            GetData(this.Dt, this.Index);
        }

        private void OnCustomerSelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cBox = sender as ComboBox;

            ControlsValueClear(cBox);

            LoadComboBoxesList(this.Dt, cBox.Text);
        }

        private void OnClickBtnClose(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Method
        /// <summary>
        /// Get Info by ID
        /// </summary>
        /// <param name="idx"></param>
        private void GetData(DataTable dt, int idx)
        {
            DataRow row = dt.Select().Where(x => x["id"].ToString().Equals(idx.ToString()) == true).FirstOrDefault();

            if (row == null)
            {
                return;
            }

            ui_lbIdNumber.Text = ui_lbIdNumber.Text = String.Format("(No.{0})", idx);
            ui_lbIdNumber.Visible = true;

            ui_cbSite.SelectedText = row["site"].ToString();
            ui_cbType.SelectedText = row["type"].ToString();
            ui_cbCategory1.SelectedText = row["category1"].ToString();
            ui_cbCategory2.SelectedText = row["category2"].ToString();
            ui_cbPriority.SelectedText = row["priority"].ToString();
            ui_cbWorker.SelectedText = row["worker"].ToString();
            ui_tbWorkTime.Text = row["work_time"].ToString();
            ui_cbStatus.SelectedText = row["status"].ToString();
            ui_tbSummaryKr.Text = row["summary_kr"].ToString();
            ui_tbSummaryJp.Text = row["summary_jp"].ToString();
            ui_tbDetails.Text = row["details"].ToString();
            ui_tbDocument.Text = row["document_file"].ToString();
            ui_tbSample.Text = row["sample_file"].ToString();
            ui_tbMail.Text = row["mail_file"].ToString();

            DateTime dateTimeValue;

            if (DateTime.TryParse(row["receive_date"].ToString(), out dateTimeValue) == true)
            {
                ui_dtpReceiveDate.Value = dateTimeValue;
            }
            else
            {
                ui_dtpReceiveDate.CustomFormat = " ";
            }

            if (DateTime.TryParse(row["due_date"].ToString(), out dateTimeValue) == true)
            {
                ui_dtpDueDate.Value = dateTimeValue;
            }
            else
            {
                ui_dtpDueDate.CustomFormat = " ";
            }

            if (DateTime.TryParse(row["start_date"].ToString(), out dateTimeValue) == true)
            {
                ui_dtpStartDate.Value = dateTimeValue;
            }
            else
            {
                ui_dtpStartDate.CustomFormat = " ";
            }

            if (DateTime.TryParse(row["end_date"].ToString(), out dateTimeValue) == true)
            {
                ui_dtpEndDate.Value = dateTimeValue;
            }
            else
            {
                ui_dtpEndDate.CustomFormat = " ";
            }

            if (DateTime.TryParse(row["verification_date"].ToString(), out dateTimeValue) == true)
            {
                ui_dtpVerificationDate.Value = dateTimeValue;
            }
            else
            {
                ui_dtpVerificationDate.CustomFormat = " ";
            }

            if (DateTime.TryParse(row["update_date"].ToString(), out dateTimeValue) == true)
            {
                ui_dtpUpdateDate.Value = dateTimeValue;
            }
            else
            {
                ui_dtpUpdateDate.CustomFormat = " ";
            }
        }

        /// <summary>
        /// Load Customer List in ComboBox
        /// </summary>
        /// <param name="dt"></param>
        private void LoadCustomerList(DataTable dt)
        {
            List<string> customerList = dt.Select().Select(x => x["customer"]).Where(x => String.IsNullOrWhiteSpace(x.ToString()) == false).Cast<string>().Distinct().ToList();
            customerList.ForEach(x => ui_cbCustomer.Items.Add(x));
            customerList = customerList.OrderByDescending(x => x).ToList();
            ui_cbCustomer.Items.Insert(0, "");

            if (this.Customer.Contains("ALL") == false && String.IsNullOrWhiteSpace(this.Customer) == false)
            {
                ui_cbCustomer.SelectedText = this.Customer;

                LoadComboBoxesList(this.Dt, this.Customer);
            }
        }

        /// <summary>
        /// Load ComboBoxes Items according to Customer Change
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="customer"></param>
        private void LoadComboBoxesList(DataTable dt, string customer)
        {
            if (dt.Select().Where(x => x["customer"].ToString() == customer).Count() < 1)
            {
                return;
            }

            DataTable tempDt = dt.Select().Where(x => x["customer"].ToString() == customer).CopyToDataTable();

            List<string> siteList = tempDt.Select().Select(x => x["site"]).Where(x => String.IsNullOrWhiteSpace(x.ToString()) == false).Cast<string>().Distinct().ToList();
            List<string> typeList = tempDt.Select().Select(x => x["type"]).Where(x => String.IsNullOrWhiteSpace(x.ToString()) == false).Cast<string>().Distinct().ToList();
            List<string> category1List = tempDt.Select().Select(x => x["category1"]).Where(x => String.IsNullOrWhiteSpace(x.ToString()) == false).Cast<string>().Distinct().ToList();
            List<string> category2List = tempDt.Select().Select(x => x["category2"]).Where(x => String.IsNullOrWhiteSpace(x.ToString()) == false).Cast<string>().Distinct().ToList();
            List<string> prioiryList = tempDt.Select().Select(x => x["priority"]).Where(x => String.IsNullOrWhiteSpace(x.ToString()) == false).Cast<string>().Distinct().ToList();
            List<string> workerList = tempDt.Select().Select(x => x["worker"]).Where(x => String.IsNullOrWhiteSpace(x.ToString()) == false).Cast<string>().Distinct().ToList();
            List<string> statusList = tempDt.Select().Select(x => x["status"]).Where(x => String.IsNullOrWhiteSpace(x.ToString()) == false).Cast<string>().Distinct().ToList();

            siteList.ForEach(x => ui_cbSite.Items.Add(x));
            typeList.ForEach(x => ui_cbType.Items.Add(x));
            category1List.ForEach(x => ui_cbCategory1.Items.Add(x));
            category2List.ForEach(x => ui_cbCategory2.Items.Add(x));
            prioiryList.ForEach(x => ui_cbPriority.Items.Add(x));
            workerList.ForEach(x => ui_cbWorker.Items.Add(x));
            statusList.ForEach(x => ui_cbStatus.Items.Add(x));

            siteList = siteList.OrderByDescending(x => x).ToList();
            typeList = typeList.OrderByDescending(x => x).ToList();
            category1List = category1List.OrderByDescending(x => x).ToList();
            category2List = category2List.OrderByDescending(x => x).ToList();
            prioiryList = prioiryList.OrderByDescending(x => x).ToList();
            workerList = workerList.OrderByDescending(x => x).ToList();
            statusList = statusList.OrderByDescending(x => x).ToList();

            ui_cbSite.Items.Insert(0, "");
            ui_cbType.Items.Insert(0, "");
            ui_cbCategory1.Items.Insert(0, "");
            ui_cbCategory2.Items.Insert(0, "");
            ui_cbPriority.Items.Insert(0, "");
            ui_cbWorker.Items.Insert(0, "");
            ui_cbStatus.Items.Insert(0, "");
        }

        /// <summary>
        /// Initialize Controls
        /// </summary>
        private void ControlsValueClear(ComboBox customerBox)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is GroupBox)
                {
                    GroupBox gb = ctrl as GroupBox;

                    foreach (Control item in gb.Controls)
                    {
                        if (item is ComboBox)
                        {
                            ComboBox cb = item as ComboBox;

                            if (cb != customerBox)
                            {
                                cb.Items.Clear();
                                cb.Text = string.Empty;
                            }
                        }

                        if (item is TextBox)
                        {
                            TextBox tb = item as TextBox;
                            tb.Clear();
                        }

                        if (item is MetroTextBox)
                        {
                            MetroTextBox mtb = item as MetroTextBox;
                            mtb.Clear();
                        }

                        if (item is DateTimePicker)
                        {
                            DateTimePicker dtp = item as DateTimePicker;
                            dtp.CustomFormat = " ";
                        }
                    }
                }
            }
        }
        #endregion
    }
}
