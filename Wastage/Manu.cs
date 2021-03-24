using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControls;

namespace RestaurantSystem.Wastage
{
    public partial class Manu : Form
    {
        Model.ResturantManagementEntities db = Model.DatabaseConfigure.getConfigure();
        public Manu()
        {
            InitializeComponent();


        }


        private void materialButton_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
           
        }

        private void button_wastagefood_Click(object sender, EventArgs e)
        {
           
        }

        private void button_load_Click(object sender, EventArgs e)
        {

        }

        private void btn_purchaseitems_Click(object sender, EventArgs e)
        {
            var menu = new Wastage.Purchaseitems.List();
            menu.Show();
        }

        private void btn_menuitems_Click(object sender, EventArgs e)
        {
            var menu = new Wastage.Menuitems.List();
            menu.Show();
        }
    }
}