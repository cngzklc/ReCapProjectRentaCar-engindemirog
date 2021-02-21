namespace RentaCarWfUI.Forms
{
    partial class Form_00_MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_00_MainScreen));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ProgramTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ProgramSettingsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ProgramExitTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowCascadeTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowTileHorizontallyTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowTileVerticallyTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.WindowCloseAllTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.TreeView = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuTSMI,
            this.ProgramTSMI,
            this.WindowTSMI});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.WindowTSMI;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1005, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuTSMI
            // 
            this.MenuTSMI.Image = ((System.Drawing.Image)(resources.GetObject("MenuTSMI.Image")));
            this.MenuTSMI.Name = "MenuTSMI";
            this.MenuTSMI.Size = new System.Drawing.Size(65, 20);
            this.MenuTSMI.Text = "Menu";
            this.MenuTSMI.Click += new System.EventHandler(this.MenuTSMI_Click);
            // 
            // ProgramTSMI
            // 
            this.ProgramTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgramSettingsTSMI,
            this.toolStripSeparator2,
            this.ProgramExitTSMI});
            this.ProgramTSMI.Name = "ProgramTSMI";
            this.ProgramTSMI.Size = new System.Drawing.Size(64, 20);
            this.ProgramTSMI.Text = "Program";
            // 
            // ProgramSettingsTSMI
            // 
            this.ProgramSettingsTSMI.Image = global::RentaCarWfUI.Properties.Resources.Gear;
            this.ProgramSettingsTSMI.Name = "ProgramSettingsTSMI";
            this.ProgramSettingsTSMI.Size = new System.Drawing.Size(180, 22);
            this.ProgramSettingsTSMI.Text = "Settings";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // ProgramExitTSMI
            // 
            this.ProgramExitTSMI.Image = global::RentaCarWfUI.Properties.Resources.Exit;
            this.ProgramExitTSMI.Name = "ProgramExitTSMI";
            this.ProgramExitTSMI.Size = new System.Drawing.Size(180, 22);
            this.ProgramExitTSMI.Text = "Exit";
            this.ProgramExitTSMI.Click += new System.EventHandler(this.ProgramExitTSMI_Click);
            // 
            // WindowTSMI
            // 
            this.WindowTSMI.Checked = true;
            this.WindowTSMI.CheckOnClick = true;
            this.WindowTSMI.CheckState = System.Windows.Forms.CheckState.Checked;
            this.WindowTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.WindowCascadeTSMI,
            this.WindowTileHorizontallyTSMI,
            this.WindowTileVerticallyTSMI,
            this.toolStripSeparator3,
            this.WindowCloseAllTSMI});
            this.WindowTSMI.Name = "WindowTSMI";
            this.WindowTSMI.Size = new System.Drawing.Size(64, 20);
            this.WindowTSMI.Text = "Window";
            // 
            // WindowCascadeTSMI
            // 
            this.WindowCascadeTSMI.Image = global::RentaCarWfUI.Properties.Resources.Cascade;
            this.WindowCascadeTSMI.Name = "WindowCascadeTSMI";
            this.WindowCascadeTSMI.Size = new System.Drawing.Size(180, 22);
            this.WindowCascadeTSMI.Text = "Cascade";
            this.WindowCascadeTSMI.Click += new System.EventHandler(this.WindowCascadeTSMI_Click);
            // 
            // WindowTileHorizontallyTSMI
            // 
            this.WindowTileHorizontallyTSMI.Image = global::RentaCarWfUI.Properties.Resources.Horizantal;
            this.WindowTileHorizontallyTSMI.Name = "WindowTileHorizontallyTSMI";
            this.WindowTileHorizontallyTSMI.Size = new System.Drawing.Size(180, 22);
            this.WindowTileHorizontallyTSMI.Text = "Tile Horizontally";
            this.WindowTileHorizontallyTSMI.Click += new System.EventHandler(this.WindowTileHorizontallyTSMI_Click);
            // 
            // WindowTileVerticallyTSMI
            // 
            this.WindowTileVerticallyTSMI.Image = global::RentaCarWfUI.Properties.Resources.Vertical;
            this.WindowTileVerticallyTSMI.Name = "WindowTileVerticallyTSMI";
            this.WindowTileVerticallyTSMI.Size = new System.Drawing.Size(180, 22);
            this.WindowTileVerticallyTSMI.Text = "Tile Vertically";
            this.WindowTileVerticallyTSMI.Click += new System.EventHandler(this.WindowTileVerticallyTSMI_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // WindowCloseAllTSMI
            // 
            this.WindowCloseAllTSMI.Image = global::RentaCarWfUI.Properties.Resources.Closeall;
            this.WindowCloseAllTSMI.Name = "WindowCloseAllTSMI";
            this.WindowCloseAllTSMI.Size = new System.Drawing.Size(180, 22);
            this.WindowCloseAllTSMI.Text = "Close All";
            this.WindowCloseAllTSMI.Click += new System.EventHandler(this.WindowCloseAllTSMI_Click);
            // 
            // TreeView
            // 
            this.TreeView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.TreeView.Location = new System.Drawing.Point(0, 24);
            this.TreeView.Name = "TreeView";
            this.TreeView.Size = new System.Drawing.Size(374, 572);
            this.TreeView.TabIndex = 9;
            this.TreeView.DoubleClick += new System.EventHandler(this.TreeView_DoubleClick);
            // 
            // Form_00_MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1005, 596);
            this.Controls.Add(this.TreeView);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Form_00_MainScreen";
            this.Text = "My CK Apps";
            this.Load += new System.EventHandler(this.Form_000_MainScreen_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuTSMI;
        private System.Windows.Forms.ToolStripMenuItem ProgramTSMI;
        private System.Windows.Forms.ToolStripMenuItem ProgramSettingsTSMI;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ProgramExitTSMI;
        private System.Windows.Forms.ToolStripMenuItem WindowTSMI;
        private System.Windows.Forms.ToolStripMenuItem WindowCascadeTSMI;
        private System.Windows.Forms.ToolStripMenuItem WindowTileHorizontallyTSMI;
        private System.Windows.Forms.ToolStripMenuItem WindowTileVerticallyTSMI;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem WindowCloseAllTSMI;
        private System.Windows.Forms.TreeView TreeView;
    }
}

