namespace PrjWinCsFinalProject
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStandardCal = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuScientificCal = new System.Windows.Forms.ToolStripMenuItem();
            this.exchangeOfficeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuLocal = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuOnline = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuToolbar = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuStatusbar = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuUserManual = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnStandard = new System.Windows.Forms.ToolStripButton();
            this.btnScientific = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1100, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculatorsToolStripMenuItem,
            this.exchangeOfficeToolStripMenuItem,
            this.toolStripSeparator2,
            this.MnuQuit});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // calculatorsToolStripMenuItem
            // 
            this.calculatorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuStandardCal,
            this.MnuScientificCal});
            this.calculatorsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("calculatorsToolStripMenuItem.Image")));
            this.calculatorsToolStripMenuItem.Name = "calculatorsToolStripMenuItem";
            this.calculatorsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.calculatorsToolStripMenuItem.Text = "Calculators";
            // 
            // MnuStandardCal
            // 
            this.MnuStandardCal.Name = "MnuStandardCal";
            this.MnuStandardCal.Size = new System.Drawing.Size(224, 26);
            this.MnuStandardCal.Text = "Standard Calculator";
            this.MnuStandardCal.Click += new System.EventHandler(this.MnuStandardCal_Click);
            // 
            // MnuScientificCal
            // 
            this.MnuScientificCal.Name = "MnuScientificCal";
            this.MnuScientificCal.Size = new System.Drawing.Size(224, 26);
            this.MnuScientificCal.Text = "Scientific Calculator";
            this.MnuScientificCal.Click += new System.EventHandler(this.MnuScientificCal_Click);
            // 
            // exchangeOfficeToolStripMenuItem
            // 
            this.exchangeOfficeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuLocal,
            this.MnuOnline});
            this.exchangeOfficeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exchangeOfficeToolStripMenuItem.Image")));
            this.exchangeOfficeToolStripMenuItem.Name = "exchangeOfficeToolStripMenuItem";
            this.exchangeOfficeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exchangeOfficeToolStripMenuItem.Text = "Exchange office";
            // 
            // MnuLocal
            // 
            this.MnuLocal.Name = "MnuLocal";
            this.MnuLocal.Size = new System.Drawing.Size(187, 26);
            this.MnuLocal.Text = "Local Version";
            // 
            // MnuOnline
            // 
            this.MnuOnline.Name = "MnuOnline";
            this.MnuOnline.Size = new System.Drawing.Size(187, 26);
            this.MnuOnline.Text = "Online Version";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // MnuQuit
            // 
            this.MnuQuit.Name = "MnuQuit";
            this.MnuQuit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.MnuQuit.Size = new System.Drawing.Size(224, 26);
            this.MnuQuit.Text = "Quit";
            this.MnuQuit.Click += new System.EventHandler(this.MnuQuit_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuToolbar,
            this.MnuStatusbar});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // MnuToolbar
            // 
            this.MnuToolbar.CheckOnClick = true;
            this.MnuToolbar.Name = "MnuToolbar";
            this.MnuToolbar.Size = new System.Drawing.Size(224, 26);
            this.MnuToolbar.Text = "Toolbar";
            this.MnuToolbar.Click += new System.EventHandler(this.MnuToolbar_Click);
            // 
            // MnuStatusbar
            // 
            this.MnuStatusbar.CheckOnClick = true;
            this.MnuStatusbar.Name = "MnuStatusbar";
            this.MnuStatusbar.Size = new System.Drawing.Size(224, 26);
            this.MnuStatusbar.Text = "StatusBar";
            this.MnuStatusbar.Click += new System.EventHandler(this.MnuStatusbar_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnuUserManual,
            this.toolStripSeparator1,
            this.MnuAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // MnuUserManual
            // 
            this.MnuUserManual.Image = ((System.Drawing.Image)(resources.GetObject("MnuUserManual.Image")));
            this.MnuUserManual.Name = "MnuUserManual";
            this.MnuUserManual.Size = new System.Drawing.Size(224, 26);
            this.MnuUserManual.Text = "User Manual";
            this.MnuUserManual.Click += new System.EventHandler(this.MnuUserManual_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // MnuAbout
            // 
            this.MnuAbout.Name = "MnuAbout";
            this.MnuAbout.Size = new System.Drawing.Size(224, 26);
            this.MnuAbout.Text = "About";
            this.MnuAbout.Click += new System.EventHandler(this.MnuAbout_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnStandard,
            this.btnScientific,
            this.toolStripButton3,
            this.toolStripSeparator3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1100, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnStandard
            // 
            this.btnStandard.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStandard.Image = ((System.Drawing.Image)(resources.GetObject("btnStandard.Image")));
            this.btnStandard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStandard.Name = "btnStandard";
            this.btnStandard.Size = new System.Drawing.Size(29, 24);
            this.btnStandard.Text = "toolStripButton1";
            this.btnStandard.Click += new System.EventHandler(this.btnStandard_Click);
            // 
            // btnScientific
            // 
            this.btnScientific.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnScientific.Image = ((System.Drawing.Image)(resources.GetObject("btnScientific.Image")));
            this.btnScientific.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnScientific.Name = "btnScientific";
            this.btnScientific.Size = new System.Drawing.Size(29, 24);
            this.btnScientific.Text = "toolStripButton2";
            this.btnScientific.Click += new System.EventHandler(this.btnScientific_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 536);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1100, 26);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel1.Text = "Status";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1100, 562);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Lasalle College 420-CT2-AS O. O. Programming";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculatorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuStandardCal;
        private System.Windows.Forms.ToolStripMenuItem MnuScientificCal;
        private System.Windows.Forms.ToolStripMenuItem exchangeOfficeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuLocal;
        private System.Windows.Forms.ToolStripMenuItem MnuOnline;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem MnuQuit;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuToolbar;
        private System.Windows.Forms.ToolStripMenuItem MnuStatusbar;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuUserManual;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MnuAbout;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnStandard;
        private System.Windows.Forms.ToolStripButton btnScientific;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}