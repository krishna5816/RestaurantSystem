using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.Customer
{
    public partial class CustomerSalesItemlist : Form
    {
        int id;
        int sn = 1;
        public CustomerSalesItemlist(int id)
        {
            InitializeComponent();
            using (var db = Model.DatabaseConfigure.getConfigure())
            {
                foreach (var billitem in db.bills.Find(id).billitems.ToList())
                {
                    betterListView1.Items.Add(new ListViewItem(new string[]
                    {
                        sn.ToString(),id.ToString(),billitem.menuitem.name,billitem.qty.ToString(),
                        billitem.menuitem.price.ToString(),billitem.date.ToString()
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
