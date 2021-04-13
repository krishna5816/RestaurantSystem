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
        Model.customer Customer;
        public class CustomerLedgerViwer
        {
            public int ID { get; set; }
            public string Date { get; set; }
            public string InvoiceNo { get; set; }
            public Decimal? Cr { get; set; }
            public Decimal? Dr { get; set; }
            public string Balance { get; set; }
        }
        List<CustomerLedgerViwer> customerLedgerViwers;
        public int cu_id { get; set; }

        public int id;
        public Details(int id)
        {
            InitializeComponent(); 
            using (var db = Model.DatabaseConfigure.getConfigure())
            {
                customerLedgerViwers = new List<CustomerLedgerViwer>();
                var load = db.customers.Find(id);
                id = load.id;
                name = load.name;
                address = load.address;
                phone = load.phone;
                email = load.email;
                //pannumber = load.panno;
               // dueamount = load.currentdue.Value;
                
                this.id = id;
            }
            using (var db = Model.DatabaseConfigure.getConfigure())
            {
                var ledgers = db.customer_ledgers.Where(o => o.customer_id == id).ToList();
                decimal balance = 0;

                foreach (var ledger in ledgers)
                {
                    var clv = new CustomerLedgerViwer();
                    clv.ID = ledger.id;
                    clv.Date = ledger.date.ToString();
                    clv.InvoiceNo = ledger.id.ToString();
                    if (ledger.type == "DR")
                    {
                        clv.Dr = ledger.amount;
                        balance += ledger.amount.Value;
                    }
                    else
                    {
                        clv.Cr = ledger.amount;
                        balance -= ledger.amount.Value;
                    }

                    if (balance < 0)
                    {
                        clv.Balance = (-1 * balance).ToString() + "CR";
                    }
                    else if (balance > 0)
                    {
                        clv.Balance = (balance).ToString() + "DR";

                    }
                    else
                    {
                        clv.Balance = "---";
                    }

                    customerLedgerViwers.Add(clv);
                }

                dataGridView1.DataSource = customerLedgerViwers;

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
        

        public void loadata(int id)
        {
            using (var db = Model.DatabaseConfigure.getConfigure())
            {
                var load = db.customers.Find(id);
                id = load.id;
                name = load.name;
                address = load.address;
                phone = load.phone;
                email = load.email;
              
               
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
                    list.paidamount.ToString(),list.dueamount.ToString(),//list.bill_Date
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
           
        }

        private void materialButton_AddPayment_Click(object sender, EventArgs e)
        {
            var payment = new Customer.PaymentMode(id);
            var t =new CustomControls.Modal(payment);
            t.Show();
        }
    }
}
