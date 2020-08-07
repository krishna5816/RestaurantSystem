using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.PurchaseCategories
{
    public partial class List : Form
    {
        Model.ResturantManagementEntities db = new Model.ResturantManagementEntities();
        public List()
        {
            InitializeComponent();
            foreach (var item in db.purchasecategories.Select(o => o.id))
            {
                panel_menu.Controls.Add(new AddViwer(item));
            }
        }

        private void materialButton_Add_Click(object sender, EventArgs e)
        {
            panel_menu.Controls.Add(new AddViwer());
        }

        private void materialButton_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
