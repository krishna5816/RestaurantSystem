using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RestaurantSystem.PurchaseItems
{
    public partial class Edit : CustomControls.MaterialForm
    {
        Model.ResturantManagementEntities db = new Model.ResturantManagementEntities();
        public delegate void edithandler(Model.purchaseitem purchaseitem);
        public event edithandler  editdata;
        public Edit(int id)
        {
            InitializeComponent();
            foreach (var item in db.purchasecategories)
            {
                comboBox_cate.Items.Add(item);
            }
        }
        public void loaddata(int id)
        {
            var load = db.purchaseitems.Find(id);
            betterTextBox_name.Text = load.name;
            betterTextBox_currentstock.decVal = load.qty;
            betterTextBox_unit.Text = load.unit;
            comboBox_cate.Text = ((load.purchasecategory as Model.purchasecategory).name);
            this.id = id;

        }
        int id;
        private void materialButton_save_Click(object sender, EventArgs e)
        {
            var edit = db.purchaseitems.Find(id);
            edit.name = betterTextBox_name.Text;
            edit.qty = betterTextBox_currentstock.decVal;
            edit.unit = betterTextBox_unit.Text;
            edit.purchasecategory = ((comboBox_cate.SelectedItem as Model.purchasecategory));
            db.Entry(edit).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            editdata?.Invoke(edit);
            this.Close();

        }
    }
}
