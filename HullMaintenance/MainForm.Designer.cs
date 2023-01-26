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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle113 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle114 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle115 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle116 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle117 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle118 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle125 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle126 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle119 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle120 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle121 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle122 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle123 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle124 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ui_tabControl = new MetroFramework.Controls.MetroTabControl();
            this.smhPage = new System.Windows.Forms.TabPage();
            this.ui_panelSmh = new MetroFramework.Controls.MetroPanel();
            this.ui_gridSmh = new MetroFramework.Controls.MetroGrid();
            this.smhColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smhColCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smhColType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smhColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smhColSummaryKr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smhColReceiveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smhColDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smhColStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smhColEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smhColVerificationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smhColUpdateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smhColDocumentLink = new System.Windows.Forms.DataGridViewLinkColumn();
            this.smhColDocumentPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ui_panelSmhCollapsible = new MetroFramework.Controls.MetroPanel();
            this.ui_panelSubSmh2 = new MetroFramework.Controls.MetroPanel();
            this.ui_btnSmhAddItem = new MetroFramework.Controls.MetroButton();
            this.ui_panelSubSmh1 = new MetroFramework.Controls.MetroPanel();
            this.ui_cbSmhPeriod = new System.Windows.Forms.ComboBox();
            this.ui_cbSmhCustomer = new System.Windows.Forms.ComboBox();
            this.ui_btnSmhSearchHistoryClear = new MetroFramework.Controls.MetroButton();
            this.ui_btnSmhSearchTextClear = new System.Windows.Forms.Button();
            this.ui_btnSmhSearch = new MetroFramework.Controls.MetroButton();
            this.ui_cbSmhSearchText = new System.Windows.Forms.ComboBox();
            this.stdPage = new System.Windows.Forms.TabPage();
            this.ui_panelStd = new MetroFramework.Controls.MetroPanel();
            this.ui_gridStd = new MetroFramework.Controls.MetroGrid();
            this.stdColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdColCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdColType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdColSummaryKr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdColReceiveDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdColDueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdColStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdColEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdColVerificationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdColUpdateDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stdColDocumentLink = new System.Windows.Forms.DataGridViewLinkColumn();
            this.stdColDocumentPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ui_panelStdCollapsible = new MetroFramework.Controls.MetroPanel();
            this.ui_panelSubStd2 = new MetroFramework.Controls.MetroPanel();
            this.ui_btnStdAddItem = new MetroFramework.Controls.MetroButton();
            this.ui_panelSubStd1 = new MetroFramework.Controls.MetroPanel();
            this.ui_cbStdPeriod = new System.Windows.Forms.ComboBox();
            this.ui_cbStdCustomer = new System.Windows.Forms.ComboBox();
            this.ui_btnStdSearchHistoryClear = new MetroFramework.Controls.MetroButton();
            this.ui_btnStdSearchTextClear = new System.Windows.Forms.Button();
            this.ui_btnStdSearch = new MetroFramework.Controls.MetroButton();
            this.ui_cbStdSearchText = new System.Windows.Forms.ComboBox();
            this.settingPage = new System.Windows.Forms.TabPage();
            this.ui_gbColorCode = new System.Windows.Forms.GroupBox();
            this.ui_btnTheme = new MetroFramework.Controls.MetroButton();
            this.ui_btnStyle = new MetroFramework.Controls.MetroButton();
            this.ui_tbColorD7 = new MetroFramework.Controls.MetroTextBox();
            this.ui_lbColorD7 = new MetroFramework.Controls.MetroLabel();
            this.ui_tbColorD3 = new MetroFramework.Controls.MetroTextBox();
            this.ui_lbColorD3 = new MetroFramework.Controls.MetroLabel();
            this.ui_tbColorD1 = new MetroFramework.Controls.MetroTextBox();
            this.ui_lbColorD1 = new MetroFramework.Controls.MetroLabel();
            this.ui_tbColorError = new MetroFramework.Controls.MetroTextBox();
            this.ui_tbColorImpossible = new MetroFramework.Controls.MetroTextBox();
            this.ui_tbColorCancel = new MetroFramework.Controls.MetroTextBox();
            this.ui_tbColorPending = new MetroFramework.Controls.MetroTextBox();
            this.ui_tbColorComplete = new MetroFramework.Controls.MetroTextBox();
            this.ui_tbColorPartialDone = new MetroFramework.Controls.MetroTextBox();
            this.ui_tbColorWorkDone = new MetroFramework.Controls.MetroTextBox();
            this.ui_tbColorWorking = new MetroFramework.Controls.MetroTextBox();
            this.ui_lbColorError = new MetroFramework.Controls.MetroLabel();
            this.ui_lbColorImpossible = new MetroFramework.Controls.MetroLabel();
            this.ui_lbColorCancel = new MetroFramework.Controls.MetroLabel();
            this.ui_lbColorPending = new MetroFramework.Controls.MetroLabel();
            this.ui_lbColorComplete = new MetroFramework.Controls.MetroLabel();
            this.ui_lbColorPartialDone = new MetroFramework.Controls.MetroLabel();
            this.ui_lbColorWorkDone = new MetroFramework.Controls.MetroLabel();
            this.ui_lbColorWorking = new MetroFramework.Controls.MetroLabel();
            this.ui_gbStd = new System.Windows.Forms.GroupBox();
            this.ui_btnStdSamplePathOpen = new MetroFramework.Controls.MetroButton();
            this.ui_btnStdSamplePath = new MetroFramework.Controls.MetroButton();
            this.ui_tbStdSamplePath = new MetroFramework.Controls.MetroTextBox();
            this.ui_lbStdSampleDir = new MetroFramework.Controls.MetroLabel();
            this.ui_btnStdDocPathOpen = new MetroFramework.Controls.MetroButton();
            this.ui_btnStdDocPath = new MetroFramework.Controls.MetroButton();
            this.ui_tbStdDocPath = new MetroFramework.Controls.MetroTextBox();
            this.ui_lbStdDocDir = new MetroFramework.Controls.MetroLabel();
            this.ui_gbSmh = new System.Windows.Forms.GroupBox();
            this.ui_btnSmhSamplePathOpen = new MetroFramework.Controls.MetroButton();
            this.ui_btnSmhDocPathOpen = new MetroFramework.Controls.MetroButton();
            this.ui_btnSmhSamplePath = new MetroFramework.Controls.MetroButton();
            this.ui_tbSmhSamplePath = new MetroFramework.Controls.MetroTextBox();
            this.ui_lbSmhSampleDir = new MetroFramework.Controls.MetroLabel();
            this.ui_btnSmhDocPath = new MetroFramework.Controls.MetroButton();
            this.ui_tbSmhDocPath = new MetroFramework.Controls.MetroTextBox();
            this.ui_lbSmhDocDir = new MetroFramework.Controls.MetroLabel();
            this.ui_gbDb = new System.Windows.Forms.GroupBox();
            this.ui_lbDBStatus = new MetroFramework.Controls.MetroLabel();
            this.ui_btnConnect = new MetroFramework.Controls.MetroButton();
            this.ui_tbDbName = new MetroFramework.Controls.MetroTextBox();
            this.ui_tbDbPw = new MetroFramework.Controls.MetroTextBox();
            this.ui_tbDbId = new MetroFramework.Controls.MetroTextBox();
            this.ui_tbDbServer = new MetroFramework.Controls.MetroTextBox();
            this.ui_lbDbName = new MetroFramework.Controls.MetroLabel();
            this.ui_lbPassword = new MetroFramework.Controls.MetroLabel();
            this.ui_lbLoginId = new MetroFramework.Controls.MetroLabel();
            this.ui_lbServer = new MetroFramework.Controls.MetroLabel();
            this.HelperPage = new System.Windows.Forms.TabPage();
            this.ui_panelHelper = new MetroFramework.Controls.MetroPanel();
            this.ui_panelHelperCollapsible = new MetroFramework.Controls.MetroPanel();
            this.ui_btnLoadExcel = new MetroFramework.Controls.MetroButton();
            this.ui_btnClearExcel = new MetroFramework.Controls.MetroButton();
            this.ui_btnImportExcel = new MetroFramework.Controls.MetroButton();
            this.ui_lbMainTitle1 = new MetroFramework.Controls.MetroLabel();
            this.ui_lbMainTitle2 = new MetroFramework.Controls.MetroLabel();
            this.ui_lbMainTitle3 = new MetroFramework.Controls.MetroLabel();
            this.ui_lbMainVersion = new MetroFramework.Controls.MetroLabel();
            this.ui_styleMgr = new MetroFramework.Components.MetroStyleManager(this.components);
            this.ui_progressBar = new MetroFramework.Controls.MetroProgressBar();
            this.ui_tabControl.SuspendLayout();
            this.smhPage.SuspendLayout();
            this.ui_panelSmh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ui_gridSmh)).BeginInit();
            this.ui_panelSmhCollapsible.SuspendLayout();
            this.ui_panelSubSmh2.SuspendLayout();
            this.ui_panelSubSmh1.SuspendLayout();
            this.stdPage.SuspendLayout();
            this.ui_panelStd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ui_gridStd)).BeginInit();
            this.ui_panelStdCollapsible.SuspendLayout();
            this.ui_panelSubStd2.SuspendLayout();
            this.ui_panelSubStd1.SuspendLayout();
            this.settingPage.SuspendLayout();
            this.ui_gbColorCode.SuspendLayout();
            this.ui_gbStd.SuspendLayout();
            this.ui_gbSmh.SuspendLayout();
            this.ui_gbDb.SuspendLayout();
            this.HelperPage.SuspendLayout();
            this.ui_panelHelperCollapsible.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ui_styleMgr)).BeginInit();
            this.SuspendLayout();
            // 
            // ui_tabControl
            // 
            this.ui_tabControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.ui_tabControl.Controls.Add(this.smhPage);
            this.ui_tabControl.Controls.Add(this.stdPage);
            this.ui_tabControl.Controls.Add(this.settingPage);
            this.ui_tabControl.Controls.Add(this.HelperPage);
            this.ui_tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ui_tabControl.Location = new System.Drawing.Point(23, 38);
            this.ui_tabControl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_tabControl.Name = "ui_tabControl";
            this.ui_tabControl.SelectedIndex = 3;
            this.ui_tabControl.Size = new System.Drawing.Size(1417, 897);
            this.ui_tabControl.TabIndex = 0;
            this.ui_tabControl.UseSelectable = true;
            this.ui_tabControl.SelectedIndexChanged += new System.EventHandler(this.OnTabControlSelectedIndexChanged);
            this.ui_tabControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnTabControlKeyDown);
            this.ui_tabControl.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            // 
            // smhPage
            // 
            this.smhPage.BackColor = System.Drawing.SystemColors.Window;
            this.smhPage.Controls.Add(this.ui_panelSmh);
            this.smhPage.Controls.Add(this.ui_panelSmhCollapsible);
            this.smhPage.Font = new System.Drawing.Font("굴림", 9F);
            this.smhPage.Location = new System.Drawing.Point(4, 41);
            this.smhPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.smhPage.Name = "smhPage";
            this.smhPage.Size = new System.Drawing.Size(1409, 852);
            this.smhPage.TabIndex = 1;
            this.smhPage.Tag = "smarthull";
            this.smhPage.Text = "SmartHull";
            // 
            // ui_panelSmh
            // 
            this.ui_panelSmh.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ui_panelSmh.Controls.Add(this.ui_gridSmh);
            this.ui_panelSmh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ui_panelSmh.HorizontalScrollbarBarColor = true;
            this.ui_panelSmh.HorizontalScrollbarHighlightOnWheel = false;
            this.ui_panelSmh.HorizontalScrollbarSize = 12;
            this.ui_panelSmh.Location = new System.Drawing.Point(0, 60);
            this.ui_panelSmh.Margin = new System.Windows.Forms.Padding(0);
            this.ui_panelSmh.Name = "ui_panelSmh";
            this.ui_panelSmh.Padding = new System.Windows.Forms.Padding(1);
            this.ui_panelSmh.Size = new System.Drawing.Size(1409, 792);
            this.ui_panelSmh.TabIndex = 1;
            this.ui_panelSmh.UseCustomBackColor = true;
            this.ui_panelSmh.VerticalScrollbarBarColor = true;
            this.ui_panelSmh.VerticalScrollbarHighlightOnWheel = false;
            this.ui_panelSmh.VerticalScrollbarSize = 11;
            // 
            // ui_gridSmh
            // 
            this.ui_gridSmh.AllowUserToAddRows = false;
            this.ui_gridSmh.AllowUserToDeleteRows = false;
            this.ui_gridSmh.AllowUserToOrderColumns = true;
            this.ui_gridSmh.AllowUserToResizeRows = false;
            dataGridViewCellStyle113.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ui_gridSmh.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle113;
            this.ui_gridSmh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ui_gridSmh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ui_gridSmh.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ui_gridSmh.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ui_gridSmh.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle114.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle114.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle114.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle114.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle114.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle114.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle114.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle114.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ui_gridSmh.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle114;
            this.ui_gridSmh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ui_gridSmh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.smhColId,
            this.smhColCustomer,
            this.smhColType,
            this.smhColStatus,
            this.smhColSummaryKr,
            this.smhColReceiveDate,
            this.smhColDueDate,
            this.smhColStartDate,
            this.smhColEndDate,
            this.smhColVerificationDate,
            this.smhColUpdateDate,
            this.smhColDocumentLink,
            this.smhColDocumentPath});
            dataGridViewCellStyle115.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle115.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle115.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle115.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle115.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            dataGridViewCellStyle115.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle115.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle115.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ui_gridSmh.DefaultCellStyle = dataGridViewCellStyle115;
            this.ui_gridSmh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ui_gridSmh.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ui_gridSmh.EnableHeadersVisualStyles = false;
            this.ui_gridSmh.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ui_gridSmh.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ui_gridSmh.Location = new System.Drawing.Point(1, 1);
            this.ui_gridSmh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_gridSmh.MultiSelect = false;
            this.ui_gridSmh.Name = "ui_gridSmh";
            this.ui_gridSmh.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle116.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle116.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle116.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle116.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle116.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle116.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle116.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ui_gridSmh.RowHeadersDefaultCellStyle = dataGridViewCellStyle116;
            this.ui_gridSmh.RowHeadersWidth = 60;
            this.ui_gridSmh.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ui_gridSmh.RowTemplate.DividerHeight = 1;
            this.ui_gridSmh.RowTemplate.Height = 23;
            this.ui_gridSmh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ui_gridSmh.Size = new System.Drawing.Size(1407, 790);
            this.ui_gridSmh.TabIndex = 1;
            this.ui_gridSmh.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnGridCellDoubleClick);
            this.ui_gridSmh.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.OnGridDataBindingComplete);
            this.ui_gridSmh.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            // 
            // smhColId
            // 
            this.smhColId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.smhColId.DataPropertyName = "id";
            this.smhColId.DividerWidth = 1;
            this.smhColId.HeaderText = "ID";
            this.smhColId.Name = "smhColId";
            this.smhColId.Visible = false;
            // 
            // smhColCustomer
            // 
            this.smhColCustomer.DataPropertyName = "customer";
            this.smhColCustomer.DividerWidth = 1;
            this.smhColCustomer.HeaderText = "Customer";
            this.smhColCustomer.Name = "smhColCustomer";
            this.smhColCustomer.Visible = false;
            // 
            // smhColType
            // 
            this.smhColType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.smhColType.DataPropertyName = "type";
            this.smhColType.DividerWidth = 1;
            this.smhColType.HeaderText = "Type";
            this.smhColType.Name = "smhColType";
            this.smhColType.Width = 63;
            // 
            // smhColStatus
            // 
            this.smhColStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.smhColStatus.DataPropertyName = "status";
            this.smhColStatus.DividerWidth = 1;
            this.smhColStatus.HeaderText = "Status";
            this.smhColStatus.Name = "smhColStatus";
            this.smhColStatus.Width = 71;
            // 
            // smhColSummaryKr
            // 
            this.smhColSummaryKr.DataPropertyName = "summary_kr";
            this.smhColSummaryKr.DividerWidth = 1;
            this.smhColSummaryKr.HeaderText = "Summary";
            this.smhColSummaryKr.Name = "smhColSummaryKr";
            // 
            // smhColReceiveDate
            // 
            this.smhColReceiveDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.smhColReceiveDate.DataPropertyName = "receive_date";
            this.smhColReceiveDate.DividerWidth = 1;
            this.smhColReceiveDate.HeaderText = "Receive Date";
            this.smhColReceiveDate.Name = "smhColReceiveDate";
            this.smhColReceiveDate.Width = 102;
            // 
            // smhColDueDate
            // 
            this.smhColDueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.smhColDueDate.DataPropertyName = "due_date";
            this.smhColDueDate.DividerWidth = 1;
            this.smhColDueDate.HeaderText = "Due Date";
            this.smhColDueDate.Name = "smhColDueDate";
            this.smhColDueDate.Width = 83;
            // 
            // smhColStartDate
            // 
            this.smhColStartDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.smhColStartDate.DataPropertyName = "start_date";
            this.smhColStartDate.DividerWidth = 1;
            this.smhColStartDate.HeaderText = "Start Date";
            this.smhColStartDate.Name = "smhColStartDate";
            this.smhColStartDate.Visible = false;
            // 
            // smhColEndDate
            // 
            this.smhColEndDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.smhColEndDate.DataPropertyName = "end_date";
            this.smhColEndDate.DividerWidth = 1;
            this.smhColEndDate.HeaderText = "End Date";
            this.smhColEndDate.Name = "smhColEndDate";
            this.smhColEndDate.Visible = false;
            // 
            // smhColVerificationDate
            // 
            this.smhColVerificationDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.smhColVerificationDate.DataPropertyName = "verification_date";
            this.smhColVerificationDate.DividerWidth = 1;
            this.smhColVerificationDate.HeaderText = "Verification Date";
            this.smhColVerificationDate.Name = "smhColVerificationDate";
            this.smhColVerificationDate.Visible = false;
            // 
            // smhColUpdateDate
            // 
            this.smhColUpdateDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.smhColUpdateDate.DataPropertyName = "update_date";
            this.smhColUpdateDate.DividerWidth = 1;
            this.smhColUpdateDate.HeaderText = "Update Date";
            this.smhColUpdateDate.Name = "smhColUpdateDate";
            this.smhColUpdateDate.Width = 101;
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
            this.smhColDocumentLink.Width = 87;
            // 
            // smhColDocumentPath
            // 
            this.smhColDocumentPath.DataPropertyName = "document_file";
            this.smhColDocumentPath.DividerWidth = 1;
            this.smhColDocumentPath.HeaderText = "File Path";
            this.smhColDocumentPath.Name = "smhColDocumentPath";
            this.smhColDocumentPath.Visible = false;
            // 
            // ui_panelSmhCollapsible
            // 
            this.ui_panelSmhCollapsible.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ui_panelSmhCollapsible.Controls.Add(this.ui_panelSubSmh2);
            this.ui_panelSmhCollapsible.Controls.Add(this.ui_panelSubSmh1);
            this.ui_panelSmhCollapsible.Controls.Add(this.ui_btnSmhSearchHistoryClear);
            this.ui_panelSmhCollapsible.Controls.Add(this.ui_btnSmhSearchTextClear);
            this.ui_panelSmhCollapsible.Controls.Add(this.ui_btnSmhSearch);
            this.ui_panelSmhCollapsible.Controls.Add(this.ui_cbSmhSearchText);
            this.ui_panelSmhCollapsible.Dock = System.Windows.Forms.DockStyle.Top;
            this.ui_panelSmhCollapsible.HorizontalScrollbarBarColor = true;
            this.ui_panelSmhCollapsible.HorizontalScrollbarHighlightOnWheel = false;
            this.ui_panelSmhCollapsible.HorizontalScrollbarSize = 12;
            this.ui_panelSmhCollapsible.Location = new System.Drawing.Point(0, 0);
            this.ui_panelSmhCollapsible.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_panelSmhCollapsible.Name = "ui_panelSmhCollapsible";
            this.ui_panelSmhCollapsible.Size = new System.Drawing.Size(1409, 60);
            this.ui_panelSmhCollapsible.TabIndex = 0;
            this.ui_panelSmhCollapsible.UseCustomBackColor = true;
            this.ui_panelSmhCollapsible.VerticalScrollbarBarColor = true;
            this.ui_panelSmhCollapsible.VerticalScrollbarHighlightOnWheel = false;
            this.ui_panelSmhCollapsible.VerticalScrollbarSize = 11;
            // 
            // ui_panelSubSmh2
            // 
            this.ui_panelSubSmh2.BackColor = System.Drawing.Color.Transparent;
            this.ui_panelSubSmh2.Controls.Add(this.ui_btnSmhAddItem);
            this.ui_panelSubSmh2.Dock = System.Windows.Forms.DockStyle.Right;
            this.ui_panelSubSmh2.HorizontalScrollbarBarColor = true;
            this.ui_panelSubSmh2.HorizontalScrollbarHighlightOnWheel = false;
            this.ui_panelSubSmh2.HorizontalScrollbarSize = 10;
            this.ui_panelSubSmh2.Location = new System.Drawing.Point(1209, 0);
            this.ui_panelSubSmh2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ui_panelSubSmh2.Name = "ui_panelSubSmh2";
            this.ui_panelSubSmh2.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.ui_panelSubSmh2.Size = new System.Drawing.Size(200, 60);
            this.ui_panelSubSmh2.TabIndex = 25;
            this.ui_panelSubSmh2.UseCustomBackColor = true;
            this.ui_panelSubSmh2.VerticalScrollbarBarColor = true;
            this.ui_panelSubSmh2.VerticalScrollbarHighlightOnWheel = false;
            this.ui_panelSubSmh2.VerticalScrollbarSize = 10;
            // 
            // ui_btnSmhAddItem
            // 
            this.ui_btnSmhAddItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ui_btnSmhAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ui_btnSmhAddItem.Location = new System.Drawing.Point(122, 19);
            this.ui_btnSmhAddItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_btnSmhAddItem.Name = "ui_btnSmhAddItem";
            this.ui_btnSmhAddItem.Size = new System.Drawing.Size(59, 25);
            this.ui_btnSmhAddItem.TabIndex = 8;
            this.ui_btnSmhAddItem.Tag = "ui_gridSmh";
            this.ui_btnSmhAddItem.Text = "Add";
            this.ui_btnSmhAddItem.UseCustomBackColor = true;
            this.ui_btnSmhAddItem.UseSelectable = true;
            this.ui_btnSmhAddItem.Click += new System.EventHandler(this.OnClickBtnAddItem);
            // 
            // ui_panelSubSmh1
            // 
            this.ui_panelSubSmh1.BackColor = System.Drawing.Color.Transparent;
            this.ui_panelSubSmh1.Controls.Add(this.ui_cbSmhPeriod);
            this.ui_panelSubSmh1.Controls.Add(this.ui_cbSmhCustomer);
            this.ui_panelSubSmh1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ui_panelSubSmh1.HorizontalScrollbarBarColor = true;
            this.ui_panelSubSmh1.HorizontalScrollbarHighlightOnWheel = false;
            this.ui_panelSubSmh1.HorizontalScrollbarSize = 10;
            this.ui_panelSubSmh1.Location = new System.Drawing.Point(0, 0);
            this.ui_panelSubSmh1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ui_panelSubSmh1.Name = "ui_panelSubSmh1";
            this.ui_panelSubSmh1.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.ui_panelSubSmh1.Size = new System.Drawing.Size(343, 60);
            this.ui_panelSubSmh1.TabIndex = 24;
            this.ui_panelSubSmh1.UseCustomBackColor = true;
            this.ui_panelSubSmh1.VerticalScrollbarBarColor = true;
            this.ui_panelSubSmh1.VerticalScrollbarHighlightOnWheel = false;
            this.ui_panelSubSmh1.VerticalScrollbarSize = 10;
            // 
            // ui_cbSmhPeriod
            // 
            this.ui_cbSmhPeriod.BackColor = System.Drawing.SystemColors.Window;
            this.ui_cbSmhPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ui_cbSmhPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ui_cbSmhPeriod.Font = new System.Drawing.Font("굴림", 9F);
            this.ui_cbSmhPeriod.FormattingEnabled = true;
            this.ui_cbSmhPeriod.ItemHeight = 15;
            this.ui_cbSmhPeriod.Location = new System.Drawing.Point(187, 19);
            this.ui_cbSmhPeriod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_cbSmhPeriod.Name = "ui_cbSmhPeriod";
            this.ui_cbSmhPeriod.Size = new System.Drawing.Size(137, 23);
            this.ui_cbSmhPeriod.TabIndex = 3;
            this.ui_cbSmhPeriod.Tag = "ui_gridStd";
            this.ui_cbSmhPeriod.SelectedValueChanged += new System.EventHandler(this.OnConditionSelectedValueChanged);
            // 
            // ui_cbSmhCustomer
            // 
            this.ui_cbSmhCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ui_cbSmhCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ui_cbSmhCustomer.FormattingEnabled = true;
            this.ui_cbSmhCustomer.Location = new System.Drawing.Point(18, 19);
            this.ui_cbSmhCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_cbSmhCustomer.Name = "ui_cbSmhCustomer";
            this.ui_cbSmhCustomer.Size = new System.Drawing.Size(137, 23);
            this.ui_cbSmhCustomer.TabIndex = 2;
            this.ui_cbSmhCustomer.Tag = "ui_gridSmh";
            this.ui_cbSmhCustomer.SelectedValueChanged += new System.EventHandler(this.OnConditionSelectedValueChanged);
            // 
            // ui_btnSmhSearchHistoryClear
            // 
            this.ui_btnSmhSearchHistoryClear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ui_btnSmhSearchHistoryClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ui_btnSmhSearchHistoryClear.Location = new System.Drawing.Point(847, 19);
            this.ui_btnSmhSearchHistoryClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_btnSmhSearchHistoryClear.Name = "ui_btnSmhSearchHistoryClear";
            this.ui_btnSmhSearchHistoryClear.Size = new System.Drawing.Size(59, 25);
            this.ui_btnSmhSearchHistoryClear.TabIndex = 7;
            this.ui_btnSmhSearchHistoryClear.Tag = "ui_cbSmhSearchText";
            this.ui_btnSmhSearchHistoryClear.Text = "Clear";
            this.ui_btnSmhSearchHistoryClear.UseCustomBackColor = true;
            this.ui_btnSmhSearchHistoryClear.UseSelectable = true;
            this.ui_btnSmhSearchHistoryClear.Click += new System.EventHandler(this.OnClickBtnSearchHistoryClear);
            // 
            // ui_btnSmhSearchTextClear
            // 
            this.ui_btnSmhSearchTextClear.BackColor = System.Drawing.Color.Transparent;
            this.ui_btnSmhSearchTextClear.BackgroundImage = global::HullMaintenance.Properties.Resources.iconmonstr_x_mark_1_24;
            this.ui_btnSmhSearchTextClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ui_btnSmhSearchTextClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ui_btnSmhSearchTextClear.FlatAppearance.BorderSize = 0;
            this.ui_btnSmhSearchTextClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ui_btnSmhSearchTextClear.Location = new System.Drawing.Point(350, 25);
            this.ui_btnSmhSearchTextClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_btnSmhSearchTextClear.Name = "ui_btnSmhSearchTextClear";
            this.ui_btnSmhSearchTextClear.Size = new System.Drawing.Size(11, 12);
            this.ui_btnSmhSearchTextClear.TabIndex = 5;
            this.ui_btnSmhSearchTextClear.Tag = "ui_cbSmhSearchText";
            this.ui_btnSmhSearchTextClear.UseVisualStyleBackColor = false;
            this.ui_btnSmhSearchTextClear.Click += new System.EventHandler(this.OnClickBtnSearchTextClear);
            // 
            // ui_btnSmhSearch
            // 
            this.ui_btnSmhSearch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ui_btnSmhSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ui_btnSmhSearch.Location = new System.Drawing.Point(781, 19);
            this.ui_btnSmhSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_btnSmhSearch.Name = "ui_btnSmhSearch";
            this.ui_btnSmhSearch.Size = new System.Drawing.Size(59, 25);
            this.ui_btnSmhSearch.TabIndex = 6;
            this.ui_btnSmhSearch.Tag = "ui_cbSmhSearchText";
            this.ui_btnSmhSearch.Text = "Find";
            this.ui_btnSmhSearch.UseCustomBackColor = true;
            this.ui_btnSmhSearch.UseSelectable = true;
            this.ui_btnSmhSearch.Click += new System.EventHandler(this.OnClickBtnSearch);
            // 
            // ui_cbSmhSearchText
            // 
            this.ui_cbSmhSearchText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ui_cbSmhSearchText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ui_cbSmhSearchText.FormattingEnabled = true;
            this.ui_cbSmhSearchText.Location = new System.Drawing.Point(373, 19);
            this.ui_cbSmhSearchText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_cbSmhSearchText.Name = "ui_cbSmhSearchText";
            this.ui_cbSmhSearchText.Size = new System.Drawing.Size(399, 23);
            this.ui_cbSmhSearchText.TabIndex = 4;
            this.ui_cbSmhSearchText.Tag = "ui_gridSmh";
            this.ui_cbSmhSearchText.TextChanged += new System.EventHandler(this.OnSeachTextChanged);
            this.ui_cbSmhSearchText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnSearchTexKeyDown);
            // 
            // stdPage
            // 
            this.stdPage.AutoScroll = true;
            this.stdPage.BackColor = System.Drawing.SystemColors.Window;
            this.stdPage.Controls.Add(this.ui_panelStd);
            this.stdPage.Controls.Add(this.ui_panelStdCollapsible);
            this.stdPage.Font = new System.Drawing.Font("굴림", 9F);
            this.stdPage.Location = new System.Drawing.Point(4, 41);
            this.stdPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stdPage.Name = "stdPage";
            this.stdPage.Size = new System.Drawing.Size(1409, 852);
            this.stdPage.TabIndex = 2;
            this.stdPage.Tag = "spishull";
            this.stdPage.Text = "SpisHull";
            // 
            // ui_panelStd
            // 
            this.ui_panelStd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ui_panelStd.Controls.Add(this.ui_gridStd);
            this.ui_panelStd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ui_panelStd.HorizontalScrollbarBarColor = true;
            this.ui_panelStd.HorizontalScrollbarHighlightOnWheel = false;
            this.ui_panelStd.HorizontalScrollbarSize = 12;
            this.ui_panelStd.Location = new System.Drawing.Point(0, 60);
            this.ui_panelStd.Margin = new System.Windows.Forms.Padding(0);
            this.ui_panelStd.Name = "ui_panelStd";
            this.ui_panelStd.Padding = new System.Windows.Forms.Padding(1);
            this.ui_panelStd.Size = new System.Drawing.Size(1409, 792);
            this.ui_panelStd.TabIndex = 1;
            this.ui_panelStd.UseCustomBackColor = true;
            this.ui_panelStd.VerticalScrollbarBarColor = true;
            this.ui_panelStd.VerticalScrollbarHighlightOnWheel = false;
            this.ui_panelStd.VerticalScrollbarSize = 11;
            // 
            // ui_gridStd
            // 
            this.ui_gridStd.AllowUserToAddRows = false;
            this.ui_gridStd.AllowUserToDeleteRows = false;
            this.ui_gridStd.AllowUserToOrderColumns = true;
            this.ui_gridStd.AllowUserToResizeRows = false;
            dataGridViewCellStyle117.BackColor = System.Drawing.Color.White;
            this.ui_gridStd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle117;
            this.ui_gridStd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ui_gridStd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ui_gridStd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ui_gridStd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.ui_gridStd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle118.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle118.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle118.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle118.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle118.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            dataGridViewCellStyle118.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle118.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle118.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ui_gridStd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle118;
            this.ui_gridStd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ui_gridStd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stdColId,
            this.stdColCustomer,
            this.stdColType,
            this.stdColStatus,
            this.stdColSummaryKr,
            this.stdColReceiveDate,
            this.stdColDueDate,
            this.stdColStartDate,
            this.stdColEndDate,
            this.stdColVerificationDate,
            this.stdColUpdateDate,
            this.stdColDocumentLink,
            this.stdColDocumentPath});
            dataGridViewCellStyle125.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle125.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle125.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle125.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle125.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            dataGridViewCellStyle125.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle125.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle125.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ui_gridStd.DefaultCellStyle = dataGridViewCellStyle125;
            this.ui_gridStd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ui_gridStd.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.ui_gridStd.EnableHeadersVisualStyles = false;
            this.ui_gridStd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ui_gridStd.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ui_gridStd.Location = new System.Drawing.Point(1, 1);
            this.ui_gridStd.Margin = new System.Windows.Forms.Padding(0);
            this.ui_gridStd.MultiSelect = false;
            this.ui_gridStd.Name = "ui_gridStd";
            this.ui_gridStd.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle126.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle126.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle126.Font = new System.Drawing.Font("Open Sans", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle126.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle126.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle126.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle126.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ui_gridStd.RowHeadersDefaultCellStyle = dataGridViewCellStyle126;
            this.ui_gridStd.RowHeadersWidth = 60;
            this.ui_gridStd.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ui_gridStd.RowTemplate.DividerHeight = 1;
            this.ui_gridStd.RowTemplate.Height = 23;
            this.ui_gridStd.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ui_gridStd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ui_gridStd.Size = new System.Drawing.Size(1407, 790);
            this.ui_gridStd.TabIndex = 1;
            this.ui_gridStd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnClickBtnCellContent);
            this.ui_gridStd.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OnGridCellDoubleClick);
            this.ui_gridStd.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.OnGridDataBindingComplete);
            this.ui_gridStd.MouseEnter += new System.EventHandler(this.OnMouseEnter);
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
            this.stdColId.Visible = false;
            // 
            // stdColCustomer
            // 
            this.stdColCustomer.DataPropertyName = "customer";
            this.stdColCustomer.DividerWidth = 1;
            this.stdColCustomer.HeaderText = "Customer";
            this.stdColCustomer.Name = "stdColCustomer";
            this.stdColCustomer.Visible = false;
            // 
            // stdColType
            // 
            this.stdColType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stdColType.DataPropertyName = "type";
            this.stdColType.DividerWidth = 1;
            this.stdColType.FillWeight = 25.33413F;
            this.stdColType.HeaderText = "Type";
            this.stdColType.Name = "stdColType";
            this.stdColType.Width = 63;
            // 
            // stdColStatus
            // 
            this.stdColStatus.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stdColStatus.DataPropertyName = "status";
            this.stdColStatus.DividerWidth = 1;
            this.stdColStatus.FillWeight = 33.8766F;
            this.stdColStatus.HeaderText = "Status";
            this.stdColStatus.Name = "stdColStatus";
            this.stdColStatus.Width = 71;
            // 
            // stdColSummaryKr
            // 
            this.stdColSummaryKr.DataPropertyName = "summary_kr";
            this.stdColSummaryKr.DividerWidth = 1;
            this.stdColSummaryKr.FillWeight = 76.81911F;
            this.stdColSummaryKr.HeaderText = "Summary";
            this.stdColSummaryKr.Name = "stdColSummaryKr";
            // 
            // stdColReceiveDate
            // 
            this.stdColReceiveDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stdColReceiveDate.DataPropertyName = "receive_date";
            dataGridViewCellStyle119.Format = "yyyy-MM-dd ddd";
            this.stdColReceiveDate.DefaultCellStyle = dataGridViewCellStyle119;
            this.stdColReceiveDate.DividerWidth = 1;
            this.stdColReceiveDate.HeaderText = "Receive Date";
            this.stdColReceiveDate.Name = "stdColReceiveDate";
            this.stdColReceiveDate.Width = 102;
            // 
            // stdColDueDate
            // 
            this.stdColDueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stdColDueDate.DataPropertyName = "due_date";
            dataGridViewCellStyle120.Format = "yyyy-MM-dd ddd";
            dataGridViewCellStyle120.NullValue = null;
            this.stdColDueDate.DefaultCellStyle = dataGridViewCellStyle120;
            this.stdColDueDate.DividerWidth = 1;
            this.stdColDueDate.FillWeight = 51.24502F;
            this.stdColDueDate.HeaderText = "Due Date";
            this.stdColDueDate.Name = "stdColDueDate";
            this.stdColDueDate.Width = 83;
            // 
            // stdColStartDate
            // 
            this.stdColStartDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stdColStartDate.DataPropertyName = "start_date";
            dataGridViewCellStyle121.Format = "yyyy-MM-dd ddd";
            this.stdColStartDate.DefaultCellStyle = dataGridViewCellStyle121;
            this.stdColStartDate.DividerWidth = 1;
            this.stdColStartDate.HeaderText = "Start Date";
            this.stdColStartDate.Name = "stdColStartDate";
            this.stdColStartDate.Visible = false;
            // 
            // stdColEndDate
            // 
            this.stdColEndDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stdColEndDate.DataPropertyName = "end_date";
            dataGridViewCellStyle122.Format = "yyyy-MM-dd ddd";
            this.stdColEndDate.DefaultCellStyle = dataGridViewCellStyle122;
            this.stdColEndDate.DividerWidth = 1;
            this.stdColEndDate.HeaderText = "End Date";
            this.stdColEndDate.Name = "stdColEndDate";
            this.stdColEndDate.Visible = false;
            // 
            // stdColVerificationDate
            // 
            this.stdColVerificationDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stdColVerificationDate.DataPropertyName = "verification_date";
            dataGridViewCellStyle123.Format = "yyyy-MM-dd ddd";
            this.stdColVerificationDate.DefaultCellStyle = dataGridViewCellStyle123;
            this.stdColVerificationDate.DividerWidth = 1;
            this.stdColVerificationDate.HeaderText = "Verification Date";
            this.stdColVerificationDate.Name = "stdColVerificationDate";
            this.stdColVerificationDate.Visible = false;
            // 
            // stdColUpdateDate
            // 
            this.stdColUpdateDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stdColUpdateDate.DataPropertyName = "update_date";
            dataGridViewCellStyle124.Format = "yyyy-MM-dd ddd";
            this.stdColUpdateDate.DefaultCellStyle = dataGridViewCellStyle124;
            this.stdColUpdateDate.DividerWidth = 1;
            this.stdColUpdateDate.FillWeight = 51.79351F;
            this.stdColUpdateDate.HeaderText = "Update Date";
            this.stdColUpdateDate.Name = "stdColUpdateDate";
            this.stdColUpdateDate.Width = 101;
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
            this.stdColDocumentLink.Width = 87;
            // 
            // stdColDocumentPath
            // 
            this.stdColDocumentPath.DataPropertyName = "document_file";
            this.stdColDocumentPath.DividerWidth = 1;
            this.stdColDocumentPath.HeaderText = "File Path";
            this.stdColDocumentPath.Name = "stdColDocumentPath";
            this.stdColDocumentPath.Visible = false;
            // 
            // ui_panelStdCollapsible
            // 
            this.ui_panelStdCollapsible.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ui_panelStdCollapsible.Controls.Add(this.ui_panelSubStd2);
            this.ui_panelStdCollapsible.Controls.Add(this.ui_panelSubStd1);
            this.ui_panelStdCollapsible.Controls.Add(this.ui_btnStdSearchHistoryClear);
            this.ui_panelStdCollapsible.Controls.Add(this.ui_btnStdSearchTextClear);
            this.ui_panelStdCollapsible.Controls.Add(this.ui_btnStdSearch);
            this.ui_panelStdCollapsible.Controls.Add(this.ui_cbStdSearchText);
            this.ui_panelStdCollapsible.Dock = System.Windows.Forms.DockStyle.Top;
            this.ui_panelStdCollapsible.HorizontalScrollbarBarColor = true;
            this.ui_panelStdCollapsible.HorizontalScrollbarHighlightOnWheel = false;
            this.ui_panelStdCollapsible.HorizontalScrollbarSize = 12;
            this.ui_panelStdCollapsible.Location = new System.Drawing.Point(0, 0);
            this.ui_panelStdCollapsible.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_panelStdCollapsible.Name = "ui_panelStdCollapsible";
            this.ui_panelStdCollapsible.Size = new System.Drawing.Size(1409, 60);
            this.ui_panelStdCollapsible.TabIndex = 0;
            this.ui_panelStdCollapsible.UseCustomBackColor = true;
            this.ui_panelStdCollapsible.VerticalScrollbarBarColor = true;
            this.ui_panelStdCollapsible.VerticalScrollbarHighlightOnWheel = false;
            this.ui_panelStdCollapsible.VerticalScrollbarSize = 11;
            // 
            // ui_panelSubStd2
            // 
            this.ui_panelSubStd2.BackColor = System.Drawing.Color.Transparent;
            this.ui_panelSubStd2.Controls.Add(this.ui_btnStdAddItem);
            this.ui_panelSubStd2.Dock = System.Windows.Forms.DockStyle.Right;
            this.ui_panelSubStd2.HorizontalScrollbarBarColor = true;
            this.ui_panelSubStd2.HorizontalScrollbarHighlightOnWheel = false;
            this.ui_panelSubStd2.HorizontalScrollbarSize = 10;
            this.ui_panelSubStd2.Location = new System.Drawing.Point(1209, 0);
            this.ui_panelSubStd2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ui_panelSubStd2.Name = "ui_panelSubStd2";
            this.ui_panelSubStd2.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.ui_panelSubStd2.Size = new System.Drawing.Size(200, 60);
            this.ui_panelSubStd2.TabIndex = 31;
            this.ui_panelSubStd2.UseCustomBackColor = true;
            this.ui_panelSubStd2.VerticalScrollbarBarColor = true;
            this.ui_panelSubStd2.VerticalScrollbarHighlightOnWheel = false;
            this.ui_panelSubStd2.VerticalScrollbarSize = 10;
            // 
            // ui_btnStdAddItem
            // 
            this.ui_btnStdAddItem.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ui_btnStdAddItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ui_btnStdAddItem.Location = new System.Drawing.Point(122, 19);
            this.ui_btnStdAddItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_btnStdAddItem.Name = "ui_btnStdAddItem";
            this.ui_btnStdAddItem.Size = new System.Drawing.Size(59, 25);
            this.ui_btnStdAddItem.TabIndex = 8;
            this.ui_btnStdAddItem.Tag = "ui_gridStd";
            this.ui_btnStdAddItem.Text = "Add";
            this.ui_btnStdAddItem.UseCustomBackColor = true;
            this.ui_btnStdAddItem.UseSelectable = true;
            this.ui_btnStdAddItem.Click += new System.EventHandler(this.OnClickBtnAddItem);
            // 
            // ui_panelSubStd1
            // 
            this.ui_panelSubStd1.BackColor = System.Drawing.Color.Transparent;
            this.ui_panelSubStd1.Controls.Add(this.ui_cbStdPeriod);
            this.ui_panelSubStd1.Controls.Add(this.ui_cbStdCustomer);
            this.ui_panelSubStd1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ui_panelSubStd1.HorizontalScrollbarBarColor = true;
            this.ui_panelSubStd1.HorizontalScrollbarHighlightOnWheel = false;
            this.ui_panelSubStd1.HorizontalScrollbarSize = 10;
            this.ui_panelSubStd1.Location = new System.Drawing.Point(0, 0);
            this.ui_panelSubStd1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ui_panelSubStd1.Name = "ui_panelSubStd1";
            this.ui_panelSubStd1.Padding = new System.Windows.Forms.Padding(15, 0, 15, 0);
            this.ui_panelSubStd1.Size = new System.Drawing.Size(343, 60);
            this.ui_panelSubStd1.TabIndex = 30;
            this.ui_panelSubStd1.UseCustomBackColor = true;
            this.ui_panelSubStd1.VerticalScrollbarBarColor = true;
            this.ui_panelSubStd1.VerticalScrollbarHighlightOnWheel = false;
            this.ui_panelSubStd1.VerticalScrollbarSize = 10;
            // 
            // ui_cbStdPeriod
            // 
            this.ui_cbStdPeriod.BackColor = System.Drawing.SystemColors.Window;
            this.ui_cbStdPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ui_cbStdPeriod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ui_cbStdPeriod.Font = new System.Drawing.Font("굴림", 9F);
            this.ui_cbStdPeriod.FormattingEnabled = true;
            this.ui_cbStdPeriod.ItemHeight = 15;
            this.ui_cbStdPeriod.Location = new System.Drawing.Point(187, 19);
            this.ui_cbStdPeriod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_cbStdPeriod.Name = "ui_cbStdPeriod";
            this.ui_cbStdPeriod.Size = new System.Drawing.Size(137, 23);
            this.ui_cbStdPeriod.TabIndex = 3;
            this.ui_cbStdPeriod.Tag = "ui_gridStd";
            this.ui_cbStdPeriod.SelectedValueChanged += new System.EventHandler(this.OnConditionSelectedValueChanged);
            // 
            // ui_cbStdCustomer
            // 
            this.ui_cbStdCustomer.BackColor = System.Drawing.SystemColors.Window;
            this.ui_cbStdCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ui_cbStdCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ui_cbStdCustomer.Font = new System.Drawing.Font("굴림", 9F);
            this.ui_cbStdCustomer.FormattingEnabled = true;
            this.ui_cbStdCustomer.ItemHeight = 15;
            this.ui_cbStdCustomer.Location = new System.Drawing.Point(18, 19);
            this.ui_cbStdCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_cbStdCustomer.Name = "ui_cbStdCustomer";
            this.ui_cbStdCustomer.Size = new System.Drawing.Size(137, 23);
            this.ui_cbStdCustomer.TabIndex = 2;
            this.ui_cbStdCustomer.Tag = "ui_gridStd";
            this.ui_cbStdCustomer.SelectedValueChanged += new System.EventHandler(this.OnConditionSelectedValueChanged);
            // 
            // ui_btnStdSearchHistoryClear
            // 
            this.ui_btnStdSearchHistoryClear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ui_btnStdSearchHistoryClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ui_btnStdSearchHistoryClear.Location = new System.Drawing.Point(847, 19);
            this.ui_btnStdSearchHistoryClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_btnStdSearchHistoryClear.Name = "ui_btnStdSearchHistoryClear";
            this.ui_btnStdSearchHistoryClear.Size = new System.Drawing.Size(59, 25);
            this.ui_btnStdSearchHistoryClear.TabIndex = 7;
            this.ui_btnStdSearchHistoryClear.Tag = "ui_cbStdSearchText";
            this.ui_btnStdSearchHistoryClear.Text = "Clear";
            this.ui_btnStdSearchHistoryClear.UseCustomBackColor = true;
            this.ui_btnStdSearchHistoryClear.UseSelectable = true;
            this.ui_btnStdSearchHistoryClear.Click += new System.EventHandler(this.OnClickBtnSearchHistoryClear);
            // 
            // ui_btnStdSearchTextClear
            // 
            this.ui_btnStdSearchTextClear.BackColor = System.Drawing.Color.Transparent;
            this.ui_btnStdSearchTextClear.BackgroundImage = global::HullMaintenance.Properties.Resources.iconmonstr_x_mark_1_24;
            this.ui_btnStdSearchTextClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ui_btnStdSearchTextClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ui_btnStdSearchTextClear.FlatAppearance.BorderSize = 0;
            this.ui_btnStdSearchTextClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ui_btnStdSearchTextClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ui_btnStdSearchTextClear.Location = new System.Drawing.Point(350, 25);
            this.ui_btnStdSearchTextClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_btnStdSearchTextClear.Name = "ui_btnStdSearchTextClear";
            this.ui_btnStdSearchTextClear.Size = new System.Drawing.Size(11, 12);
            this.ui_btnStdSearchTextClear.TabIndex = 5;
            this.ui_btnStdSearchTextClear.Tag = "ui_cbStdSearchText";
            this.ui_btnStdSearchTextClear.UseVisualStyleBackColor = false;
            this.ui_btnStdSearchTextClear.Click += new System.EventHandler(this.OnClickBtnSearchTextClear);
            // 
            // ui_btnStdSearch
            // 
            this.ui_btnStdSearch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ui_btnStdSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ui_btnStdSearch.Location = new System.Drawing.Point(781, 19);
            this.ui_btnStdSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_btnStdSearch.Name = "ui_btnStdSearch";
            this.ui_btnStdSearch.Size = new System.Drawing.Size(59, 25);
            this.ui_btnStdSearch.TabIndex = 6;
            this.ui_btnStdSearch.Tag = "ui_cbStdSearchText";
            this.ui_btnStdSearch.Text = "Find";
            this.ui_btnStdSearch.UseCustomBackColor = true;
            this.ui_btnStdSearch.UseSelectable = true;
            this.ui_btnStdSearch.Click += new System.EventHandler(this.OnClickBtnSearch);
            // 
            // ui_cbStdSearchText
            // 
            this.ui_cbStdSearchText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ui_cbStdSearchText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ui_cbStdSearchText.Font = new System.Drawing.Font("굴림", 9F);
            this.ui_cbStdSearchText.FormattingEnabled = true;
            this.ui_cbStdSearchText.Location = new System.Drawing.Point(373, 19);
            this.ui_cbStdSearchText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_cbStdSearchText.Name = "ui_cbStdSearchText";
            this.ui_cbStdSearchText.Size = new System.Drawing.Size(399, 23);
            this.ui_cbStdSearchText.TabIndex = 4;
            this.ui_cbStdSearchText.Tag = "ui_gridStd";
            this.ui_cbStdSearchText.TextChanged += new System.EventHandler(this.OnSeachTextChanged);
            this.ui_cbStdSearchText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnSearchTexKeyDown);
            // 
            // settingPage
            // 
            this.settingPage.AutoScroll = true;
            this.settingPage.BackColor = System.Drawing.SystemColors.Window;
            this.settingPage.Controls.Add(this.ui_gbColorCode);
            this.settingPage.Controls.Add(this.ui_gbStd);
            this.settingPage.Controls.Add(this.ui_gbSmh);
            this.settingPage.Controls.Add(this.ui_gbDb);
            this.settingPage.Location = new System.Drawing.Point(4, 41);
            this.settingPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.settingPage.Name = "settingPage";
            this.settingPage.Size = new System.Drawing.Size(1409, 852);
            this.settingPage.TabIndex = 4;
            this.settingPage.Text = "Settings";
            // 
            // ui_gbColorCode
            // 
            this.ui_gbColorCode.Controls.Add(this.ui_btnTheme);
            this.ui_gbColorCode.Controls.Add(this.ui_btnStyle);
            this.ui_gbColorCode.Controls.Add(this.ui_tbColorD7);
            this.ui_gbColorCode.Controls.Add(this.ui_lbColorD7);
            this.ui_gbColorCode.Controls.Add(this.ui_tbColorD3);
            this.ui_gbColorCode.Controls.Add(this.ui_lbColorD3);
            this.ui_gbColorCode.Controls.Add(this.ui_tbColorD1);
            this.ui_gbColorCode.Controls.Add(this.ui_lbColorD1);
            this.ui_gbColorCode.Controls.Add(this.ui_tbColorError);
            this.ui_gbColorCode.Controls.Add(this.ui_tbColorImpossible);
            this.ui_gbColorCode.Controls.Add(this.ui_tbColorCancel);
            this.ui_gbColorCode.Controls.Add(this.ui_tbColorPending);
            this.ui_gbColorCode.Controls.Add(this.ui_tbColorComplete);
            this.ui_gbColorCode.Controls.Add(this.ui_tbColorPartialDone);
            this.ui_gbColorCode.Controls.Add(this.ui_tbColorWorkDone);
            this.ui_gbColorCode.Controls.Add(this.ui_tbColorWorking);
            this.ui_gbColorCode.Controls.Add(this.ui_lbColorError);
            this.ui_gbColorCode.Controls.Add(this.ui_lbColorImpossible);
            this.ui_gbColorCode.Controls.Add(this.ui_lbColorCancel);
            this.ui_gbColorCode.Controls.Add(this.ui_lbColorPending);
            this.ui_gbColorCode.Controls.Add(this.ui_lbColorComplete);
            this.ui_gbColorCode.Controls.Add(this.ui_lbColorPartialDone);
            this.ui_gbColorCode.Controls.Add(this.ui_lbColorWorkDone);
            this.ui_gbColorCode.Controls.Add(this.ui_lbColorWorking);
            this.ui_gbColorCode.Location = new System.Drawing.Point(11, 475);
            this.ui_gbColorCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_gbColorCode.Name = "ui_gbColorCode";
            this.ui_gbColorCode.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_gbColorCode.Size = new System.Drawing.Size(464, 356);
            this.ui_gbColorCode.TabIndex = 4;
            this.ui_gbColorCode.TabStop = false;
            this.ui_gbColorCode.Text = "Color Code (Hexadecimal)";
            // 
            // ui_btnTheme
            // 
            this.ui_btnTheme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ui_btnTheme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ui_btnTheme.Location = new System.Drawing.Point(298, 282);
            this.ui_btnTheme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ui_btnTheme.Name = "ui_btnTheme";
            this.ui_btnTheme.Size = new System.Drawing.Size(87, 30);
            this.ui_btnTheme.TabIndex = 30;
            this.ui_btnTheme.Tag = "";
            this.ui_btnTheme.Text = "Theme";
            this.ui_btnTheme.UseSelectable = true;
            this.ui_btnTheme.Click += new System.EventHandler(this.OnClickBtnTheme);
            // 
            // ui_btnStyle
            // 
            this.ui_btnStyle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ui_btnStyle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ui_btnStyle.Location = new System.Drawing.Point(395, 282);
            this.ui_btnStyle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ui_btnStyle.Name = "ui_btnStyle";
            this.ui_btnStyle.Size = new System.Drawing.Size(46, 30);
            this.ui_btnStyle.TabIndex = 31;
            this.ui_btnStyle.Tag = "";
            this.ui_btnStyle.Text = "Style";
            this.ui_btnStyle.UseSelectable = true;
            this.ui_btnStyle.Click += new System.EventHandler(this.OnClickBtnStyle);
            // 
            // ui_tbColorD7
            // 
            // 
            // 
            // 
            this.ui_tbColorD7.CustomButton.Image = null;
            this.ui_tbColorD7.CustomButton.Location = new System.Drawing.Point(86, 1);
            this.ui_tbColorD7.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ui_tbColorD7.CustomButton.Name = "";
            this.ui_tbColorD7.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.ui_tbColorD7.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ui_tbColorD7.CustomButton.TabIndex = 1;
            this.ui_tbColorD7.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ui_tbColorD7.CustomButton.UseSelectable = true;
            this.ui_tbColorD7.CustomButton.Visible = false;
            this.ui_tbColorD7.Lines = new string[0];
            this.ui_tbColorD7.Location = new System.Drawing.Point(327, 100);
            this.ui_tbColorD7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_tbColorD7.MaxLength = 32767;
            this.ui_tbColorD7.Name = "ui_tbColorD7";
            this.ui_tbColorD7.PasswordChar = '\0';
            this.ui_tbColorD7.ReadOnly = true;
            this.ui_tbColorD7.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ui_tbColorD7.SelectedText = "";
            this.ui_tbColorD7.SelectionLength = 0;
            this.ui_tbColorD7.SelectionStart = 0;
            this.ui_tbColorD7.ShortcutsEnabled = true;
            this.ui_tbColorD7.Size = new System.Drawing.Size(114, 29);
            this.ui_tbColorD7.TabIndex = 29;
            this.ui_tbColorD7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ui_tbColorD7.UseCustomBackColor = true;
            this.ui_tbColorD7.UseSelectable = true;
            this.ui_tbColorD7.UseStyleColors = true;
            this.ui_tbColorD7.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ui_tbColorD7.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.ui_tbColorD7.TextChanged += new System.EventHandler(this.OnColorCodeTextChanged);
            // 
            // ui_lbColorD7
            // 
            this.ui_lbColorD7.Location = new System.Drawing.Point(251, 100);
            this.ui_lbColorD7.Name = "ui_lbColorD7";
            this.ui_lbColorD7.Size = new System.Drawing.Size(69, 24);
            this.ui_lbColorD7.TabIndex = 31;
            this.ui_lbColorD7.Text = "D-7 :";
            this.ui_lbColorD7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ui_tbColorD3
            // 
            // 
            // 
            // 
            this.ui_tbColorD3.CustomButton.Image = null;
            this.ui_tbColorD3.CustomButton.Location = new System.Drawing.Point(86, 1);
            this.ui_tbColorD3.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ui_tbColorD3.CustomButton.Name = "";
            this.ui_tbColorD3.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.ui_tbColorD3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ui_tbColorD3.CustomButton.TabIndex = 1;
            this.ui_tbColorD3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ui_tbColorD3.CustomButton.UseSelectable = true;
            this.ui_tbColorD3.CustomButton.Visible = false;
            this.ui_tbColorD3.Lines = new string[0];
            this.ui_tbColorD3.Location = new System.Drawing.Point(327, 64);
            this.ui_tbColorD3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_tbColorD3.MaxLength = 32767;
            this.ui_tbColorD3.Name = "ui_tbColorD3";
            this.ui_tbColorD3.PasswordChar = '\0';
            this.ui_tbColorD3.ReadOnly = true;
            this.ui_tbColorD3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ui_tbColorD3.SelectedText = "";
            this.ui_tbColorD3.SelectionLength = 0;
            this.ui_tbColorD3.SelectionStart = 0;
            this.ui_tbColorD3.ShortcutsEnabled = true;
            this.ui_tbColorD3.Size = new System.Drawing.Size(114, 29);
            this.ui_tbColorD3.TabIndex = 28;
            this.ui_tbColorD3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ui_tbColorD3.UseCustomBackColor = true;
            this.ui_tbColorD3.UseSelectable = true;
            this.ui_tbColorD3.UseStyleColors = true;
            this.ui_tbColorD3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ui_tbColorD3.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.ui_tbColorD3.TextChanged += new System.EventHandler(this.OnColorCodeTextChanged);
            // 
            // ui_lbColorD3
            // 
            this.ui_lbColorD3.Location = new System.Drawing.Point(251, 64);
            this.ui_lbColorD3.Name = "ui_lbColorD3";
            this.ui_lbColorD3.Size = new System.Drawing.Size(69, 24);
            this.ui_lbColorD3.TabIndex = 29;
            this.ui_lbColorD3.Text = "D-3 :";
            this.ui_lbColorD3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ui_tbColorD1
            // 
            // 
            // 
            // 
            this.ui_tbColorD1.CustomButton.Image = null;
            this.ui_tbColorD1.CustomButton.Location = new System.Drawing.Point(86, 1);
            this.ui_tbColorD1.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ui_tbColorD1.CustomButton.Name = "";
            this.ui_tbColorD1.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.ui_tbColorD1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ui_tbColorD1.CustomButton.TabIndex = 1;
            this.ui_tbColorD1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ui_tbColorD1.CustomButton.UseSelectable = true;
            this.ui_tbColorD1.CustomButton.Visible = false;
            this.ui_tbColorD1.Lines = new string[0];
            this.ui_tbColorD1.Location = new System.Drawing.Point(327, 28);
            this.ui_tbColorD1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_tbColorD1.MaxLength = 32767;
            this.ui_tbColorD1.Name = "ui_tbColorD1";
            this.ui_tbColorD1.PasswordChar = '\0';
            this.ui_tbColorD1.ReadOnly = true;
            this.ui_tbColorD1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ui_tbColorD1.SelectedText = "";
            this.ui_tbColorD1.SelectionLength = 0;
            this.ui_tbColorD1.SelectionStart = 0;
            this.ui_tbColorD1.ShortcutsEnabled = true;
            this.ui_tbColorD1.Size = new System.Drawing.Size(114, 29);
            this.ui_tbColorD1.TabIndex = 27;
            this.ui_tbColorD1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ui_tbColorD1.UseCustomBackColor = true;
            this.ui_tbColorD1.UseSelectable = true;
            this.ui_tbColorD1.UseStyleColors = true;
            this.ui_tbColorD1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ui_tbColorD1.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.ui_tbColorD1.TextChanged += new System.EventHandler(this.OnColorCodeTextChanged);
            // 
            // ui_lbColorD1
            // 
            this.ui_lbColorD1.Location = new System.Drawing.Point(251, 28);
            this.ui_lbColorD1.Name = "ui_lbColorD1";
            this.ui_lbColorD1.Size = new System.Drawing.Size(69, 24);
            this.ui_lbColorD1.TabIndex = 27;
            this.ui_lbColorD1.Text = "D-1 :";
            this.ui_lbColorD1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ui_tbColorError
            // 
            // 
            // 
            // 
            this.ui_tbColorError.CustomButton.Image = null;
            this.ui_tbColorError.CustomButton.Location = new System.Drawing.Point(86, 1);
            this.ui_tbColorError.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ui_tbColorError.CustomButton.Name = "";
            this.ui_tbColorError.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.ui_tbColorError.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ui_tbColorError.CustomButton.TabIndex = 1;
            this.ui_tbColorError.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ui_tbColorError.CustomButton.UseSelectable = true;
            this.ui_tbColorError.CustomButton.Visible = false;
            this.ui_tbColorError.Lines = new string[0];
            this.ui_tbColorError.Location = new System.Drawing.Point(121, 282);
            this.ui_tbColorError.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_tbColorError.MaxLength = 32767;
            this.ui_tbColorError.Name = "ui_tbColorError";
            this.ui_tbColorError.PasswordChar = '\0';
            this.ui_tbColorError.ReadOnly = true;
            this.ui_tbColorError.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ui_tbColorError.SelectedText = "";
            this.ui_tbColorError.SelectionLength = 0;
            this.ui_tbColorError.SelectionStart = 0;
            this.ui_tbColorError.ShortcutsEnabled = true;
            this.ui_tbColorError.Size = new System.Drawing.Size(114, 29);
            this.ui_tbColorError.TabIndex = 26;
            this.ui_tbColorError.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ui_tbColorError.UseCustomBackColor = true;
            this.ui_tbColorError.UseSelectable = true;
            this.ui_tbColorError.UseStyleColors = true;
            this.ui_tbColorError.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ui_tbColorError.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.ui_tbColorError.TextChanged += new System.EventHandler(this.OnColorCodeTextChanged);
            // 
            // ui_tbColorImpossible
            // 
            // 
            // 
            // 
            this.ui_tbColorImpossible.CustomButton.Image = null;
            this.ui_tbColorImpossible.CustomButton.Location = new System.Drawing.Point(86, 1);
            this.ui_tbColorImpossible.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ui_tbColorImpossible.CustomButton.Name = "";
            this.ui_tbColorImpossible.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.ui_tbColorImpossible.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ui_tbColorImpossible.CustomButton.TabIndex = 1;
            this.ui_tbColorImpossible.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ui_tbColorImpossible.CustomButton.UseSelectable = true;
            this.ui_tbColorImpossible.CustomButton.Visible = false;
            this.ui_tbColorImpossible.Lines = new string[0];
            this.ui_tbColorImpossible.Location = new System.Drawing.Point(121, 246);
            this.ui_tbColorImpossible.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_tbColorImpossible.MaxLength = 32767;
            this.ui_tbColorImpossible.Name = "ui_tbColorImpossible";
            this.ui_tbColorImpossible.PasswordChar = '\0';
            this.ui_tbColorImpossible.ReadOnly = true;
            this.ui_tbColorImpossible.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ui_tbColorImpossible.SelectedText = "";
            this.ui_tbColorImpossible.SelectionLength = 0;
            this.ui_tbColorImpossible.SelectionStart = 0;
            this.ui_tbColorImpossible.ShortcutsEnabled = true;
            this.ui_tbColorImpossible.Size = new System.Drawing.Size(114, 29);
            this.ui_tbColorImpossible.TabIndex = 25;
            this.ui_tbColorImpossible.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ui_tbColorImpossible.UseCustomBackColor = true;
            this.ui_tbColorImpossible.UseSelectable = true;
            this.ui_tbColorImpossible.UseStyleColors = true;
            this.ui_tbColorImpossible.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ui_tbColorImpossible.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.ui_tbColorImpossible.TextChanged += new System.EventHandler(this.OnColorCodeTextChanged);
            // 
            // ui_tbColorCancel
            // 
            // 
            // 
            // 
            this.ui_tbColorCancel.CustomButton.Image = null;
            this.ui_tbColorCancel.CustomButton.Location = new System.Drawing.Point(86, 1);
            this.ui_tbColorCancel.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ui_tbColorCancel.CustomButton.Name = "";
            this.ui_tbColorCancel.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.ui_tbColorCancel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ui_tbColorCancel.CustomButton.TabIndex = 1;
            this.ui_tbColorCancel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ui_tbColorCancel.CustomButton.UseSelectable = true;
            this.ui_tbColorCancel.CustomButton.Visible = false;
            this.ui_tbColorCancel.Lines = new string[0];
            this.ui_tbColorCancel.Location = new System.Drawing.Point(121, 209);
            this.ui_tbColorCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_tbColorCancel.MaxLength = 32767;
            this.ui_tbColorCancel.Name = "ui_tbColorCancel";
            this.ui_tbColorCancel.PasswordChar = '\0';
            this.ui_tbColorCancel.ReadOnly = true;
            this.ui_tbColorCancel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ui_tbColorCancel.SelectedText = "";
            this.ui_tbColorCancel.SelectionLength = 0;
            this.ui_tbColorCancel.SelectionStart = 0;
            this.ui_tbColorCancel.ShortcutsEnabled = true;
            this.ui_tbColorCancel.Size = new System.Drawing.Size(114, 29);
            this.ui_tbColorCancel.TabIndex = 24;
            this.ui_tbColorCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ui_tbColorCancel.UseCustomBackColor = true;
            this.ui_tbColorCancel.UseSelectable = true;
            this.ui_tbColorCancel.UseStyleColors = true;
            this.ui_tbColorCancel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ui_tbColorCancel.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.ui_tbColorCancel.TextChanged += new System.EventHandler(this.OnColorCodeTextChanged);
            // 
            // ui_tbColorPending
            // 
            // 
            // 
            // 
            this.ui_tbColorPending.CustomButton.Image = null;
            this.ui_tbColorPending.CustomButton.Location = new System.Drawing.Point(86, 1);
            this.ui_tbColorPending.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ui_tbColorPending.CustomButton.Name = "";
            this.ui_tbColorPending.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.ui_tbColorPending.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ui_tbColorPending.CustomButton.TabIndex = 1;
            this.ui_tbColorPending.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ui_tbColorPending.CustomButton.UseSelectable = true;
            this.ui_tbColorPending.CustomButton.Visible = false;
            this.ui_tbColorPending.Lines = new string[0];
            this.ui_tbColorPending.Location = new System.Drawing.Point(121, 172);
            this.ui_tbColorPending.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_tbColorPending.MaxLength = 32767;
            this.ui_tbColorPending.Name = "ui_tbColorPending";
            this.ui_tbColorPending.PasswordChar = '\0';
            this.ui_tbColorPending.ReadOnly = true;
            this.ui_tbColorPending.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ui_tbColorPending.SelectedText = "";
            this.ui_tbColorPending.SelectionLength = 0;
            this.ui_tbColorPending.SelectionStart = 0;
            this.ui_tbColorPending.ShortcutsEnabled = true;
            this.ui_tbColorPending.Size = new System.Drawing.Size(114, 29);
            this.ui_tbColorPending.TabIndex = 22;
            this.ui_tbColorPending.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ui_tbColorPending.UseCustomBackColor = true;
            this.ui_tbColorPending.UseSelectable = true;
            this.ui_tbColorPending.UseStyleColors = true;
            this.ui_tbColorPending.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ui_tbColorPending.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.ui_tbColorPending.TextChanged += new System.EventHandler(this.OnColorCodeTextChanged);
            // 
            // ui_tbColorComplete
            // 
            // 
            // 
            // 
            this.ui_tbColorComplete.CustomButton.Image = null;
            this.ui_tbColorComplete.CustomButton.Location = new System.Drawing.Point(86, 1);
            this.ui_tbColorComplete.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ui_tbColorComplete.CustomButton.Name = "";
            this.ui_tbColorComplete.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.ui_tbColorComplete.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ui_tbColorComplete.CustomButton.TabIndex = 1;
            this.ui_tbColorComplete.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ui_tbColorComplete.CustomButton.UseSelectable = true;
            this.ui_tbColorComplete.CustomButton.Visible = false;
            this.ui_tbColorComplete.Lines = new string[0];
            this.ui_tbColorComplete.Location = new System.Drawing.Point(121, 136);
            this.ui_tbColorComplete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_tbColorComplete.MaxLength = 32767;
            this.ui_tbColorComplete.Name = "ui_tbColorComplete";
            this.ui_tbColorComplete.PasswordChar = '\0';
            this.ui_tbColorComplete.ReadOnly = true;
            this.ui_tbColorComplete.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ui_tbColorComplete.SelectedText = "";
            this.ui_tbColorComplete.SelectionLength = 0;
            this.ui_tbColorComplete.SelectionStart = 0;
            this.ui_tbColorComplete.ShortcutsEnabled = true;
            this.ui_tbColorComplete.Size = new System.Drawing.Size(114, 29);
            this.ui_tbColorComplete.TabIndex = 21;
            this.ui_tbColorComplete.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ui_tbColorComplete.UseCustomBackColor = true;
            this.ui_tbColorComplete.UseSelectable = true;
            this.ui_tbColorComplete.UseStyleColors = true;
            this.ui_tbColorComplete.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ui_tbColorComplete.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.ui_tbColorComplete.TextChanged += new System.EventHandler(this.OnColorCodeTextChanged);
            // 
            // ui_tbColorPartialDone
            // 
            // 
            // 
            // 
            this.ui_tbColorPartialDone.CustomButton.Image = null;
            this.ui_tbColorPartialDone.CustomButton.Location = new System.Drawing.Point(86, 1);
            this.ui_tbColorPartialDone.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ui_tbColorPartialDone.CustomButton.Name = "";
            this.ui_tbColorPartialDone.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.ui_tbColorPartialDone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ui_tbColorPartialDone.CustomButton.TabIndex = 1;
            this.ui_tbColorPartialDone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ui_tbColorPartialDone.CustomButton.UseSelectable = true;
            this.ui_tbColorPartialDone.CustomButton.Visible = false;
            this.ui_tbColorPartialDone.Lines = new string[0];
            this.ui_tbColorPartialDone.Location = new System.Drawing.Point(121, 100);
            this.ui_tbColorPartialDone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_tbColorPartialDone.MaxLength = 32767;
            this.ui_tbColorPartialDone.Name = "ui_tbColorPartialDone";
            this.ui_tbColorPartialDone.PasswordChar = '\0';
            this.ui_tbColorPartialDone.ReadOnly = true;
            this.ui_tbColorPartialDone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ui_tbColorPartialDone.SelectedText = "";
            this.ui_tbColorPartialDone.SelectionLength = 0;
            this.ui_tbColorPartialDone.SelectionStart = 0;
            this.ui_tbColorPartialDone.ShortcutsEnabled = true;
            this.ui_tbColorPartialDone.Size = new System.Drawing.Size(114, 29);
            this.ui_tbColorPartialDone.TabIndex = 20;
            this.ui_tbColorPartialDone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ui_tbColorPartialDone.UseCustomBackColor = true;
            this.ui_tbColorPartialDone.UseSelectable = true;
            this.ui_tbColorPartialDone.UseStyleColors = true;
            this.ui_tbColorPartialDone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ui_tbColorPartialDone.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.ui_tbColorPartialDone.TextChanged += new System.EventHandler(this.OnColorCodeTextChanged);
            // 
            // ui_tbColorWorkDone
            // 
            // 
            // 
            // 
            this.ui_tbColorWorkDone.CustomButton.Image = null;
            this.ui_tbColorWorkDone.CustomButton.Location = new System.Drawing.Point(86, 1);
            this.ui_tbColorWorkDone.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ui_tbColorWorkDone.CustomButton.Name = "";
            this.ui_tbColorWorkDone.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.ui_tbColorWorkDone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ui_tbColorWorkDone.CustomButton.TabIndex = 1;
            this.ui_tbColorWorkDone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ui_tbColorWorkDone.CustomButton.UseSelectable = true;
            this.ui_tbColorWorkDone.CustomButton.Visible = false;
            this.ui_tbColorWorkDone.Lines = new string[0];
            this.ui_tbColorWorkDone.Location = new System.Drawing.Point(121, 64);
            this.ui_tbColorWorkDone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_tbColorWorkDone.MaxLength = 32767;
            this.ui_tbColorWorkDone.Name = "ui_tbColorWorkDone";
            this.ui_tbColorWorkDone.PasswordChar = '\0';
            this.ui_tbColorWorkDone.ReadOnly = true;
            this.ui_tbColorWorkDone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ui_tbColorWorkDone.SelectedText = "";
            this.ui_tbColorWorkDone.SelectionLength = 0;
            this.ui_tbColorWorkDone.SelectionStart = 0;
            this.ui_tbColorWorkDone.ShortcutsEnabled = true;
            this.ui_tbColorWorkDone.Size = new System.Drawing.Size(114, 29);
            this.ui_tbColorWorkDone.TabIndex = 19;
            this.ui_tbColorWorkDone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ui_tbColorWorkDone.UseCustomBackColor = true;
            this.ui_tbColorWorkDone.UseSelectable = true;
            this.ui_tbColorWorkDone.UseStyleColors = true;
            this.ui_tbColorWorkDone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ui_tbColorWorkDone.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.ui_tbColorWorkDone.TextChanged += new System.EventHandler(this.OnColorCodeTextChanged);
            // 
            // ui_tbColorWorking
            // 
            // 
            // 
            // 
            this.ui_tbColorWorking.CustomButton.Image = null;
            this.ui_tbColorWorking.CustomButton.Location = new System.Drawing.Point(86, 1);
            this.ui_tbColorWorking.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ui_tbColorWorking.CustomButton.Name = "";
            this.ui_tbColorWorking.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.ui_tbColorWorking.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ui_tbColorWorking.CustomButton.TabIndex = 1;
            this.ui_tbColorWorking.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ui_tbColorWorking.CustomButton.UseSelectable = true;
            this.ui_tbColorWorking.CustomButton.Visible = false;
            this.ui_tbColorWorking.Lines = new string[0];
            this.ui_tbColorWorking.Location = new System.Drawing.Point(121, 28);
            this.ui_tbColorWorking.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_tbColorWorking.MaxLength = 32767;
            this.ui_tbColorWorking.Name = "ui_tbColorWorking";
            this.ui_tbColorWorking.PasswordChar = '\0';
            this.ui_tbColorWorking.ReadOnly = true;
            this.ui_tbColorWorking.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ui_tbColorWorking.SelectedText = "";
            this.ui_tbColorWorking.SelectionLength = 0;
            this.ui_tbColorWorking.SelectionStart = 0;
            this.ui_tbColorWorking.ShortcutsEnabled = true;
            this.ui_tbColorWorking.Size = new System.Drawing.Size(114, 29);
            this.ui_tbColorWorking.TabIndex = 18;
            this.ui_tbColorWorking.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ui_tbColorWorking.UseCustomBackColor = true;
            this.ui_tbColorWorking.UseSelectable = true;
            this.ui_tbColorWorking.UseStyleColors = true;
            this.ui_tbColorWorking.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ui_tbColorWorking.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.ui_tbColorWorking.TextChanged += new System.EventHandler(this.OnColorCodeTextChanged);
            // 
            // ui_lbColorError
            // 
            this.ui_lbColorError.Location = new System.Drawing.Point(13, 282);
            this.ui_lbColorError.Name = "ui_lbColorError";
            this.ui_lbColorError.Size = new System.Drawing.Size(103, 24);
            this.ui_lbColorError.TabIndex = 17;
            this.ui_lbColorError.Text = "Error :";
            this.ui_lbColorError.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ui_lbColorImpossible
            // 
            this.ui_lbColorImpossible.Location = new System.Drawing.Point(13, 246);
            this.ui_lbColorImpossible.Name = "ui_lbColorImpossible";
            this.ui_lbColorImpossible.Size = new System.Drawing.Size(103, 24);
            this.ui_lbColorImpossible.TabIndex = 14;
            this.ui_lbColorImpossible.Text = "Impossible :";
            this.ui_lbColorImpossible.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ui_lbColorCancel
            // 
            this.ui_lbColorCancel.Location = new System.Drawing.Point(13, 209);
            this.ui_lbColorCancel.Name = "ui_lbColorCancel";
            this.ui_lbColorCancel.Size = new System.Drawing.Size(103, 24);
            this.ui_lbColorCancel.TabIndex = 13;
            this.ui_lbColorCancel.Text = "Cancel :";
            this.ui_lbColorCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ui_lbColorPending
            // 
            this.ui_lbColorPending.Location = new System.Drawing.Point(13, 172);
            this.ui_lbColorPending.Name = "ui_lbColorPending";
            this.ui_lbColorPending.Size = new System.Drawing.Size(103, 24);
            this.ui_lbColorPending.TabIndex = 4;
            this.ui_lbColorPending.Text = "Pending :";
            this.ui_lbColorPending.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ui_lbColorComplete
            // 
            this.ui_lbColorComplete.Location = new System.Drawing.Point(13, 136);
            this.ui_lbColorComplete.Name = "ui_lbColorComplete";
            this.ui_lbColorComplete.Size = new System.Drawing.Size(103, 24);
            this.ui_lbColorComplete.TabIndex = 3;
            this.ui_lbColorComplete.Text = "Complete :";
            this.ui_lbColorComplete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ui_lbColorPartialDone
            // 
            this.ui_lbColorPartialDone.Location = new System.Drawing.Point(13, 100);
            this.ui_lbColorPartialDone.Name = "ui_lbColorPartialDone";
            this.ui_lbColorPartialDone.Size = new System.Drawing.Size(103, 24);
            this.ui_lbColorPartialDone.TabIndex = 2;
            this.ui_lbColorPartialDone.Text = "Partial Done :";
            this.ui_lbColorPartialDone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ui_lbColorWorkDone
            // 
            this.ui_lbColorWorkDone.Location = new System.Drawing.Point(13, 64);
            this.ui_lbColorWorkDone.Name = "ui_lbColorWorkDone";
            this.ui_lbColorWorkDone.Size = new System.Drawing.Size(103, 24);
            this.ui_lbColorWorkDone.TabIndex = 1;
            this.ui_lbColorWorkDone.Text = "Work Done :";
            this.ui_lbColorWorkDone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ui_lbColorWorking
            // 
            this.ui_lbColorWorking.Location = new System.Drawing.Point(13, 28);
            this.ui_lbColorWorking.Name = "ui_lbColorWorking";
            this.ui_lbColorWorking.Size = new System.Drawing.Size(103, 24);
            this.ui_lbColorWorking.TabIndex = 0;
            this.ui_lbColorWorking.Text = "Working :";
            this.ui_lbColorWorking.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ui_gbStd
            // 
            this.ui_gbStd.Controls.Add(this.ui_btnStdSamplePathOpen);
            this.ui_gbStd.Controls.Add(this.ui_btnStdSamplePath);
            this.ui_gbStd.Controls.Add(this.ui_tbStdSamplePath);
            this.ui_gbStd.Controls.Add(this.ui_lbStdSampleDir);
            this.ui_gbStd.Controls.Add(this.ui_btnStdDocPathOpen);
            this.ui_gbStd.Controls.Add(this.ui_btnStdDocPath);
            this.ui_gbStd.Controls.Add(this.ui_tbStdDocPath);
            this.ui_gbStd.Controls.Add(this.ui_lbStdDocDir);
            this.ui_gbStd.Location = new System.Drawing.Point(11, 338);
            this.ui_gbStd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_gbStd.Name = "ui_gbStd";
            this.ui_gbStd.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_gbStd.Size = new System.Drawing.Size(994, 125);
            this.ui_gbStd.TabIndex = 3;
            this.ui_gbStd.TabStop = false;
            this.ui_gbStd.Text = "SpisHull";
            // 
            // ui_btnStdSamplePathOpen
            // 
            this.ui_btnStdSamplePathOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ui_btnStdSamplePathOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ui_btnStdSamplePathOpen.Location = new System.Drawing.Point(931, 64);
            this.ui_btnStdSamplePathOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ui_btnStdSamplePathOpen.Name = "ui_btnStdSamplePathOpen";
            this.ui_btnStdSamplePathOpen.Size = new System.Drawing.Size(40, 30);
            this.ui_btnStdSamplePathOpen.TabIndex = 17;
            this.ui_btnStdSamplePathOpen.Tag = "ui_tbStdSamplePath";
            this.ui_btnStdSamplePathOpen.Text = "Open";
            this.ui_btnStdSamplePathOpen.UseSelectable = true;
            this.ui_btnStdSamplePathOpen.Click += new System.EventHandler(this.OnClickBtnPathOpen);
            // 
            // ui_btnStdSamplePath
            // 
            this.ui_btnStdSamplePath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ui_btnStdSamplePath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ui_btnStdSamplePath.Location = new System.Drawing.Point(885, 64);
            this.ui_btnStdSamplePath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ui_btnStdSamplePath.Name = "ui_btnStdSamplePath";
            this.ui_btnStdSamplePath.Size = new System.Drawing.Size(40, 30);
            this.ui_btnStdSamplePath.TabIndex = 16;
            this.ui_btnStdSamplePath.Tag = "ui_tbStdSamplePath";
            this.ui_btnStdSamplePath.Text = "···";
            this.ui_btnStdSamplePath.UseSelectable = true;
            this.ui_btnStdSamplePath.Click += new System.EventHandler(this.OnClickBtnPath);
            // 
            // ui_tbStdSamplePath
            // 
            // 
            // 
            // 
            this.ui_tbStdSamplePath.CustomButton.Image = null;
            this.ui_tbStdSamplePath.CustomButton.Location = new System.Drawing.Point(671, 1);
            this.ui_tbStdSamplePath.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ui_tbStdSamplePath.CustomButton.Name = "";
            this.ui_tbStdSamplePath.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.ui_tbStdSamplePath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ui_tbStdSamplePath.CustomButton.TabIndex = 1;
            this.ui_tbStdSamplePath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ui_tbStdSamplePath.CustomButton.UseSelectable = true;
            this.ui_tbStdSamplePath.CustomButton.Visible = false;
            this.ui_tbStdSamplePath.Lines = new string[0];
            this.ui_tbStdSamplePath.Location = new System.Drawing.Point(178, 64);
            this.ui_tbStdSamplePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_tbStdSamplePath.MaxLength = 32767;
            this.ui_tbStdSamplePath.Name = "ui_tbStdSamplePath";
            this.ui_tbStdSamplePath.PasswordChar = '\0';
            this.ui_tbStdSamplePath.ReadOnly = true;
            this.ui_tbStdSamplePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ui_tbStdSamplePath.SelectedText = "";
            this.ui_tbStdSamplePath.SelectionLength = 0;
            this.ui_tbStdSamplePath.SelectionStart = 0;
            this.ui_tbStdSamplePath.ShortcutsEnabled = true;
            this.ui_tbStdSamplePath.Size = new System.Drawing.Size(699, 29);
            this.ui_tbStdSamplePath.TabIndex = 15;
            this.ui_tbStdSamplePath.UseSelectable = true;
            this.ui_tbStdSamplePath.UseStyleColors = true;
            this.ui_tbStdSamplePath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ui_tbStdSamplePath.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ui_lbStdSampleDir
            // 
            this.ui_lbStdSampleDir.Location = new System.Drawing.Point(13, 65);
            this.ui_lbStdSampleDir.Name = "ui_lbStdSampleDir";
            this.ui_lbStdSampleDir.Size = new System.Drawing.Size(160, 25);
            this.ui_lbStdSampleDir.TabIndex = 19;
            this.ui_lbStdSampleDir.Text = "Sample Directory :";
            this.ui_lbStdSampleDir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ui_btnStdDocPathOpen
            // 
            this.ui_btnStdDocPathOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ui_btnStdDocPathOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ui_btnStdDocPathOpen.Location = new System.Drawing.Point(931, 28);
            this.ui_btnStdDocPathOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ui_btnStdDocPathOpen.Name = "ui_btnStdDocPathOpen";
            this.ui_btnStdDocPathOpen.Size = new System.Drawing.Size(40, 30);
            this.ui_btnStdDocPathOpen.TabIndex = 14;
            this.ui_btnStdDocPathOpen.Tag = "ui_tbStdDocPath";
            this.ui_btnStdDocPathOpen.Text = "Open";
            this.ui_btnStdDocPathOpen.UseSelectable = true;
            this.ui_btnStdDocPathOpen.Click += new System.EventHandler(this.OnClickBtnPathOpen);
            // 
            // ui_btnStdDocPath
            // 
            this.ui_btnStdDocPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ui_btnStdDocPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ui_btnStdDocPath.Location = new System.Drawing.Point(885, 28);
            this.ui_btnStdDocPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ui_btnStdDocPath.Name = "ui_btnStdDocPath";
            this.ui_btnStdDocPath.Size = new System.Drawing.Size(40, 30);
            this.ui_btnStdDocPath.TabIndex = 13;
            this.ui_btnStdDocPath.Tag = "ui_tbStdDocPath";
            this.ui_btnStdDocPath.Text = "···";
            this.ui_btnStdDocPath.UseSelectable = true;
            this.ui_btnStdDocPath.Click += new System.EventHandler(this.OnClickBtnPath);
            // 
            // ui_tbStdDocPath
            // 
            // 
            // 
            // 
            this.ui_tbStdDocPath.CustomButton.Image = null;
            this.ui_tbStdDocPath.CustomButton.Location = new System.Drawing.Point(671, 1);
            this.ui_tbStdDocPath.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ui_tbStdDocPath.CustomButton.Name = "";
            this.ui_tbStdDocPath.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.ui_tbStdDocPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ui_tbStdDocPath.CustomButton.TabIndex = 1;
            this.ui_tbStdDocPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ui_tbStdDocPath.CustomButton.UseSelectable = true;
            this.ui_tbStdDocPath.CustomButton.Visible = false;
            this.ui_tbStdDocPath.Lines = new string[0];
            this.ui_tbStdDocPath.Location = new System.Drawing.Point(178, 28);
            this.ui_tbStdDocPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_tbStdDocPath.MaxLength = 32767;
            this.ui_tbStdDocPath.Name = "ui_tbStdDocPath";
            this.ui_tbStdDocPath.PasswordChar = '\0';
            this.ui_tbStdDocPath.ReadOnly = true;
            this.ui_tbStdDocPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ui_tbStdDocPath.SelectedText = "";
            this.ui_tbStdDocPath.SelectionLength = 0;
            this.ui_tbStdDocPath.SelectionStart = 0;
            this.ui_tbStdDocPath.ShortcutsEnabled = true;
            this.ui_tbStdDocPath.Size = new System.Drawing.Size(699, 29);
            this.ui_tbStdDocPath.TabIndex = 12;
            this.ui_tbStdDocPath.UseSelectable = true;
            this.ui_tbStdDocPath.UseStyleColors = true;
            this.ui_tbStdDocPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ui_tbStdDocPath.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ui_lbStdDocDir
            // 
            this.ui_lbStdDocDir.Location = new System.Drawing.Point(13, 29);
            this.ui_lbStdDocDir.Name = "ui_lbStdDocDir";
            this.ui_lbStdDocDir.Size = new System.Drawing.Size(160, 25);
            this.ui_lbStdDocDir.TabIndex = 15;
            this.ui_lbStdDocDir.Text = "Document Directory :";
            this.ui_lbStdDocDir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ui_gbSmh
            // 
            this.ui_gbSmh.Controls.Add(this.ui_btnSmhSamplePathOpen);
            this.ui_gbSmh.Controls.Add(this.ui_btnSmhDocPathOpen);
            this.ui_gbSmh.Controls.Add(this.ui_btnSmhSamplePath);
            this.ui_gbSmh.Controls.Add(this.ui_tbSmhSamplePath);
            this.ui_gbSmh.Controls.Add(this.ui_lbSmhSampleDir);
            this.ui_gbSmh.Controls.Add(this.ui_btnSmhDocPath);
            this.ui_gbSmh.Controls.Add(this.ui_tbSmhDocPath);
            this.ui_gbSmh.Controls.Add(this.ui_lbSmhDocDir);
            this.ui_gbSmh.Location = new System.Drawing.Point(11, 200);
            this.ui_gbSmh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_gbSmh.Name = "ui_gbSmh";
            this.ui_gbSmh.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_gbSmh.Size = new System.Drawing.Size(994, 125);
            this.ui_gbSmh.TabIndex = 2;
            this.ui_gbSmh.TabStop = false;
            this.ui_gbSmh.Text = "SmartHull";
            // 
            // ui_btnSmhSamplePathOpen
            // 
            this.ui_btnSmhSamplePathOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ui_btnSmhSamplePathOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ui_btnSmhSamplePathOpen.Location = new System.Drawing.Point(931, 66);
            this.ui_btnSmhSamplePathOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ui_btnSmhSamplePathOpen.Name = "ui_btnSmhSamplePathOpen";
            this.ui_btnSmhSamplePathOpen.Size = new System.Drawing.Size(40, 30);
            this.ui_btnSmhSamplePathOpen.TabIndex = 11;
            this.ui_btnSmhSamplePathOpen.Tag = "ui_tbSmhSamplePath";
            this.ui_btnSmhSamplePathOpen.Text = "Open";
            this.ui_btnSmhSamplePathOpen.UseSelectable = true;
            this.ui_btnSmhSamplePathOpen.Click += new System.EventHandler(this.OnClickBtnPathOpen);
            // 
            // ui_btnSmhDocPathOpen
            // 
            this.ui_btnSmhDocPathOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ui_btnSmhDocPathOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ui_btnSmhDocPathOpen.Location = new System.Drawing.Point(931, 30);
            this.ui_btnSmhDocPathOpen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ui_btnSmhDocPathOpen.Name = "ui_btnSmhDocPathOpen";
            this.ui_btnSmhDocPathOpen.Size = new System.Drawing.Size(40, 30);
            this.ui_btnSmhDocPathOpen.TabIndex = 8;
            this.ui_btnSmhDocPathOpen.Tag = "ui_tbSmhDocPath";
            this.ui_btnSmhDocPathOpen.Text = "Open";
            this.ui_btnSmhDocPathOpen.UseSelectable = true;
            this.ui_btnSmhDocPathOpen.Click += new System.EventHandler(this.OnClickBtnPathOpen);
            // 
            // ui_btnSmhSamplePath
            // 
            this.ui_btnSmhSamplePath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ui_btnSmhSamplePath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ui_btnSmhSamplePath.Location = new System.Drawing.Point(885, 66);
            this.ui_btnSmhSamplePath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ui_btnSmhSamplePath.Name = "ui_btnSmhSamplePath";
            this.ui_btnSmhSamplePath.Size = new System.Drawing.Size(40, 30);
            this.ui_btnSmhSamplePath.TabIndex = 10;
            this.ui_btnSmhSamplePath.Tag = "ui_tbSmhSamplePath";
            this.ui_btnSmhSamplePath.Text = "···";
            this.ui_btnSmhSamplePath.UseSelectable = true;
            this.ui_btnSmhSamplePath.Click += new System.EventHandler(this.OnClickBtnPath);
            // 
            // ui_tbSmhSamplePath
            // 
            // 
            // 
            // 
            this.ui_tbSmhSamplePath.CustomButton.Image = null;
            this.ui_tbSmhSamplePath.CustomButton.Location = new System.Drawing.Point(671, 1);
            this.ui_tbSmhSamplePath.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ui_tbSmhSamplePath.CustomButton.Name = "";
            this.ui_tbSmhSamplePath.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.ui_tbSmhSamplePath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ui_tbSmhSamplePath.CustomButton.TabIndex = 1;
            this.ui_tbSmhSamplePath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ui_tbSmhSamplePath.CustomButton.UseSelectable = true;
            this.ui_tbSmhSamplePath.CustomButton.Visible = false;
            this.ui_tbSmhSamplePath.Lines = new string[0];
            this.ui_tbSmhSamplePath.Location = new System.Drawing.Point(178, 66);
            this.ui_tbSmhSamplePath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_tbSmhSamplePath.MaxLength = 32767;
            this.ui_tbSmhSamplePath.Name = "ui_tbSmhSamplePath";
            this.ui_tbSmhSamplePath.PasswordChar = '\0';
            this.ui_tbSmhSamplePath.ReadOnly = true;
            this.ui_tbSmhSamplePath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ui_tbSmhSamplePath.SelectedText = "";
            this.ui_tbSmhSamplePath.SelectionLength = 0;
            this.ui_tbSmhSamplePath.SelectionStart = 0;
            this.ui_tbSmhSamplePath.ShortcutsEnabled = true;
            this.ui_tbSmhSamplePath.Size = new System.Drawing.Size(699, 29);
            this.ui_tbSmhSamplePath.TabIndex = 9;
            this.ui_tbSmhSamplePath.UseSelectable = true;
            this.ui_tbSmhSamplePath.UseStyleColors = true;
            this.ui_tbSmhSamplePath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ui_tbSmhSamplePath.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ui_lbSmhSampleDir
            // 
            this.ui_lbSmhSampleDir.Location = new System.Drawing.Point(13, 68);
            this.ui_lbSmhSampleDir.Name = "ui_lbSmhSampleDir";
            this.ui_lbSmhSampleDir.Size = new System.Drawing.Size(160, 25);
            this.ui_lbSmhSampleDir.TabIndex = 12;
            this.ui_lbSmhSampleDir.Text = "Sample Directory :";
            this.ui_lbSmhSampleDir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ui_btnSmhDocPath
            // 
            this.ui_btnSmhDocPath.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ui_btnSmhDocPath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ui_btnSmhDocPath.Location = new System.Drawing.Point(885, 30);
            this.ui_btnSmhDocPath.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ui_btnSmhDocPath.Name = "ui_btnSmhDocPath";
            this.ui_btnSmhDocPath.Size = new System.Drawing.Size(40, 30);
            this.ui_btnSmhDocPath.TabIndex = 7;
            this.ui_btnSmhDocPath.Tag = "ui_tbSmhDocPath";
            this.ui_btnSmhDocPath.Text = "···";
            this.ui_btnSmhDocPath.UseSelectable = true;
            this.ui_btnSmhDocPath.Click += new System.EventHandler(this.OnClickBtnPath);
            // 
            // ui_tbSmhDocPath
            // 
            // 
            // 
            // 
            this.ui_tbSmhDocPath.CustomButton.Image = null;
            this.ui_tbSmhDocPath.CustomButton.Location = new System.Drawing.Point(671, 1);
            this.ui_tbSmhDocPath.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ui_tbSmhDocPath.CustomButton.Name = "";
            this.ui_tbSmhDocPath.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.ui_tbSmhDocPath.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ui_tbSmhDocPath.CustomButton.TabIndex = 1;
            this.ui_tbSmhDocPath.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ui_tbSmhDocPath.CustomButton.UseSelectable = true;
            this.ui_tbSmhDocPath.CustomButton.Visible = false;
            this.ui_tbSmhDocPath.Lines = new string[0];
            this.ui_tbSmhDocPath.Location = new System.Drawing.Point(178, 30);
            this.ui_tbSmhDocPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_tbSmhDocPath.MaxLength = 32767;
            this.ui_tbSmhDocPath.Name = "ui_tbSmhDocPath";
            this.ui_tbSmhDocPath.PasswordChar = '\0';
            this.ui_tbSmhDocPath.ReadOnly = true;
            this.ui_tbSmhDocPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ui_tbSmhDocPath.SelectedText = "";
            this.ui_tbSmhDocPath.SelectionLength = 0;
            this.ui_tbSmhDocPath.SelectionStart = 0;
            this.ui_tbSmhDocPath.ShortcutsEnabled = true;
            this.ui_tbSmhDocPath.Size = new System.Drawing.Size(699, 29);
            this.ui_tbSmhDocPath.TabIndex = 6;
            this.ui_tbSmhDocPath.UseSelectable = true;
            this.ui_tbSmhDocPath.UseStyleColors = true;
            this.ui_tbSmhDocPath.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ui_tbSmhDocPath.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ui_lbSmhDocDir
            // 
            this.ui_lbSmhDocDir.Location = new System.Drawing.Point(13, 31);
            this.ui_lbSmhDocDir.Name = "ui_lbSmhDocDir";
            this.ui_lbSmhDocDir.Size = new System.Drawing.Size(160, 25);
            this.ui_lbSmhDocDir.TabIndex = 13;
            this.ui_lbSmhDocDir.Text = "Document Directory :";
            this.ui_lbSmhDocDir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ui_gbDb
            // 
            this.ui_gbDb.Controls.Add(this.ui_lbDBStatus);
            this.ui_gbDb.Controls.Add(this.ui_btnConnect);
            this.ui_gbDb.Controls.Add(this.ui_tbDbName);
            this.ui_gbDb.Controls.Add(this.ui_tbDbPw);
            this.ui_gbDb.Controls.Add(this.ui_tbDbId);
            this.ui_gbDb.Controls.Add(this.ui_tbDbServer);
            this.ui_gbDb.Controls.Add(this.ui_lbDbName);
            this.ui_gbDb.Controls.Add(this.ui_lbPassword);
            this.ui_gbDb.Controls.Add(this.ui_lbLoginId);
            this.ui_gbDb.Controls.Add(this.ui_lbServer);
            this.ui_gbDb.Location = new System.Drawing.Point(11, 12);
            this.ui_gbDb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_gbDb.Name = "ui_gbDb";
            this.ui_gbDb.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_gbDb.Size = new System.Drawing.Size(411, 175);
            this.ui_gbDb.TabIndex = 1;
            this.ui_gbDb.TabStop = false;
            this.ui_gbDb.Text = "Database";
            this.ui_gbDb.UseCompatibleTextRendering = true;
            // 
            // ui_lbDBStatus
            // 
            this.ui_lbDBStatus.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ui_lbDBStatus.ForeColor = System.Drawing.Color.Red;
            this.ui_lbDBStatus.Location = new System.Drawing.Point(298, 131);
            this.ui_lbDBStatus.Name = "ui_lbDBStatus";
            this.ui_lbDBStatus.Size = new System.Drawing.Size(86, 25);
            this.ui_lbDBStatus.TabIndex = 17;
            this.ui_lbDBStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ui_lbDBStatus.UseCustomForeColor = true;
            // 
            // ui_btnConnect
            // 
            this.ui_btnConnect.Highlight = true;
            this.ui_btnConnect.Location = new System.Drawing.Point(298, 59);
            this.ui_btnConnect.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_btnConnect.Name = "ui_btnConnect";
            this.ui_btnConnect.Size = new System.Drawing.Size(86, 64);
            this.ui_btnConnect.TabIndex = 5;
            this.ui_btnConnect.Text = "Connection\r\nTest";
            this.ui_btnConnect.UseSelectable = true;
            this.ui_btnConnect.Click += new System.EventHandler(this.OnClickBtnConnect);
            // 
            // ui_tbDbName
            // 
            // 
            // 
            // 
            this.ui_tbDbName.CustomButton.Image = null;
            this.ui_tbDbName.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.ui_tbDbName.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ui_tbDbName.CustomButton.Name = "";
            this.ui_tbDbName.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.ui_tbDbName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ui_tbDbName.CustomButton.TabIndex = 1;
            this.ui_tbDbName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ui_tbDbName.CustomButton.UseSelectable = true;
            this.ui_tbDbName.CustomButton.Visible = false;
            this.ui_tbDbName.Lines = new string[0];
            this.ui_tbDbName.Location = new System.Drawing.Point(121, 130);
            this.ui_tbDbName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_tbDbName.MaxLength = 32767;
            this.ui_tbDbName.Name = "ui_tbDbName";
            this.ui_tbDbName.PasswordChar = '\0';
            this.ui_tbDbName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ui_tbDbName.SelectedText = "";
            this.ui_tbDbName.SelectionLength = 0;
            this.ui_tbDbName.SelectionStart = 0;
            this.ui_tbDbName.ShortcutsEnabled = true;
            this.ui_tbDbName.Size = new System.Drawing.Size(171, 29);
            this.ui_tbDbName.TabIndex = 4;
            this.ui_tbDbName.UseSelectable = true;
            this.ui_tbDbName.UseStyleColors = true;
            this.ui_tbDbName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ui_tbDbName.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ui_tbDbPw
            // 
            // 
            // 
            // 
            this.ui_tbDbPw.CustomButton.Image = null;
            this.ui_tbDbPw.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.ui_tbDbPw.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ui_tbDbPw.CustomButton.Name = "";
            this.ui_tbDbPw.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.ui_tbDbPw.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ui_tbDbPw.CustomButton.TabIndex = 1;
            this.ui_tbDbPw.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ui_tbDbPw.CustomButton.UseSelectable = true;
            this.ui_tbDbPw.CustomButton.Visible = false;
            this.ui_tbDbPw.Lines = new string[0];
            this.ui_tbDbPw.Location = new System.Drawing.Point(121, 94);
            this.ui_tbDbPw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_tbDbPw.MaxLength = 32767;
            this.ui_tbDbPw.Name = "ui_tbDbPw";
            this.ui_tbDbPw.PasswordChar = '*';
            this.ui_tbDbPw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ui_tbDbPw.SelectedText = "";
            this.ui_tbDbPw.SelectionLength = 0;
            this.ui_tbDbPw.SelectionStart = 0;
            this.ui_tbDbPw.ShortcutsEnabled = true;
            this.ui_tbDbPw.Size = new System.Drawing.Size(171, 29);
            this.ui_tbDbPw.TabIndex = 3;
            this.ui_tbDbPw.UseSelectable = true;
            this.ui_tbDbPw.UseStyleColors = true;
            this.ui_tbDbPw.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ui_tbDbPw.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ui_tbDbId
            // 
            // 
            // 
            // 
            this.ui_tbDbId.CustomButton.Image = null;
            this.ui_tbDbId.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.ui_tbDbId.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ui_tbDbId.CustomButton.Name = "";
            this.ui_tbDbId.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.ui_tbDbId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ui_tbDbId.CustomButton.TabIndex = 1;
            this.ui_tbDbId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ui_tbDbId.CustomButton.UseSelectable = true;
            this.ui_tbDbId.CustomButton.Visible = false;
            this.ui_tbDbId.Lines = new string[0];
            this.ui_tbDbId.Location = new System.Drawing.Point(121, 59);
            this.ui_tbDbId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_tbDbId.MaxLength = 32767;
            this.ui_tbDbId.Name = "ui_tbDbId";
            this.ui_tbDbId.PasswordChar = '\0';
            this.ui_tbDbId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ui_tbDbId.SelectedText = "";
            this.ui_tbDbId.SelectionLength = 0;
            this.ui_tbDbId.SelectionStart = 0;
            this.ui_tbDbId.ShortcutsEnabled = true;
            this.ui_tbDbId.Size = new System.Drawing.Size(171, 29);
            this.ui_tbDbId.TabIndex = 2;
            this.ui_tbDbId.UseSelectable = true;
            this.ui_tbDbId.UseStyleColors = true;
            this.ui_tbDbId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ui_tbDbId.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ui_tbDbServer
            // 
            // 
            // 
            // 
            this.ui_tbDbServer.CustomButton.Image = null;
            this.ui_tbDbServer.CustomButton.Location = new System.Drawing.Point(235, 1);
            this.ui_tbDbServer.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ui_tbDbServer.CustomButton.Name = "";
            this.ui_tbDbServer.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.ui_tbDbServer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ui_tbDbServer.CustomButton.TabIndex = 1;
            this.ui_tbDbServer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ui_tbDbServer.CustomButton.UseSelectable = true;
            this.ui_tbDbServer.CustomButton.Visible = false;
            this.ui_tbDbServer.Lines = new string[0];
            this.ui_tbDbServer.Location = new System.Drawing.Point(121, 24);
            this.ui_tbDbServer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_tbDbServer.MaxLength = 32767;
            this.ui_tbDbServer.Name = "ui_tbDbServer";
            this.ui_tbDbServer.PasswordChar = '\0';
            this.ui_tbDbServer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ui_tbDbServer.SelectedText = "";
            this.ui_tbDbServer.SelectionLength = 0;
            this.ui_tbDbServer.SelectionStart = 0;
            this.ui_tbDbServer.ShortcutsEnabled = true;
            this.ui_tbDbServer.Size = new System.Drawing.Size(263, 29);
            this.ui_tbDbServer.TabIndex = 1;
            this.ui_tbDbServer.UseSelectable = true;
            this.ui_tbDbServer.UseStyleColors = true;
            this.ui_tbDbServer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ui_tbDbServer.WaterMarkFont = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ui_lbDbName
            // 
            this.ui_lbDbName.Location = new System.Drawing.Point(13, 129);
            this.ui_lbDbName.Name = "ui_lbDbName";
            this.ui_lbDbName.Size = new System.Drawing.Size(103, 25);
            this.ui_lbDbName.TabIndex = 11;
            this.ui_lbDbName.Text = "DB Name :";
            this.ui_lbDbName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ui_lbPassword
            // 
            this.ui_lbPassword.Location = new System.Drawing.Point(13, 92);
            this.ui_lbPassword.Name = "ui_lbPassword";
            this.ui_lbPassword.Size = new System.Drawing.Size(103, 25);
            this.ui_lbPassword.TabIndex = 12;
            this.ui_lbPassword.Text = "Password :";
            this.ui_lbPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ui_lbLoginId
            // 
            this.ui_lbLoginId.Location = new System.Drawing.Point(13, 58);
            this.ui_lbLoginId.Name = "ui_lbLoginId";
            this.ui_lbLoginId.Size = new System.Drawing.Size(103, 25);
            this.ui_lbLoginId.TabIndex = 8;
            this.ui_lbLoginId.Text = "Login ID :";
            this.ui_lbLoginId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ui_lbServer
            // 
            this.ui_lbServer.Location = new System.Drawing.Point(13, 22);
            this.ui_lbServer.Name = "ui_lbServer";
            this.ui_lbServer.Size = new System.Drawing.Size(103, 25);
            this.ui_lbServer.TabIndex = 9;
            this.ui_lbServer.Text = "Server :";
            this.ui_lbServer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // HelperPage
            // 
            this.HelperPage.BackColor = System.Drawing.SystemColors.Window;
            this.HelperPage.Controls.Add(this.ui_panelHelper);
            this.HelperPage.Controls.Add(this.ui_panelHelperCollapsible);
            this.HelperPage.Location = new System.Drawing.Point(4, 41);
            this.HelperPage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HelperPage.Name = "HelperPage";
            this.HelperPage.Size = new System.Drawing.Size(1409, 852);
            this.HelperPage.TabIndex = 5;
            this.HelperPage.Text = "Helper";
            // 
            // ui_panelHelper
            // 
            this.ui_panelHelper.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ui_panelHelper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ui_panelHelper.HorizontalScrollbarBarColor = true;
            this.ui_panelHelper.HorizontalScrollbarHighlightOnWheel = false;
            this.ui_panelHelper.HorizontalScrollbarSize = 10;
            this.ui_panelHelper.Location = new System.Drawing.Point(0, 60);
            this.ui_panelHelper.Margin = new System.Windows.Forms.Padding(0);
            this.ui_panelHelper.Name = "ui_panelHelper";
            this.ui_panelHelper.Padding = new System.Windows.Forms.Padding(1);
            this.ui_panelHelper.Size = new System.Drawing.Size(1409, 792);
            this.ui_panelHelper.TabIndex = 1;
            this.ui_panelHelper.UseCustomBackColor = true;
            this.ui_panelHelper.VerticalScrollbarBarColor = true;
            this.ui_panelHelper.VerticalScrollbarHighlightOnWheel = false;
            this.ui_panelHelper.VerticalScrollbarSize = 11;
            // 
            // ui_panelHelperCollapsible
            // 
            this.ui_panelHelperCollapsible.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ui_panelHelperCollapsible.Controls.Add(this.ui_progressBar);
            this.ui_panelHelperCollapsible.Controls.Add(this.ui_btnLoadExcel);
            this.ui_panelHelperCollapsible.Controls.Add(this.ui_btnClearExcel);
            this.ui_panelHelperCollapsible.Controls.Add(this.ui_btnImportExcel);
            this.ui_panelHelperCollapsible.Dock = System.Windows.Forms.DockStyle.Top;
            this.ui_panelHelperCollapsible.HorizontalScrollbarBarColor = true;
            this.ui_panelHelperCollapsible.HorizontalScrollbarHighlightOnWheel = false;
            this.ui_panelHelperCollapsible.HorizontalScrollbarSize = 12;
            this.ui_panelHelperCollapsible.Location = new System.Drawing.Point(0, 0);
            this.ui_panelHelperCollapsible.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_panelHelperCollapsible.Name = "ui_panelHelperCollapsible";
            this.ui_panelHelperCollapsible.Size = new System.Drawing.Size(1409, 60);
            this.ui_panelHelperCollapsible.TabIndex = 0;
            this.ui_panelHelperCollapsible.UseCustomBackColor = true;
            this.ui_panelHelperCollapsible.VerticalScrollbarBarColor = true;
            this.ui_panelHelperCollapsible.VerticalScrollbarHighlightOnWheel = false;
            this.ui_panelHelperCollapsible.VerticalScrollbarSize = 11;
            // 
            // ui_btnLoadExcel
            // 
            this.ui_btnLoadExcel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ui_btnLoadExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ui_btnLoadExcel.Location = new System.Drawing.Point(1201, 19);
            this.ui_btnLoadExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_btnLoadExcel.Name = "ui_btnLoadExcel";
            this.ui_btnLoadExcel.Size = new System.Drawing.Size(59, 25);
            this.ui_btnLoadExcel.TabIndex = 9;
            this.ui_btnLoadExcel.Tag = "";
            this.ui_btnLoadExcel.Text = "Load";
            this.ui_btnLoadExcel.UseCustomBackColor = true;
            this.ui_btnLoadExcel.UseSelectable = true;
            this.ui_btnLoadExcel.Click += new System.EventHandler(this.OnClickLoad);
            // 
            // ui_btnClearExcel
            // 
            this.ui_btnClearExcel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ui_btnClearExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ui_btnClearExcel.Location = new System.Drawing.Point(1266, 19);
            this.ui_btnClearExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_btnClearExcel.Name = "ui_btnClearExcel";
            this.ui_btnClearExcel.Size = new System.Drawing.Size(59, 25);
            this.ui_btnClearExcel.TabIndex = 10;
            this.ui_btnClearExcel.Tag = "";
            this.ui_btnClearExcel.Text = "Clear";
            this.ui_btnClearExcel.UseCustomBackColor = true;
            this.ui_btnClearExcel.UseSelectable = true;
            this.ui_btnClearExcel.Click += new System.EventHandler(this.OnClickClearExcel);
            // 
            // ui_btnImportExcel
            // 
            this.ui_btnImportExcel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ui_btnImportExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ui_btnImportExcel.Location = new System.Drawing.Point(1331, 19);
            this.ui_btnImportExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_btnImportExcel.Name = "ui_btnImportExcel";
            this.ui_btnImportExcel.Size = new System.Drawing.Size(59, 25);
            this.ui_btnImportExcel.TabIndex = 11;
            this.ui_btnImportExcel.Tag = "";
            this.ui_btnImportExcel.Text = "Import";
            this.ui_btnImportExcel.UseCustomBackColor = true;
            this.ui_btnImportExcel.UseSelectable = true;
            this.ui_btnImportExcel.Click += new System.EventHandler(this.OnClickImport);
            // 
            // ui_lbMainTitle1
            // 
            this.ui_lbMainTitle1.AutoSize = true;
            this.ui_lbMainTitle1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ui_lbMainTitle1.ForeColor = System.Drawing.Color.Gray;
            this.ui_lbMainTitle1.Location = new System.Drawing.Point(34, 9);
            this.ui_lbMainTitle1.Name = "ui_lbMainTitle1";
            this.ui_lbMainTitle1.Size = new System.Drawing.Size(125, 20);
            this.ui_lbMainTitle1.TabIndex = 1;
            this.ui_lbMainTitle1.Text = "Hull Maintenance";
            this.ui_lbMainTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ui_lbMainTitle1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ui_lbMainTitle1.UseCustomForeColor = true;
            // 
            // ui_lbMainTitle2
            // 
            this.ui_lbMainTitle2.AutoSize = true;
            this.ui_lbMainTitle2.FontSize = MetroFramework.MetroLabelSize.Small;
            this.ui_lbMainTitle2.ForeColor = System.Drawing.Color.DarkGray;
            this.ui_lbMainTitle2.Location = new System.Drawing.Point(194, 14);
            this.ui_lbMainTitle2.Name = "ui_lbMainTitle2";
            this.ui_lbMainTitle2.Size = new System.Drawing.Size(140, 17);
            this.ui_lbMainTitle2.TabIndex = 1;
            this.ui_lbMainTitle2.Text = "Cadwin System Co., Ltd.";
            this.ui_lbMainTitle2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ui_lbMainTitle2.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ui_lbMainTitle2.UseCustomForeColor = true;
            // 
            // ui_lbMainTitle3
            // 
            this.ui_lbMainTitle3.AutoSize = true;
            this.ui_lbMainTitle3.ForeColor = System.Drawing.Color.DarkGray;
            this.ui_lbMainTitle3.Location = new System.Drawing.Point(174, 9);
            this.ui_lbMainTitle3.Name = "ui_lbMainTitle3";
            this.ui_lbMainTitle3.Size = new System.Drawing.Size(12, 20);
            this.ui_lbMainTitle3.TabIndex = 1;
            this.ui_lbMainTitle3.Text = "|";
            this.ui_lbMainTitle3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ui_lbMainTitle3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ui_lbMainTitle3.UseCustomForeColor = true;
            // 
            // ui_lbMainVersion
            // 
            this.ui_lbMainVersion.AutoSize = true;
            this.ui_lbMainVersion.FontSize = MetroFramework.MetroLabelSize.Small;
            this.ui_lbMainVersion.ForeColor = System.Drawing.Color.DarkGray;
            this.ui_lbMainVersion.Location = new System.Drawing.Point(346, 14);
            this.ui_lbMainVersion.Name = "ui_lbMainVersion";
            this.ui_lbMainVersion.Size = new System.Drawing.Size(90, 17);
            this.ui_lbMainVersion.TabIndex = 1;
            this.ui_lbMainVersion.Text = "version=1.0.0.0";
            this.ui_lbMainVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ui_lbMainVersion.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ui_lbMainVersion.UseCustomForeColor = true;
            // 
            // ui_styleMgr
            // 
            this.ui_styleMgr.Owner = this;
            // 
            // ui_progressBar
            // 
            this.ui_progressBar.Location = new System.Drawing.Point(0, 55);
            this.ui_progressBar.Name = "ui_progressBar";
            this.ui_progressBar.Size = new System.Drawing.Size(1409, 5);
            this.ui_progressBar.Step = 1;
            this.ui_progressBar.TabIndex = 12;
            this.ui_progressBar.UseCustomBackColor = true;
            this.ui_progressBar.Value = 100;
            this.ui_progressBar.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1463, 960);
            this.Controls.Add(this.ui_lbMainVersion);
            this.Controls.Add(this.ui_lbMainTitle3);
            this.Controls.Add(this.ui_lbMainTitle2);
            this.Controls.Add(this.ui_lbMainTitle1);
            this.Controls.Add(this.ui_tabControl);
            this.DisplayHeader = false;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1463, 832);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(23, 38, 23, 25);
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.StyleManager = this.ui_styleMgr;
            this.Text = "Hull Maintenance";
            this.Load += new System.EventHandler(this.OnLoadMainForm);
            this.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.ui_tabControl.ResumeLayout(false);
            this.smhPage.ResumeLayout(false);
            this.ui_panelSmh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ui_gridSmh)).EndInit();
            this.ui_panelSmhCollapsible.ResumeLayout(false);
            this.ui_panelSubSmh2.ResumeLayout(false);
            this.ui_panelSubSmh1.ResumeLayout(false);
            this.stdPage.ResumeLayout(false);
            this.ui_panelStd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ui_gridStd)).EndInit();
            this.ui_panelStdCollapsible.ResumeLayout(false);
            this.ui_panelSubStd2.ResumeLayout(false);
            this.ui_panelSubStd1.ResumeLayout(false);
            this.settingPage.ResumeLayout(false);
            this.ui_gbColorCode.ResumeLayout(false);
            this.ui_gbStd.ResumeLayout(false);
            this.ui_gbSmh.ResumeLayout(false);
            this.ui_gbDb.ResumeLayout(false);
            this.HelperPage.ResumeLayout(false);
            this.ui_panelHelperCollapsible.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ui_styleMgr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl ui_tabControl;
        private System.Windows.Forms.TabPage smhPage;
        private System.Windows.Forms.TabPage stdPage;
        private System.Windows.Forms.TabPage settingPage;
        private System.Windows.Forms.TabPage HelperPage;
        private MetroFramework.Controls.MetroLabel ui_lbMainTitle1;
        private MetroFramework.Controls.MetroLabel ui_lbMainTitle2;
        private MetroFramework.Controls.MetroLabel ui_lbMainTitle3;
        private MetroFramework.Controls.MetroLabel ui_lbMainVersion;
        private MetroFramework.Controls.MetroPanel ui_panelSmh;
        private MetroFramework.Controls.MetroPanel ui_panelSmhCollapsible;
        private MetroFramework.Controls.MetroPanel ui_panelStd;
        private MetroFramework.Controls.MetroPanel ui_panelStdCollapsible;
        private MetroFramework.Components.MetroStyleManager ui_styleMgr;
        private MetroFramework.Controls.MetroGrid ui_gridStd;
        private MetroFramework.Controls.MetroGrid ui_gridSmh;
        private System.Windows.Forms.GroupBox ui_gbStd;
        private MetroFramework.Controls.MetroButton ui_btnStdSamplePathOpen;
        private MetroFramework.Controls.MetroButton ui_btnStdSamplePath;
        private MetroFramework.Controls.MetroTextBox ui_tbStdSamplePath;
        private MetroFramework.Controls.MetroLabel ui_lbStdSampleDir;
        private MetroFramework.Controls.MetroButton ui_btnStdDocPathOpen;
        private MetroFramework.Controls.MetroButton ui_btnStdDocPath;
        private MetroFramework.Controls.MetroTextBox ui_tbStdDocPath;
        private MetroFramework.Controls.MetroLabel ui_lbStdDocDir;
        private System.Windows.Forms.GroupBox ui_gbSmh;
        private MetroFramework.Controls.MetroButton ui_btnSmhSamplePathOpen;
        private MetroFramework.Controls.MetroButton ui_btnSmhDocPathOpen;
        private MetroFramework.Controls.MetroButton ui_btnSmhSamplePath;
        private MetroFramework.Controls.MetroTextBox ui_tbSmhSamplePath;
        private MetroFramework.Controls.MetroLabel ui_lbSmhSampleDir;
        private MetroFramework.Controls.MetroButton ui_btnSmhDocPath;
        private MetroFramework.Controls.MetroTextBox ui_tbSmhDocPath;
        private MetroFramework.Controls.MetroLabel ui_lbSmhDocDir;
        private System.Windows.Forms.GroupBox ui_gbDb;
        private MetroFramework.Controls.MetroLabel ui_lbDBStatus;
        private MetroFramework.Controls.MetroButton ui_btnConnect;
        private MetroFramework.Controls.MetroTextBox ui_tbDbName;
        private MetroFramework.Controls.MetroTextBox ui_tbDbPw;
        private MetroFramework.Controls.MetroTextBox ui_tbDbId;
        private MetroFramework.Controls.MetroTextBox ui_tbDbServer;
        private MetroFramework.Controls.MetroLabel ui_lbDbName;
        private MetroFramework.Controls.MetroLabel ui_lbPassword;
        private MetroFramework.Controls.MetroLabel ui_lbLoginId;
        private MetroFramework.Controls.MetroLabel ui_lbServer;
        private System.Windows.Forms.GroupBox ui_gbColorCode;
        private MetroFramework.Controls.MetroLabel ui_lbColorPending;
        private MetroFramework.Controls.MetroLabel ui_lbColorComplete;
        private MetroFramework.Controls.MetroLabel ui_lbColorPartialDone;
        private MetroFramework.Controls.MetroLabel ui_lbColorWorkDone;
        private MetroFramework.Controls.MetroLabel ui_lbColorWorking;
        private MetroFramework.Controls.MetroLabel ui_lbColorImpossible;
        private MetroFramework.Controls.MetroLabel ui_lbColorCancel;
        private MetroFramework.Controls.MetroLabel ui_lbColorError;
        private MetroFramework.Controls.MetroTextBox ui_tbColorError;
        private MetroFramework.Controls.MetroTextBox ui_tbColorImpossible;
        private MetroFramework.Controls.MetroTextBox ui_tbColorCancel;
        private MetroFramework.Controls.MetroTextBox ui_tbColorPending;
        private MetroFramework.Controls.MetroTextBox ui_tbColorComplete;
        private MetroFramework.Controls.MetroTextBox ui_tbColorPartialDone;
        private MetroFramework.Controls.MetroTextBox ui_tbColorWorkDone;
        private MetroFramework.Controls.MetroTextBox ui_tbColorWorking;
        private MetroFramework.Controls.MetroTextBox ui_tbColorD7;
        private MetroFramework.Controls.MetroLabel ui_lbColorD7;
        private MetroFramework.Controls.MetroTextBox ui_tbColorD3;
        private MetroFramework.Controls.MetroLabel ui_lbColorD3;
        private MetroFramework.Controls.MetroTextBox ui_tbColorD1;
        private MetroFramework.Controls.MetroLabel ui_lbColorD1;
        private MetroFramework.Controls.MetroButton ui_btnTheme;
        private MetroFramework.Controls.MetroButton ui_btnStyle;
		private MetroFramework.Controls.MetroPanel ui_panelSubSmh2;
		private MetroFramework.Controls.MetroButton ui_btnSmhAddItem;
		private MetroFramework.Controls.MetroPanel ui_panelSubSmh1;
		private MetroFramework.Controls.MetroButton ui_btnSmhSearchHistoryClear;
		private System.Windows.Forms.Button ui_btnSmhSearchTextClear;
		private MetroFramework.Controls.MetroButton ui_btnSmhSearch;
		private System.Windows.Forms.ComboBox ui_cbSmhSearchText;
		private MetroFramework.Controls.MetroPanel ui_panelSubStd2;
		private MetroFramework.Controls.MetroButton ui_btnStdAddItem;
		private MetroFramework.Controls.MetroPanel ui_panelSubStd1;
		private MetroFramework.Controls.MetroButton ui_btnStdSearchHistoryClear;
		private System.Windows.Forms.Button ui_btnStdSearchTextClear;
		private MetroFramework.Controls.MetroButton ui_btnStdSearch;
		private System.Windows.Forms.ComboBox ui_cbStdSearchText;
        private System.Windows.Forms.ComboBox ui_cbStdCustomer;
        private System.Windows.Forms.ComboBox ui_cbStdPeriod;
        private System.Windows.Forms.ComboBox ui_cbSmhPeriod;
        private System.Windows.Forms.ComboBox ui_cbSmhCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn smhColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn smhColCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn smhColType;
        private System.Windows.Forms.DataGridViewTextBoxColumn smhColStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn smhColSummaryKr;
        private System.Windows.Forms.DataGridViewTextBoxColumn smhColReceiveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn smhColDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn smhColStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn smhColEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn smhColVerificationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn smhColUpdateDate;
        private System.Windows.Forms.DataGridViewLinkColumn smhColDocumentLink;
        private System.Windows.Forms.DataGridViewTextBoxColumn smhColDocumentPath;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdColId;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdColCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdColType;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdColStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdColSummaryKr;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdColReceiveDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdColDueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdColStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdColEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdColVerificationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdColUpdateDate;
        private System.Windows.Forms.DataGridViewLinkColumn stdColDocumentLink;
        private System.Windows.Forms.DataGridViewTextBoxColumn stdColDocumentPath;
        private MetroFramework.Controls.MetroPanel ui_panelHelperCollapsible;
        private MetroFramework.Controls.MetroPanel ui_panelHelper;
        private MetroFramework.Controls.MetroButton ui_btnLoadExcel;
        private MetroFramework.Controls.MetroButton ui_btnClearExcel;
        private MetroFramework.Controls.MetroButton ui_btnImportExcel;
        private MetroFramework.Controls.MetroProgressBar ui_progressBar;
    }
}

