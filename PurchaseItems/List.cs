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
namespace RestaurantSystem.PurchaseItems
{
    public partial class List : Form
    {
        ResturantManagementEntities db = Model.DatabaseConfigure.getConfigure();
        public List()
        {
            
            InitializeComponent();
            foreach (var item in db.purchaseitems)
            {
                add(item);
            }
        }
        public void add(Model.purchaseitem purchaseitem)
        {
            var viwer = new PurchaseItems.Viwer();
            viwer.name = purchaseitem.name;
            viwer.unit = purchaseitem.unit;
            viwer.qty = purchaseitem.qty;
            viwer.category_id = purchaseitem.purchasecategory == null ? "":purchaseitem.purchasecategory.name;
            viwer.Dock = DockStyle.Top;
            panel_menuitem.Controls.Add(viwer);
        }

        private void materialButton_add_Click(object sender, EventArgs e)
        {
            var addnew = new PurchaseItems.Add();
            var trance = new CustomControls.Modal(addnew);
            addnew.adddata += Addnew_adddata;
            trance.Show();
        }

        private void Addnew_adddata(purchaseitem purchaseitem)
        {
            add(purchaseitem);
        }

        private void materialButton_cate_Click(object sender, EventArgs e)
        {
            var cate = new PurchaseCategories.List();
            var t = new CustomControls.Modal(cate);
            t.Show();
        }

        private void materialButton_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialButton_issuestock_Click(object sender, EventArgs e)
        {
            var issed = new IssueKitchen.Issuekitchenitems();
            var trance = new CustomControls.Modal(issed);
            trance.Show();
        }

        private void materialButton_refresh_Click(object sender, EventArgs e)
        {
                panel_menuitem.Controls.Clear();
                using(var db = DatabaseConfigure.getConfigure())
            {

                foreach (var item in db.purchaseitems)
                {
                add(item);
            }
            }
        }

        private void materialButton_addstock_Click(object sender, EventArgs e)
        {
            var addstock = new AddStock.AddKitchenStock();
            var t = new CustomControls.Modal(addstock);
            t.Show();
        }

        private void betterTextBox_search_TextChanged(object sender, EventArgs e)
        {
            foreach (Control p_item in panel_menuitem.Controls)
            {
                var p_itm = p_item as Viwer;
                if (p_itm.name.ToLower().Contains(betterTextBox_search.Text.ToLower()))
                {
                    p_itm.Show();
                }
                else
                {
                    p_itm.Hide();
                }
            }
        }
    }
}
