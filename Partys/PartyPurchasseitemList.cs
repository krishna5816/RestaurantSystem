using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.Partys
{
    public partial class PartyPurchasseitemList : Form
    {
        int id;
        int sn = 1;
        public PartyPurchasseitemList(int id)
        {
            InitializeComponent();
            using(var db= Model.DatabaseConfigure.getConfigure())
            {
                foreach (var purchasitem in db.purchaseinvoices.Find(id).purchaseinvoiceitems.ToList())
                {
                    betterListView1.Items.Add(new ListViewItem(new string[]
                    {
                        sn.ToString(),purchasitem.purchaseinvoice_id.ToString(),purchasitem.purchaseitem.name,purchasitem.qty.ToString(),
                        purchasitem.price.ToString(),purchasitem.date.ToString()
                    }));
                    sn += 1;
                }
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
