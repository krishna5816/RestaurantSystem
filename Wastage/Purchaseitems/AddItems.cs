using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.Wastage
{
    public partial class AddItems : Form
    {
        Model.ResturantManagementEntities db = new Model.ResturantManagementEntities();
        public AddItems()
        {
            InitializeComponent();
            foreach (var item in db.purchaseinvoiceitems.ToList())
            {
                comboBox_itemlist.Items.Add(item);
            }
        }

        private void AddItems_Load(object sender, EventArgs e)
        {

        }

        private void materialButton_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            var selitem = (comboBox_itemlist.SelectedItem as Wastage.Purchaseitems.ItemNameViwer).Item;
            var newbillitem = new Wastage.Purchaseitems.Viewer(selitem, betterTextBox_qty.decVal, betterTextBox_unit.Text,nepaliCalender_date.Datestamp);
            betterListView1.Items.Add(newbillitem);
          
        }
    }
}
