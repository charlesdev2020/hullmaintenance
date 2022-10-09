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
            this.metroTabControl = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.lbMainTitle1 = new MetroFramework.Controls.MetroLabel();
            this.lbMainTitle2 = new MetroFramework.Controls.MetroLabel();
            this.lbMainTitle3 = new MetroFramework.Controls.MetroLabel();
            this.lbMainVersion = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl
            // 
            this.metroTabControl.Controls.Add(this.tabPage1);
            this.metroTabControl.Controls.Add(this.tabPage2);
            this.metroTabControl.Controls.Add(this.tabPage3);
            this.metroTabControl.Controls.Add(this.tabPage4);
            this.metroTabControl.Controls.Add(this.tabPage5);
            this.metroTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl.Location = new System.Drawing.Point(20, 30);
            this.metroTabControl.Name = "metroTabControl";
            this.metroTabControl.SelectedIndex = 1;
            this.metroTabControl.Size = new System.Drawing.Size(760, 550);
            this.metroTabControl.TabIndex = 0;
            this.metroTabControl.UseSelectable = true;
            this.metroTabControl.SelectedIndexChanged += new System.EventHandler(this.metroTabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(752, 508);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "이마바리(SpisHull)";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(752, 508);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "이마바리(SmartHull)";
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
            this.tabPage4.Size = new System.Drawing.Size(752, 508);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Settings";
            // 
            // lbDBStatus
            // 
            this.lbDBStatus.ForeColor = System.Drawing.Color.Red;
            this.lbDBStatus.Location = new System.Drawing.Point(260, 100);
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
            this.tbDbName.CustomButton.Name = "";
            this.tbDbName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbDbName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbDbName.CustomButton.TabIndex = 1;
            this.tbDbName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbDbName.CustomButton.UseSelectable = true;
            this.tbDbName.CustomButton.Visible = false;
            this.tbDbName.Lines = new string[] {
        "HULLDB"};
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
            this.tbDbName.TabIndex = 5;
            this.tbDbName.Text = "HULLDB";
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
            this.tbDbPw.CustomButton.Name = "";
            this.tbDbPw.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbDbPw.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbDbPw.CustomButton.TabIndex = 1;
            this.tbDbPw.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbDbPw.CustomButton.UseSelectable = true;
            this.tbDbPw.CustomButton.Visible = false;
            this.tbDbPw.Lines = new string[] {
        "spishull"};
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
            this.tbDbPw.TabIndex = 4;
            this.tbDbPw.Text = "spishull";
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
            this.tbDbId.CustomButton.Name = "";
            this.tbDbId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbDbId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbDbId.CustomButton.TabIndex = 1;
            this.tbDbId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbDbId.CustomButton.UseSelectable = true;
            this.tbDbId.CustomButton.Visible = false;
            this.tbDbId.Lines = new string[] {
        "Spis"};
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
            this.tbDbId.TabIndex = 3;
            this.tbDbId.Text = "Spis";
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
            this.tbDbServer.CustomButton.Name = "";
            this.tbDbServer.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbDbServer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbDbServer.CustomButton.TabIndex = 1;
            this.tbDbServer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbDbServer.CustomButton.UseSelectable = true;
            this.tbDbServer.CustomButton.Visible = false;
            this.tbDbServer.Lines = new string[] {
        "192.168.10.49\\MSSQLSERVER, 1566"};
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
            this.tbDbServer.TabIndex = 2;
            this.tbDbServer.Text = "192.168.10.49\\MSSQLSERVER, 1566";
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
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(752, 508);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "미츠이";
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.SystemColors.Window;
            this.tabPage5.Location = new System.Drawing.Point(4, 38);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(752, 508);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.lbMainVersion);
            this.Controls.Add(this.lbMainTitle3);
            this.Controls.Add(this.lbMainTitle2);
            this.Controls.Add(this.lbMainTitle1);
            this.Controls.Add(this.metroTabControl);
            this.DisplayHeader = false;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Text = "Hull Maintenance";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.metroTabControl.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl;
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
    }
}

