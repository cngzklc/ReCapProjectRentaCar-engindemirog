using System;
using System.Windows.Forms;

namespace RentaCarWfUI.Forms
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
        private void Form_000_MainScreen_Load(object sender, EventArgs e)
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

            //TreeView.Nodes[0].Nodes.Add("Desktop Apps");
            //TreeView.Nodes[0].Nodes[3].Nodes.Add("File Search");
            //TreeView.Nodes[0].Nodes[3].Nodes.Add("File Rename");
            //TreeView.Nodes[0].Nodes[3].Nodes.Add("Get File and Folder List");
            //TreeView.Nodes[0].Nodes[3].Nodes.Add("Text Length");
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
    }
}
