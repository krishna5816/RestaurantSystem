﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantSystem.Model;

namespace RestaurantSystem.Items
{
    public partial class EditItems : Form
    {
        public delegate void edithandeler(Model.menuitem menuitem);
        public event edithandeler edit;
       Model.ResturantManagementEntities db = new ResturantManagementEntities();
        int id;
        public EditItems()
        {
            InitializeComponent();
            foreach (var item in db.categories.ToList())
            {
                comboBox1_category.Items.Add(item);
            }
            foreach (var pitem in db.purchaseitems.ToList())
            {
                comboBox_pitems.Items.Add(pitem);
            }

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditItems_Load(object sender, EventArgs e)
        {

        }

        public void loaddata(int id)
        {
            var item = db.menuitems.Find(id);
            betterTextBox1_name.Text = item.name;
            betterTextBox1_price.Text = item.price.ToString();
            betterTextBox1_unit.Text = item.unit;
            betterTextBox_Estimateby.Text = item.estimated_by;
            comboBox1_category.Text = ((item.category as Model.category).name);
            foreach (var mc in db.manufacturingestimations.Where(o => o.menuitem_id == id).ToList())
            {

                var loaddata = new ListViewItem(new string[]{ sn.ToString(), mc.purchaseitem.name, mc.quantity.ToString(),mc.id.ToString() });
                sn = sn + 1;
                betterListView1.Items.Add(loaddata);

            }
            this.id = id;
        }

        private void materialButton1_update_Click(object sender, EventArgs e)
        {
            try
            {

            var editdata = db.menuitems.Find(id);
            editdata.name = betterTextBox1_name.Text;
            editdata.price = (betterTextBox1_price.decVal);
            editdata.unit = betterTextBox1_unit.Text;
            editdata.category_id = ((comboBox1_category.SelectedItem as Model.category).id);
            editdata.admin_id = INFO.admin_id;
            editdata.estimated_by = betterTextBox_Estimateby.Text;
            editdata.updated_at = DateTime.Now;
            db.Entry(editdata).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();     
            edit?.Invoke(editdata);
            this.Close();

            }
            catch (Exception ex)
            {
                CustomControls.Alert.show("delete your estimated items", "please delete first your all estimate items and and add your new estimated items", 5000);
                return;
            }

        }

        private void betterTextBox1_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void betterTextBox1_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void betterTextBox1_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void betterTextBox1_unit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
                var sel = betterListView1.SelectedItems[0];
                int id =Convert.ToInt32(sel.SubItems[3].Text);
                var d = db.manufacturingestimations.Where(o => o.id ==id).First();
                db.Entry(d).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                betterListView1.Items.Remove(sel);         
        }
        int sn = 1;
        private void materialButton_Addtocart_Click(object sender, EventArgs e)
        {
            var selitem = (purchaseitem)comboBox_pitems.SelectedItem;

                Model.manufacturingestimation MC = new Model.manufacturingestimation()
                {
                    purchaseitem_id = selitem.id,
                    menuitem_id = id,
                    quantity = betterTextBox_qty.decVal,
                    updated_at = DateTime.Now,
                    created_at = DateTime.Now
                };
                db.manufacturingestimations.Add(MC);
                db.SaveChanges();
            comboBox_pitems.SelectedIndex = -1;
            betterTextBox_qty.Clear();

        }

        private void materialButton_newitem_Click(object sender, EventArgs e)
        {
            var addnewitem = new PurchaseItems.Add();
            var trance = new CustomControls.Modal(addnewitem);
            trance.Show();
        }

        private void materialButton_loadestimate_Click(object sender, EventArgs e)
        {
            betterListView1.Items.Clear();
            foreach (var mc in db.manufacturingestimations.Where(o => o.menuitem_id == id).ToList())
            {

                var loaddata = new ListViewItem(new string[] { sn.ToString(), mc.purchaseitem.name, mc.quantity.ToString(), mc.id.ToString() });
                sn = sn + 1;
                betterListView1.Items.Add(loaddata);

            }
        }
    }
}