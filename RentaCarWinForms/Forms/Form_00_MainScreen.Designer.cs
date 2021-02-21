
namespace RentaCarWinForms.Forms
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
            this.MainScreenMI = new System.Windows.Forms.MenuStrip();
            this.MenuTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ProgramTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.WindowTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.CascadeTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.TileHorizontallyTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.TileVertically = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMIseperator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CloseAllTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.TreeView = new System.Windows.Forms.TreeView();
            this.MainScreenMI.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainScreenMI
            // 
            this.MainScreenMI.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.MainScreenMI.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MainScreenMI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuTSMI,
            this.ProgramTSMI,
            this.WindowTSMI});
            this.MainScreenMI.Location = new System.Drawing.Point(0, 0);
            this.MainScreenMI.Name = "MainScreenMI";
            this.MainScreenMI.Size = new System.Drawing.Size(800, 24);
            this.MainScreenMI.TabIndex = 1;
            this.MainScreenMI.Text = "menuStrip1";
            this.MainScreenMI.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MainScreenMI_ItemClicked);
            // 
            // MenuTSMI
            // 
            this.MenuTSMI.Name = "MenuTSMI";
            this.MenuTSMI.Size = new System.Drawing.Size(50, 20);
            this.MenuTSMI.Text = "Menu";
            // 
            // ProgramTSMI
            // 
            this.ProgramTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingsTSMI,
            this.ExitTSMI});
            this.ProgramTSMI.Name = "ProgramTSMI";
            this.ProgramTSMI.Size = new System.Drawing.Size(65, 20);
            this.ProgramTSMI.Text = "Program";
            // 
            // SettingsTSMI
            // 
            this.SettingsTSMI.Name = "SettingsTSMI";
            this.SettingsTSMI.Size = new System.Drawing.Size(116, 22);
            this.SettingsTSMI.Text = "Settings";
            // 
            // ExitTSMI
            // 
            this.ExitTSMI.Name = "ExitTSMI";
            this.ExitTSMI.Size = new System.Drawing.Size(116, 22);
            this.ExitTSMI.Text = "Exit";
            // 
            // WindowTSMI
            // 
            this.WindowTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CascadeTSMI,
            this.TileHorizontallyTSMI,
            this.TileVertically,
            this.TSMIseperator1,
            this.CloseAllTSMI});
            this.WindowTSMI.Name = "WindowTSMI";
            this.WindowTSMI.Size = new System.Drawing.Size(63, 20);
            this.WindowTSMI.Text = "Window";
            // 
            // CascadeTSMI
            // 
            this.CascadeTSMI.Name = "CascadeTSMI";
            this.CascadeTSMI.Size = new System.Drawing.Size(159, 22);
            this.CascadeTSMI.Text = "Cascade";
            // 
            // TileHorizontallyTSMI
            // 
            this.TileHorizontallyTSMI.Name = "TileHorizontallyTSMI";
            this.TileHorizontallyTSMI.Size = new System.Drawing.Size(159, 22);
            this.TileHorizontallyTSMI.Text = "Tile Horizontally";
            // 
            // TileVertically
            // 
            this.TileVertically.Name = "TileVertically";
            this.TileVertically.Size = new System.Drawing.Size(159, 22);
            this.TileVertically.Text = "Tile Vertically";
            // 
            // TSMIseperator1
            // 
            this.TSMIseperator1.Name = "TSMIseperator1";
            this.TSMIseperator1.Size = new System.Drawing.Size(156, 6);
            // 
            // CloseAllTSMI
            // 
            this.CloseAllTSMI.Name = "CloseAllTSMI";
            this.CloseAllTSMI.Size = new System.Drawing.Size(159, 22);
            this.CloseAllTSMI.Text = "Close All";
            // 
            // TreeView
            // 
            this.TreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.TreeView.Location = new System.Drawing.Point(0, 24);
            this.TreeView.Name = "TreeView";
            this.TreeView.Size = new System.Drawing.Size(260, 426);
            this.TreeView.TabIndex = 3;
            this.TreeView.DoubleClick += new System.EventHandler(this.TreeView_DoubleClick);
            // 
            // Form_00_MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TreeView);
            this.Controls.Add(this.MainScreenMI);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MainScreenMI;
            this.Name = "Form_00_MainScreen";
            this.Text = "Form_00_MainScreen";
            this.Load += new System.EventHandler(this.Form_00_MainScreen_Load);
            this.MainScreenMI.ResumeLayout(false);
            this.MainScreenMI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainScreenMI;
        private System.Windows.Forms.ToolStripMenuItem MenuTSMI;
        private System.Windows.Forms.ToolStripMenuItem ProgramTSMI;
        private System.Windows.Forms.ToolStripMenuItem WindowTSMI;
        private System.Windows.Forms.ToolStripMenuItem CascadeTSMI;
        private System.Windows.Forms.ToolStripMenuItem ExitTSMI;
        private System.Windows.Forms.ToolStripMenuItem TileHorizontallyTSMI;
        private System.Windows.Forms.ToolStripMenuItem TileVertically;
        private System.Windows.Forms.ToolStripSeparator TSMIseperator1;
        private System.Windows.Forms.ToolStripMenuItem CloseAllTSMI;
        private System.Windows.Forms.ToolStripMenuItem SettingsTSMI;
        private System.Windows.Forms.TreeView TreeView;
    }
}