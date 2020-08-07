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

namespace RestaurantSystem.Customer
{
    public partial class List : Form
    {
       Model.ResturantManagementEntities db = new ResturantManagementEntities();
        public List()
        {
            InitializeComponent();
            foreach(var item in db.accounts.ToList())
            {
                add(item);
            }
        }
        private void add(Model.account account)
        {
            var viwer = new Customer.Viwer();
            viwer.id = account.id;
            viwer.name = account.name;
            viwer.address = account.address;
            viwer.panno = account.panno;
            viwer.phone = account.phone;
            viwer.due = account.currentdue.Value;
            viwer.advance = account.currentadvance.Value;
            viwer.Dock = DockStyle.Top;
            flowLayoutPanel1.Controls.Add(viwer);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Add newitem = new Add();
            newitem.add += Newitem_savedata;
            var trans = new CustomControls.Modal(newitem);
            trans.Show();
            
        }
        private void Newitem_savedata(Model.account account)
        {
            add(account);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialButton_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void betterTextBox_search_TextChanged(object sender, EventArgs e)
        {
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                var c_list = c as Viwer;
                if (c_list.name.ToLower().Contains(betterTextBox_search.Text.ToLower()))
                {
                    c_list.Show();
                }
                else
                {
                    c_list.Hide();
                }
            }
        }
    }
}
