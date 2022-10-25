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
            this.smhPage = new System.Windows.Forms.TabPage();
            this.smhPanel = new MetroFramework.Controls.MetroPanel();
            this.smhGrid = new MetroFramework.Controls.MetroGrid();
            this.smhColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smhColCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smhColType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smhColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smhColSummaryKr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smhColDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smhColUpdateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smhColDocumentLink = new System.Windows.Forms.DataGridViewLinkColumn();
            this.smhColDocumentPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collapsibleSmhPanel = new MetroFramework.Controls.MetroPanel();
            this.btnSmhAddItem = new MetroFramework.Controls.MetroButton();
            this.btnSmhSearchClear = new System.Windows.Forms.Button();
            this.btnSmhSearch = new MetroFramework.Controls.MetroButton();
            this.cbSmhSearch = new System.Windows.Forms.ComboBox();
            this.stdPage = new System.Windows.Forms.TabPage();
            this.stdPanel = new MetroFramework.Controls.MetroPanel();
            this.stdGrid = new MetroFramework.Controls.MetroGrid();
            this.stdColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdColCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdColType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdColSummaryKr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdColDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdColUpdateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdColDocumentLink = new System.Windows.Forms.DataGridViewLinkColumn();
            this.stdColDocumentPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collapsibleStdPanel = new MetroFramework.Controls.MetroPanel();
            this.btnStdAddItem = new MetroFramework.Controls.MetroButton();
            this.btnStdSearchClear = new System.Windows.Forms.Button();
            this.btnStdSearch = new MetroFramework.Controls.MetroButton();
            this.cbStdSearch = new System.Windows.Forms.ComboBox();
            this.settingPage = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnTheme = new MetroFramework.Controls.MetroButton();
            this.btnStyle = new MetroFramework.Controls.MetroButton();
            this.tbColorD7 = new MetroFramework.Controls.MetroTextBox();
            this.lbColorD7 = new MetroFramework.Controls.MetroLabel();
            this.tbColorD3 = new MetroFramework.Controls.MetroTextBox();
            this.lbColorD3 = new MetroFramework.Controls.MetroLabel();
            this.tbColorD1 = new MetroFramework.Controls.MetroTextBox();
            this.lbColorD1 = new MetroFramework.Controls.MetroLabel();
            this.tbColorError = new MetroFramework.Controls.MetroTextBox();
            this.tbColorImpossible = new MetroFramework.Controls.MetroTextBox();
            this.tbColorCancel = new MetroFramework.Controls.MetroTextBox();
            this.tbColorWaiting = new MetroFramework.Controls.MetroTextBox();
            this.tbColorPending = new MetroFramework.Controls.MetroTextBox();
            this.tbColorComplete = new MetroFramework.Controls.MetroTextBox();
            this.tbColorPartialDone = new MetroFramework.Controls.MetroTextBox();
            this.tbColorWorkDone = new MetroFramework.Controls.MetroTextBox();
            this.tbColorWorking = new MetroFramework.Controls.MetroTextBox();
            this.lbColorError = new MetroFramework.Controls.MetroLabel();
            this.lbColorImpossible = new MetroFramework.Controls.MetroLabel();
            this.lbColorCancel = new MetroFramework.Controls.MetroLabel();
            this.lbColorWaiting = new MetroFramework.Controls.MetroLabel();
            this.lbColorPending = new MetroFramework.Controls.MetroLabel();
            this.lbColorComplete = new MetroFramework.Controls.MetroLabel();
            this.lbColorPartialDone = new MetroFramework.Controls.MetroLabel();
            this.lbColorWorkDone = new MetroFramework.Controls.MetroLabel();
            this.lbColorWorking = new MetroFramework.Controls.MetroLabel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnStdSamplePathOpen = new MetroFramework.Controls.MetroButton();
            this.btnStdSamplePath = new MetroFramework.Controls.MetroButton();
            this.tbStdSamplePath = new MetroFramework.Controls.MetroTextBox();
            this.lbStdSampleDir = new MetroFramework.Controls.MetroLabel();
            this.btnStdDocPathOpen = new MetroFramework.Controls.MetroButton();
            this.btnStdDocPath = new MetroFramework.Controls.MetroButton();
            this.tbStdDocPath = new MetroFramework.Controls.MetroTextBox();
            this.lbStdDocDir = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSmhSamplePathOpen = new MetroFramework.Controls.MetroButton();
            this.btnSmhDocPathOpen = new MetroFramework.Controls.MetroButton();
            this.btnSmhSamplePath = new MetroFramework.Controls.MetroButton();
            this.tbSmhSamplePath = new MetroFramework.Controls.MetroTextBox();
            this.lbSmhSampleDir = new MetroFramework.Controls.MetroLabel();
            this.btnSmhDocPath = new MetroFramework.Controls.MetroButton();
            this.tbSmhDocPath = new MetroFramework.Controls.MetroTextBox();
            this.lbSmhDocDir = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.HelperPage = new System.Windows.Forms.TabPage();
            this.lbMainTitle1 = new MetroFramework.Controls.MetroLabel();
            this.lbMainTitle2 = new MetroFramework.Controls.MetroLabel();
            this.lbMainTitle3 = new MetroFramework.Controls.MetroLabel();
            this.lbMainVersion = new MetroFramework.Controls.MetroLabel();
            this.styleMgr = new MetroFramework.Components.MetroStyleManager(this.components);
            this.tabControl.SuspendLayout();
            this.smhPage.SuspendLayout();
            this.smhPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.smhGrid)).BeginInit();
            this.collapsibleSmhPanel.SuspendLayout();
            this.stdPage.SuspendLayout();
            this.stdPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stdGrid)).BeginInit();
            this.collapsibleStdPanel.SuspendLayout();
            this.settingPage.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.styleMgr)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl.Controls.Add(this.smhPage);
            this.tabControl.Controls.Add(this.stdPage);
            this.tabControl.Controls.Add(this.settingPage);
            this.tabControl.Controls.Add(this.HelperPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(20, 30);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1240, 718);
            this.tabControl.TabIndex = 0;
            this.tabControl.UseSelectable = true;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.metroTabControl_SelectedIndexChanged);
            this.tabControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControl_KeyDown);
            // 
            // smhPage
            // 
            this.smhPage.BackColor = System.Drawing.SystemColors.Window;
            this.smhPage.Controls.Add(this.smhPanel);
            this.smhPage.Controls.Add(this.collapsibleSmhPanel);
            this.smhPage.Font = new System.Drawing.Font("굴림", 9F);
            this.smhPage.Location = new System.Drawing.Point(4, 41);
            this.smhPage.Name = "smhPage";
            this.smhPage.Size = new System.Drawing.Size(1232, 673);
            this.smhPage.TabIndex = 1;
            this.smhPage.Text = "SmartHull";
            // 
            // smhPanel
            // 
            this.smhPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.smhPanel.Controls.Add(this.smhGrid);
            this.smhPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.smhPanel.HorizontalScrollbarBarColor = true;
            this.smhPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.smhPanel.HorizontalScrollbarSize = 10;
            this.smhPanel.Location = new System.Drawing.Point(0, 48);
            this.smhPanel.Margin = new System.Windows.Forms.Padding(0);
            this.smhPanel.Name = "smhPanel";
            this.smhPanel.Padding = new System.Windows.Forms.Padding(1);
            this.smhPanel.Size = new System.Drawing.Size(1232, 625);
            this.smhPanel.TabIndex = 1;
            this.smhPanel.UseCustomBackColor = true;
            this.smhPanel.VerticalScrollbarBarColor = true;
            this.smhPanel.VerticalScrollbarHighlightOnWheel = false;
            this.smhPanel.VerticalScrollbarSize = 10;
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.smhGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.smhGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.smhGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.smhGrid.EnableHeadersVisualStyles = false;
            this.smhGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.smhGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.smhGrid.Location = new System.Drawing.Point(1, 1);
            this.smhGrid.MultiSelect = false;
            this.smhGrid.Name = "smhGrid";
            this.smhGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            this.smhGrid.Size = new System.Drawing.Size(1230, 623);
            this.smhGrid.TabIndex = 1;
            // 
            // smhColId
            // 
            this.smhColId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.smhColId.DataPropertyName = "id";
            this.smhColId.DividerWidth = 1;
            this.smhColId.HeaderText = "ID";
            this.smhColId.Name = "smhColId";
            this.smhColId.Width = 42;
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
            this.smhColType.Width = 54;
            // 
            // smhColStatus
            // 
            this.smhColStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.smhColStatus.DataPropertyName = "status";
            this.smhColStatus.DividerWidth = 1;
            this.smhColStatus.HeaderText = "Status";
            this.smhColStatus.Name = "smhColStatus";
            this.smhColStatus.Width = 63;
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
            this.smhColDueDate.Width = 79;
            // 
            // smhColUpdateDate
            // 
            this.smhColUpdateDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.smhColUpdateDate.DataPropertyName = "update_date";
            this.smhColUpdateDate.DividerWidth = 1;
            this.smhColUpdateDate.HeaderText = "Update Date";
            this.smhColUpdateDate.Name = "smhColUpdateDate";
            this.smhColUpdateDate.Width = 96;
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
            this.smhColDocumentLink.Width = 81;
            // 
            // smhColDocumentPath
            // 
            this.smhColDocumentPath.DataPropertyName = "document_file";
            this.smhColDocumentPath.HeaderText = "File Path";
            this.smhColDocumentPath.Name = "smhColDocumentPath";
            this.smhColDocumentPath.Visible = false;
            // 
            // collapsibleSmhPanel
            // 
            this.collapsibleSmhPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.collapsibleSmhPanel.Controls.Add(this.btnSmhAddItem);
            this.collapsibleSmhPanel.Controls.Add(this.btnSmhSearchClear);
            this.collapsibleSmhPanel.Controls.Add(this.btnSmhSearch);
            this.collapsibleSmhPanel.Controls.Add(this.cbSmhSearch);
            this.collapsibleSmhPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.collapsibleSmhPanel.HorizontalScrollbarBarColor = true;
            this.collapsibleSmhPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.collapsibleSmhPanel.HorizontalScrollbarSize = 10;
            this.collapsibleSmhPanel.Location = new System.Drawing.Point(0, 0);
            this.collapsibleSmhPanel.Name = "collapsibleSmhPanel";
            this.collapsibleSmhPanel.Size = new System.Drawing.Size(1232, 48);
            this.collapsibleSmhPanel.TabIndex = 0;
            this.collapsibleSmhPanel.UseCustomBackColor = true;
            this.collapsibleSmhPanel.VerticalScrollbarBarColor = true;
            this.collapsibleSmhPanel.VerticalScrollbarHighlightOnWheel = false;
            this.collapsibleSmhPanel.VerticalScrollbarSize = 10;
            // 
            // btnSmhAddItem
            // 
            this.btnSmhAddItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSmhAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSmhAddItem.Location = new System.Drawing.Point(1157, 13);
            this.btnSmhAddItem.Name = "btnSmhAddItem";
            this.btnSmhAddItem.Size = new System.Drawing.Size(60, 23);
            this.btnSmhAddItem.TabIndex = 10;
            this.btnSmhAddItem.Tag = "smhGrid";
            this.btnSmhAddItem.Text = "추가";
            this.btnSmhAddItem.UseCustomBackColor = true;
            this.btnSmhAddItem.UseSelectable = true;
            this.btnSmhAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnSmhSearchClear
            // 
            this.btnSmhSearchClear.BackColor = System.Drawing.Color.Transparent;
            this.btnSmhSearchClear.BackgroundImage = global::HullMaintenance.Properties.Resources.iconmonstr_x_mark_1_24;
            this.btnSmhSearchClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSmhSearchClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSmhSearchClear.FlatAppearance.BorderSize = 0;
            this.btnSmhSearchClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSmhSearchClear.Location = new System.Drawing.Point(15, 20);
            this.btnSmhSearchClear.Name = "btnSmhSearchClear";
            this.btnSmhSearchClear.Size = new System.Drawing.Size(10, 10);
            this.btnSmhSearchClear.TabIndex = 9;
            this.btnSmhSearchClear.Tag = "cbSmhSearch";
            this.btnSmhSearchClear.UseVisualStyleBackColor = false;
            this.btnSmhSearchClear.Click += new System.EventHandler(this.btnSearchClear_Click);
            // 
            // btnSmhSearch
            // 
            this.btnSmhSearch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSmhSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSmhSearch.Location = new System.Drawing.Point(392, 13);
            this.btnSmhSearch.Name = "btnSmhSearch";
            this.btnSmhSearch.Size = new System.Drawing.Size(60, 23);
            this.btnSmhSearch.TabIndex = 8;
            this.btnSmhSearch.Tag = "cbSmhSearch";
            this.btnSmhSearch.Text = "Search";
            this.btnSmhSearch.UseCustomBackColor = true;
            this.btnSmhSearch.UseSelectable = true;
            this.btnSmhSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbSmhSearch
            // 
            this.cbSmhSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbSmhSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbSmhSearch.FormattingEnabled = true;
            this.cbSmhSearch.Location = new System.Drawing.Point(35, 15);
            this.cbSmhSearch.Name = "cbSmhSearch";
            this.cbSmhSearch.Size = new System.Drawing.Size(350, 20);
            this.cbSmhSearch.TabIndex = 7;
            this.cbSmhSearch.Tag = "smhGrid";
            this.cbSmhSearch.TextChanged += new System.EventHandler(this.cbSearch_TextChanged);
            // 
            // stdPage
            // 
            this.stdPage.AutoScroll = true;
            this.stdPage.BackColor = System.Drawing.SystemColors.Window;
            this.stdPage.Controls.Add(this.stdPanel);
            this.stdPage.Controls.Add(this.collapsibleStdPanel);
            this.stdPage.Font = new System.Drawing.Font("굴림", 9F);
            this.stdPage.Location = new System.Drawing.Point(4, 41);
            this.stdPage.Name = "stdPage";
            this.stdPage.Size = new System.Drawing.Size(1232, 673);
            this.stdPage.TabIndex = 2;
            this.stdPage.Text = "SpisHull";
            // 
            // stdPanel
            // 
            this.stdPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.stdPanel.Controls.Add(this.stdGrid);
            this.stdPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stdPanel.HorizontalScrollbarBarColor = true;
            this.stdPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.stdPanel.HorizontalScrollbarSize = 10;
            this.stdPanel.Location = new System.Drawing.Point(0, 48);
            this.stdPanel.Margin = new System.Windows.Forms.Padding(0);
            this.stdPanel.Name = "stdPanel";
            this.stdPanel.Padding = new System.Windows.Forms.Padding(1);
            this.stdPanel.Size = new System.Drawing.Size(1232, 625);
            this.stdPanel.TabIndex = 1;
            this.stdPanel.UseCustomBackColor = true;
            this.stdPanel.VerticalScrollbarBarColor = true;
            this.stdPanel.VerticalScrollbarHighlightOnWheel = false;
            this.stdPanel.VerticalScrollbarSize = 10;
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
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.stdGrid.DefaultCellStyle = dataGridViewCellStyle7;
            this.stdGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stdGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.stdGrid.EnableHeadersVisualStyles = false;
            this.stdGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.stdGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.stdGrid.Location = new System.Drawing.Point(1, 1);
            this.stdGrid.Margin = new System.Windows.Forms.Padding(0);
            this.stdGrid.MultiSelect = false;
            this.stdGrid.Name = "stdGrid";
            this.stdGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
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
            this.stdGrid.Size = new System.Drawing.Size(1230, 623);
            this.stdGrid.TabIndex = 1;
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
            this.stdColId.Width = 42;
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
            this.stdColType.Width = 54;
            // 
            // stdColStatus
            // 
            this.stdColStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.stdColStatus.DataPropertyName = "status";
            this.stdColStatus.DividerWidth = 1;
            this.stdColStatus.FillWeight = 33.8766F;
            this.stdColStatus.HeaderText = "Status";
            this.stdColStatus.Name = "stdColStatus";
            this.stdColStatus.Width = 63;
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
            this.stdColDueDate.Width = 79;
            // 
            // stdColUpdateDate
            // 
            this.stdColUpdateDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stdColUpdateDate.DataPropertyName = "update_date";
            this.stdColUpdateDate.DividerWidth = 1;
            this.stdColUpdateDate.FillWeight = 51.79351F;
            this.stdColUpdateDate.HeaderText = "Update Date";
            this.stdColUpdateDate.Name = "stdColUpdateDate";
            this.stdColUpdateDate.Width = 96;
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
            this.stdColDocumentLink.Width = 81;
            // 
            // stdColDocumentPath
            // 
            this.stdColDocumentPath.DataPropertyName = "document_file";
            this.stdColDocumentPath.HeaderText = "File Path";
            this.stdColDocumentPath.Name = "stdColDocumentPath";
            this.stdColDocumentPath.Visible = false;
            // 
            // collapsibleStdPanel
            // 
            this.collapsibleStdPanel.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.collapsibleStdPanel.Controls.Add(this.btnStdAddItem);
            this.collapsibleStdPanel.Controls.Add(this.btnStdSearchClear);
            this.collapsibleStdPanel.Controls.Add(this.btnStdSearch);
            this.collapsibleStdPanel.Controls.Add(this.cbStdSearch);
            this.collapsibleStdPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.collapsibleStdPanel.HorizontalScrollbarBarColor = true;
            this.collapsibleStdPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.collapsibleStdPanel.HorizontalScrollbarSize = 10;
            this.collapsibleStdPanel.Location = new System.Drawing.Point(0, 0);
            this.collapsibleStdPanel.Name = "collapsibleStdPanel";
            this.collapsibleStdPanel.Size = new System.Drawing.Size(1232, 48);
            this.collapsibleStdPanel.TabIndex = 0;
            this.collapsibleStdPanel.UseCustomBackColor = true;
            this.collapsibleStdPanel.VerticalScrollbarBarColor = true;
            this.collapsibleStdPanel.VerticalScrollbarHighlightOnWheel = false;
            this.collapsibleStdPanel.VerticalScrollbarSize = 10;
            // 
            // btnStdAddItem
            // 
            this.btnStdAddItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnStdAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStdAddItem.Location = new System.Drawing.Point(1157, 13);
            this.btnStdAddItem.Name = "btnStdAddItem";
            this.btnStdAddItem.Size = new System.Drawing.Size(60, 23);
            this.btnStdAddItem.TabIndex = 6;
            this.btnStdAddItem.Tag = "stdGrid";
            this.btnStdAddItem.Text = "추가";
            this.btnStdAddItem.UseCustomBackColor = true;
            this.btnStdAddItem.UseSelectable = true;
            this.btnStdAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnStdSearchClear
            // 
            this.btnStdSearchClear.BackColor = System.Drawing.Color.Transparent;
            this.btnStdSearchClear.BackgroundImage = global::HullMaintenance.Properties.Resources.iconmonstr_x_mark_1_24;
            this.btnStdSearchClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStdSearchClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStdSearchClear.FlatAppearance.BorderSize = 0;
            this.btnStdSearchClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStdSearchClear.Location = new System.Drawing.Point(15, 20);
            this.btnStdSearchClear.Name = "btnStdSearchClear";
            this.btnStdSearchClear.Size = new System.Drawing.Size(10, 10);
            this.btnStdSearchClear.TabIndex = 5;
            this.btnStdSearchClear.Tag = "cbStdSearch";
            this.btnStdSearchClear.UseVisualStyleBackColor = false;
            this.btnStdSearchClear.Click += new System.EventHandler(this.btnSearchClear_Click);
            // 
            // btnStdSearch
            // 
            this.btnStdSearch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnStdSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStdSearch.Location = new System.Drawing.Point(392, 13);
            this.btnStdSearch.Name = "btnStdSearch";
            this.btnStdSearch.Size = new System.Drawing.Size(60, 23);
            this.btnStdSearch.TabIndex = 4;
            this.btnStdSearch.Tag = "cbStdSearch";
            this.btnStdSearch.Text = "Search";
            this.btnStdSearch.UseCustomBackColor = true;
            this.btnStdSearch.UseSelectable = true;
            this.btnStdSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbStdSearch
            // 
            this.cbStdSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbStdSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbStdSearch.FormattingEnabled = true;
            this.cbStdSearch.Location = new System.Drawing.Point(35, 15);
            this.cbStdSearch.Name = "cbStdSearch";
            this.cbStdSearch.Size = new System.Drawing.Size(350, 20);
            this.cbStdSearch.TabIndex = 2;
            this.cbStdSearch.Tag = "stdGrid";
            this.cbStdSearch.TextChanged += new System.EventHandler(this.cbSearch_TextChanged);
            // 
            // settingPage
            // 
            this.settingPage.AutoScroll = true;
            this.settingPage.BackColor = System.Drawing.SystemColors.Window;
            this.settingPage.Controls.Add(this.groupBox4);
            this.settingPage.Controls.Add(this.groupBox3);
            this.settingPage.Controls.Add(this.groupBox2);
            this.settingPage.Controls.Add(this.groupBox1);
            this.settingPage.Location = new System.Drawing.Point(4, 41);
            this.settingPage.Name = "settingPage";
            this.settingPage.Size = new System.Drawing.Size(1232, 673);
            this.settingPage.TabIndex = 4;
            this.settingPage.Text = "Settings";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnTheme);
            this.groupBox4.Controls.Add(this.btnStyle);
            this.groupBox4.Controls.Add(this.tbColorD7);
            this.groupBox4.Controls.Add(this.lbColorD7);
            this.groupBox4.Controls.Add(this.tbColorD3);
            this.groupBox4.Controls.Add(this.lbColorD3);
            this.groupBox4.Controls.Add(this.tbColorD1);
            this.groupBox4.Controls.Add(this.lbColorD1);
            this.groupBox4.Controls.Add(this.tbColorError);
            this.groupBox4.Controls.Add(this.tbColorImpossible);
            this.groupBox4.Controls.Add(this.tbColorCancel);
            this.groupBox4.Controls.Add(this.tbColorWaiting);
            this.groupBox4.Controls.Add(this.tbColorPending);
            this.groupBox4.Controls.Add(this.tbColorComplete);
            this.groupBox4.Controls.Add(this.tbColorPartialDone);
            this.groupBox4.Controls.Add(this.tbColorWorkDone);
            this.groupBox4.Controls.Add(this.tbColorWorking);
            this.groupBox4.Controls.Add(this.lbColorError);
            this.groupBox4.Controls.Add(this.lbColorImpossible);
            this.groupBox4.Controls.Add(this.lbColorCancel);
            this.groupBox4.Controls.Add(this.lbColorWaiting);
            this.groupBox4.Controls.Add(this.lbColorPending);
            this.groupBox4.Controls.Add(this.lbColorComplete);
            this.groupBox4.Controls.Add(this.lbColorPartialDone);
            this.groupBox4.Controls.Add(this.lbColorWorkDone);
            this.groupBox4.Controls.Add(this.lbColorWorking);
            this.groupBox4.Location = new System.Drawing.Point(10, 380);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(406, 285);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Color Code (Hexadecimal)";
            // 
            // btnTheme
            // 
            this.btnTheme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTheme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTheme.Location = new System.Drawing.Point(261, 249);
            this.btnTheme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTheme.Name = "btnTheme";
            this.btnTheme.Size = new System.Drawing.Size(76, 24);
            this.btnTheme.TabIndex = 34;
            this.btnTheme.Tag = "";
            this.btnTheme.Text = "Theme";
            this.btnTheme.UseSelectable = true;
            this.btnTheme.Click += new System.EventHandler(this.btnTheme_Click);
            // 
            // btnStyle
            // 
            this.btnStyle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStyle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStyle.Location = new System.Drawing.Point(346, 249);
            this.btnStyle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStyle.Name = "btnStyle";
            this.btnStyle.Size = new System.Drawing.Size(40, 24);
            this.btnStyle.TabIndex = 33;
            this.btnStyle.Tag = "";
            this.btnStyle.Text = "Style";
            this.btnStyle.UseSelectable = true;
            this.btnStyle.Click += new System.EventHandler(this.btnStyle_Click);
            // 
            // tbColorD7
            // 
            // 
            // 
            // 
            this.tbColorD7.CustomButton.Image = null;
            this.tbColorD7.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.tbColorD7.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbColorD7.CustomButton.Name = "";
            this.tbColorD7.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbColorD7.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbColorD7.CustomButton.TabIndex = 1;
            this.tbColorD7.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbColorD7.CustomButton.UseSelectable = true;
            this.tbColorD7.CustomButton.Visible = false;
            this.tbColorD7.Lines = new string[0];
            this.tbColorD7.Location = new System.Drawing.Point(286, 80);
            this.tbColorD7.MaxLength = 32767;
            this.tbColorD7.Name = "tbColorD7";
            this.tbColorD7.PasswordChar = '\0';
            this.tbColorD7.ReadOnly = true;
            this.tbColorD7.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbColorD7.SelectedText = "";
            this.tbColorD7.SelectionLength = 0;
            this.tbColorD7.SelectionStart = 0;
            this.tbColorD7.ShortcutsEnabled = true;
            this.tbColorD7.Size = new System.Drawing.Size(100, 23);
            this.tbColorD7.TabIndex = 32;
            this.tbColorD7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbColorD7.UseCustomBackColor = true;
            this.tbColorD7.UseSelectable = true;
            this.tbColorD7.UseStyleColors = true;
            this.tbColorD7.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbColorD7.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbColorD7.TextChanged += new System.EventHandler(this.tbColor_TextChanged);
            // 
            // lbColorD7
            // 
            this.lbColorD7.Location = new System.Drawing.Point(220, 80);
            this.lbColorD7.Name = "lbColorD7";
            this.lbColorD7.Size = new System.Drawing.Size(60, 19);
            this.lbColorD7.TabIndex = 31;
            this.lbColorD7.Text = "D-7 :";
            this.lbColorD7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbColorD3
            // 
            // 
            // 
            // 
            this.tbColorD3.CustomButton.Image = null;
            this.tbColorD3.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.tbColorD3.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbColorD3.CustomButton.Name = "";
            this.tbColorD3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbColorD3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbColorD3.CustomButton.TabIndex = 1;
            this.tbColorD3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbColorD3.CustomButton.UseSelectable = true;
            this.tbColorD3.CustomButton.Visible = false;
            this.tbColorD3.Lines = new string[0];
            this.tbColorD3.Location = new System.Drawing.Point(286, 51);
            this.tbColorD3.MaxLength = 32767;
            this.tbColorD3.Name = "tbColorD3";
            this.tbColorD3.PasswordChar = '\0';
            this.tbColorD3.ReadOnly = true;
            this.tbColorD3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbColorD3.SelectedText = "";
            this.tbColorD3.SelectionLength = 0;
            this.tbColorD3.SelectionStart = 0;
            this.tbColorD3.ShortcutsEnabled = true;
            this.tbColorD3.Size = new System.Drawing.Size(100, 23);
            this.tbColorD3.TabIndex = 30;
            this.tbColorD3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbColorD3.UseCustomBackColor = true;
            this.tbColorD3.UseSelectable = true;
            this.tbColorD3.UseStyleColors = true;
            this.tbColorD3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbColorD3.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbColorD3.TextChanged += new System.EventHandler(this.tbColor_TextChanged);
            // 
            // lbColorD3
            // 
            this.lbColorD3.Location = new System.Drawing.Point(220, 51);
            this.lbColorD3.Name = "lbColorD3";
            this.lbColorD3.Size = new System.Drawing.Size(60, 19);
            this.lbColorD3.TabIndex = 29;
            this.lbColorD3.Text = "D-3 :";
            this.lbColorD3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbColorD1
            // 
            // 
            // 
            // 
            this.tbColorD1.CustomButton.Image = null;
            this.tbColorD1.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.tbColorD1.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbColorD1.CustomButton.Name = "";
            this.tbColorD1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbColorD1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbColorD1.CustomButton.TabIndex = 1;
            this.tbColorD1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbColorD1.CustomButton.UseSelectable = true;
            this.tbColorD1.CustomButton.Visible = false;
            this.tbColorD1.Lines = new string[0];
            this.tbColorD1.Location = new System.Drawing.Point(286, 22);
            this.tbColorD1.MaxLength = 32767;
            this.tbColorD1.Name = "tbColorD1";
            this.tbColorD1.PasswordChar = '\0';
            this.tbColorD1.ReadOnly = true;
            this.tbColorD1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbColorD1.SelectedText = "";
            this.tbColorD1.SelectionLength = 0;
            this.tbColorD1.SelectionStart = 0;
            this.tbColorD1.ShortcutsEnabled = true;
            this.tbColorD1.Size = new System.Drawing.Size(100, 23);
            this.tbColorD1.TabIndex = 28;
            this.tbColorD1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbColorD1.UseCustomBackColor = true;
            this.tbColorD1.UseSelectable = true;
            this.tbColorD1.UseStyleColors = true;
            this.tbColorD1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbColorD1.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbColorD1.TextChanged += new System.EventHandler(this.tbColor_TextChanged);
            // 
            // lbColorD1
            // 
            this.lbColorD1.Location = new System.Drawing.Point(220, 22);
            this.lbColorD1.Name = "lbColorD1";
            this.lbColorD1.Size = new System.Drawing.Size(60, 19);
            this.lbColorD1.TabIndex = 27;
            this.lbColorD1.Text = "D-1 :";
            this.lbColorD1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbColorError
            // 
            // 
            // 
            // 
            this.tbColorError.CustomButton.Image = null;
            this.tbColorError.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.tbColorError.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbColorError.CustomButton.Name = "";
            this.tbColorError.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbColorError.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbColorError.CustomButton.TabIndex = 1;
            this.tbColorError.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbColorError.CustomButton.UseSelectable = true;
            this.tbColorError.CustomButton.Visible = false;
            this.tbColorError.Lines = new string[0];
            this.tbColorError.Location = new System.Drawing.Point(106, 254);
            this.tbColorError.MaxLength = 32767;
            this.tbColorError.Name = "tbColorError";
            this.tbColorError.PasswordChar = '\0';
            this.tbColorError.ReadOnly = true;
            this.tbColorError.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbColorError.SelectedText = "";
            this.tbColorError.SelectionLength = 0;
            this.tbColorError.SelectionStart = 0;
            this.tbColorError.ShortcutsEnabled = true;
            this.tbColorError.Size = new System.Drawing.Size(100, 23);
            this.tbColorError.TabIndex = 26;
            this.tbColorError.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbColorError.UseCustomBackColor = true;
            this.tbColorError.UseSelectable = true;
            this.tbColorError.UseStyleColors = true;
            this.tbColorError.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbColorError.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbColorError.TextChanged += new System.EventHandler(this.tbColor_TextChanged);
            // 
            // tbColorImpossible
            // 
            // 
            // 
            // 
            this.tbColorImpossible.CustomButton.Image = null;
            this.tbColorImpossible.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.tbColorImpossible.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbColorImpossible.CustomButton.Name = "";
            this.tbColorImpossible.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbColorImpossible.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbColorImpossible.CustomButton.TabIndex = 1;
            this.tbColorImpossible.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbColorImpossible.CustomButton.UseSelectable = true;
            this.tbColorImpossible.CustomButton.Visible = false;
            this.tbColorImpossible.Lines = new string[0];
            this.tbColorImpossible.Location = new System.Drawing.Point(106, 225);
            this.tbColorImpossible.MaxLength = 32767;
            this.tbColorImpossible.Name = "tbColorImpossible";
            this.tbColorImpossible.PasswordChar = '\0';
            this.tbColorImpossible.ReadOnly = true;
            this.tbColorImpossible.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbColorImpossible.SelectedText = "";
            this.tbColorImpossible.SelectionLength = 0;
            this.tbColorImpossible.SelectionStart = 0;
            this.tbColorImpossible.ShortcutsEnabled = true;
            this.tbColorImpossible.Size = new System.Drawing.Size(100, 23);
            this.tbColorImpossible.TabIndex = 25;
            this.tbColorImpossible.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbColorImpossible.UseCustomBackColor = true;
            this.tbColorImpossible.UseSelectable = true;
            this.tbColorImpossible.UseStyleColors = true;
            this.tbColorImpossible.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbColorImpossible.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbColorImpossible.TextChanged += new System.EventHandler(this.tbColor_TextChanged);
            // 
            // tbColorCancel
            // 
            // 
            // 
            // 
            this.tbColorCancel.CustomButton.Image = null;
            this.tbColorCancel.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.tbColorCancel.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbColorCancel.CustomButton.Name = "";
            this.tbColorCancel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbColorCancel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbColorCancel.CustomButton.TabIndex = 1;
            this.tbColorCancel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbColorCancel.CustomButton.UseSelectable = true;
            this.tbColorCancel.CustomButton.Visible = false;
            this.tbColorCancel.Lines = new string[0];
            this.tbColorCancel.Location = new System.Drawing.Point(106, 196);
            this.tbColorCancel.MaxLength = 32767;
            this.tbColorCancel.Name = "tbColorCancel";
            this.tbColorCancel.PasswordChar = '\0';
            this.tbColorCancel.ReadOnly = true;
            this.tbColorCancel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbColorCancel.SelectedText = "";
            this.tbColorCancel.SelectionLength = 0;
            this.tbColorCancel.SelectionStart = 0;
            this.tbColorCancel.ShortcutsEnabled = true;
            this.tbColorCancel.Size = new System.Drawing.Size(100, 23);
            this.tbColorCancel.TabIndex = 24;
            this.tbColorCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbColorCancel.UseCustomBackColor = true;
            this.tbColorCancel.UseSelectable = true;
            this.tbColorCancel.UseStyleColors = true;
            this.tbColorCancel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbColorCancel.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbColorCancel.TextChanged += new System.EventHandler(this.tbColor_TextChanged);
            // 
            // tbColorWaiting
            // 
            // 
            // 
            // 
            this.tbColorWaiting.CustomButton.Image = null;
            this.tbColorWaiting.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.tbColorWaiting.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbColorWaiting.CustomButton.Name = "";
            this.tbColorWaiting.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbColorWaiting.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbColorWaiting.CustomButton.TabIndex = 1;
            this.tbColorWaiting.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbColorWaiting.CustomButton.UseSelectable = true;
            this.tbColorWaiting.CustomButton.Visible = false;
            this.tbColorWaiting.Lines = new string[0];
            this.tbColorWaiting.Location = new System.Drawing.Point(106, 167);
            this.tbColorWaiting.MaxLength = 32767;
            this.tbColorWaiting.Name = "tbColorWaiting";
            this.tbColorWaiting.PasswordChar = '\0';
            this.tbColorWaiting.ReadOnly = true;
            this.tbColorWaiting.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbColorWaiting.SelectedText = "";
            this.tbColorWaiting.SelectionLength = 0;
            this.tbColorWaiting.SelectionStart = 0;
            this.tbColorWaiting.ShortcutsEnabled = true;
            this.tbColorWaiting.Size = new System.Drawing.Size(100, 23);
            this.tbColorWaiting.TabIndex = 23;
            this.tbColorWaiting.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbColorWaiting.UseCustomBackColor = true;
            this.tbColorWaiting.UseSelectable = true;
            this.tbColorWaiting.UseStyleColors = true;
            this.tbColorWaiting.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbColorWaiting.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbColorWaiting.TextChanged += new System.EventHandler(this.tbColor_TextChanged);
            // 
            // tbColorPending
            // 
            // 
            // 
            // 
            this.tbColorPending.CustomButton.Image = null;
            this.tbColorPending.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.tbColorPending.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbColorPending.CustomButton.Name = "";
            this.tbColorPending.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbColorPending.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbColorPending.CustomButton.TabIndex = 1;
            this.tbColorPending.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbColorPending.CustomButton.UseSelectable = true;
            this.tbColorPending.CustomButton.Visible = false;
            this.tbColorPending.Lines = new string[0];
            this.tbColorPending.Location = new System.Drawing.Point(106, 138);
            this.tbColorPending.MaxLength = 32767;
            this.tbColorPending.Name = "tbColorPending";
            this.tbColorPending.PasswordChar = '\0';
            this.tbColorPending.ReadOnly = true;
            this.tbColorPending.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbColorPending.SelectedText = "";
            this.tbColorPending.SelectionLength = 0;
            this.tbColorPending.SelectionStart = 0;
            this.tbColorPending.ShortcutsEnabled = true;
            this.tbColorPending.Size = new System.Drawing.Size(100, 23);
            this.tbColorPending.TabIndex = 22;
            this.tbColorPending.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbColorPending.UseCustomBackColor = true;
            this.tbColorPending.UseSelectable = true;
            this.tbColorPending.UseStyleColors = true;
            this.tbColorPending.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbColorPending.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbColorPending.TextChanged += new System.EventHandler(this.tbColor_TextChanged);
            // 
            // tbColorComplete
            // 
            // 
            // 
            // 
            this.tbColorComplete.CustomButton.Image = null;
            this.tbColorComplete.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.tbColorComplete.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbColorComplete.CustomButton.Name = "";
            this.tbColorComplete.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbColorComplete.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbColorComplete.CustomButton.TabIndex = 1;
            this.tbColorComplete.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbColorComplete.CustomButton.UseSelectable = true;
            this.tbColorComplete.CustomButton.Visible = false;
            this.tbColorComplete.Lines = new string[0];
            this.tbColorComplete.Location = new System.Drawing.Point(106, 109);
            this.tbColorComplete.MaxLength = 32767;
            this.tbColorComplete.Name = "tbColorComplete";
            this.tbColorComplete.PasswordChar = '\0';
            this.tbColorComplete.ReadOnly = true;
            this.tbColorComplete.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbColorComplete.SelectedText = "";
            this.tbColorComplete.SelectionLength = 0;
            this.tbColorComplete.SelectionStart = 0;
            this.tbColorComplete.ShortcutsEnabled = true;
            this.tbColorComplete.Size = new System.Drawing.Size(100, 23);
            this.tbColorComplete.TabIndex = 21;
            this.tbColorComplete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbColorComplete.UseCustomBackColor = true;
            this.tbColorComplete.UseSelectable = true;
            this.tbColorComplete.UseStyleColors = true;
            this.tbColorComplete.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbColorComplete.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbColorComplete.TextChanged += new System.EventHandler(this.tbColor_TextChanged);
            // 
            // tbColorPartialDone
            // 
            // 
            // 
            // 
            this.tbColorPartialDone.CustomButton.Image = null;
            this.tbColorPartialDone.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.tbColorPartialDone.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbColorPartialDone.CustomButton.Name = "";
            this.tbColorPartialDone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbColorPartialDone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbColorPartialDone.CustomButton.TabIndex = 1;
            this.tbColorPartialDone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbColorPartialDone.CustomButton.UseSelectable = true;
            this.tbColorPartialDone.CustomButton.Visible = false;
            this.tbColorPartialDone.Lines = new string[0];
            this.tbColorPartialDone.Location = new System.Drawing.Point(106, 80);
            this.tbColorPartialDone.MaxLength = 32767;
            this.tbColorPartialDone.Name = "tbColorPartialDone";
            this.tbColorPartialDone.PasswordChar = '\0';
            this.tbColorPartialDone.ReadOnly = true;
            this.tbColorPartialDone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbColorPartialDone.SelectedText = "";
            this.tbColorPartialDone.SelectionLength = 0;
            this.tbColorPartialDone.SelectionStart = 0;
            this.tbColorPartialDone.ShortcutsEnabled = true;
            this.tbColorPartialDone.Size = new System.Drawing.Size(100, 23);
            this.tbColorPartialDone.TabIndex = 20;
            this.tbColorPartialDone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbColorPartialDone.UseCustomBackColor = true;
            this.tbColorPartialDone.UseSelectable = true;
            this.tbColorPartialDone.UseStyleColors = true;
            this.tbColorPartialDone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbColorPartialDone.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbColorPartialDone.TextChanged += new System.EventHandler(this.tbColor_TextChanged);
            // 
            // tbColorWorkDone
            // 
            // 
            // 
            // 
            this.tbColorWorkDone.CustomButton.Image = null;
            this.tbColorWorkDone.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.tbColorWorkDone.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbColorWorkDone.CustomButton.Name = "";
            this.tbColorWorkDone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbColorWorkDone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbColorWorkDone.CustomButton.TabIndex = 1;
            this.tbColorWorkDone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbColorWorkDone.CustomButton.UseSelectable = true;
            this.tbColorWorkDone.CustomButton.Visible = false;
            this.tbColorWorkDone.Lines = new string[0];
            this.tbColorWorkDone.Location = new System.Drawing.Point(106, 51);
            this.tbColorWorkDone.MaxLength = 32767;
            this.tbColorWorkDone.Name = "tbColorWorkDone";
            this.tbColorWorkDone.PasswordChar = '\0';
            this.tbColorWorkDone.ReadOnly = true;
            this.tbColorWorkDone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbColorWorkDone.SelectedText = "";
            this.tbColorWorkDone.SelectionLength = 0;
            this.tbColorWorkDone.SelectionStart = 0;
            this.tbColorWorkDone.ShortcutsEnabled = true;
            this.tbColorWorkDone.Size = new System.Drawing.Size(100, 23);
            this.tbColorWorkDone.TabIndex = 19;
            this.tbColorWorkDone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbColorWorkDone.UseCustomBackColor = true;
            this.tbColorWorkDone.UseSelectable = true;
            this.tbColorWorkDone.UseStyleColors = true;
            this.tbColorWorkDone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbColorWorkDone.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbColorWorkDone.TextChanged += new System.EventHandler(this.tbColor_TextChanged);
            // 
            // tbColorWorking
            // 
            // 
            // 
            // 
            this.tbColorWorking.CustomButton.Image = null;
            this.tbColorWorking.CustomButton.Location = new System.Drawing.Point(78, 1);
            this.tbColorWorking.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbColorWorking.CustomButton.Name = "";
            this.tbColorWorking.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbColorWorking.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbColorWorking.CustomButton.TabIndex = 1;
            this.tbColorWorking.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbColorWorking.CustomButton.UseSelectable = true;
            this.tbColorWorking.CustomButton.Visible = false;
            this.tbColorWorking.Lines = new string[0];
            this.tbColorWorking.Location = new System.Drawing.Point(106, 22);
            this.tbColorWorking.MaxLength = 32767;
            this.tbColorWorking.Name = "tbColorWorking";
            this.tbColorWorking.PasswordChar = '\0';
            this.tbColorWorking.ReadOnly = true;
            this.tbColorWorking.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbColorWorking.SelectedText = "";
            this.tbColorWorking.SelectionLength = 0;
            this.tbColorWorking.SelectionStart = 0;
            this.tbColorWorking.ShortcutsEnabled = true;
            this.tbColorWorking.Size = new System.Drawing.Size(100, 23);
            this.tbColorWorking.TabIndex = 18;
            this.tbColorWorking.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbColorWorking.UseCustomBackColor = true;
            this.tbColorWorking.UseSelectable = true;
            this.tbColorWorking.UseStyleColors = true;
            this.tbColorWorking.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbColorWorking.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbColorWorking.TextChanged += new System.EventHandler(this.tbColor_TextChanged);
            // 
            // lbColorError
            // 
            this.lbColorError.Location = new System.Drawing.Point(11, 254);
            this.lbColorError.Name = "lbColorError";
            this.lbColorError.Size = new System.Drawing.Size(90, 19);
            this.lbColorError.TabIndex = 17;
            this.lbColorError.Text = "Error :";
            this.lbColorError.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbColorImpossible
            // 
            this.lbColorImpossible.Location = new System.Drawing.Point(11, 225);
            this.lbColorImpossible.Name = "lbColorImpossible";
            this.lbColorImpossible.Size = new System.Drawing.Size(90, 19);
            this.lbColorImpossible.TabIndex = 14;
            this.lbColorImpossible.Text = "Impossible :";
            this.lbColorImpossible.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbColorCancel
            // 
            this.lbColorCancel.Location = new System.Drawing.Point(11, 196);
            this.lbColorCancel.Name = "lbColorCancel";
            this.lbColorCancel.Size = new System.Drawing.Size(90, 19);
            this.lbColorCancel.TabIndex = 13;
            this.lbColorCancel.Text = "Cancel :";
            this.lbColorCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbColorWaiting
            // 
            this.lbColorWaiting.Location = new System.Drawing.Point(11, 167);
            this.lbColorWaiting.Name = "lbColorWaiting";
            this.lbColorWaiting.Size = new System.Drawing.Size(90, 19);
            this.lbColorWaiting.TabIndex = 12;
            this.lbColorWaiting.Text = "Waiting :";
            this.lbColorWaiting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbColorPending
            // 
            this.lbColorPending.Location = new System.Drawing.Point(11, 138);
            this.lbColorPending.Name = "lbColorPending";
            this.lbColorPending.Size = new System.Drawing.Size(90, 19);
            this.lbColorPending.TabIndex = 4;
            this.lbColorPending.Text = "Pending :";
            this.lbColorPending.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbColorComplete
            // 
            this.lbColorComplete.Location = new System.Drawing.Point(11, 109);
            this.lbColorComplete.Name = "lbColorComplete";
            this.lbColorComplete.Size = new System.Drawing.Size(90, 19);
            this.lbColorComplete.TabIndex = 3;
            this.lbColorComplete.Text = "Complete :";
            this.lbColorComplete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbColorPartialDone
            // 
            this.lbColorPartialDone.Location = new System.Drawing.Point(11, 80);
            this.lbColorPartialDone.Name = "lbColorPartialDone";
            this.lbColorPartialDone.Size = new System.Drawing.Size(90, 19);
            this.lbColorPartialDone.TabIndex = 2;
            this.lbColorPartialDone.Text = "Partial Done :";
            this.lbColorPartialDone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbColorWorkDone
            // 
            this.lbColorWorkDone.Location = new System.Drawing.Point(11, 51);
            this.lbColorWorkDone.Name = "lbColorWorkDone";
            this.lbColorWorkDone.Size = new System.Drawing.Size(90, 19);
            this.lbColorWorkDone.TabIndex = 1;
            this.lbColorWorkDone.Text = "Work Done :";
            this.lbColorWorkDone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbColorWorking
            // 
            this.lbColorWorking.Location = new System.Drawing.Point(11, 22);
            this.lbColorWorking.Name = "lbColorWorking";
            this.lbColorWorking.Size = new System.Drawing.Size(90, 19);
            this.lbColorWorking.TabIndex = 0;
            this.lbColorWorking.Text = "Working :";
            this.lbColorWorking.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnStdSamplePathOpen);
            this.groupBox3.Controls.Add(this.btnStdSamplePath);
            this.groupBox3.Controls.Add(this.tbStdSamplePath);
            this.groupBox3.Controls.Add(this.lbStdSampleDir);
            this.groupBox3.Controls.Add(this.btnStdDocPathOpen);
            this.groupBox3.Controls.Add(this.btnStdDocPath);
            this.groupBox3.Controls.Add(this.tbStdDocPath);
            this.groupBox3.Controls.Add(this.lbStdDocDir);
            this.groupBox3.Location = new System.Drawing.Point(10, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(870, 100);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "SpisHull";
            // 
            // btnStdSamplePathOpen
            // 
            this.btnStdSamplePathOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStdSamplePathOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStdSamplePathOpen.Location = new System.Drawing.Point(815, 51);
            this.btnStdSamplePathOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStdSamplePathOpen.Name = "btnStdSamplePathOpen";
            this.btnStdSamplePathOpen.Size = new System.Drawing.Size(35, 24);
            this.btnStdSamplePathOpen.TabIndex = 22;
            this.btnStdSamplePathOpen.Tag = "tbStdSamplePath";
            this.btnStdSamplePathOpen.Text = "Open";
            this.btnStdSamplePathOpen.UseSelectable = true;
            this.btnStdSamplePathOpen.Click += new System.EventHandler(this.btnPathOpen_Click);
            // 
            // btnStdSamplePath
            // 
            this.btnStdSamplePath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStdSamplePath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStdSamplePath.Location = new System.Drawing.Point(774, 51);
            this.btnStdSamplePath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStdSamplePath.Name = "btnStdSamplePath";
            this.btnStdSamplePath.Size = new System.Drawing.Size(35, 24);
            this.btnStdSamplePath.TabIndex = 21;
            this.btnStdSamplePath.Tag = "tbStdSamplePath";
            this.btnStdSamplePath.Text = "···";
            this.btnStdSamplePath.UseSelectable = true;
            this.btnStdSamplePath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // tbStdSamplePath
            // 
            // 
            // 
            // 
            this.tbStdSamplePath.CustomButton.Image = null;
            this.tbStdSamplePath.CustomButton.Location = new System.Drawing.Point(590, 1);
            this.tbStdSamplePath.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbStdSamplePath.CustomButton.Name = "";
            this.tbStdSamplePath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbStdSamplePath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbStdSamplePath.CustomButton.TabIndex = 1;
            this.tbStdSamplePath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbStdSamplePath.CustomButton.UseSelectable = true;
            this.tbStdSamplePath.CustomButton.Visible = false;
            this.tbStdSamplePath.Lines = new string[0];
            this.tbStdSamplePath.Location = new System.Drawing.Point(156, 51);
            this.tbStdSamplePath.MaxLength = 32767;
            this.tbStdSamplePath.Name = "tbStdSamplePath";
            this.tbStdSamplePath.PasswordChar = '\0';
            this.tbStdSamplePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbStdSamplePath.SelectedText = "";
            this.tbStdSamplePath.SelectionLength = 0;
            this.tbStdSamplePath.SelectionStart = 0;
            this.tbStdSamplePath.ShortcutsEnabled = true;
            this.tbStdSamplePath.Size = new System.Drawing.Size(612, 23);
            this.tbStdSamplePath.TabIndex = 20;
            this.tbStdSamplePath.UseSelectable = true;
            this.tbStdSamplePath.UseStyleColors = true;
            this.tbStdSamplePath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbStdSamplePath.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbStdSampleDir
            // 
            this.lbStdSampleDir.Location = new System.Drawing.Point(11, 52);
            this.lbStdSampleDir.Name = "lbStdSampleDir";
            this.lbStdSampleDir.Size = new System.Drawing.Size(140, 20);
            this.lbStdSampleDir.TabIndex = 19;
            this.lbStdSampleDir.Text = "Sample Directory :";
            this.lbStdSampleDir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnStdDocPathOpen
            // 
            this.btnStdDocPathOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStdDocPathOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStdDocPathOpen.Location = new System.Drawing.Point(815, 22);
            this.btnStdDocPathOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStdDocPathOpen.Name = "btnStdDocPathOpen";
            this.btnStdDocPathOpen.Size = new System.Drawing.Size(35, 24);
            this.btnStdDocPathOpen.TabIndex = 18;
            this.btnStdDocPathOpen.Tag = "tbStdDocPath";
            this.btnStdDocPathOpen.Text = "Open";
            this.btnStdDocPathOpen.UseSelectable = true;
            this.btnStdDocPathOpen.Click += new System.EventHandler(this.btnPathOpen_Click);
            // 
            // btnStdDocPath
            // 
            this.btnStdDocPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStdDocPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStdDocPath.Location = new System.Drawing.Point(774, 22);
            this.btnStdDocPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStdDocPath.Name = "btnStdDocPath";
            this.btnStdDocPath.Size = new System.Drawing.Size(35, 24);
            this.btnStdDocPath.TabIndex = 17;
            this.btnStdDocPath.Tag = "tbStdDocPath";
            this.btnStdDocPath.Text = "···";
            this.btnStdDocPath.UseSelectable = true;
            this.btnStdDocPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // tbStdDocPath
            // 
            // 
            // 
            // 
            this.tbStdDocPath.CustomButton.Image = null;
            this.tbStdDocPath.CustomButton.Location = new System.Drawing.Point(590, 1);
            this.tbStdDocPath.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbStdDocPath.CustomButton.Name = "";
            this.tbStdDocPath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbStdDocPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbStdDocPath.CustomButton.TabIndex = 1;
            this.tbStdDocPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbStdDocPath.CustomButton.UseSelectable = true;
            this.tbStdDocPath.CustomButton.Visible = false;
            this.tbStdDocPath.Lines = new string[0];
            this.tbStdDocPath.Location = new System.Drawing.Point(156, 22);
            this.tbStdDocPath.MaxLength = 32767;
            this.tbStdDocPath.Name = "tbStdDocPath";
            this.tbStdDocPath.PasswordChar = '\0';
            this.tbStdDocPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbStdDocPath.SelectedText = "";
            this.tbStdDocPath.SelectionLength = 0;
            this.tbStdDocPath.SelectionStart = 0;
            this.tbStdDocPath.ShortcutsEnabled = true;
            this.tbStdDocPath.Size = new System.Drawing.Size(612, 23);
            this.tbStdDocPath.TabIndex = 16;
            this.tbStdDocPath.UseSelectable = true;
            this.tbStdDocPath.UseStyleColors = true;
            this.tbStdDocPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbStdDocPath.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbStdDocDir
            // 
            this.lbStdDocDir.Location = new System.Drawing.Point(11, 23);
            this.lbStdDocDir.Name = "lbStdDocDir";
            this.lbStdDocDir.Size = new System.Drawing.Size(140, 20);
            this.lbStdDocDir.TabIndex = 15;
            this.lbStdDocDir.Text = "Document Directory :";
            this.lbStdDocDir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSmhSamplePathOpen);
            this.groupBox2.Controls.Add(this.btnSmhDocPathOpen);
            this.groupBox2.Controls.Add(this.btnSmhSamplePath);
            this.groupBox2.Controls.Add(this.tbSmhSamplePath);
            this.groupBox2.Controls.Add(this.lbSmhSampleDir);
            this.groupBox2.Controls.Add(this.btnSmhDocPath);
            this.groupBox2.Controls.Add(this.tbSmhDocPath);
            this.groupBox2.Controls.Add(this.lbSmhDocDir);
            this.groupBox2.Location = new System.Drawing.Point(10, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(870, 100);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SmartHull";
            // 
            // btnSmhSamplePathOpen
            // 
            this.btnSmhSamplePathOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSmhSamplePathOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSmhSamplePathOpen.Location = new System.Drawing.Point(815, 53);
            this.btnSmhSamplePathOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSmhSamplePathOpen.Name = "btnSmhSamplePathOpen";
            this.btnSmhSamplePathOpen.Size = new System.Drawing.Size(35, 24);
            this.btnSmhSamplePathOpen.TabIndex = 19;
            this.btnSmhSamplePathOpen.Tag = "tbSmhSamplePath";
            this.btnSmhSamplePathOpen.Text = "Open";
            this.btnSmhSamplePathOpen.UseSelectable = true;
            this.btnSmhSamplePathOpen.Click += new System.EventHandler(this.btnPathOpen_Click);
            // 
            // btnSmhDocPathOpen
            // 
            this.btnSmhDocPathOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSmhDocPathOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSmhDocPathOpen.Location = new System.Drawing.Point(815, 24);
            this.btnSmhDocPathOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSmhDocPathOpen.Name = "btnSmhDocPathOpen";
            this.btnSmhDocPathOpen.Size = new System.Drawing.Size(35, 24);
            this.btnSmhDocPathOpen.TabIndex = 16;
            this.btnSmhDocPathOpen.Tag = "tbSmhDocPath";
            this.btnSmhDocPathOpen.Text = "Open";
            this.btnSmhDocPathOpen.UseSelectable = true;
            this.btnSmhDocPathOpen.Click += new System.EventHandler(this.btnPathOpen_Click);
            // 
            // btnSmhSamplePath
            // 
            this.btnSmhSamplePath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSmhSamplePath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSmhSamplePath.Location = new System.Drawing.Point(774, 53);
            this.btnSmhSamplePath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSmhSamplePath.Name = "btnSmhSamplePath";
            this.btnSmhSamplePath.Size = new System.Drawing.Size(35, 24);
            this.btnSmhSamplePath.TabIndex = 18;
            this.btnSmhSamplePath.Tag = "tbSmhSamplePath";
            this.btnSmhSamplePath.Text = "···";
            this.btnSmhSamplePath.UseSelectable = true;
            this.btnSmhSamplePath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // tbSmhSamplePath
            // 
            // 
            // 
            // 
            this.tbSmhSamplePath.CustomButton.Image = null;
            this.tbSmhSamplePath.CustomButton.Location = new System.Drawing.Point(590, 1);
            this.tbSmhSamplePath.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSmhSamplePath.CustomButton.Name = "";
            this.tbSmhSamplePath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbSmhSamplePath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbSmhSamplePath.CustomButton.TabIndex = 1;
            this.tbSmhSamplePath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSmhSamplePath.CustomButton.UseSelectable = true;
            this.tbSmhSamplePath.CustomButton.Visible = false;
            this.tbSmhSamplePath.Lines = new string[0];
            this.tbSmhSamplePath.Location = new System.Drawing.Point(156, 53);
            this.tbSmhSamplePath.MaxLength = 32767;
            this.tbSmhSamplePath.Name = "tbSmhSamplePath";
            this.tbSmhSamplePath.PasswordChar = '\0';
            this.tbSmhSamplePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSmhSamplePath.SelectedText = "";
            this.tbSmhSamplePath.SelectionLength = 0;
            this.tbSmhSamplePath.SelectionStart = 0;
            this.tbSmhSamplePath.ShortcutsEnabled = true;
            this.tbSmhSamplePath.Size = new System.Drawing.Size(612, 23);
            this.tbSmhSamplePath.TabIndex = 17;
            this.tbSmhSamplePath.UseSelectable = true;
            this.tbSmhSamplePath.UseStyleColors = true;
            this.tbSmhSamplePath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSmhSamplePath.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbSmhSampleDir
            // 
            this.lbSmhSampleDir.Location = new System.Drawing.Point(11, 54);
            this.lbSmhSampleDir.Name = "lbSmhSampleDir";
            this.lbSmhSampleDir.Size = new System.Drawing.Size(140, 20);
            this.lbSmhSampleDir.TabIndex = 12;
            this.lbSmhSampleDir.Text = "Sample Directory :";
            this.lbSmhSampleDir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSmhDocPath
            // 
            this.btnSmhDocPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSmhDocPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSmhDocPath.Location = new System.Drawing.Point(774, 24);
            this.btnSmhDocPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSmhDocPath.Name = "btnSmhDocPath";
            this.btnSmhDocPath.Size = new System.Drawing.Size(35, 24);
            this.btnSmhDocPath.TabIndex = 15;
            this.btnSmhDocPath.Tag = "tbSmhDocPath";
            this.btnSmhDocPath.Text = "···";
            this.btnSmhDocPath.UseSelectable = true;
            this.btnSmhDocPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // tbSmhDocPath
            // 
            // 
            // 
            // 
            this.tbSmhDocPath.CustomButton.Image = null;
            this.tbSmhDocPath.CustomButton.Location = new System.Drawing.Point(590, 1);
            this.tbSmhDocPath.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSmhDocPath.CustomButton.Name = "";
            this.tbSmhDocPath.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbSmhDocPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbSmhDocPath.CustomButton.TabIndex = 1;
            this.tbSmhDocPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSmhDocPath.CustomButton.UseSelectable = true;
            this.tbSmhDocPath.CustomButton.Visible = false;
            this.tbSmhDocPath.Lines = new string[0];
            this.tbSmhDocPath.Location = new System.Drawing.Point(156, 24);
            this.tbSmhDocPath.MaxLength = 32767;
            this.tbSmhDocPath.Name = "tbSmhDocPath";
            this.tbSmhDocPath.PasswordChar = '\0';
            this.tbSmhDocPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSmhDocPath.SelectedText = "";
            this.tbSmhDocPath.SelectionLength = 0;
            this.tbSmhDocPath.SelectionStart = 0;
            this.tbSmhDocPath.ShortcutsEnabled = true;
            this.tbSmhDocPath.Size = new System.Drawing.Size(612, 23);
            this.tbSmhDocPath.TabIndex = 14;
            this.tbSmhDocPath.UseSelectable = true;
            this.tbSmhDocPath.UseStyleColors = true;
            this.tbSmhDocPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSmhDocPath.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbSmhDocDir
            // 
            this.lbSmhDocDir.Location = new System.Drawing.Point(11, 25);
            this.lbSmhDocDir.Name = "lbSmhDocDir";
            this.lbSmhDocDir.Size = new System.Drawing.Size(140, 20);
            this.lbSmhDocDir.TabIndex = 13;
            this.lbSmhDocDir.Text = "Document Directory :";
            this.lbSmhDocDir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbDBStatus);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.tbDbName);
            this.groupBox1.Controls.Add(this.tbDbPw);
            this.groupBox1.Controls.Add(this.tbDbId);
            this.groupBox1.Controls.Add(this.tbDbServer);
            this.groupBox1.Controls.Add(this.lbDbName);
            this.groupBox1.Controls.Add(this.lbPassword);
            this.groupBox1.Controls.Add(this.lbLoginId);
            this.groupBox1.Controls.Add(this.lbServer);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 140);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Database";
            this.groupBox1.UseCompatibleTextRendering = true;
            // 
            // lbDBStatus
            // 
            this.lbDBStatus.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbDBStatus.ForeColor = System.Drawing.Color.Red;
            this.lbDBStatus.Location = new System.Drawing.Point(261, 105);
            this.lbDBStatus.Name = "lbDBStatus";
            this.lbDBStatus.Size = new System.Drawing.Size(75, 20);
            this.lbDBStatus.TabIndex = 17;
            this.lbDBStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbDBStatus.UseCustomForeColor = true;
            // 
            // btnConnect
            // 
            this.btnConnect.Highlight = true;
            this.btnConnect.Location = new System.Drawing.Point(261, 47);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 51);
            this.btnConnect.TabIndex = 16;
            this.btnConnect.Text = "Connection\r\nTest";
            this.btnConnect.UseSelectable = true;
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
            this.tbDbName.Location = new System.Drawing.Point(106, 104);
            this.tbDbName.MaxLength = 32767;
            this.tbDbName.Name = "tbDbName";
            this.tbDbName.PasswordChar = '\0';
            this.tbDbName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDbName.SelectedText = "";
            this.tbDbName.SelectionLength = 0;
            this.tbDbName.SelectionStart = 0;
            this.tbDbName.ShortcutsEnabled = true;
            this.tbDbName.Size = new System.Drawing.Size(150, 23);
            this.tbDbName.TabIndex = 15;
            this.tbDbName.UseSelectable = true;
            this.tbDbName.UseStyleColors = true;
            this.tbDbName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbDbName.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.tbDbPw.Location = new System.Drawing.Point(106, 75);
            this.tbDbPw.MaxLength = 32767;
            this.tbDbPw.Name = "tbDbPw";
            this.tbDbPw.PasswordChar = '*';
            this.tbDbPw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDbPw.SelectedText = "";
            this.tbDbPw.SelectionLength = 0;
            this.tbDbPw.SelectionStart = 0;
            this.tbDbPw.ShortcutsEnabled = true;
            this.tbDbPw.Size = new System.Drawing.Size(150, 23);
            this.tbDbPw.TabIndex = 14;
            this.tbDbPw.UseSelectable = true;
            this.tbDbPw.UseStyleColors = true;
            this.tbDbPw.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbDbPw.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.tbDbId.Location = new System.Drawing.Point(106, 47);
            this.tbDbId.MaxLength = 32767;
            this.tbDbId.Name = "tbDbId";
            this.tbDbId.PasswordChar = '\0';
            this.tbDbId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDbId.SelectedText = "";
            this.tbDbId.SelectionLength = 0;
            this.tbDbId.SelectionStart = 0;
            this.tbDbId.ShortcutsEnabled = true;
            this.tbDbId.Size = new System.Drawing.Size(150, 23);
            this.tbDbId.TabIndex = 13;
            this.tbDbId.UseSelectable = true;
            this.tbDbId.UseStyleColors = true;
            this.tbDbId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbDbId.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.tbDbServer.Location = new System.Drawing.Point(106, 19);
            this.tbDbServer.MaxLength = 32767;
            this.tbDbServer.Name = "tbDbServer";
            this.tbDbServer.PasswordChar = '\0';
            this.tbDbServer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbDbServer.SelectedText = "";
            this.tbDbServer.SelectionLength = 0;
            this.tbDbServer.SelectionStart = 0;
            this.tbDbServer.ShortcutsEnabled = true;
            this.tbDbServer.Size = new System.Drawing.Size(230, 23);
            this.tbDbServer.TabIndex = 10;
            this.tbDbServer.UseSelectable = true;
            this.tbDbServer.UseStyleColors = true;
            this.tbDbServer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbDbServer.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lbDbName
            // 
            this.lbDbName.Location = new System.Drawing.Point(11, 103);
            this.lbDbName.Name = "lbDbName";
            this.lbDbName.Size = new System.Drawing.Size(90, 20);
            this.lbDbName.TabIndex = 11;
            this.lbDbName.Text = "DB Name :";
            this.lbDbName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbPassword
            // 
            this.lbPassword.Location = new System.Drawing.Point(11, 74);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(90, 20);
            this.lbPassword.TabIndex = 12;
            this.lbPassword.Text = "Password :";
            this.lbPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbLoginId
            // 
            this.lbLoginId.Location = new System.Drawing.Point(11, 46);
            this.lbLoginId.Name = "lbLoginId";
            this.lbLoginId.Size = new System.Drawing.Size(90, 20);
            this.lbLoginId.TabIndex = 8;
            this.lbLoginId.Text = "Login ID :";
            this.lbLoginId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbServer
            // 
            this.lbServer.Location = new System.Drawing.Point(11, 18);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(90, 20);
            this.lbServer.TabIndex = 9;
            this.lbServer.Text = "Server :";
            this.lbServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HelperPage
            // 
            this.HelperPage.BackColor = System.Drawing.SystemColors.Window;
            this.HelperPage.Location = new System.Drawing.Point(4, 41);
            this.HelperPage.Name = "HelperPage";
            this.HelperPage.Size = new System.Drawing.Size(1232, 673);
            this.HelperPage.TabIndex = 5;
            this.HelperPage.Text = "Helper";
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
            // styleMgr
            // 
            this.styleMgr.Owner = this;
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
            this.MinimumSize = new System.Drawing.Size(1280, 768);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.StyleManager = this.styleMgr;
            this.Text = "Hull Maintenance";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.smhPage.ResumeLayout(false);
            this.smhPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.smhGrid)).EndInit();
            this.collapsibleSmhPanel.ResumeLayout(false);
            this.stdPage.ResumeLayout(false);
            this.stdPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stdGrid)).EndInit();
            this.collapsibleStdPanel.ResumeLayout(false);
            this.settingPage.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.styleMgr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl tabControl;
        private System.Windows.Forms.TabPage smhPage;
        private System.Windows.Forms.TabPage stdPage;
        private System.Windows.Forms.TabPage settingPage;
        private System.Windows.Forms.TabPage HelperPage;
        private MetroFramework.Controls.MetroLabel lbMainTitle1;
        private MetroFramework.Controls.MetroLabel lbMainTitle2;
        private MetroFramework.Controls.MetroLabel lbMainTitle3;
        private MetroFramework.Controls.MetroLabel lbMainVersion;
        private MetroFramework.Controls.MetroPanel smhPanel;
        private MetroFramework.Controls.MetroPanel collapsibleSmhPanel;
        private MetroFramework.Controls.MetroPanel stdPanel;
        private MetroFramework.Controls.MetroPanel collapsibleStdPanel;
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
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroButton btnStdSamplePathOpen;
        private MetroFramework.Controls.MetroButton btnStdSamplePath;
        private MetroFramework.Controls.MetroTextBox tbStdSamplePath;
        private MetroFramework.Controls.MetroLabel lbStdSampleDir;
        private MetroFramework.Controls.MetroButton btnStdDocPathOpen;
        private MetroFramework.Controls.MetroButton btnStdDocPath;
        private MetroFramework.Controls.MetroTextBox tbStdDocPath;
        private MetroFramework.Controls.MetroLabel lbStdDocDir;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroButton btnSmhSamplePathOpen;
        private MetroFramework.Controls.MetroButton btnSmhDocPathOpen;
        private MetroFramework.Controls.MetroButton btnSmhSamplePath;
        private MetroFramework.Controls.MetroTextBox tbSmhSamplePath;
        private MetroFramework.Controls.MetroLabel lbSmhSampleDir;
        private MetroFramework.Controls.MetroButton btnSmhDocPath;
        private MetroFramework.Controls.MetroTextBox tbSmhDocPath;
        private MetroFramework.Controls.MetroLabel lbSmhDocDir;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel lbDBStatus;
        private MetroFramework.Controls.MetroButton btnConnect;
        private MetroFramework.Controls.MetroTextBox tbDbName;
        private MetroFramework.Controls.MetroTextBox tbDbPw;
        private MetroFramework.Controls.MetroTextBox tbDbId;
        private MetroFramework.Controls.MetroTextBox tbDbServer;
        private MetroFramework.Controls.MetroLabel lbDbName;
        private MetroFramework.Controls.MetroLabel lbPassword;
        private MetroFramework.Controls.MetroLabel lbLoginId;
        private MetroFramework.Controls.MetroLabel lbServer;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroLabel lbColorPending;
        private MetroFramework.Controls.MetroLabel lbColorComplete;
        private MetroFramework.Controls.MetroLabel lbColorPartialDone;
        private MetroFramework.Controls.MetroLabel lbColorWorkDone;
        private MetroFramework.Controls.MetroLabel lbColorWorking;
        private MetroFramework.Controls.MetroLabel lbColorImpossible;
        private MetroFramework.Controls.MetroLabel lbColorCancel;
        private MetroFramework.Controls.MetroLabel lbColorWaiting;
        private MetroFramework.Controls.MetroLabel lbColorError;
        private MetroFramework.Controls.MetroTextBox tbColorError;
        private MetroFramework.Controls.MetroTextBox tbColorImpossible;
        private MetroFramework.Controls.MetroTextBox tbColorCancel;
        private MetroFramework.Controls.MetroTextBox tbColorWaiting;
        private MetroFramework.Controls.MetroTextBox tbColorPending;
        private MetroFramework.Controls.MetroTextBox tbColorComplete;
        private MetroFramework.Controls.MetroTextBox tbColorPartialDone;
        private MetroFramework.Controls.MetroTextBox tbColorWorkDone;
        private MetroFramework.Controls.MetroTextBox tbColorWorking;
        private MetroFramework.Controls.MetroTextBox tbColorD7;
        private MetroFramework.Controls.MetroLabel lbColorD7;
        private MetroFramework.Controls.MetroTextBox tbColorD3;
        private MetroFramework.Controls.MetroLabel lbColorD3;
        private MetroFramework.Controls.MetroTextBox tbColorD1;
        private MetroFramework.Controls.MetroLabel lbColorD1;
        private MetroFramework.Controls.MetroButton btnTheme;
        private MetroFramework.Controls.MetroButton btnStyle;
        private System.Windows.Forms.ComboBox cbStdSearch;
        private MetroFramework.Controls.MetroButton btnStdSearch;
        private System.Windows.Forms.Button btnStdSearchClear;
        private MetroFramework.Controls.MetroButton btnStdAddItem;
        private MetroFramework.Controls.MetroButton btnSmhAddItem;
        private System.Windows.Forms.Button btnSmhSearchClear;
        private MetroFramework.Controls.MetroButton btnSmhSearch;
        private System.Windows.Forms.ComboBox cbSmhSearch;
    }
}

