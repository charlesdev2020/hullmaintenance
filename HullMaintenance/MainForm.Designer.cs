namespace HullMaintenance
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSummaryKr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpdateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocumentLink = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colDocumentPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lbDBStatus = new MetroFramework.Controls.MetroLabel();
            this.btnConnect = new MetroFramework.Controls.MetroButton();
            this.tbDbName = new MetroFramework.Controls.MetroTextBox();
            this.tbDbPw = new MetroFramework.Controls.MetroTextBox();
            this.tbDbId = new MetroFramework.Controls.MetroTextBox();
            this.tbDbServer = new MetroFramework.Controls.MetroTextBox();
            this.lbDbName = new MetroFramework.Controls.MetroLabel();
            this.lbPassword = new MetroFramework.Controls.MetroLabel();
            this.lbLoginId = new MetroFramework.Controls.MetroLabel();
            this.lbServer = new MetroFramework.Controls.MetroLabel();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.lbMainTitle1 = new MetroFramework.Controls.MetroLabel();
            this.lbMainTitle2 = new MetroFramework.Controls.MetroLabel();
            this.lbMainTitle3 = new MetroFramework.Controls.MetroLabel();
            this.lbMainVersion = new MetroFramework.Controls.MetroLabel();
            this.panel1 = new MetroFramework.Controls.MetroPanel();
            this.panel2 = new MetroFramework.Controls.MetroPanel();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(20, 30);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 2;
            this.tabControl.Size = new System.Drawing.Size(1240, 718);
            this.tabControl.TabIndex = 0;
            this.tabControl.UseSelectable = true;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.metroTabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Font = new System.Drawing.Font("굴림", 9F);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1232, 676);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "이마바리(SpisHull)";
            // 
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToAddRows = false;
            this.metroGrid1.AllowUserToDeleteRows = false;
            this.metroGrid1.AllowUserToOrderColumns = true;
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.White;
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.colType,
            this.colStatus,
            this.colSummaryKr,
            this.colDueDate,
            this.colUpdateDate,
            this.colDocumentLink,
            this.colDocumentPath});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid1.Location = new System.Drawing.Point(3, 50);
            this.metroGrid1.MultiSelect = false;
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidth = 20;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.metroGrid1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.metroGrid1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("나눔바른고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.metroGrid1.RowTemplate.Height = 20;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.ShowEditingIcon = false;
            this.metroGrid1.Size = new System.Drawing.Size(1226, 615);
            this.metroGrid1.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.FillWeight = 16.98324F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // colType
            // 
            this.colType.DataPropertyName = "type";
            this.colType.FillWeight = 25.33413F;
            this.colType.HeaderText = "Type";
            this.colType.Name = "colType";
            // 
            // colStatus
            // 
            this.colStatus.DataPropertyName = "status";
            this.colStatus.FillWeight = 33.8766F;
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            // 
            // colSummaryKr
            // 
            this.colSummaryKr.DataPropertyName = "summary_kr";
            this.colSummaryKr.FillWeight = 76.81911F;
            this.colSummaryKr.HeaderText = "Summary";
            this.colSummaryKr.Name = "colSummaryKr";
            // 
            // colDueDate
            // 
            this.colDueDate.DataPropertyName = "due_date";
            this.colDueDate.FillWeight = 51.24502F;
            this.colDueDate.HeaderText = "Due Date";
            this.colDueDate.Name = "colDueDate";
            // 
            // colUpdateDate
            // 
            this.colUpdateDate.DataPropertyName = "update_date";
            this.colUpdateDate.FillWeight = 51.79351F;
            this.colUpdateDate.HeaderText = "Update Date";
            this.colUpdateDate.Name = "colUpdateDate";
            // 
            // colDocumentLink
            // 
            this.colDocumentLink.DataPropertyName = "document_name";
            this.colDocumentLink.FillWeight = 76.66993F;
            this.colDocumentLink.HeaderText = "File Name";
            this.colDocumentLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.colDocumentLink.Name = "colDocumentLink";
            // 
            // colDocumentPath
            // 
            this.colDocumentPath.DataPropertyName = "document_file";
            this.colDocumentPath.HeaderText = "File Path";
            this.colDocumentPath.Name = "colDocumentPath";
            this.colDocumentPath.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage2.Font = new System.Drawing.Font("굴림", 9F);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1232, 676);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "이마바리(SmartHull)";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1232, 676);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "미츠이";
            // 
            // tabPage4
            // 
            this.tabPage4.AutoScroll = true;
            this.tabPage4.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage4.Controls.Add(this.lbDBStatus);
            this.tabPage4.Controls.Add(this.btnConnect);
            this.tabPage4.Controls.Add(this.tbDbName);
            this.tabPage4.Controls.Add(this.tbDbPw);
            this.tabPage4.Controls.Add(this.tbDbId);
            this.tabPage4.Controls.Add(this.tbDbServer);
            this.tabPage4.Controls.Add(this.lbDbName);
            this.tabPage4.Controls.Add(this.lbPassword);
            this.tabPage4.Controls.Add(this.lbLoginId);
            this.tabPage4.Controls.Add(this.lbServer);
            this.tabPage4.Location = new System.Drawing.Point(4, 38);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1232, 676);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Settings";
            // 
            // lbDBStatus
            // 
            this.lbDBStatus.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbDBStatus.ForeColor = System.Drawing.Color.Red;
            this.lbDBStatus.Location = new System.Drawing.Point(260, 102);
            this.lbDBStatus.Name = "lbDBStatus";
            this.lbDBStatus.Size = new System.Drawing.Size(75, 20);
            this.lbDBStatus.TabIndex = 7;
            this.lbDBStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbDBStatus.UseCustomForeColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Highlight = true;
            this.btnConnect.Location = new System.Drawing.Point(260, 44);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 51);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connection\r\nTest";
            this.btnConnect.UseSelectable = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbDbName
            // 
            // 
            // 
            // 
            this.tbDbName.CustomButton.Image = null;
            this.tbDbName.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.tbDbName.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDbName.CustomButton.Name = "";
            this.tbDbName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbDbName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbDbName.CustomButton.TabIndex = 1;
            this.tbDbName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbDbName.CustomButton.UseSelectable = true;
            this.tbDbName.CustomButton.Visible = false;
            this.tbDbName.Lines = new string[0];
            this.tbDbName.Location = new System.Drawing.Point(105, 101);
            this.tbDbName.MaxLength = 32767;
            this.tbDbName.Name = "tbDbName";
            this.tbDbName.PasswordChar = '\0';
            this.tbDbName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDbName.SelectedText = "";
            this.tbDbName.SelectionLength = 0;
            this.tbDbName.SelectionStart = 0;
            this.tbDbName.ShortcutsEnabled = true;
            this.tbDbName.Size = new System.Drawing.Size(150, 23);
            this.tbDbName.TabIndex = 1;
            this.tbDbName.UseSelectable = true;
            this.tbDbName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbDbName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbDbPw
            // 
            // 
            // 
            // 
            this.tbDbPw.CustomButton.Image = null;
            this.tbDbPw.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.tbDbPw.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDbPw.CustomButton.Name = "";
            this.tbDbPw.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbDbPw.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbDbPw.CustomButton.TabIndex = 1;
            this.tbDbPw.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbDbPw.CustomButton.UseSelectable = true;
            this.tbDbPw.CustomButton.Visible = false;
            this.tbDbPw.Lines = new string[0];
            this.tbDbPw.Location = new System.Drawing.Point(105, 72);
            this.tbDbPw.MaxLength = 32767;
            this.tbDbPw.Name = "tbDbPw";
            this.tbDbPw.PasswordChar = '*';
            this.tbDbPw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDbPw.SelectedText = "";
            this.tbDbPw.SelectionLength = 0;
            this.tbDbPw.SelectionStart = 0;
            this.tbDbPw.ShortcutsEnabled = true;
            this.tbDbPw.Size = new System.Drawing.Size(150, 23);
            this.tbDbPw.TabIndex = 1;
            this.tbDbPw.UseSelectable = true;
            this.tbDbPw.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbDbPw.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbDbId
            // 
            // 
            // 
            // 
            this.tbDbId.CustomButton.Image = null;
            this.tbDbId.CustomButton.Location = new System.Drawing.Point(128, 1);
            this.tbDbId.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDbId.CustomButton.Name = "";
            this.tbDbId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbDbId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbDbId.CustomButton.TabIndex = 1;
            this.tbDbId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbDbId.CustomButton.UseSelectable = true;
            this.tbDbId.CustomButton.Visible = false;
            this.tbDbId.Lines = new string[0];
            this.tbDbId.Location = new System.Drawing.Point(105, 44);
            this.tbDbId.MaxLength = 32767;
            this.tbDbId.Name = "tbDbId";
            this.tbDbId.PasswordChar = '\0';
            this.tbDbId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDbId.SelectedText = "";
            this.tbDbId.SelectionLength = 0;
            this.tbDbId.SelectionStart = 0;
            this.tbDbId.ShortcutsEnabled = true;
            this.tbDbId.Size = new System.Drawing.Size(150, 23);
            this.tbDbId.TabIndex = 1;
            this.tbDbId.UseSelectable = true;
            this.tbDbId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbDbId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbDbServer
            // 
            // 
            // 
            // 
            this.tbDbServer.CustomButton.Image = null;
            this.tbDbServer.CustomButton.Location = new System.Drawing.Point(208, 1);
            this.tbDbServer.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDbServer.CustomButton.Name = "";
            this.tbDbServer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbDbServer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbDbServer.CustomButton.TabIndex = 1;
            this.tbDbServer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbDbServer.CustomButton.UseSelectable = true;
            this.tbDbServer.CustomButton.Visible = false;
            this.tbDbServer.Lines = new string[0];
            this.tbDbServer.Location = new System.Drawing.Point(105, 16);
            this.tbDbServer.MaxLength = 32767;
            this.tbDbServer.Name = "tbDbServer";
            this.tbDbServer.PasswordChar = '\0';
            this.tbDbServer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDbServer.SelectedText = "";
            this.tbDbServer.SelectionLength = 0;
            this.tbDbServer.SelectionStart = 0;
            this.tbDbServer.ShortcutsEnabled = true;
            this.tbDbServer.Size = new System.Drawing.Size(230, 23);
            this.tbDbServer.TabIndex = 1;
            this.tbDbServer.UseSelectable = true;
            this.tbDbServer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbDbServer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbDbName
            // 
            this.lbDbName.Location = new System.Drawing.Point(10, 100);
            this.lbDbName.Name = "lbDbName";
            this.lbDbName.Size = new System.Drawing.Size(90, 20);
            this.lbDbName.TabIndex = 1;
            this.lbDbName.Text = "DB Name :";
            this.lbDbName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbPassword
            // 
            this.lbPassword.Location = new System.Drawing.Point(10, 71);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(90, 20);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Password :";
            this.lbPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbLoginId
            // 
            this.lbLoginId.Location = new System.Drawing.Point(10, 43);
            this.lbLoginId.Name = "lbLoginId";
            this.lbLoginId.Size = new System.Drawing.Size(90, 20);
            this.lbLoginId.TabIndex = 0;
            this.lbLoginId.Text = "Login ID :";
            this.lbLoginId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbServer
            // 
            this.lbServer.Location = new System.Drawing.Point(10, 15);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(90, 20);
            this.lbServer.TabIndex = 0;
            this.lbServer.Text = "Server :";
            this.lbServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage5.Location = new System.Drawing.Point(4, 38);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1232, 676);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "SpisHelper";
            // 
            // lbMainTitle1
            // 
            this.lbMainTitle1.AutoSize = true;
            this.lbMainTitle1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbMainTitle1.ForeColor = System.Drawing.Color.Gray;
            this.lbMainTitle1.Location = new System.Drawing.Point(30, 7);
            this.lbMainTitle1.Name = "lbMainTitle1";
            this.lbMainTitle1.Size = new System.Drawing.Size(116, 19);
            this.lbMainTitle1.TabIndex = 1;
            this.lbMainTitle1.Text = "Hull Maintenance";
            this.lbMainTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbMainTitle1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lbMainTitle1.UseCustomForeColor = true;
            // 
            // lbMainTitle2
            // 
            this.lbMainTitle2.AutoSize = true;
            this.lbMainTitle2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lbMainTitle2.ForeColor = System.Drawing.Color.DarkGray;
            this.lbMainTitle2.Location = new System.Drawing.Point(170, 11);
            this.lbMainTitle2.Name = "lbMainTitle2";
            this.lbMainTitle2.Size = new System.Drawing.Size(127, 15);
            this.lbMainTitle2.TabIndex = 1;
            this.lbMainTitle2.Text = "Cadwin System Co., Ltd.";
            this.lbMainTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbMainTitle2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lbMainTitle2.UseCustomForeColor = true;
            // 
            // lbMainTitle3
            // 
            this.lbMainTitle3.AutoSize = true;
            this.lbMainTitle3.ForeColor = System.Drawing.Color.DarkGray;
            this.lbMainTitle3.Location = new System.Drawing.Point(152, 7);
            this.lbMainTitle3.Name = "lbMainTitle3";
            this.lbMainTitle3.Size = new System.Drawing.Size(12, 19);
            this.lbMainTitle3.TabIndex = 1;
            this.lbMainTitle3.Text = "|";
            this.lbMainTitle3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbMainTitle3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lbMainTitle3.UseCustomForeColor = true;
            // 
            // lbMainVersion
            // 
            this.lbMainVersion.AutoSize = true;
            this.lbMainVersion.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lbMainVersion.ForeColor = System.Drawing.Color.DarkGray;
            this.lbMainVersion.Location = new System.Drawing.Point(303, 11);
            this.lbMainVersion.Name = "lbMainVersion";
            this.lbMainVersion.Size = new System.Drawing.Size(81, 15);
            this.lbMainVersion.TabIndex = 1;
            this.lbMainVersion.Text = "version=1.0.0.0";
            this.lbMainVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbMainVersion.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lbMainVersion.UseCustomForeColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroGrid1);
            this.panel1.HorizontalScrollbarBarColor = true;
            this.panel1.HorizontalScrollbarHighlightOnWheel = false;
            this.panel1.HorizontalScrollbarSize = 10;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1232, 676);
            this.panel1.TabIndex = 0;
            this.panel1.VerticalScrollbarBarColor = true;
            this.panel1.VerticalScrollbarHighlightOnWheel = false;
            this.panel1.VerticalScrollbarSize = 10;
            // 
            // panel2
            // 
            this.panel2.HorizontalScrollbarBarColor = true;
            this.panel2.HorizontalScrollbarHighlightOnWheel = false;
            this.panel2.HorizontalScrollbarSize = 10;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1232, 676);
            this.panel2.TabIndex = 0;
            this.panel2.VerticalScrollbarBarColor = true;
            this.panel2.VerticalScrollbarHighlightOnWheel = false;
            this.panel2.VerticalScrollbarSize = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 768);
            this.Controls.Add(this.lbMainVersion);
            this.Controls.Add(this.lbMainTitle3);
            this.Controls.Add(this.lbMainTitle2);
            this.Controls.Add(this.lbMainTitle1);
            this.Controls.Add(this.tabControl);
            this.DisplayHeader = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Text = "Hull Maintenance";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private MetroFramework.Controls.MetroLabel lbMainTitle1;
        private MetroFramework.Controls.MetroLabel lbMainTitle2;
        private MetroFramework.Controls.MetroLabel lbMainTitle3;
        private MetroFramework.Controls.MetroLabel lbMainVersion;
        private MetroFramework.Controls.MetroTextBox tbDbName;
        private MetroFramework.Controls.MetroTextBox tbDbPw;
        private MetroFramework.Controls.MetroTextBox tbDbId;
        private MetroFramework.Controls.MetroTextBox tbDbServer;
        private MetroFramework.Controls.MetroLabel lbDbName;
        private MetroFramework.Controls.MetroLabel lbPassword;
        private MetroFramework.Controls.MetroLabel lbLoginId;
        private MetroFramework.Controls.MetroLabel lbServer;
        private MetroFramework.Controls.MetroButton btnConnect;
        private MetroFramework.Controls.MetroLabel lbDBStatus;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSummaryKr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUpdateDate;
        private System.Windows.Forms.DataGridViewLinkColumn colDocumentLink;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocumentPath;
        private MetroFramework.Controls.MetroPanel panel1;
        private MetroFramework.Controls.MetroPanel panel2;
    }
}

