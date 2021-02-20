using RentaCarBusiness.Concrete;
using RentaCarDataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentaCarWfUI.Forms
{
    public partial class EntitiesFormBase : Form
    {
        public EntitiesFormBase()
        {
            InitializeComponent();
        }

        protected virtual void BtnFirstRow_Click(object sender, EventArgs e)
        {

        }

        protected virtual void BtnPrevious_Click(object sender, EventArgs e)
        {

        }

        protected virtual void BtnNext_Click(object sender, EventArgs e)
        {

        }

        protected virtual void BtnLastRow_Click(object sender, EventArgs e)
        {

        }

        protected virtual void BtnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Save clikck!");
        }

        protected virtual void BtnAdd_Click(object sender, EventArgs e)
        {

        }

        protected virtual void BtnDelete_Click(object sender, EventArgs e)
        {

        }

        protected virtual void BtnFind_Click(object sender, EventArgs e)
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            //DgvTable.DataSource = brandManager.GetAll().Data;
        }

        protected virtual void BtnPercent_Click(object sender, EventArgs e)
        {

        }
        protected virtual void TbxId_TextChanged(object sender, EventArgs e)
        {

        }
        protected virtual void EntitiesFormBase_Load(object sender, EventArgs e)
        {

        }

    }
}
