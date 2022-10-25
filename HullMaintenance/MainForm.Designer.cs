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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			this.tabControl = new MetroFramework.Controls.MetroTabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.smhPanel = new MetroFramework.Controls.MetroPanel();
			this.smhGrid = new MetroFramework.Controls.MetroGrid();
			this.collapsibleSmhPanel = new MetroFramework.Controls.MetroPanel();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.stdPanel = new MetroFramework.Controls.MetroPanel();
			this.stdGrid = new MetroFramework.Controls.MetroGrid();
			this.collapsibleStdPanel = new MetroFramework.Controls.MetroPanel();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.btnTheme = new MetroFramework.Controls.MetroButton();
			this.btnStyle = new MetroFramework.Controls.MetroButton();
			this.btnPathOpen3 = new MetroFramework.Controls.MetroButton();
			this.btnPathOpen2 = new MetroFramework.Controls.MetroButton();
			this.btnPathOpen1 = new MetroFramework.Controls.MetroButton();
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
			this.lbMainTitle1 = new MetroFramework.Controls.MetroLabel();
			this.lbMainTitle2 = new MetroFramework.Controls.MetroLabel();
			this.lbMainTitle3 = new MetroFramework.Controls.MetroLabel();
			this.lbMainVersion = new MetroFramework.Controls.MetroLabel();
			this.styleMgr = new MetroFramework.Components.MetroStyleManager(this.components);
			this.stdColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.stdColCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.stdColType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.stdColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.stdColSummaryKr = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.stdColDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.stdColUpdateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.stdColDocumentLink = new System.Windows.Forms.DataGridViewLinkColumn();
			this.stdColDocumentPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.smhColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.smhColCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.smhColType = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.smhColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.smhColSummaryKr = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.smhColDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.smhColUpdateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.smhColDocumentLink = new System.Windows.Forms.DataGridViewLinkColumn();
			this.smhColDocumentPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tabControl.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.smhPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.smhGrid)).BeginInit();
			this.tabPage2.SuspendLayout();
			this.stdPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.stdGrid)).BeginInit();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.styleMgr)).BeginInit();
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
			this.tabControl.Location = new System.Drawing.Point(23, 38);
			this.tabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(1417, 897);
			this.tabControl.TabIndex = 0;
			this.tabControl.UseSelectable = true;
			this.tabControl.SelectedIndexChanged += new System.EventHandler(this.metroTabControl_SelectedIndexChanged);
			this.tabControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControl_KeyDown);
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.SystemColors.Window;
			this.tabPage1.Controls.Add(this.smhPanel);
			this.tabPage1.Controls.Add(this.collapsibleSmhPanel);
			this.tabPage1.Font = new System.Drawing.Font("굴림", 9F);
			this.tabPage1.Location = new System.Drawing.Point(4, 41);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(1409, 852);
			this.tabPage1.TabIndex = 1;
			this.tabPage1.Text = "SmartHull";
			// 
			// smhPanel
			// 
			this.smhPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.smhPanel.Controls.Add(this.smhGrid);
			this.smhPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.smhPanel.HorizontalScrollbarBarColor = true;
			this.smhPanel.HorizontalScrollbarHighlightOnWheel = false;
			this.smhPanel.HorizontalScrollbarSize = 12;
			this.smhPanel.Location = new System.Drawing.Point(0, 60);
			this.smhPanel.Margin = new System.Windows.Forms.Padding(0);
			this.smhPanel.Name = "smhPanel";
			this.smhPanel.Padding = new System.Windows.Forms.Padding(1);
			this.smhPanel.Size = new System.Drawing.Size(1409, 792);
			this.smhPanel.TabIndex = 1;
			this.smhPanel.UseCustomBackColor = true;
			this.smhPanel.VerticalScrollbarBarColor = true;
			this.smhPanel.VerticalScrollbarHighlightOnWheel = false;
			this.smhPanel.VerticalScrollbarSize = 11;
			// 
			// smhGrid
			// 
			this.smhGrid.AllowUserToAddRows = false;
			this.smhGrid.AllowUserToDeleteRows = false;
			this.smhGrid.AllowUserToOrderColumns = true;
			this.smhGrid.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.smhGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.smhGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.smhGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.smhGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.smhGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.smhGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.smhGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.smhGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.smhGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.smhColId,
            this.smhColCustomer,
            this.smhColType,
            this.smhColStatus,
            this.smhColSummaryKr,
            this.smhColDueDate,
            this.smhColUpdateDate,
            this.smhColDocumentLink,
            this.smhColDocumentPath});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.smhGrid.DefaultCellStyle = dataGridViewCellStyle3;
			this.smhGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.smhGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.smhGrid.EnableHeadersVisualStyles = false;
			this.smhGrid.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.smhGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.smhGrid.Location = new System.Drawing.Point(1, 1);
			this.smhGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.smhGrid.MultiSelect = false;
			this.smhGrid.Name = "smhGrid";
			this.smhGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.smhGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.smhGrid.RowHeadersWidth = 20;
			this.smhGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.smhGrid.RowTemplate.DividerHeight = 1;
			this.smhGrid.RowTemplate.Height = 23;
			this.smhGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.smhGrid.Size = new System.Drawing.Size(1407, 790);
			this.smhGrid.TabIndex = 1;
			// 
			// collapsibleSmhPanel
			// 
			this.collapsibleSmhPanel.BackColor = System.Drawing.SystemColors.ControlLight;
			this.collapsibleSmhPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.collapsibleSmhPanel.HorizontalScrollbarBarColor = true;
			this.collapsibleSmhPanel.HorizontalScrollbarHighlightOnWheel = false;
			this.collapsibleSmhPanel.HorizontalScrollbarSize = 12;
			this.collapsibleSmhPanel.Location = new System.Drawing.Point(0, 0);
			this.collapsibleSmhPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.collapsibleSmhPanel.Name = "collapsibleSmhPanel";
			this.collapsibleSmhPanel.Size = new System.Drawing.Size(1409, 60);
			this.collapsibleSmhPanel.TabIndex = 0;
			this.collapsibleSmhPanel.UseCustomBackColor = true;
			this.collapsibleSmhPanel.VerticalScrollbarBarColor = true;
			this.collapsibleSmhPanel.VerticalScrollbarHighlightOnWheel = false;
			this.collapsibleSmhPanel.VerticalScrollbarSize = 11;
			// 
			// tabPage2
			// 
			this.tabPage2.AutoScroll = true;
			this.tabPage2.BackColor = System.Drawing.SystemColors.Window;
			this.tabPage2.Controls.Add(this.stdPanel);
			this.tabPage2.Controls.Add(this.collapsibleStdPanel);
			this.tabPage2.Font = new System.Drawing.Font("굴림", 9F);
			this.tabPage2.Location = new System.Drawing.Point(4, 41);
			this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(1409, 852);
			this.tabPage2.TabIndex = 2;
			this.tabPage2.Text = "SpisHull";
			// 
			// stdPanel
			// 
			this.stdPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.stdPanel.Controls.Add(this.stdGrid);
			this.stdPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stdPanel.HorizontalScrollbarBarColor = true;
			this.stdPanel.HorizontalScrollbarHighlightOnWheel = false;
			this.stdPanel.HorizontalScrollbarSize = 12;
			this.stdPanel.Location = new System.Drawing.Point(0, 60);
			this.stdPanel.Margin = new System.Windows.Forms.Padding(0);
			this.stdPanel.Name = "stdPanel";
			this.stdPanel.Padding = new System.Windows.Forms.Padding(1);
			this.stdPanel.Size = new System.Drawing.Size(1409, 792);
			this.stdPanel.TabIndex = 1;
			this.stdPanel.UseCustomBackColor = true;
			this.stdPanel.VerticalScrollbarBarColor = true;
			this.stdPanel.VerticalScrollbarHighlightOnWheel = false;
			this.stdPanel.VerticalScrollbarSize = 11;
			// 
			// stdGrid
			// 
			this.stdGrid.AllowUserToAddRows = false;
			this.stdGrid.AllowUserToDeleteRows = false;
			this.stdGrid.AllowUserToOrderColumns = true;
			this.stdGrid.AllowUserToResizeRows = false;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.stdGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
			this.stdGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.stdGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.stdGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.stdGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
			this.stdGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.stdGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.stdGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.stdGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stdColId,
            this.stdColCustomer,
            this.stdColType,
            this.stdColStatus,
            this.stdColSummaryKr,
            this.stdColDueDate,
            this.stdColUpdateDate,
            this.stdColDocumentLink,
            this.stdColDocumentPath});
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
			dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.stdGrid.DefaultCellStyle = dataGridViewCellStyle7;
			this.stdGrid.Dock = System.Windows.Forms.DockStyle.Fill;
			this.stdGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.stdGrid.EnableHeadersVisualStyles = false;
			this.stdGrid.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			this.stdGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.stdGrid.Location = new System.Drawing.Point(1, 1);
			this.stdGrid.Margin = new System.Windows.Forms.Padding(0);
			this.stdGrid.MultiSelect = false;
			this.stdGrid.Name = "stdGrid";
			this.stdGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
			dataGridViewCellStyle8.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
			dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
			dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.stdGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
			this.stdGrid.RowHeadersWidth = 20;
			this.stdGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.stdGrid.RowTemplate.DividerHeight = 1;
			this.stdGrid.RowTemplate.Height = 23;
			this.stdGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.stdGrid.Size = new System.Drawing.Size(1407, 790);
			this.stdGrid.TabIndex = 1;
			// 
			// collapsibleStdPanel
			// 
			this.collapsibleStdPanel.BackColor = System.Drawing.SystemColors.ControlLight;
			this.collapsibleStdPanel.Dock = System.Windows.Forms.DockStyle.Top;
			this.collapsibleStdPanel.HorizontalScrollbarBarColor = true;
			this.collapsibleStdPanel.HorizontalScrollbarHighlightOnWheel = false;
			this.collapsibleStdPanel.HorizontalScrollbarSize = 12;
			this.collapsibleStdPanel.Location = new System.Drawing.Point(0, 0);
			this.collapsibleStdPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.collapsibleStdPanel.Name = "collapsibleStdPanel";
			this.collapsibleStdPanel.Size = new System.Drawing.Size(1409, 60);
			this.collapsibleStdPanel.TabIndex = 0;
			this.collapsibleStdPanel.UseCustomBackColor = true;
			this.collapsibleStdPanel.VerticalScrollbarBarColor = true;
			this.collapsibleStdPanel.VerticalScrollbarHighlightOnWheel = false;
			this.collapsibleStdPanel.VerticalScrollbarSize = 11;
			// 
			// tabPage3
			// 
			this.tabPage3.AutoScroll = true;
			this.tabPage3.BackColor = System.Drawing.SystemColors.Window;
			this.tabPage3.Controls.Add(this.btnTheme);
			this.tabPage3.Controls.Add(this.btnStyle);
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
			this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(1409, 852);
			this.tabPage3.TabIndex = 4;
			this.tabPage3.Text = "Settings";
			// 
			// btnTheme
			// 
			this.btnTheme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnTheme.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnTheme.Location = new System.Drawing.Point(963, 19);
			this.btnTheme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnTheme.Name = "btnTheme";
			this.btnTheme.Size = new System.Drawing.Size(87, 30);
			this.btnTheme.TabIndex = 16;
			this.btnTheme.Tag = "";
			this.btnTheme.Text = "Theme";
			this.btnTheme.UseSelectable = true;
			this.btnTheme.Click += new System.EventHandler(this.btnTheme_Click);
			// 
			// btnStyle
			// 
			this.btnStyle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnStyle.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnStyle.Location = new System.Drawing.Point(1057, 19);
			this.btnStyle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnStyle.Name = "btnStyle";
			this.btnStyle.Size = new System.Drawing.Size(40, 30);
			this.btnStyle.TabIndex = 15;
			this.btnStyle.Tag = "";
			this.btnStyle.Text = "Style";
			this.btnStyle.UseSelectable = true;
			this.btnStyle.Click += new System.EventHandler(this.btnStyle_Click);
			// 
			// btnPathOpen3
			// 
			this.btnPathOpen3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnPathOpen3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPathOpen3.Location = new System.Drawing.Point(1010, 271);
			this.btnPathOpen3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPathOpen3.Name = "btnPathOpen3";
			this.btnPathOpen3.Size = new System.Drawing.Size(40, 30);
			this.btnPathOpen3.TabIndex = 14;
			this.btnPathOpen3.Tag = "tbPath3";
			this.btnPathOpen3.Text = "Open";
			this.btnPathOpen3.UseSelectable = true;
			this.btnPathOpen3.Click += new System.EventHandler(this.btnPathOpen_Click);
			// 
			// btnPathOpen2
			// 
			this.btnPathOpen2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnPathOpen2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPathOpen2.Location = new System.Drawing.Point(1010, 235);
			this.btnPathOpen2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPathOpen2.Name = "btnPathOpen2";
			this.btnPathOpen2.Size = new System.Drawing.Size(40, 30);
			this.btnPathOpen2.TabIndex = 11;
			this.btnPathOpen2.Tag = "tbPath2";
			this.btnPathOpen2.Text = "Open";
			this.btnPathOpen2.UseSelectable = true;
			this.btnPathOpen2.Click += new System.EventHandler(this.btnPathOpen_Click);
			// 
			// btnPathOpen1
			// 
			this.btnPathOpen1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnPathOpen1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPathOpen1.Location = new System.Drawing.Point(1010, 199);
			this.btnPathOpen1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPathOpen1.Name = "btnPathOpen1";
			this.btnPathOpen1.Size = new System.Drawing.Size(40, 30);
			this.btnPathOpen1.TabIndex = 8;
			this.btnPathOpen1.Tag = "tbPath1";
			this.btnPathOpen1.Text = "Open";
			this.btnPathOpen1.UseSelectable = true;
			this.btnPathOpen1.Click += new System.EventHandler(this.btnPathOpen_Click);
			// 
			// btnPath3
			// 
			this.btnPath3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnPath3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPath3.Location = new System.Drawing.Point(963, 271);
			this.btnPath3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPath3.Name = "btnPath3";
			this.btnPath3.Size = new System.Drawing.Size(40, 30);
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
			this.tbPath3.CustomButton.Location = new System.Drawing.Point(671, 1);
			this.tbPath3.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbPath3.CustomButton.Name = "";
			this.tbPath3.CustomButton.Size = new System.Drawing.Size(27, 27);
			this.tbPath3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.tbPath3.CustomButton.TabIndex = 1;
			this.tbPath3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.tbPath3.CustomButton.UseSelectable = true;
			this.tbPath3.CustomButton.Visible = false;
			this.tbPath3.Lines = new string[0];
			this.tbPath3.Location = new System.Drawing.Point(257, 271);
			this.tbPath3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tbPath3.MaxLength = 32767;
			this.tbPath3.Name = "tbPath3";
			this.tbPath3.PasswordChar = '\0';
			this.tbPath3.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.tbPath3.SelectedText = "";
			this.tbPath3.SelectionLength = 0;
			this.tbPath3.SelectionStart = 0;
			this.tbPath3.ShortcutsEnabled = true;
			this.tbPath3.Size = new System.Drawing.Size(699, 29);
			this.tbPath3.TabIndex = 12;
			this.tbPath3.UseSelectable = true;
			this.tbPath3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.tbPath3.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// lbPath3
			// 
			this.lbPath3.Location = new System.Drawing.Point(11, 272);
			this.lbPath3.Name = "lbPath3";
			this.lbPath3.Size = new System.Drawing.Size(240, 25);
			this.lbPath3.TabIndex = 10;
			this.lbPath3.Text = "이마바리(SmartHull) 디렉토리 :";
			this.lbPath3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnPath2
			// 
			this.btnPath2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnPath2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPath2.Location = new System.Drawing.Point(963, 235);
			this.btnPath2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPath2.Name = "btnPath2";
			this.btnPath2.Size = new System.Drawing.Size(40, 30);
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
			this.tbPath2.CustomButton.Location = new System.Drawing.Point(671, 1);
			this.tbPath2.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbPath2.CustomButton.Name = "";
			this.tbPath2.CustomButton.Size = new System.Drawing.Size(27, 27);
			this.tbPath2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.tbPath2.CustomButton.TabIndex = 1;
			this.tbPath2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.tbPath2.CustomButton.UseSelectable = true;
			this.tbPath2.CustomButton.Visible = false;
			this.tbPath2.Lines = new string[0];
			this.tbPath2.Location = new System.Drawing.Point(257, 235);
			this.tbPath2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tbPath2.MaxLength = 32767;
			this.tbPath2.Name = "tbPath2";
			this.tbPath2.PasswordChar = '\0';
			this.tbPath2.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.tbPath2.SelectedText = "";
			this.tbPath2.SelectionLength = 0;
			this.tbPath2.SelectionStart = 0;
			this.tbPath2.ShortcutsEnabled = true;
			this.tbPath2.Size = new System.Drawing.Size(699, 29);
			this.tbPath2.TabIndex = 9;
			this.tbPath2.UseSelectable = true;
			this.tbPath2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.tbPath2.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// lbPath2
			// 
			this.lbPath2.Location = new System.Drawing.Point(11, 236);
			this.lbPath2.Name = "lbPath2";
			this.lbPath2.Size = new System.Drawing.Size(240, 25);
			this.lbPath2.TabIndex = 1;
			this.lbPath2.Text = "미츠이(SpisHull) 디렉토리 :";
			this.lbPath2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// btnPath1
			// 
			this.btnPath1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnPath1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPath1.Location = new System.Drawing.Point(963, 199);
			this.btnPath1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnPath1.Name = "btnPath1";
			this.btnPath1.Size = new System.Drawing.Size(40, 30);
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
			this.tbPath1.CustomButton.Location = new System.Drawing.Point(671, 1);
			this.tbPath1.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbPath1.CustomButton.Name = "";
			this.tbPath1.CustomButton.Size = new System.Drawing.Size(27, 27);
			this.tbPath1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.tbPath1.CustomButton.TabIndex = 1;
			this.tbPath1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.tbPath1.CustomButton.UseSelectable = true;
			this.tbPath1.CustomButton.Visible = false;
			this.tbPath1.Lines = new string[0];
			this.tbPath1.Location = new System.Drawing.Point(257, 199);
			this.tbPath1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tbPath1.MaxLength = 32767;
			this.tbPath1.Name = "tbPath1";
			this.tbPath1.PasswordChar = '\0';
			this.tbPath1.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.tbPath1.SelectedText = "";
			this.tbPath1.SelectionLength = 0;
			this.tbPath1.SelectionStart = 0;
			this.tbPath1.ShortcutsEnabled = true;
			this.tbPath1.Size = new System.Drawing.Size(699, 29);
			this.tbPath1.TabIndex = 6;
			this.tbPath1.UseSelectable = true;
			this.tbPath1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.tbPath1.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// lbPath1
			// 
			this.lbPath1.Location = new System.Drawing.Point(11, 200);
			this.lbPath1.Name = "lbPath1";
			this.lbPath1.Size = new System.Drawing.Size(240, 25);
			this.lbPath1.TabIndex = 1;
			this.lbPath1.Text = "이마바리(SpisHull) 디렉토리 :";
			this.lbPath1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbDBStatus
			// 
			this.lbDBStatus.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.lbDBStatus.ForeColor = System.Drawing.Color.Red;
			this.lbDBStatus.Location = new System.Drawing.Point(297, 128);
			this.lbDBStatus.Name = "lbDBStatus";
			this.lbDBStatus.Size = new System.Drawing.Size(86, 25);
			this.lbDBStatus.TabIndex = 7;
			this.lbDBStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lbDBStatus.UseCustomForeColor = true;
			// 
			// btnConnect
			// 
			this.btnConnect.Highlight = true;
			this.btnConnect.Location = new System.Drawing.Point(297, 55);
			this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(86, 64);
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
			this.tbDbName.CustomButton.Location = new System.Drawing.Point(143, 1);
			this.tbDbName.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbDbName.CustomButton.Name = "";
			this.tbDbName.CustomButton.Size = new System.Drawing.Size(27, 27);
			this.tbDbName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.tbDbName.CustomButton.TabIndex = 1;
			this.tbDbName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.tbDbName.CustomButton.UseSelectable = true;
			this.tbDbName.CustomButton.Visible = false;
			this.tbDbName.Lines = new string[0];
			this.tbDbName.Location = new System.Drawing.Point(120, 126);
			this.tbDbName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tbDbName.MaxLength = 32767;
			this.tbDbName.Name = "tbDbName";
			this.tbDbName.PasswordChar = '\0';
			this.tbDbName.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.tbDbName.SelectedText = "";
			this.tbDbName.SelectionLength = 0;
			this.tbDbName.SelectionStart = 0;
			this.tbDbName.ShortcutsEnabled = true;
			this.tbDbName.Size = new System.Drawing.Size(171, 29);
			this.tbDbName.TabIndex = 4;
			this.tbDbName.UseSelectable = true;
			this.tbDbName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.tbDbName.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// tbDbPw
			// 
			// 
			// 
			// 
			this.tbDbPw.CustomButton.Image = null;
			this.tbDbPw.CustomButton.Location = new System.Drawing.Point(143, 1);
			this.tbDbPw.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbDbPw.CustomButton.Name = "";
			this.tbDbPw.CustomButton.Size = new System.Drawing.Size(27, 27);
			this.tbDbPw.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.tbDbPw.CustomButton.TabIndex = 1;
			this.tbDbPw.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.tbDbPw.CustomButton.UseSelectable = true;
			this.tbDbPw.CustomButton.Visible = false;
			this.tbDbPw.Lines = new string[0];
			this.tbDbPw.Location = new System.Drawing.Point(120, 90);
			this.tbDbPw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tbDbPw.MaxLength = 32767;
			this.tbDbPw.Name = "tbDbPw";
			this.tbDbPw.PasswordChar = '*';
			this.tbDbPw.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.tbDbPw.SelectedText = "";
			this.tbDbPw.SelectionLength = 0;
			this.tbDbPw.SelectionStart = 0;
			this.tbDbPw.ShortcutsEnabled = true;
			this.tbDbPw.Size = new System.Drawing.Size(171, 29);
			this.tbDbPw.TabIndex = 3;
			this.tbDbPw.UseSelectable = true;
			this.tbDbPw.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.tbDbPw.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// tbDbId
			// 
			// 
			// 
			// 
			this.tbDbId.CustomButton.Image = null;
			this.tbDbId.CustomButton.Location = new System.Drawing.Point(143, 1);
			this.tbDbId.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbDbId.CustomButton.Name = "";
			this.tbDbId.CustomButton.Size = new System.Drawing.Size(27, 27);
			this.tbDbId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.tbDbId.CustomButton.TabIndex = 1;
			this.tbDbId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.tbDbId.CustomButton.UseSelectable = true;
			this.tbDbId.CustomButton.Visible = false;
			this.tbDbId.Lines = new string[0];
			this.tbDbId.Location = new System.Drawing.Point(120, 55);
			this.tbDbId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tbDbId.MaxLength = 32767;
			this.tbDbId.Name = "tbDbId";
			this.tbDbId.PasswordChar = '\0';
			this.tbDbId.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.tbDbId.SelectedText = "";
			this.tbDbId.SelectionLength = 0;
			this.tbDbId.SelectionStart = 0;
			this.tbDbId.ShortcutsEnabled = true;
			this.tbDbId.Size = new System.Drawing.Size(171, 29);
			this.tbDbId.TabIndex = 2;
			this.tbDbId.UseSelectable = true;
			this.tbDbId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.tbDbId.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// tbDbServer
			// 
			// 
			// 
			// 
			this.tbDbServer.CustomButton.Image = null;
			this.tbDbServer.CustomButton.Location = new System.Drawing.Point(235, 1);
			this.tbDbServer.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.tbDbServer.CustomButton.Name = "";
			this.tbDbServer.CustomButton.Size = new System.Drawing.Size(27, 27);
			this.tbDbServer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
			this.tbDbServer.CustomButton.TabIndex = 1;
			this.tbDbServer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
			this.tbDbServer.CustomButton.UseSelectable = true;
			this.tbDbServer.CustomButton.Visible = false;
			this.tbDbServer.Lines = new string[0];
			this.tbDbServer.Location = new System.Drawing.Point(120, 20);
			this.tbDbServer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tbDbServer.MaxLength = 32767;
			this.tbDbServer.Name = "tbDbServer";
			this.tbDbServer.PasswordChar = '\0';
			this.tbDbServer.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.tbDbServer.SelectedText = "";
			this.tbDbServer.SelectionLength = 0;
			this.tbDbServer.SelectionStart = 0;
			this.tbDbServer.ShortcutsEnabled = true;
			this.tbDbServer.Size = new System.Drawing.Size(263, 29);
			this.tbDbServer.TabIndex = 1;
			this.tbDbServer.UseSelectable = true;
			this.tbDbServer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
			this.tbDbServer.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
			// 
			// lbDbName
			// 
			this.lbDbName.Location = new System.Drawing.Point(11, 125);
			this.lbDbName.Name = "lbDbName";
			this.lbDbName.Size = new System.Drawing.Size(103, 25);
			this.lbDbName.TabIndex = 1;
			this.lbDbName.Text = "DB Name :";
			this.lbDbName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbPassword
			// 
			this.lbPassword.Location = new System.Drawing.Point(11, 89);
			this.lbPassword.Name = "lbPassword";
			this.lbPassword.Size = new System.Drawing.Size(103, 25);
			this.lbPassword.TabIndex = 1;
			this.lbPassword.Text = "Password :";
			this.lbPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbLoginId
			// 
			this.lbLoginId.Location = new System.Drawing.Point(11, 54);
			this.lbLoginId.Name = "lbLoginId";
			this.lbLoginId.Size = new System.Drawing.Size(103, 25);
			this.lbLoginId.TabIndex = 0;
			this.lbLoginId.Text = "Login ID :";
			this.lbLoginId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lbServer
			// 
			this.lbServer.Location = new System.Drawing.Point(11, 19);
			this.lbServer.Name = "lbServer";
			this.lbServer.Size = new System.Drawing.Size(103, 25);
			this.lbServer.TabIndex = 0;
			this.lbServer.Text = "Server :";
			this.lbServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tabPage4
			// 
			this.tabPage4.BackColor = System.Drawing.SystemColors.Window;
			this.tabPage4.Location = new System.Drawing.Point(4, 41);
			this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(1409, 852);
			this.tabPage4.TabIndex = 5;
			this.tabPage4.Text = "Helper";
			// 
			// lbMainTitle1
			// 
			this.lbMainTitle1.AutoSize = true;
			this.lbMainTitle1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
			this.lbMainTitle1.ForeColor = System.Drawing.Color.Gray;
			this.lbMainTitle1.Location = new System.Drawing.Point(34, 9);
			this.lbMainTitle1.Name = "lbMainTitle1";
			this.lbMainTitle1.Size = new System.Drawing.Size(125, 20);
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
			this.lbMainTitle2.Location = new System.Drawing.Point(194, 14);
			this.lbMainTitle2.Name = "lbMainTitle2";
			this.lbMainTitle2.Size = new System.Drawing.Size(140, 17);
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
			this.lbMainTitle3.Location = new System.Drawing.Point(174, 9);
			this.lbMainTitle3.Name = "lbMainTitle3";
			this.lbMainTitle3.Size = new System.Drawing.Size(12, 20);
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
			this.lbMainVersion.Location = new System.Drawing.Point(346, 14);
			this.lbMainVersion.Name = "lbMainVersion";
			this.lbMainVersion.Size = new System.Drawing.Size(90, 17);
			this.lbMainVersion.TabIndex = 1;
			this.lbMainVersion.Text = "version=1.0.0.0";
			this.lbMainVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.lbMainVersion.Theme = MetroFramework.MetroThemeStyle.Light;
			this.lbMainVersion.UseCustomForeColor = true;
			// 
			// styleMgr
			// 
			this.styleMgr.Owner = this;
			// 
			// stdColId
			// 
			this.stdColId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.stdColId.DataPropertyName = "id";
			this.stdColId.DividerWidth = 1;
			this.stdColId.FillWeight = 16.98324F;
			this.stdColId.HeaderText = "ID";
			this.stdColId.Name = "stdColId";
			this.stdColId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.stdColId.Width = 49;
			// 
			// stdColCustomer
			// 
			this.stdColCustomer.DataPropertyName = "customer";
			this.stdColCustomer.HeaderText = "Customer";
			this.stdColCustomer.Name = "stdColCustomer";
			this.stdColCustomer.Visible = false;
			// 
			// stdColType
			// 
			this.stdColType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.stdColType.DataPropertyName = "type";
			this.stdColType.DividerWidth = 1;
			this.stdColType.FillWeight = 25.33413F;
			this.stdColType.HeaderText = "Type";
			this.stdColType.Name = "stdColType";
			this.stdColType.Width = 65;
			// 
			// stdColStatus
			// 
			this.stdColStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.stdColStatus.DataPropertyName = "status";
			this.stdColStatus.DividerWidth = 1;
			this.stdColStatus.FillWeight = 33.8766F;
			this.stdColStatus.HeaderText = "Status";
			this.stdColStatus.Name = "stdColStatus";
			this.stdColStatus.Width = 74;
			// 
			// stdColSummaryKr
			// 
			this.stdColSummaryKr.DataPropertyName = "summary_kr";
			this.stdColSummaryKr.DividerWidth = 1;
			this.stdColSummaryKr.FillWeight = 76.81911F;
			this.stdColSummaryKr.HeaderText = "Summary";
			this.stdColSummaryKr.Name = "stdColSummaryKr";
			// 
			// stdColDueDate
			// 
			this.stdColDueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.stdColDueDate.DataPropertyName = "due_date";
			this.stdColDueDate.DividerWidth = 1;
			this.stdColDueDate.FillWeight = 51.24502F;
			this.stdColDueDate.HeaderText = "Due Date";
			this.stdColDueDate.Name = "stdColDueDate";
			this.stdColDueDate.Width = 91;
			// 
			// stdColUpdateDate
			// 
			this.stdColUpdateDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.stdColUpdateDate.DataPropertyName = "update_date";
			this.stdColUpdateDate.DividerWidth = 1;
			this.stdColUpdateDate.FillWeight = 51.79351F;
			this.stdColUpdateDate.HeaderText = "Update Date";
			this.stdColUpdateDate.Name = "stdColUpdateDate";
			this.stdColUpdateDate.Width = 111;
			// 
			// stdColDocumentLink
			// 
			this.stdColDocumentLink.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.stdColDocumentLink.DataPropertyName = "document_name";
			this.stdColDocumentLink.DividerWidth = 1;
			this.stdColDocumentLink.FillWeight = 76.66993F;
			this.stdColDocumentLink.HeaderText = "File Name";
			this.stdColDocumentLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.stdColDocumentLink.Name = "stdColDocumentLink";
			this.stdColDocumentLink.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.stdColDocumentLink.Width = 95;
			// 
			// stdColDocumentPath
			// 
			this.stdColDocumentPath.DataPropertyName = "document_file";
			this.stdColDocumentPath.HeaderText = "File Path";
			this.stdColDocumentPath.Name = "stdColDocumentPath";
			this.stdColDocumentPath.Visible = false;
			// 
			// smhColId
			// 
			this.smhColId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.smhColId.DataPropertyName = "id";
			this.smhColId.DividerWidth = 1;
			this.smhColId.HeaderText = "ID";
			this.smhColId.Name = "smhColId";
			this.smhColId.Width = 49;
			// 
			// smhColCustomer
			// 
			this.smhColCustomer.DataPropertyName = "customer";
			this.smhColCustomer.HeaderText = "Customer";
			this.smhColCustomer.Name = "smhColCustomer";
			this.smhColCustomer.Visible = false;
			// 
			// smhColType
			// 
			this.smhColType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.smhColType.DataPropertyName = "type";
			this.smhColType.DividerWidth = 1;
			this.smhColType.HeaderText = "Type";
			this.smhColType.Name = "smhColType";
			this.smhColType.Width = 65;
			// 
			// smhColStatus
			// 
			this.smhColStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.smhColStatus.DataPropertyName = "status";
			this.smhColStatus.DividerWidth = 1;
			this.smhColStatus.HeaderText = "Status";
			this.smhColStatus.Name = "smhColStatus";
			this.smhColStatus.Width = 74;
			// 
			// smhColSummaryKr
			// 
			this.smhColSummaryKr.DataPropertyName = "summary_kr";
			this.smhColSummaryKr.DividerWidth = 1;
			this.smhColSummaryKr.HeaderText = "Summary";
			this.smhColSummaryKr.Name = "smhColSummaryKr";
			// 
			// smhColDueDate
			// 
			this.smhColDueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.smhColDueDate.DataPropertyName = "due_date";
			this.smhColDueDate.DividerWidth = 1;
			this.smhColDueDate.HeaderText = "Due Date";
			this.smhColDueDate.Name = "smhColDueDate";
			this.smhColDueDate.Width = 91;
			// 
			// smhColUpdateDate
			// 
			this.smhColUpdateDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.smhColUpdateDate.DataPropertyName = "update_date";
			this.smhColUpdateDate.DividerWidth = 1;
			this.smhColUpdateDate.HeaderText = "Update Date";
			this.smhColUpdateDate.Name = "smhColUpdateDate";
			this.smhColUpdateDate.Width = 111;
			// 
			// smhColDocumentLink
			// 
			this.smhColDocumentLink.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
			this.smhColDocumentLink.DataPropertyName = "document_name";
			this.smhColDocumentLink.DividerWidth = 1;
			this.smhColDocumentLink.HeaderText = "File Name";
			this.smhColDocumentLink.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.smhColDocumentLink.Name = "smhColDocumentLink";
			this.smhColDocumentLink.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.smhColDocumentLink.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.smhColDocumentLink.Width = 95;
			// 
			// smhColDocumentPath
			// 
			this.smhColDocumentPath.DataPropertyName = "document_file";
			this.smhColDocumentPath.HeaderText = "File Path";
			this.smhColDocumentPath.Name = "smhColDocumentPath";
			this.smhColDocumentPath.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1463, 960);
			this.Controls.Add(this.lbMainVersion);
			this.Controls.Add(this.lbMainTitle3);
			this.Controls.Add(this.lbMainTitle2);
			this.Controls.Add(this.lbMainTitle1);
			this.Controls.Add(this.tabControl);
			this.DisplayHeader = false;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MinimumSize = new System.Drawing.Size(1463, 960);
			this.Name = "MainForm";
			this.Padding = new System.Windows.Forms.Padding(23, 38, 23, 25);
			this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
			this.StyleManager = this.styleMgr;
			this.Text = "Hull Maintenance";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.Resize += new System.EventHandler(this.MainForm_Resize);
			this.tabControl.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.smhPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.smhGrid)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.stdPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.stdGrid)).EndInit();
			this.tabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.styleMgr)).EndInit();
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
        private MetroFramework.Controls.MetroTextBox tbPath1;
        private MetroFramework.Controls.MetroLabel lbPath1;
        private MetroFramework.Controls.MetroButton btnPath1;
        private MetroFramework.Controls.MetroButton btnPath2;
        private MetroFramework.Controls.MetroTextBox tbPath2;
        private MetroFramework.Controls.MetroLabel lbPath2;
        private MetroFramework.Controls.MetroButton btnPath3;
        private MetroFramework.Controls.MetroTextBox tbPath3;
        private MetroFramework.Controls.MetroLabel lbPath3;
        private MetroFramework.Controls.MetroPanel smhPanel;
        private MetroFramework.Controls.MetroPanel collapsibleSmhPanel;
        private MetroFramework.Controls.MetroPanel stdPanel;
        private MetroFramework.Controls.MetroPanel collapsibleStdPanel;
        private MetroFramework.Controls.MetroButton btnPathOpen3;
        private MetroFramework.Controls.MetroButton btnPathOpen2;
        private MetroFramework.Controls.MetroButton btnPathOpen1;
        private MetroFramework.Controls.MetroButton btnTheme;
        private MetroFramework.Controls.MetroButton btnStyle;
        private MetroFramework.Components.MetroStyleManager styleMgr;
        private MetroFramework.Controls.MetroGrid stdGrid;
        private MetroFramework.Controls.MetroGrid smhGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn smhColId;
		private System.Windows.Forms.DataGridViewTextBoxColumn smhColCustomer;
		private System.Windows.Forms.DataGridViewTextBoxColumn smhColType;
		private System.Windows.Forms.DataGridViewTextBoxColumn smhColStatus;
		private System.Windows.Forms.DataGridViewTextBoxColumn smhColSummaryKr;
		private System.Windows.Forms.DataGridViewTextBoxColumn smhColDueDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn smhColUpdateDate;
		private System.Windows.Forms.DataGridViewLinkColumn smhColDocumentLink;
		private System.Windows.Forms.DataGridViewTextBoxColumn smhColDocumentPath;
		private System.Windows.Forms.DataGridViewTextBoxColumn stdColId;
		private System.Windows.Forms.DataGridViewTextBoxColumn stdColCustomer;
		private System.Windows.Forms.DataGridViewTextBoxColumn stdColType;
		private System.Windows.Forms.DataGridViewTextBoxColumn stdColStatus;
		private System.Windows.Forms.DataGridViewTextBoxColumn stdColSummaryKr;
		private System.Windows.Forms.DataGridViewTextBoxColumn stdColDueDate;
		private System.Windows.Forms.DataGridViewTextBoxColumn stdColUpdateDate;
		private System.Windows.Forms.DataGridViewLinkColumn stdColDocumentLink;
		private System.Windows.Forms.DataGridViewTextBoxColumn stdColDocumentPath;
	}
}

