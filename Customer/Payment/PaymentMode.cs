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
    public partial class PaymentMode : Form
    {
        int id;
        public PaymentMode(int id)
        {
            InitializeComponent();
           using(var db= Model.DatabaseConfigure.getConfigure())
            {
                var loaddata = db.customers.Find(id);
                betterTextBox_Due.decVal = loaddata.currentdue.Value;
                name = loaddata.name;
                address = loaddata.address;
                phone = loaddata.phone;

            }
            this.id = id;
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
       
        private void materialButton_save_Click(object sender, EventArgs e)
        {

        }
           
        private void materialButton_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void betterTextBox_paid_TextChanged(object sender, EventArgs e)
        {
           // refresh();
        }

        private void betterTextBox_retrun_TextChanged(object sender, EventArgs e)
        {
            //refresh();
        }

        private void checkBo_bank_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void materialButton_add_Click(object sender, EventArgs e)
        {

            using(var db= Model.DatabaseConfigure.getConfigure())
            {
                customer_ledgers ledger = new customer_ledgers()
                {
                    date = INFO.currentdate,
                    amount = betterTextBox_amount.decVal,
                    due = betterTextBox_Due.decVal,
                    returnamount = betterTextBox_return.decVal,
                    type="CR",
                    customer_id=id,
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now,
                };
                db.customer_ledgers.Add(ledger);
                db.SaveChanges();
                this.Close();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
