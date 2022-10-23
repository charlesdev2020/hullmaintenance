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
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel1 = new MetroFramework.Controls.MetroPanel();
            this.collapsiblePanel1 = new MetroFramework.Controls.MetroPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new MetroFramework.Controls.MetroPanel();
            this.collapsiblePanel2 = new MetroFramework.Controls.MetroPanel();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnPath3 = new MetroFramework.Controls.MetroButton();
            this.tbPath3 = new MetroFramework.Controls.MetroTextBox();
            this.lbPath3 = new MetroFramework.Controls.MetroLabel();
            this.btnPath2 = new MetroFramework.Controls.MetroButton();
            this.tbPath2 = new MetroFramework.Controls.MetroTextBox();
            this.lbPath2 = new MetroFramework.Controls.MetroLabel();
            this.btnPath1 = new MetroFramework.Controls.MetroButton();
            this.tbPath1 = new MetroFramework.Controls.MetroTextBox();
            this.lbPath1 = new MetroFramework.Controls.MetroLabel();
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
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSummaryKr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUpdateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDocumentLink = new System.Windows.Forms.DataGridViewLinkColumn();
            this.colDocumentPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbMainTitle1 = new MetroFramework.Controls.MetroLabel();
            this.lbMainTitle2 = new MetroFramework.Controls.MetroLabel();
            this.lbMainTitle3 = new MetroFramework.Controls.MetroLabel();
            this.lbMainVersion = new MetroFramework.Controls.MetroLabel();
            this.btnPathOpen1 = new MetroFramework.Controls.MetroButton();
            this.btnPathOpen2 = new MetroFramework.Controls.MetroButton();
            this.btnPathOpen3 = new MetroFramework.Controls.MetroButton();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(20, 30);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 3;
            this.tabControl.Size = new System.Drawing.Size(1240, 718);
            this.tabControl.TabIndex = 0;
            this.tabControl.UseSelectable = true;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.metroTabControl_SelectedIndexChanged);
            this.tabControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControl_KeyDown);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.collapsiblePanel1);
            this.tabPage1.Font = new System.Drawing.Font("굴림", 9F);
            this.tabPage1.Location = new System.Drawing.Point(4, 41);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1232, 673);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "SmartHull";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.HorizontalScrollbarBarColor = true;
            this.panel1.HorizontalScrollbarHighlightOnWheel = false;
            this.panel1.HorizontalScrollbarSize = 10;
            this.panel1.Location = new System.Drawing.Point(0, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1232, 573);
            this.panel1.TabIndex = 1;
            this.panel1.UseCustomBackColor = true;
            this.panel1.VerticalScrollbarBarColor = true;
            this.panel1.VerticalScrollbarHighlightOnWheel = false;
            this.panel1.VerticalScrollbarSize = 10;
            // 
            // collapsiblePanel1
            // 
            this.collapsiblePanel1.BackColor = System.Drawing.SystemColors.Info;
            this.collapsiblePanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.collapsiblePanel1.HorizontalScrollbarBarColor = true;
            this.collapsiblePanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.collapsiblePanel1.HorizontalScrollbarSize = 10;
            this.collapsiblePanel1.Location = new System.Drawing.Point(0, 0);
            this.collapsiblePanel1.Name = "collapsiblePanel1";
            this.collapsiblePanel1.Size = new System.Drawing.Size(1232, 100);
            this.collapsiblePanel1.TabIndex = 0;
            this.collapsiblePanel1.UseCustomBackColor = true;
            this.collapsiblePanel1.VerticalScrollbarBarColor = true;
            this.collapsiblePanel1.VerticalScrollbarHighlightOnWheel = false;
            this.collapsiblePanel1.VerticalScrollbarSize = 10;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Controls.Add(this.collapsiblePanel2);
            this.tabPage2.Font = new System.Drawing.Font("굴림", 9F);
            this.tabPage2.Location = new System.Drawing.Point(4, 41);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1232, 673);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "SpisHull";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.HorizontalScrollbarBarColor = true;
            this.panel2.HorizontalScrollbarHighlightOnWheel = false;
            this.panel2.HorizontalScrollbarSize = 10;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1232, 573);
            this.panel2.TabIndex = 1;
            this.panel2.UseCustomBackColor = true;
            this.panel2.VerticalScrollbarBarColor = true;
            this.panel2.VerticalScrollbarHighlightOnWheel = false;
            this.panel2.VerticalScrollbarSize = 10;
            // 
            // collapsiblePanel2
            // 
            this.collapsiblePanel2.BackColor = System.Drawing.Color.LavenderBlush;
            this.collapsiblePanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.collapsiblePanel2.HorizontalScrollbarBarColor = true;
            this.collapsiblePanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.collapsiblePanel2.HorizontalScrollbarSize = 10;
            this.collapsiblePanel2.Location = new System.Drawing.Point(0, 0);
            this.collapsiblePanel2.Name = "collapsiblePanel2";
            this.collapsiblePanel2.Size = new System.Drawing.Size(1232, 100);
            this.collapsiblePanel2.TabIndex = 0;
            this.collapsiblePanel2.UseCustomBackColor = true;
            this.collapsiblePanel2.VerticalScrollbarBarColor = true;
            this.collapsiblePanel2.VerticalScrollbarHighlightOnWheel = false;
            this.collapsiblePanel2.VerticalScrollbarSize = 10;
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage3.Controls.Add(this.btnPathOpen3);
            this.tabPage3.Controls.Add(this.btnPathOpen2);
            this.tabPage3.Controls.Add(this.btnPathOpen1);
            this.tabPage3.Controls.Add(this.btnPath3);
            this.tabPage3.Controls.Add(this.tbPath3);
            this.tabPage3.Controls.Add(this.lbPath3);
            this.tabPage3.Controls.Add(this.btnPath2);
            this.tabPage3.Controls.Add(this.tbPath2);
            this.tabPage3.Controls.Add(this.lbPath2);
            this.tabPage3.Controls.Add(this.btnPath1);
            this.tabPage3.Controls.Add(this.tbPath1);
            this.tabPage3.Controls.Add(this.lbPath1);
            this.tabPage3.Controls.Add(this.lbDBStatus);
            this.tabPage3.Controls.Add(this.btnConnect);
            this.tabPage3.Controls.Add(this.tbDbName);
            this.tabPage3.Controls.Add(this.tbDbPw);
            this.tabPage3.Controls.Add(this.tbDbId);
            this.tabPage3.Controls.Add(this.tbDbServer);
            this.tabPage3.Controls.Add(this.lbDbName);
            this.tabPage3.Controls.Add(this.lbPassword);
            this.tabPage3.Controls.Add(this.lbLoginId);
            this.tabPage3.Controls.Add(this.lbServer);
            this.tabPage3.Location = new System.Drawing.Point(4, 41);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1232, 673);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Settings";
            // 
            // btnPath3
            // 
            this.btnPath3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPath3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPath3.Location = new System.Drawing.Point(843, 217);
            this.btnPath3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPath3.Name = "btnPath3";
            this.btnPath3.Size = new System.Drawing.Size(35, 24);
            this.btnPath3.TabIndex = 13;
            this.btnPath3.Tag = "tbPath3";
            this.btnPath3.Text = "···";
            this.btnPath3.UseSelectable = true;
            this.btnPath3.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // tbPath3
            // 
            // 
            // 
            // 
            this.tbPath3.CustomButton.Image = null;
            this.tbPath3.CustomButton.Location = new System.Drawing.Point(590, 1);
            this.tbPath3.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPath3.CustomButton.Name = "";
            this.tbPath3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPath3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPath3.CustomButton.TabIndex = 1;
            this.tbPath3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPath3.CustomButton.UseSelectable = true;
            this.tbPath3.CustomButton.Visible = false;
            this.tbPath3.Lines = new string[0];
            this.tbPath3.Location = new System.Drawing.Point(225, 217);
            this.tbPath3.MaxLength = 32767;
            this.tbPath3.Name = "tbPath3";
            this.tbPath3.PasswordChar = '\0';
            this.tbPath3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPath3.SelectedText = "";
            this.tbPath3.SelectionLength = 0;
            this.tbPath3.SelectionStart = 0;
            this.tbPath3.ShortcutsEnabled = true;
            this.tbPath3.Size = new System.Drawing.Size(612, 23);
            this.tbPath3.TabIndex = 12;
            this.tbPath3.UseSelectable = true;
            this.tbPath3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPath3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbPath3
            // 
            this.lbPath3.Location = new System.Drawing.Point(10, 218);
            this.lbPath3.Name = "lbPath3";
            this.lbPath3.Size = new System.Drawing.Size(210, 20);
            this.lbPath3.TabIndex = 10;
            this.lbPath3.Text = "이마바리(SmartHull) 디렉토리 :";
            this.lbPath3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPath2
            // 
            this.btnPath2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPath2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPath2.Location = new System.Drawing.Point(843, 188);
            this.btnPath2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPath2.Name = "btnPath2";
            this.btnPath2.Size = new System.Drawing.Size(35, 24);
            this.btnPath2.TabIndex = 10;
            this.btnPath2.Tag = "tbPath2";
            this.btnPath2.Text = "···";
            this.btnPath2.UseSelectable = true;
            this.btnPath2.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // tbPath2
            // 
            // 
            // 
            // 
            this.tbPath2.CustomButton.Image = null;
            this.tbPath2.CustomButton.Location = new System.Drawing.Point(590, 1);
            this.tbPath2.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPath2.CustomButton.Name = "";
            this.tbPath2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPath2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPath2.CustomButton.TabIndex = 1;
            this.tbPath2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPath2.CustomButton.UseSelectable = true;
            this.tbPath2.CustomButton.Visible = false;
            this.tbPath2.Lines = new string[0];
            this.tbPath2.Location = new System.Drawing.Point(225, 188);
            this.tbPath2.MaxLength = 32767;
            this.tbPath2.Name = "tbPath2";
            this.tbPath2.PasswordChar = '\0';
            this.tbPath2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPath2.SelectedText = "";
            this.tbPath2.SelectionLength = 0;
            this.tbPath2.SelectionStart = 0;
            this.tbPath2.ShortcutsEnabled = true;
            this.tbPath2.Size = new System.Drawing.Size(612, 23);
            this.tbPath2.TabIndex = 9;
            this.tbPath2.UseSelectable = true;
            this.tbPath2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPath2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbPath2
            // 
            this.lbPath2.Location = new System.Drawing.Point(10, 189);
            this.lbPath2.Name = "lbPath2";
            this.lbPath2.Size = new System.Drawing.Size(210, 20);
            this.lbPath2.TabIndex = 1;
            this.lbPath2.Text = "미츠이(SpisHull) 디렉토리 :";
            this.lbPath2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnPath1
            // 
            this.btnPath1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPath1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPath1.Location = new System.Drawing.Point(843, 159);
            this.btnPath1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPath1.Name = "btnPath1";
            this.btnPath1.Size = new System.Drawing.Size(35, 24);
            this.btnPath1.TabIndex = 7;
            this.btnPath1.Tag = "tbPath1";
            this.btnPath1.Text = "···";
            this.btnPath1.UseSelectable = true;
            this.btnPath1.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // tbPath1
            // 
            // 
            // 
            // 
            this.tbPath1.CustomButton.Image = null;
            this.tbPath1.CustomButton.Location = new System.Drawing.Point(590, 1);
            this.tbPath1.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPath1.CustomButton.Name = "";
            this.tbPath1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPath1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPath1.CustomButton.TabIndex = 1;
            this.tbPath1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPath1.CustomButton.UseSelectable = true;
            this.tbPath1.CustomButton.Visible = false;
            this.tbPath1.Lines = new string[0];
            this.tbPath1.Location = new System.Drawing.Point(225, 159);
            this.tbPath1.MaxLength = 32767;
            this.tbPath1.Name = "tbPath1";
            this.tbPath1.PasswordChar = '\0';
            this.tbPath1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPath1.SelectedText = "";
            this.tbPath1.SelectionLength = 0;
            this.tbPath1.SelectionStart = 0;
            this.tbPath1.ShortcutsEnabled = true;
            this.tbPath1.Size = new System.Drawing.Size(612, 23);
            this.tbPath1.TabIndex = 6;
            this.tbPath1.UseSelectable = true;
            this.tbPath1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPath1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbPath1
            // 
            this.lbPath1.Location = new System.Drawing.Point(10, 160);
            this.lbPath1.Name = "lbPath1";
            this.lbPath1.Size = new System.Drawing.Size(210, 20);
            this.lbPath1.TabIndex = 1;
            this.lbPath1.Text = "이마바리(SpisHull) 디렉토리 :";
            this.lbPath1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.btnConnect.TabIndex = 5;
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
            this.tbDbName.TabIndex = 4;
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
            this.tbDbPw.TabIndex = 3;
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
            this.tbDbId.TabIndex = 2;
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
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage4.Location = new System.Drawing.Point(4, 41);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1232, 673);
            this.tabPage4.TabIndex = 5;
            this.tabPage4.Text = "Helper";
            // 
            // colId
            // 
            this.colId.DataPropertyName = "id";
            this.colId.FillWeight = 16.98324F;
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // colCustomer
            // 
            this.colCustomer.DataPropertyName = "customer";
            this.colCustomer.HeaderText = "Customer";
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.Visible = false;
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
            // btnPathOpen1
            // 
            this.btnPathOpen1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPathOpen1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPathOpen1.Location = new System.Drawing.Point(884, 159);
            this.btnPathOpen1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPathOpen1.Name = "btnPathOpen1";
            this.btnPathOpen1.Size = new System.Drawing.Size(35, 24);
            this.btnPathOpen1.TabIndex = 8;
            this.btnPathOpen1.Tag = "tbPath1";
            this.btnPathOpen1.Text = "Open";
            this.btnPathOpen1.UseSelectable = true;
            this.btnPathOpen1.Click += new System.EventHandler(this.btnPathOpen_Click);
            // 
            // btnPathOpen2
            // 
            this.btnPathOpen2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPathOpen2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPathOpen2.Location = new System.Drawing.Point(884, 188);
            this.btnPathOpen2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPathOpen2.Name = "btnPathOpen2";
            this.btnPathOpen2.Size = new System.Drawing.Size(35, 24);
            this.btnPathOpen2.TabIndex = 11;
            this.btnPathOpen2.Tag = "tbPath2";
            this.btnPathOpen2.Text = "Open";
            this.btnPathOpen2.UseSelectable = true;
            this.btnPathOpen2.Click += new System.EventHandler(this.btnPathOpen_Click);
            // 
            // btnPathOpen3
            // 
            this.btnPathOpen3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPathOpen3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPathOpen3.Location = new System.Drawing.Point(884, 217);
            this.btnPathOpen3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPathOpen3.Name = "btnPathOpen3";
            this.btnPathOpen3.Size = new System.Drawing.Size(35, 24);
            this.btnPathOpen3.TabIndex = 14;
            this.btnPathOpen3.Tag = "tbPath3";
            this.btnPathOpen3.Text = "Open";
            this.btnPathOpen3.UseSelectable = true;
            this.btnPathOpen3.Click += new System.EventHandler(this.btnPathOpen_Click);
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSummaryKr;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUpdateDate;
        private System.Windows.Forms.DataGridViewLinkColumn colDocumentLink;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDocumentPath;
        private MetroFramework.Controls.MetroTextBox tbPath1;
        private MetroFramework.Controls.MetroLabel lbPath1;
        private MetroFramework.Controls.MetroButton btnPath1;
        private MetroFramework.Controls.MetroButton btnPath2;
        private MetroFramework.Controls.MetroTextBox tbPath2;
        private MetroFramework.Controls.MetroLabel lbPath2;
        private MetroFramework.Controls.MetroButton btnPath3;
        private MetroFramework.Controls.MetroTextBox tbPath3;
        private MetroFramework.Controls.MetroLabel lbPath3;
        private MetroFramework.Controls.MetroPanel panel1;
        private MetroFramework.Controls.MetroPanel collapsiblePanel1;
        private MetroFramework.Controls.MetroPanel panel2;
        private MetroFramework.Controls.MetroPanel collapsiblePanel2;
        private MetroFramework.Controls.MetroButton btnPathOpen3;
        private MetroFramework.Controls.MetroButton btnPathOpen2;
        private MetroFramework.Controls.MetroButton btnPathOpen1;
    }
}

