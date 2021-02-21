using RentaCarBusiness.Concrete;
using RentaCarDataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RentaCarWinForms.Forms
{
    public partial class EntitiesFormBase : Form
    {
        public EntitiesFormBase()
        {
            InitializeComponent();
        }

        private void EntitiesFormBase_Load(object sender, EventArgs e)
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            DgvTable.DataSource = brandManager.GetAll().Data;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
