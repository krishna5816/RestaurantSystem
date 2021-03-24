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
    public partial class Add : Form
    {
        Model.ResturantManagementEntities db = new Model.ResturantManagementEntities();
        public Add()
        {
            InitializeComponent();
            RestaurantSystem.Wastage.Menuitems.Data.items = db.menuitems.ToList();
            var itms = db.menuitems.ToList();
            var item = itms.Select(o => new RestaurantSystem.Wastage.Menuitems.ItemNameViwer(o) { }).ToArray();
            comboBox_foodlist.Items.AddRange(item);
        }

        private void materialButton_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void materialButton_close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            if (comboBox_foodlist.SelectedIndex == -1)
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
            var selitem = (comboBox_foodlist.SelectedItem as Wastage.Menuitems.ItemNameViwer).Item;
            var newbillitem = new Wastage.Menuitems.Viewer(selitem, betterTextBox_qty.decVal, betterTextBox_unit.Text, nepaliCalender_date.Datestamp);
            betterListView1.Items.Add(newbillitem);
            comboBox_foodlist.SelectedIndex = -1;
            betterTextBox_qty.decVal = 0;
            betterTextBox_unit.Clear();


        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            foreach (var item in betterListView1.Items.Cast<Wastage.Menuitems.Viewer>().ToList())
            {
                item.save();

            }
        }
    }
}
