using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RestaurantSystem.PurchaseItems
{
    public partial class Add : CustomControls.MaterialForm
    {
        public delegate void addhandler(Model.purchaseitem purchaseitem);
        public event addhandler adddata;
        Model.ResturantManagementEntities db = new Model.ResturantManagementEntities();
        public Add()
        {
            InitializeComponent();
            foreach (var item in db.purchasecategories.ToList())
            {
                comboBox_cate.Items.Add(item);
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (betterTextBox_name.Text.Trim() == "")
            {
                CustomControls.Alert.show("", "Please Enter Purchase Item Name", 1500);
                return;
            }
            if (comboBox_cate.SelectedItem == null)
            {
                CustomControls.Alert.show("", "please Select Category of Item", 1500);
                return;
            }
            using (var db = Model.DatabaseConfigure.getConfigure()) ;
            var newpitem = new Model.purchaseitem()
            {
                name = betterTextBox_name.Text,
                price = betterTextBox_name.decVal,
                purchase_Cat_id = ((comboBox_cate.SelectedItem as Model.purchasecategory).id),
                qty = betterTextBox_currentstock.decVal,
                created_at = DateTime.Now,
                updated_at = DateTime.Now,
                admin_id = INFO.admin_id,

            };
            db.purchaseitems.Add(newpitem);
            db.SaveChanges();
            adddata?.Invoke(newpitem);
        }
    }
}
