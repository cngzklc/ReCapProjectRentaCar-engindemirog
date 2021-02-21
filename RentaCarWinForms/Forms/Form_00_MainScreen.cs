using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RentaCarWinForms.Forms
{
    public partial class Form_00_MainScreen : Form
    {
        public Form_00_MainScreen()
        {
            InitializeComponent();
        }
        private void OpenForm(Form openForm)
        {
            foreach (var item in this.MdiChildren)
            {
                if (item.GetType() == openForm.GetType())
                {
                    openForm.Dispose();
                    item.Show();
                    item.WindowState = FormWindowState.Normal;
                    return;
                }
            }
            openForm.MdiParent = this;
            openForm.Show();
        }
        private void Form_00_MainScreen_Load(object sender, EventArgs e)
        {
            TreeNode tNode;
            tNode = TreeView.Nodes.Add("Rent a Car Program");

            TreeView.Nodes[0].Nodes.Add("Entities");
            TreeView.Nodes[0].Nodes[0].Nodes.Add("Brand");
            TreeView.Nodes[0].Nodes[0].Nodes.Add("Color");
            TreeView.Nodes[0].Nodes[0].Nodes.Add("Car");

            TreeView.Nodes[0].Nodes.Add("Manager");
            TreeView.Nodes[0].Nodes[0].Nodes.Add("User");
            TreeView.Nodes[0].Nodes[0].Nodes.Add("Customer");

            TreeView.Nodes[0].Nodes.Add("Rental");
            TreeView.Nodes[0].Nodes[2].Nodes.Add("Rental Car");
        }

        private void MenuTSMI_Click(object sender, EventArgs e)
        {
            if (TreeView.Visible == false)
            { TreeView.Visible = true; }
            else
            { TreeView.Visible = false; }
        }
        private void ProgramExitTSMI_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void WindowTileHorizontallyTSMI_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
        private void WindowTileVerticallyTSMI_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
        private void WindowCascadeTSMI_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
        private void WindowCloseAllTSMI_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        private void TreeView_DoubleClick(object sender, EventArgs e)
        {
            switch (TreeView.SelectedNode.Text)
            {
                case "Brand":
                    OpenForm(new EntitiesFormBase());
                    break;
            }
            TreeView.Visible = false;
        }

        private void MainScreenMI_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
           // WindowTSMI.DropDownItems[0].Click += new EventHandler(this.WindowCascadeTSMI_Click);
           //MessageBox.Show( MainScreenMI.Items[0].Name);
            MainScreenMI.Items[0].Click += new EventHandler(MenuTSMI_Click);
        }
    }
}
