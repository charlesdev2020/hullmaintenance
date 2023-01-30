using MetroFramework;
using MetroFramework.Controls;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace HullMaintenance
{
    public partial class DetailForm : MetroForm
    {
        #region Properties
        public int RowIndex { get; set; }
        public int Index { get; set; }
        public string Customer { get; set; }
        public string DocPath { get; set; }
        public DataTable Dt { get; private set; }
        #endregion

        public DetailForm()
        {
            InitializeComponent();
        }

        public DetailForm(DataTable dt)
        {
            InitializeComponent();

            this.Dt = dt;
        }

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

        /// <summary>
        /// Insert Data
        /// </summary>
        /// <param name="isNew"></param>
        /// <returns></returns>
        private int InsertData(bool isNew)
        {
            int resultId = 0;
            using (SqlConnection conn = new SqlConnection(DbHelper.DbConnectionString))
            {
                conn.Open();

                DateTime dateTime;
                SqlTransaction tran = conn.BeginTransaction();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.Transaction = tran;

                try
                {
                    cmd.CommandText = DbHelper.GetInsertQuery(this.Dt.TableName);
                    cmd.Parameters.AddWithValue("@customer", ui_cbCustomer.Text.Trim());
                    cmd.Parameters.AddWithValue("@site", ui_cbSite.Text.Trim());
                    cmd.Parameters.AddWithValue("@type", ui_cbType.Text.Trim());
                    cmd.Parameters.AddWithValue("@category1", ui_cbCategory1.Text);
                    cmd.Parameters.AddWithValue("@category2", ui_cbCategory2.Text);
                    cmd.Parameters.AddWithValue("@priority", ui_cbPriority.Text.Trim());
                    cmd.Parameters.AddWithValue("@workTime", ui_tbWorkTime.Text.Trim());
                    cmd.Parameters.AddWithValue("@worker", ui_cbWorker.Text);

                    if (isNew == true)
                    {
                        if (String.IsNullOrWhiteSpace(ui_dtpReceiveDate.Text) == false && DateTime.TryParse(ui_dtpReceiveDate.Value.ToString(), out dateTime))
                        {
                            cmd.Parameters.AddWithValue("@receiveDate", ui_dtpReceiveDate.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@receiveDate", DBNull.Value);
                        }

                        if (String.IsNullOrWhiteSpace(ui_dtpDueDate.Text) == false && DateTime.TryParse(ui_dtpDueDate.Value.ToString(), out dateTime))
                        {
                            cmd.Parameters.AddWithValue("@dueDate", ui_dtpDueDate.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@dueDate", DBNull.Value);
                        }

                        if (String.IsNullOrWhiteSpace(ui_dtpStartDate.Text) == false && DateTime.TryParse(ui_dtpStartDate.Value.ToString(), out dateTime))
                        {
                            cmd.Parameters.AddWithValue("@startDate", ui_dtpStartDate.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@startDate", DBNull.Value);
                        }

                        if (String.IsNullOrWhiteSpace(ui_dtpEndDate.Text) == false && DateTime.TryParse(ui_dtpEndDate.Value.ToString(), out dateTime))
                        {
                            cmd.Parameters.AddWithValue("@endDate", ui_dtpEndDate.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@endDate", DBNull.Value);
                        }

                        if (String.IsNullOrWhiteSpace(ui_dtpVerificationDate.Text) == false && DateTime.TryParse(ui_dtpVerificationDate.Value.ToString(), out dateTime))
                        {
                            cmd.Parameters.AddWithValue("@verificationDate", ui_dtpVerificationDate.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@verificationDate", DBNull.Value);
                        }

                        if (String.IsNullOrWhiteSpace(ui_dtpUpdateDate.Text) == false && DateTime.TryParse(ui_dtpUpdateDate.Value.ToString(), out dateTime))
                        {
                            cmd.Parameters.AddWithValue("@updateDate", ui_dtpUpdateDate.Value);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@updateDate", DBNull.Value);
                        }

                        cmd.Parameters.AddWithValue("@status", ui_cbStatus.Text);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@receiveDate", DateTime.Now);
                        cmd.Parameters.AddWithValue("@dueDate", DBNull.Value);
                        cmd.Parameters.AddWithValue("@startDate", DBNull.Value);
                        cmd.Parameters.AddWithValue("@endDate", DBNull.Value);
                        cmd.Parameters.AddWithValue("@verificationDate", DBNull.Value);
                        cmd.Parameters.AddWithValue("@updateDate", DBNull.Value);

                        cmd.Parameters.AddWithValue("@status", "");
                    }

                    cmd.Parameters.AddWithValue("@documentFile", ui_tbDocument.Text);
                    cmd.Parameters.AddWithValue("@sampleFile", ui_tbSample.Text);
                    cmd.Parameters.AddWithValue("@mailFile", ui_tbMail.Text);
                    cmd.Parameters.AddWithValue("@summaryKr", ui_tbSummaryKr.Text);
                    cmd.Parameters.AddWithValue("@summaryJp", ui_tbSummaryJp.Text);
                    cmd.Parameters.AddWithValue("@details", ui_tbDetails.Text);
                    cmd.Parameters.AddWithValue("@writer", Environment.UserName);
                    cmd.Parameters.AddWithValue("@saveDate", DateTime.Now);
                    resultId = Convert.ToInt32(cmd.ExecuteScalar());

                    tran.Commit();  // Transaction Commit
                }
                catch (Exception ex)
                {
                    tran.Rollback();    // 에러 발생 시, RollBack 처리
                    MetroMessageBox.Show(this, ex.ToString(), "Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return resultId;
        }

        /// <summary>
        /// Update Detail Form
        /// </summary>
        /// <param name="idx"></param>
        private void UpdateData(int idx)
        {
            using (SqlConnection conn = new SqlConnection(DbHelper.DbConnectionString))
            {
                conn.Open();

                DateTime dateTime;
                SqlTransaction tran = conn.BeginTransaction();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.Transaction = tran;

                try
                {
                    cmd.CommandText = DbHelper.GetUpdateQuery(this.Dt.TableName, this.Index);
                    cmd.Parameters.AddWithValue("@customer", ui_cbCustomer.Text.Trim());
                    cmd.Parameters.AddWithValue("@site", ui_cbSite.Text.Trim());
                    cmd.Parameters.AddWithValue("@type", ui_cbType.Text.Trim());
                    cmd.Parameters.AddWithValue("@category1", ui_cbCategory1.Text);
                    cmd.Parameters.AddWithValue("@category2", ui_cbCategory2.Text);
                    cmd.Parameters.AddWithValue("@priority", ui_cbPriority.Text.Trim());
                    cmd.Parameters.AddWithValue("@workTime", ui_tbWorkTime.Text.Trim());
                    cmd.Parameters.AddWithValue("@worker", ui_cbWorker.Text);

                    if (String.IsNullOrWhiteSpace(ui_dtpReceiveDate.Text) == false && DateTime.TryParse(ui_dtpReceiveDate.Value.ToString(), out dateTime))
                    {
                        cmd.Parameters.AddWithValue("@receiveDate", ui_dtpReceiveDate.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@receiveDate", DBNull.Value);
                    }

                    if (String.IsNullOrWhiteSpace(ui_dtpDueDate.Text) == false && DateTime.TryParse(ui_dtpDueDate.Value.ToString(), out dateTime))
                    {
                        cmd.Parameters.AddWithValue("@dueDate", ui_dtpDueDate.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@dueDate", DBNull.Value);
                    }

                    if (String.IsNullOrWhiteSpace(ui_dtpStartDate.Text) == false && DateTime.TryParse(ui_dtpStartDate.Value.ToString(), out dateTime))
                    {
                        cmd.Parameters.AddWithValue("@startDate", ui_dtpStartDate.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@startDate", DBNull.Value);
                    }

                    if (String.IsNullOrWhiteSpace(ui_dtpEndDate.Text) == false && DateTime.TryParse(ui_dtpEndDate.Value.ToString(), out dateTime))
                    {
                        cmd.Parameters.AddWithValue("@endDate", ui_dtpEndDate.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@endDate", DBNull.Value);
                    }

                    if (String.IsNullOrWhiteSpace(ui_dtpVerificationDate.Text) == false && DateTime.TryParse(ui_dtpVerificationDate.Value.ToString(), out dateTime))
                    {
                        cmd.Parameters.AddWithValue("@verificationDate", ui_dtpVerificationDate.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@verificationDate", DBNull.Value);
                    }

                    if (String.IsNullOrWhiteSpace(ui_dtpUpdateDate.Text) == false && DateTime.TryParse(ui_dtpUpdateDate.Value.ToString(), out dateTime))
                    {
                        cmd.Parameters.AddWithValue("@updateDate", ui_dtpUpdateDate.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@updateDate", DBNull.Value);
                    }

                    cmd.Parameters.AddWithValue("@status", ui_cbStatus.Text);
                    cmd.Parameters.AddWithValue("@documentFile", ui_tbDocument.Text);
                    cmd.Parameters.AddWithValue("@sampleFile", ui_tbSample.Text);
                    cmd.Parameters.AddWithValue("@mailFile", ui_tbMail.Text);
                    cmd.Parameters.AddWithValue("@summaryKr", ui_tbSummaryKr.Text);
                    cmd.Parameters.AddWithValue("@summaryJp", ui_tbSummaryJp.Text);
                    cmd.Parameters.AddWithValue("@details", ui_tbDetails.Text);
                    cmd.Parameters.AddWithValue("@writer", Environment.UserName);
                    cmd.Parameters.AddWithValue("@saveDate", DateTime.Now);
                    cmd.ExecuteNonQuery();

                    tran.Commit();  // Transaction Commit
                }
                catch (Exception ex)
                {
                    tran.Rollback();    // 에러 발생 시, RollBack 처리
                    MetroMessageBox.Show(this, ex.ToString(), "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Get the TextBox Control
        /// </summary>
        /// <param name="btnName"></param>
        /// <returns></returns>
        private TextBox GetTextBox(string btnName)
        {
            TextBox tb;

            if (btnName.ToLower().Contains("document") == true)
            {
                tb = ui_tbDocument;
            }
            else if (btnName.ToLower().Contains("sample") == true)
            {
                tb = ui_tbSample;
            }
            else
            {
                tb = ui_tbMail;
            }

            return tb;
        }
        #endregion

        #region Event
        private void OnLoadDetailForm(object sender, EventArgs e)
        {
            LoadCustomerList(this.Dt);

            if (this.Index == 0)
            {
                ui_dtpDueDate.CustomFormat = " ";
                ui_dtpDueDate.Format = DateTimePickerFormat.Custom;
                ui_dtpStartDate.CustomFormat = " ";
                ui_dtpStartDate.Format = DateTimePickerFormat.Custom;
                ui_dtpEndDate.CustomFormat = " ";
                ui_dtpEndDate.Format = DateTimePickerFormat.Custom;
                ui_dtpVerificationDate.CustomFormat = " ";
                ui_dtpVerificationDate.Format = DateTimePickerFormat.Custom;
                ui_dtpUpdateDate.CustomFormat = " ";
                ui_dtpUpdateDate.Format = DateTimePickerFormat.Custom;
            }
            else
            {
                GetData(this.Dt, this.Index);
            }
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

        private void OnClickBtnDelete(object sender, EventArgs e)
        {
            if (this.Index == 0)
            {
                return;
            }

            if (MetroMessageBox.Show(this, "", "Do you want to delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                return;
            }

            using (SqlConnection conn = new SqlConnection(DbHelper.DbConnectionString))
            {
                conn.Open();

                SqlTransaction tran = conn.BeginTransaction();
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = conn;
                cmd.Transaction = tran;

                try
                {
                    cmd.CommandText = DbHelper.GetDeleteQuery(this.Dt.TableName, this.Index);
                    cmd.ExecuteNonQuery();

                    tran.Commit();  // Transaction Commit

                    this.ActivateMdiChild(this);
                }
                catch (Exception ex)
                {
                    tran.Rollback();    // 에러 발생 시, RollBack 처리
                    MetroMessageBox.Show(this, ex.ToString(), "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    this.Close();
                }
            }
        }

        private void OnClickBtnSave(object sender, EventArgs e)
        {
            if (this.Index == 0)
            {
                this.Index = InsertData(true);
            }
            else
            {
                UpdateData(this.Index);
            }

            this.ActivateMdiChild(this);
        }

        private void OnClickBtnCopy(object sender, EventArgs e)
        {
            if (this.Index != 0)
            {
                InsertData(false);

                this.ActivateMdiChild(this);

                MetroMessageBox.Show(this, "", "Data Insertion Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void OnClickBtnExecute(object sender, EventArgs e)
        {
            MetroButton btn = sender as MetroButton;
            TextBox tb = GetTextBox(btn.Name);

            if (String.IsNullOrEmpty(tb.Text) == false)
            {
                string docFullPath = String.Format(@"{0}\{1}", this.DocPath, tb.Text);

                FileInfo fi = new FileInfo(docFullPath);

                if (fi.Exists == true)
                {
                    Process.Start(docFullPath);
                }
            }
        }

        private void OnClickBtnPathOpen(object sender, EventArgs e)
        {
            MetroButton btn = sender as MetroButton;
            TextBox tb = GetTextBox(btn.Name);

            if (String.IsNullOrEmpty(tb.Text) == false)
            {
                string docFullPath = String.Format(@"{0}\{1}", this.DocPath, tb.Text);

                FileInfo fi = new FileInfo(docFullPath);

                if (fi.Directory.Exists == true)
                {
                    Process.Start(fi.DirectoryName);
                }
            }
        }

        private void OnClickBtnSearch(object sender, EventArgs e)
        {
            MetroButton btn = sender as MetroButton;
            TextBox tb = GetTextBox(btn.Name);

            OpenFileDialog openFileDlg = new OpenFileDialog
            {
                InitialDirectory = this.DocPath,
                Title = "File Seach",
                CheckFileExists = true,
                CheckPathExists = true,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                string fileFullPath = openFileDlg.FileName;
                string filePath = fileFullPath.Replace(this.DocPath, "");
                tb.Text = filePath;
            }
        }

        private void OnClickBtnClear(object sender, EventArgs e)
        {
            MetroButton btn = sender as MetroButton;
            TextBox tb = GetTextBox(btn.Name);

            tb.Text = "";
        }


        private void OnDateTimeValueChanged(object sender, EventArgs e)
        {
            DateTimePicker dtPicker = sender as DateTimePicker;
            dtPicker.CustomFormat = "yyyy-MM-dd ddd";
        }
        #endregion
    }
}
