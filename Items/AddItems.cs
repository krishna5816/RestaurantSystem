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

namespace RestaurantSystem.Items
{
   
    public partial class AddItems : Form
    {
        public  delegate void addhandler(Model.menuitem menuitem);
        public event addhandler adddata;
        Model.ResturantManagementEntities db = new ResturantManagementEntities();
        public AddItems()
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
       
        private void AddItems_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_category_Click(object sender, EventArgs e)
        { 
        }

        private void materialButton1_save_Click(object sender, EventArgs e)
        {
            if(betterTextBox1_name.Text.Trim()=="")
            {
                CustomControls.Alert.show("name","enter item name",1500);
                return;
            }
            if(betterTextBox1_price.Text.Trim()=="")
            {
                CustomControls.Alert.show("price", "enter price", 1200);
                return;
            }
            if (comboBox1_category.SelectedItem == null)
            {
                CustomControls.Alert.show("Categories", "select categories", 1200);
                return;
            }
            if (betterTextBox_unit.Text.Trim()=="")
            {
                CustomControls.Alert.show("Unit", "Please enter unit", 1200);
                return;
            }
            var db = Model.DatabaseConfigure.getConfigure();
            menuitem item = new menuitem()
            {
                name = betterTextBox1_name.Text,
                price = (betterTextBox1_price.decVal),
                unit = betterTextBox_unit.Text,
                category_id = ((comboBox1_category.SelectedItem as Model.category).id),
                estimated_by=betterTextBox_Estimateby.Text,
                qty=betterTextBox_qty.decVal,
                admin_id = INFO.admin_id,
                created_at = DateTime.Now,
                updated_at = DateTime.Now
            };
            db.menuitems.Add(item);
            db.SaveChanges();
            adddata?.Invoke(item);
            foreach (ListViewItem list in betterListView1.Items)
            {
                var purchaseitem_id = Convert.ToInt32(list.SubItems[5].Text);
                var qty = Convert.ToDecimal(list.SubItems[2].Text);
                
                Model.manufacturingestimation MC = new Model.manufacturingestimation()
                {
                    purchaseitem_id=purchaseitem_id,
                    menuitem_id = item.id,
                    quantity = qty,
                    unit=item.unit,
                    updated_at = DateTime.Now,
                    created_at = DateTime.Now
                };
                db.manufacturingestimations.Add(MC);
                db.SaveChanges();
            }
            this.Close();
        }

        private void betterTextBox1_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void betterTextBox1_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&&!char.IsLetter(e.KeyChar)&&!char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

       
        }

        private void betterTextBox1_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar)&&!char.IsDigit(e.KeyChar))
            {
                e.Handled=true;
            }


        }

        private void betterTextBox1_unit_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void betterTextBox1_unit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar)&&!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void materialButton_newitem_Click(object sender, EventArgs e)
        {
            var addnewitem = new PurchaseItems.Add();
            var trance = new CustomControls.Modal(addnewitem);
            trance.Show();
        }
        public int sn = 1;
        private void materialButton_Addtocart_Click(object sender, EventArgs e)
        {
            var selitem = (purchaseitem)comboBox_pitems.SelectedItem;
            decimal estimationcost;
            estimationcost = (selitem.price.Value / betterTextBox_qty.decVal);
            var listdata = new ListViewItem(new string[]
            {
                sn.ToString(),selitem.name,betterTextBox_qty.decVal.ToString(),selitem.price.ToString(),estimationcost.ToString(), selitem.id.ToString()
            });
            sn=sn+1;
            betterListView1.Items.Add(listdata);
            comboBox_pitems.SelectedIndex = -1;
            betterTextBox_qty.Clear();
        }

        private void comboBox_pitems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_pitems.SelectedIndex > -1)
            {
                var p_items = comboBox_pitems.SelectedItem as Model.purchaseitem;
                betterTextBox_unitforestimate.Text = p_items.unit;
            }
        }

        private void materialButton_loadestimate_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialButton_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
