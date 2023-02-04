namespace HullMaintenance.UserControls
{
    partial class InterfaceHelper
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.ui_panelTop = new MetroFramework.Controls.MetroPanel();
            this.ui_panelBtm = new MetroFramework.Controls.MetroPanel();
            this.ui_panelMid = new MetroFramework.Controls.MetroPanel();
            this.ui_panelTopLeft = new MetroFramework.Controls.MetroPanel();
            this.ui_lbCustomer = new MetroFramework.Controls.MetroLabel();
            this.ui_lbProject = new MetroFramework.Controls.MetroLabel();
            this.ui_lbBlock = new MetroFramework.Controls.MetroLabel();
            this.ui_btnConfirm = new MetroFramework.Controls.MetroButton();
            this.ui_cbCustomer = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.ui_tbBlockPath = new System.Windows.Forms.TextBox();
            this.ui_lbBlockPath = new MetroFramework.Controls.MetroLabel();
            this.ui_btnBlockPathOpen = new MetroFramework.Controls.MetroButton();
            this.ui_btnEnvPathOpen = new MetroFramework.Controls.MetroButton();
            this.ui_tbEnvPath = new System.Windows.Forms.TextBox();
            this.ui_lbEnvPath = new MetroFramework.Controls.MetroLabel();
            this.ui_btnInterfacePathOpen = new MetroFramework.Controls.MetroButton();
            this.ui_tbInterfacePath = new System.Windows.Forms.TextBox();
            this.ui_lbInterfacePath = new MetroFramework.Controls.MetroLabel();
            this.ui_panelTop.SuspendLayout();
            this.ui_panelBtm.SuspendLayout();
            this.ui_panelTopLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // ui_panelTop
            // 
            this.ui_panelTop.Controls.Add(this.ui_panelTopLeft);
            this.ui_panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.ui_panelTop.HorizontalScrollbarBarColor = true;
            this.ui_panelTop.HorizontalScrollbarHighlightOnWheel = false;
            this.ui_panelTop.HorizontalScrollbarSize = 10;
            this.ui_panelTop.Location = new System.Drawing.Point(0, 0);
            this.ui_panelTop.Name = "ui_panelTop";
            this.ui_panelTop.Size = new System.Drawing.Size(998, 140);
            this.ui_panelTop.TabIndex = 0;
            this.ui_panelTop.VerticalScrollbarBarColor = true;
            this.ui_panelTop.VerticalScrollbarHighlightOnWheel = false;
            this.ui_panelTop.VerticalScrollbarSize = 10;
            // 
            // ui_panelBtm
            // 
            this.ui_panelBtm.Controls.Add(this.ui_btnInterfacePathOpen);
            this.ui_panelBtm.Controls.Add(this.ui_tbInterfacePath);
            this.ui_panelBtm.Controls.Add(this.ui_lbInterfacePath);
            this.ui_panelBtm.Controls.Add(this.ui_btnEnvPathOpen);
            this.ui_panelBtm.Controls.Add(this.ui_tbEnvPath);
            this.ui_panelBtm.Controls.Add(this.ui_lbEnvPath);
            this.ui_panelBtm.Controls.Add(this.ui_btnBlockPathOpen);
            this.ui_panelBtm.Controls.Add(this.ui_tbBlockPath);
            this.ui_panelBtm.Controls.Add(this.ui_lbBlockPath);
            this.ui_panelBtm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ui_panelBtm.HorizontalScrollbarBarColor = true;
            this.ui_panelBtm.HorizontalScrollbarHighlightOnWheel = false;
            this.ui_panelBtm.HorizontalScrollbarSize = 10;
            this.ui_panelBtm.Location = new System.Drawing.Point(0, 588);
            this.ui_panelBtm.Name = "ui_panelBtm";
            this.ui_panelBtm.Size = new System.Drawing.Size(998, 160);
            this.ui_panelBtm.TabIndex = 1;
            this.ui_panelBtm.VerticalScrollbarBarColor = true;
            this.ui_panelBtm.VerticalScrollbarHighlightOnWheel = false;
            this.ui_panelBtm.VerticalScrollbarSize = 10;
            // 
            // ui_panelMid
            // 
            this.ui_panelMid.BackColor = System.Drawing.Color.Transparent;
            this.ui_panelMid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ui_panelMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ui_panelMid.HorizontalScrollbarBarColor = true;
            this.ui_panelMid.HorizontalScrollbarHighlightOnWheel = false;
            this.ui_panelMid.HorizontalScrollbarSize = 10;
            this.ui_panelMid.Location = new System.Drawing.Point(0, 140);
            this.ui_panelMid.Name = "ui_panelMid";
            this.ui_panelMid.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.ui_panelMid.Size = new System.Drawing.Size(998, 448);
            this.ui_panelMid.TabIndex = 2;
            this.ui_panelMid.UseCustomBackColor = true;
            this.ui_panelMid.VerticalScrollbarBarColor = true;
            this.ui_panelMid.VerticalScrollbarHighlightOnWheel = false;
            this.ui_panelMid.VerticalScrollbarSize = 10;
            // 
            // ui_panelTopLeft
            // 
            this.ui_panelTopLeft.Controls.Add(this.comboBox2);
            this.ui_panelTopLeft.Controls.Add(this.comboBox1);
            this.ui_panelTopLeft.Controls.Add(this.ui_cbCustomer);
            this.ui_panelTopLeft.Controls.Add(this.ui_btnConfirm);
            this.ui_panelTopLeft.Controls.Add(this.ui_lbBlock);
            this.ui_panelTopLeft.Controls.Add(this.ui_lbProject);
            this.ui_panelTopLeft.Controls.Add(this.ui_lbCustomer);
            this.ui_panelTopLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.ui_panelTopLeft.HorizontalScrollbarBarColor = true;
            this.ui_panelTopLeft.HorizontalScrollbarHighlightOnWheel = false;
            this.ui_panelTopLeft.HorizontalScrollbarSize = 10;
            this.ui_panelTopLeft.Location = new System.Drawing.Point(0, 0);
            this.ui_panelTopLeft.Name = "ui_panelTopLeft";
            this.ui_panelTopLeft.Size = new System.Drawing.Size(835, 140);
            this.ui_panelTopLeft.TabIndex = 2;
            this.ui_panelTopLeft.VerticalScrollbarBarColor = true;
            this.ui_panelTopLeft.VerticalScrollbarHighlightOnWheel = false;
            this.ui_panelTopLeft.VerticalScrollbarSize = 10;
            // 
            // ui_lbCustomer
            // 
            this.ui_lbCustomer.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ui_lbCustomer.Location = new System.Drawing.Point(20, 20);
            this.ui_lbCustomer.Name = "ui_lbCustomer";
            this.ui_lbCustomer.Size = new System.Drawing.Size(80, 25);
            this.ui_lbCustomer.TabIndex = 10;
            this.ui_lbCustomer.Text = "Customer";
            this.ui_lbCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ui_lbProject
            // 
            this.ui_lbProject.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ui_lbProject.Location = new System.Drawing.Point(20, 54);
            this.ui_lbProject.Name = "ui_lbProject";
            this.ui_lbProject.Size = new System.Drawing.Size(80, 25);
            this.ui_lbProject.TabIndex = 11;
            this.ui_lbProject.Text = "Project";
            this.ui_lbProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ui_lbBlock
            // 
            this.ui_lbBlock.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ui_lbBlock.Location = new System.Drawing.Point(20, 89);
            this.ui_lbBlock.Name = "ui_lbBlock";
            this.ui_lbBlock.Size = new System.Drawing.Size(80, 25);
            this.ui_lbBlock.TabIndex = 12;
            this.ui_lbBlock.Text = "Block";
            this.ui_lbBlock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ui_btnConfirm
            // 
            this.ui_btnConfirm.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ui_btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ui_btnConfirm.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.ui_btnConfirm.Location = new System.Drawing.Point(703, 20);
            this.ui_btnConfirm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_btnConfirm.Name = "ui_btnConfirm";
            this.ui_btnConfirm.Size = new System.Drawing.Size(100, 30);
            this.ui_btnConfirm.TabIndex = 13;
            this.ui_btnConfirm.Tag = "";
            this.ui_btnConfirm.Text = "Confirm";
            this.ui_btnConfirm.UseCustomBackColor = true;
            this.ui_btnConfirm.UseSelectable = true;
            // 
            // ui_cbCustomer
            // 
            this.ui_cbCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ui_cbCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ui_cbCustomer.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.ui_cbCustomer.FormattingEnabled = true;
            this.ui_cbCustomer.IntegralHeight = false;
            this.ui_cbCustomer.Location = new System.Drawing.Point(122, 18);
            this.ui_cbCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ui_cbCustomer.Name = "ui_cbCustomer";
            this.ui_cbCustomer.Size = new System.Drawing.Size(150, 28);
            this.ui_cbCustomer.TabIndex = 14;
            this.ui_cbCustomer.Tag = "";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Location = new System.Drawing.Point(122, 54);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 28);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.Tag = "";
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox2.Font = new System.Drawing.Font("Verdana", 10.2F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.IntegralHeight = false;
            this.comboBox2.Location = new System.Drawing.Point(122, 90);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(150, 28);
            this.comboBox2.TabIndex = 16;
            this.comboBox2.Tag = "";
            // 
            // ui_tbBlockPath
            // 
            this.ui_tbBlockPath.Font = new System.Drawing.Font("Verdana", 11F);
            this.ui_tbBlockPath.Location = new System.Drawing.Point(122, 24);
            this.ui_tbBlockPath.Margin = new System.Windows.Forms.Padding(5);
            this.ui_tbBlockPath.Name = "ui_tbBlockPath";
            this.ui_tbBlockPath.ReadOnly = true;
            this.ui_tbBlockPath.Size = new System.Drawing.Size(621, 30);
            this.ui_tbBlockPath.TabIndex = 22;
            // 
            // ui_lbBlockPath
            // 
            this.ui_lbBlockPath.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ui_lbBlockPath.Location = new System.Drawing.Point(20, 26);
            this.ui_lbBlockPath.Margin = new System.Windows.Forms.Padding(5);
            this.ui_lbBlockPath.Name = "ui_lbBlockPath";
            this.ui_lbBlockPath.Size = new System.Drawing.Size(80, 25);
            this.ui_lbBlockPath.TabIndex = 23;
            this.ui_lbBlockPath.Text = "Block Path";
            this.ui_lbBlockPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ui_btnBlockPathOpen
            // 
            this.ui_btnBlockPathOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ui_btnBlockPathOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ui_btnBlockPathOpen.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.ui_btnBlockPathOpen.Location = new System.Drawing.Point(753, 24);
            this.ui_btnBlockPathOpen.Margin = new System.Windows.Forms.Padding(5, 5, 3, 5);
            this.ui_btnBlockPathOpen.Name = "ui_btnBlockPathOpen";
            this.ui_btnBlockPathOpen.Size = new System.Drawing.Size(50, 30);
            this.ui_btnBlockPathOpen.TabIndex = 24;
            this.ui_btnBlockPathOpen.Tag = "ui_tbBlockPath";
            this.ui_btnBlockPathOpen.Text = "Open";
            this.ui_btnBlockPathOpen.UseSelectable = true;
            // 
            // ui_btnEnvPathOpen
            // 
            this.ui_btnEnvPathOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ui_btnEnvPathOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ui_btnEnvPathOpen.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.ui_btnEnvPathOpen.Location = new System.Drawing.Point(753, 64);
            this.ui_btnEnvPathOpen.Margin = new System.Windows.Forms.Padding(5, 5, 3, 5);
            this.ui_btnEnvPathOpen.Name = "ui_btnEnvPathOpen";
            this.ui_btnEnvPathOpen.Size = new System.Drawing.Size(50, 30);
            this.ui_btnEnvPathOpen.TabIndex = 27;
            this.ui_btnEnvPathOpen.Tag = "ui_tbEnvPath";
            this.ui_btnEnvPathOpen.Text = "Open";
            this.ui_btnEnvPathOpen.UseSelectable = true;
            // 
            // ui_tbEnvPath
            // 
            this.ui_tbEnvPath.Font = new System.Drawing.Font("Verdana", 11F);
            this.ui_tbEnvPath.Location = new System.Drawing.Point(122, 64);
            this.ui_tbEnvPath.Margin = new System.Windows.Forms.Padding(5);
            this.ui_tbEnvPath.Name = "ui_tbEnvPath";
            this.ui_tbEnvPath.ReadOnly = true;
            this.ui_tbEnvPath.Size = new System.Drawing.Size(621, 30);
            this.ui_tbEnvPath.TabIndex = 25;
            // 
            // ui_lbEnvPath
            // 
            this.ui_lbEnvPath.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ui_lbEnvPath.Location = new System.Drawing.Point(20, 66);
            this.ui_lbEnvPath.Margin = new System.Windows.Forms.Padding(5);
            this.ui_lbEnvPath.Name = "ui_lbEnvPath";
            this.ui_lbEnvPath.Size = new System.Drawing.Size(80, 25);
            this.ui_lbEnvPath.TabIndex = 26;
            this.ui_lbEnvPath.Text = "Env Path";
            this.ui_lbEnvPath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ui_btnInterfacePathOpen
            // 
            this.ui_btnInterfacePathOpen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ui_btnInterfacePathOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ui_btnInterfacePathOpen.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.ui_btnInterfacePathOpen.Location = new System.Drawing.Point(753, 104);
            this.ui_btnInterfacePathOpen.Margin = new System.Windows.Forms.Padding(5, 5, 3, 5);
            this.ui_btnInterfacePathOpen.Name = "ui_btnInterfacePathOpen";
            this.ui_btnInterfacePathOpen.Size = new System.Drawing.Size(50, 30);
            this.ui_btnInterfacePathOpen.TabIndex = 30;
            this.ui_btnInterfacePathOpen.Tag = "ui_tbInterfacePath";
            this.ui_btnInterfacePathOpen.Text = "Open";
            this.ui_btnInterfacePathOpen.UseSelectable = true;
            // 
            // ui_tbInterfacePath
            // 
            this.ui_tbInterfacePath.Font = new System.Drawing.Font("Verdana", 11F);
            this.ui_tbInterfacePath.Location = new System.Drawing.Point(122, 104);
            this.ui_tbInterfacePath.Margin = new System.Windows.Forms.Padding(5);
            this.ui_tbInterfacePath.Name = "ui_tbInterfacePath";
            this.ui_tbInterfacePath.ReadOnly = true;
            this.ui_tbInterfacePath.Size = new System.Drawing.Size(621, 30);
            this.ui_tbInterfacePath.TabIndex = 28;
            // 
            // ui_lbInterfacePath
            // 
            this.ui_lbInterfacePath.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.ui_lbInterfacePath.Location = new System.Drawing.Point(20, 106);
            this.ui_lbInterfacePath.Margin = new System.Windows.Forms.Padding(5);
            this.ui_lbInterfacePath.Name = "ui_lbInterfacePath";
            this.ui_lbInterfacePath.Size = new System.Drawing.Size(80, 25);
            this.ui_lbInterfacePath.TabIndex = 29;
            this.ui_lbInterfacePath.Text = "Interface";
            this.ui_lbInterfacePath.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InterfaceHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.ui_panelMid);
            this.Controls.Add(this.ui_panelBtm);
            this.Controls.Add(this.ui_panelTop);
            this.Name = "InterfaceHelper";
            this.Size = new System.Drawing.Size(998, 748);
            this.ui_panelTop.ResumeLayout(false);
            this.ui_panelBtm.ResumeLayout(false);
            this.ui_panelBtm.PerformLayout();
            this.ui_panelTopLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel ui_panelTop;
        private MetroFramework.Controls.MetroPanel ui_panelBtm;
        private MetroFramework.Controls.MetroPanel ui_panelMid;
        private MetroFramework.Controls.MetroPanel ui_panelTopLeft;
        private MetroFramework.Controls.MetroLabel ui_lbBlock;
        private MetroFramework.Controls.MetroLabel ui_lbProject;
        private MetroFramework.Controls.MetroLabel ui_lbCustomer;
        private MetroFramework.Controls.MetroButton ui_btnConfirm;
        private System.Windows.Forms.ComboBox ui_cbCustomer;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox ui_tbBlockPath;
        private MetroFramework.Controls.MetroLabel ui_lbBlockPath;
        private MetroFramework.Controls.MetroButton ui_btnBlockPathOpen;
        private MetroFramework.Controls.MetroButton ui_btnInterfacePathOpen;
        private System.Windows.Forms.TextBox ui_tbInterfacePath;
        private MetroFramework.Controls.MetroLabel ui_lbInterfacePath;
        private MetroFramework.Controls.MetroButton ui_btnEnvPathOpen;
        private System.Windows.Forms.TextBox ui_tbEnvPath;
        private MetroFramework.Controls.MetroLabel ui_lbEnvPath;
    }
}
