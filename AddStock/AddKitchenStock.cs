using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantSystem.Model;
namespace RestaurantSystem.AddStock
{
    public partial class AddKitchenStock : Form
    {
        Model.ResturantManagementEntities db = new ResturantManagementEntities();
        int purchase_id;
        public AddKitchenStock()
        {
            InitializeComponent();
            foreach (var pitem in db.purchaseitems.ToList())
            {
                comboBox_itemlist.Items.Add(pitem);

            }
            foreach (var partylist in db.parties.ToList())
            {
                comboBox_party.Items.Add(partylist);
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
        decimal total;
        private void comboBox_itemlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            betterTextBox_quantity.Focus();
        }
        private void materialButton_cate_Click(object sender, EventArgs e)
        {
            var newcate = new PurchaseCategories.List();
            var trance = new CustomControls.Modal(newcate);
            trance.Show();
        }

        private void materialButton_newitem_Click(object sender, EventArgs e)
        {
            var newitm = new PurchaseItems.List();
            var trance = new CustomControls.Modal(newitm);
            trance.Show();
        }

        private void checkBox_party_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_party.Checked == true)
            {
                panel_party.Enabled = true;
            }
            else
            {
                panel_party.Enabled = false;
            }
        }

        private void comboBox_party_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_party.SelectedIndex > -1)
            {
                var sel = (party)comboBox_party.SelectedItem;
                using (var db = DatabaseConfigure.getConfigure())
                {
                    betterTextBox_partyphone.Text = db.parties.Find(sel.id).phone;
                    betterTextBox_partypan.Text = db.parties.Find(sel.id).pannumber;
                    betterTextBox_advance.decVal = db.parties.Find(sel.id).advance.Value;
                }
                betterTextBox_quantity.Focus();
            }
            var party_Details = (party)comboBox_party.SelectedItem;
          

        }

        private void materialButton_newparty_Click(object sender, EventArgs e)
        {
            var newparty = new Parties.List();
            var trance = new CustomControls.Modal(newparty);
            trance.Show();
        }

        private void materialButton_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int sn = 1;
        private void materialButton_addcart_Click(object sender, EventArgs e)
        {
            if (comboBox_itemlist.Text == null)
            {
                CustomControls.Alert.show("Item", "select purchase items", 2000);
                return;
            }
            if (betterTextBox_quantity.decVal == 0)
            {
                CustomControls.Alert.show("Item", "enter purchase quantity", 2000);
                return;
            }
            if (betterTextBox_rate.decVal == 0)
            {
                CustomControls.Alert.show("Item", "enter purchase rate", 2000);
                return;
            }
            var selitm = (purchaseitem)comboBox_itemlist.SelectedItem;
            decimal total;

            total = (betterTextBox_rate.decVal * betterTextBox_quantity.decVal);
            betterListView1.Items.Add(new ListViewItem(new string[]
            { sn.ToString(), selitm.name, selitm.purchasecategory.name, betterTextBox_quantity.decVal.ToString(), betterTextBox_rate.decVal.ToString(), total.ToString(),selitm.id.ToString()
            }));
            sn += 1;
            betterTextBox_grosstotal.decVal += total;
            comboBox_itemlist.SelectedIndex = -1;
            betterTextBox_quantity.Clear();
            betterTextBox_rate.Clear();
            refresstock();
        }

        private void betterTextBox_quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void betterTextBox_total_TextChanged(object sender, EventArgs e)
        {

        }
        public void refresstock()
        {

            if (betterTextBox_discount.decVal > betterTextBox_grosstotal.decVal)
            {
                betterTextBox_discount.decVal = betterTextBox_grosstotal.decVal;
            }

            betterTextBox_nettotal.decVal = betterTextBox_grosstotal.decVal - betterTextBox_discount.decVal + betterTextBox_Tax.decVal;
            if (betterTextBox_paid.decVal > betterTextBox_nettotal.decVal)
            {
                betterTextBox_Due.decVal = 0;
                betterTextBox_Return.decVal = betterTextBox_paid.decVal - betterTextBox_nettotal.decVal;

            }
            else
            {

                betterTextBox_Due.decVal = betterTextBox_nettotal.decVal - betterTextBox_paid.decVal;
                betterTextBox_Return.decVal = 0;
            }


        }

        private void betterTextBox_rate_TextChanged_1(object sender, EventArgs e)
        {
            refresstock();
        }

        private void materialButton_save_Click(object sender, EventArgs e)
        {
            if (betterListView1.Items == null)
            {
                CustomControls.Alert.show("Empty Items", "Please selcet item and enter price and quantity",3000);
                return;
            }
          
           Model.purchaseinvoice addnew = new Model.purchaseinvoice()
            {
                grosstotal = betterTextBox_grosstotal.decVal,
                discount = betterTextBox_discount.decVal,
                tax = betterTextBox_Tax.decVal,
                nettotal = betterTextBox_nettotal.decVal,
                due = betterTextBox_Due.decVal,
                paid = betterTextBox_paid.decVal,
                fiscalyear_id = INFO.currentFiscalYear.id,
                admin_id = INFO.admin_id,
                created_at = DateTime.Now,
                updated_at = DateTime.Now,
                date=INFO.currentdate
                
            };
           
            if (checkBox_party.Checked)
            {
                if (comboBox_party.SelectedIndex < 0)
                {
                    CustomControls.Alert.show("", "select party", 2000);
                    return;
                }
                var venderdata = (party)comboBox_party.SelectedItem;
                addnew.parties_id = venderdata.id;
                var vender = db.parties.Where(o => o.id == venderdata.id).First();
                if (checkBox_advance.Checked)
                {
                    if (betterTextBox_advance.decVal > vender.advance)
                    {
                        vender.advance = 0;
                    }
                    else
                    {
                        vender.advance -= betterTextBox_advance.decVal;
                    }
                }
                if (betterTextBox_Due.decVal > 0)
                {
                    if (checkBox_advance.Checked)
                    {
                        if (betterTextBox_advance.decVal >= betterTextBox_Due.decVal)
                        {
                            betterTextBox_Due.decVal = 0;
                        }
                        else
                        {
                            betterTextBox_Due.decVal -= betterTextBox_advance.decVal;
                        }
                    }
                    vender.due += betterTextBox_Due.decVal;
                    db.Entry(vender).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
               
            }
            db.purchaseinvoices.Add(addnew);
            db.SaveChanges();
            purchase_id = addnew.id;
            foreach (ListViewItem item in betterListView1.Items)
                {
                 
                    var quantity = Convert.ToDecimal(item.SubItems[3].Text);
                    var rate = Convert.ToInt32(item.SubItems[4].Text);
                    var total = Convert.ToInt32(item.SubItems[5].Text);
                    var item_id = Convert.ToInt32(item.SubItems[6].Text);
                    var purchase_item = db.purchaseitems.Find(item_id);
                    purchase_item.qty += quantity;
                    db.Entry(purchase_item).State = System.Data.Entity.EntityState.Modified;
                    purchaseinvoiceitem newstock = new purchaseinvoiceitem()
                    {
                        purchaseitems_id = item_id,
                        price = rate,
                        qty = quantity,
                        purchaseinvoice_id = purchase_id,                    
                        admin_id = INFO.admin_id,
                        updated_at = DateTime.Now,
                        created_at = DateTime.Now,

                    };
                    db.purchaseinvoiceitems.Add(newstock);
                    db.SaveChanges();
                }
            foreach (ListViewItem item in betterListView_Exp.Items)
            {
                var item_name = item.SubItems[0].Text;
                var amount =Convert.ToDecimal( item.SubItems[1].Text);

                purchseexpens  exp= new Model.purchseexpens()
                {
                   purchaseinvoice_id = purchase_id,
                    name = item_name,
                    amount =  amount,
                    date = INFO.currentdate,
                    admin_id = INFO.admin_id,
                    updated_at = DateTime.Now,
                    created_at = DateTime.Now
                };
                db.purchseexpenses.Add(exp);
                db.SaveChanges();
            }
            betterListView1.Items.Clear();
            betterListView_Exp.Items.Clear();
                if (checkBox_party.Checked) 
                {
                    comboBox_party.SelectedIndex = -1;
                }
            betterTextBox_rate.Clear();
            betterTextBox_quantity.Clear();
            betterTextBox_grosstotal.Clear();
            betterTextBox_discount.Clear();
            betterTextBox_Tax.Clear();
            betterTextBox_Due.Clear();
            betterTextBox_paid.Clear();
            betterTextBox_Return.Clear();


        }

        private void betterListView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void materialButton_Addexp_Click(object sender, EventArgs e)
        {
            if (betterTextBox_name.Text.Trim() == "")
            {
                CustomControls.Alert.show("", "please enter expenses title", 2000);
                return;
            }
            if (betterTextBox_amount.decVal == 0 && betterTextBox_amount.Text == null)
            {
                CustomControls.Alert.show("", "please enter expenses amount", 2000);
                return;
            }

            var load = new ListViewItem(new string[]
            {
               betterTextBox_name.Text,betterTextBox_amount.decVal.ToString()
            });
            betterListView_Exp.Items.Add(load);
            betterTextBox_name.Clear();
            betterTextBox_amount.Clear();
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem sel in betterListView1.SelectedItems)
            {
                betterListView1.Items.Remove(sel);
                decimal total=Convert.ToDecimal(sel.SubItems[5].Text);
                betterTextBox_grosstotal.decVal= betterTextBox_grosstotal.decVal - total;
            }
        }

        private void removeToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            foreach (ListViewItem sel in betterListView_Exp.SelectedItems)
            {
                betterListView_Exp.Items.Remove(sel);
            }
        }
    }
}
