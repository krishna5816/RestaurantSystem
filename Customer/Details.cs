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
    public partial class Details : Form
    {
        int salesitem_id;
        public int id;
        public Details(int id)
        {
            InitializeComponent(); using (var db = Model.DatabaseConfigure.getConfigure())
            {
                var load = db.accounts.Find(id);
                id = load.id;
                name = load.name;
                address = load.address;
                phone = load.phone;
                email = load.email;
                pannumber = load.panno;
                dueamount = load.currentdue.Value;
                betterTextBox_dueamount.decVal = load.currentdue.Value;
                this.id = id;
            }
            using (var db = Model.DatabaseConfigure.getConfigure())
            {
                foreach (Model.bill listdata in db.bills.Where(o => o.cusotomer_id == id).ToList())
                {
                    var loaddata = new ListViewItem(new string[]
                     { sn.ToString(),listdata.id.ToString(), listdata.grosstotal.ToString(),listdata.discount.ToString(),listdata.tax_amount.ToString(),listdata.nettotal.ToString(),listdata.paidamount.ToString(),listdata.dueamount.ToString(),listdata.date.ToString()
                    });
                    betterListView1.Items.Add(loaddata);
                    sn += 1;
                    salesitem_id = listdata.id;
                }
            }
        }
        
        public string name
        {
            get
            {
                return label_name.Text;
            }
            set
            {
                label_name.Text = value;
            }
        }
        public string address
        {
            get
            {
                return label_address.Text;
            }
            set
            {
                label_address.Text = value;
            }
        }
        public string pannumber
        {
            get
            {
                return label_pan.Text;
            }
            set
            {
                label_pan.Text = value;
            }
        }
        public string phone
        {
            get
            {
                return label_phone.Text;
            }
            set
            {
                label_phone.Text = value;
            }
        }
        public string email
        {
            get
            {
                return label_Email.Text;

            }
            set
            {
                label_Email.Text = value;
            }
        }
        public decimal dueamount
        {
            get
            {
                return Convert.ToDecimal(label_dueamount.Text);
            }
            set
            {
                label_dueamount.Text = value.ToString();
            }
        }

        public void loadata(int id)
        {
            using (var db = Model.DatabaseConfigure.getConfigure())
            {
                var load = db.accounts.Find(id);
                id = load.id;
                name = load.name;
                address = load.address;
                phone = load.phone;
                email = load.email;
                pannumber = load.panno;
                dueamount = load.currentdue.Value;
                betterTextBox_dueamount.decVal = load.currentdue.Value;
            }
        }

        private void materialButton_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int sn = 1;
        private void materialButton_refresh_Click(object sender, EventArgs e)
        {
            using (var db = Model.DatabaseConfigure.getConfigure())
            {
                var list = db.bills.Find(id);
                var loaddata = new ListViewItem(new string[]
                {
                    sn.ToString(),list.grosstotal.ToString(),list.discount.ToString(),list.tax_amount.ToString(),list.nettotal.ToString(),
                    list.paidamount.ToString(),list.dueamount.ToString(),list.bill_Date
                });
            }
        }

        private void materialButton_paymentmode_Click(object sender, EventArgs e)
        {
            var payment = new Customer.PaymentMode(id);
            var trance = new CustomControls.Modal(payment);
            trance.Show();
        }

        private void betterListView1_DoubleClick(object sender, EventArgs e)
        {
            if (betterListView1.SelectedItems.Count > 0)
            {

                var listbillitem = new Customer.CustomerSalesItemlist(Convert.ToInt32(betterListView1.SelectedItems[0].SubItems[1] .Text));
                var trance = new CustomControls.Modal(listbillitem);
                trance.Show();
            }
        }
    }
}
