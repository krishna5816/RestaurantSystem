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
            RestaurantSystem.Wastage.Purchaseitems.Data.items = db.purchaseitems.ToList();
            var itms = db.purchaseitems.ToList();
            var item = itms.Select(o => new RestaurantSystem.Wastage.Purchaseitems.ItemNameViwer(o) { }).ToArray();
            comboBox_itemlist.Items.AddRange(item);
           
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
            foreach (var item in betterListView1.Items.Cast<Wastage.Purchaseitems.Viewer>().ToList())
            {
                item.save();
            }
            this.Close();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (comboBox_itemlist.SelectedIndex == -1)
            {
                CustomControls.Alert.show("Select", "Please select Foodlist or Itemlist item", 2000);
                return;
            }
            if (betterTextBox_qty.decVal == 0)
            {
                CustomControls.Alert.show("QTY", "Please Enter Qty", 2000);
                return;
            }
            if (betterTextBox_unit.Text.Trim() == "")
            {
                CustomControls.Alert.show("Unit", "Please Enter Unit of item", 2000);
                return;
            }
            var selitem = (comboBox_itemlist.SelectedItem as Wastage.Purchaseitems.ItemNameViwer).Item;
            IEnumerable<RestaurantSystem.Wastage.Purchaseitems.Viewer> itemslist = betterListView1.Items.Cast<RestaurantSystem.Wastage.Purchaseitems.Viewer>();
            var newbillitem = new Wastage.Purchaseitems.Viewer(selitem, betterTextBox_qty.decVal, betterTextBox_unit.Text,nepaliCalender_date.Datestamp);
            betterListView1.Items.Add(newbillitem);
            comboBox_itemlist.SelectedIndex = -1;
            betterTextBox_qty.decVal = 0;
            betterTextBox_unit.Clear();
        }

        private void comboBox_itemlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
