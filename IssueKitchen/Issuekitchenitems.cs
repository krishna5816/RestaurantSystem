using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantSystem.Model;
namespace RestaurantSystem.IssueKitchen
{
    public partial class Issuekitchenitems : Form
    {
        ResturantManagementEntities db;
        public Issuekitchenitems()
        {

            InitializeComponent();
            db = Model.DatabaseConfigure.getConfigure();
            foreach (var purchaseitem in db.purchaseitems.ToList())
            {
                comboBox_itemlist.Items.Add(purchaseitem);
            }
        }
        int sn = 1;
        private void materialButton_addcart_Click(object sender, EventArgs e)
        {
            if (comboBox_itemlist.SelectedItem == null)
            {
                CustomControls.Alert.show("select items", "please select item", 2000);
                comboBox_itemlist.Focus();
                return;
            }
            if (betterTextBox_quantity.decVal ==0)
            {
                CustomControls.Alert.show("quantity", "please enter quantity", 2000);
                betterTextBox_quantity.Focus();
                return;
            }
            if (betterTextBox_quantity.decVal > betterTextBox_cuuremtstock.decVal)
            {
                CustomControls.Alert.show("not available", "your quantity is not available please", 2000);

                return;
            }
            var item = (purchaseitem)comboBox_itemlist.SelectedItem;
            var load = new ListViewItem(new string[]
            {
               sn.ToString(),item.purchasecategory.ToString(), item.name.ToString(),betterTextBox_quantity.decVal.ToString(),betterTextBox_unit.Text.ToString(),item.id.ToString()
            });
            betterListView1.Items.Add(load);
            betterTextBox_quantity.Clear();
            comboBox_itemlist.SelectedIndex = -1;
            betterTextBox_cuuremtstock.Clear();
            betterTextBox_unit.Clear();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (betterListView1.Items.Count == 0)
            {
                CustomControls.Alert.show("empty your item", "please select items and enter quntity", 2000);
                comboBox_itemlist.Focus();
                return;
            }
            if (betterTextBox_issuebye.Text.Trim() == "")
            {
                CustomControls.Alert.show("enter your nane", "please enter your name", 2000);
                betterTextBox_issuebye.Focus();
                return;

            }
            foreach (ListViewItem item in betterListView1.Items)
            {
                var quntity = Convert.ToDecimal(item.SubItems[3].Text);
                var item_id = Convert.ToInt32(item.SubItems[5].Text);
                var unit = item.SubItems[4].Text;
                var issueitem = db.purchaseitems.Find(item_id);
                issueitem.qty -= quntity;
                db.Entry(issueitem).State = System.Data.Entity.EntityState.Modified;
                Model.issueitem issue = new Model.issueitem()
                {
                    purchaseitem_id = item_id,
                    quantity = quntity,
                    units=unit,
                    issuedby = betterTextBox_issuebye.Text,
                    date=INFO.currentdate,
                    issuetime=DateTime.Now,
                    created_at=DateTime.Now,
                    updated_at=DateTime.Now,
                    admin_id=INFO.admin_id,
                    fiscalyear_id=INFO.currentFiscalYear.id
                   
                };
                db.issueitems.Add(issue);
                db.SaveChanges();
           }
            betterListView1.Items.Clear();
            betterTextBox_issuebye.Clear();
        }

        private void materialButton_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox_itemlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_itemlist.SelectedIndex > -1)
            {
                var sel = (purchaseitem)comboBox_itemlist.SelectedItem;
                using (var db = DatabaseConfigure.getConfigure())
                {
                    betterTextBox_cuuremtstock.decVal = db.purchaseitems.Find(sel.id).qty;
                    betterTextBox_unit.Text = db.purchaseitems.Find(sel.id).unit;

                }
               betterTextBox_quantity.Focus();
            }
        }

        private void betterListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem selitem in betterListView1.SelectedItems)
            {
                betterListView1.Items.Remove(selitem);
            }
        }
    }
}
