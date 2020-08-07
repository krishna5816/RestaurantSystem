using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.Items
{
    
    public partial class ItemDetails : Form
    {
        int sn = 1;
        Model.ResturantManagementEntities db = new Model.ResturantManagementEntities();
        public ItemDetails(int id)
        {
            InitializeComponent();
            var i = db.menuitems.Find(id);
            label_itemname.Text = i.name;
            label_price.Text = i.price.ToString();
            label_categories.Text = (i.category as Model.category).name;
            label_Estimatedby.Text = i.estimated_by;
            foreach (var mc in db.manufacturingestimations.Where(o => o.menuitem_id == id).ToList())
            {

                var loaddata = new ListViewItem(new string[] { mc.id.ToString(), mc.purchaseitem.name, mc.quantity.ToString() });
                betterListView1.Items.Add(loaddata);
               
                
            }
        }

        private void materialButton_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
