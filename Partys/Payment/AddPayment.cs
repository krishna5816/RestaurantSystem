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
namespace RestaurantSystem.Partys.Payment
{
    public partial class AddPayment : Form
    {
        public int id { get; set; }
        public AddPayment(int id)
        {
            InitializeComponent();
            using (var db = Model.DatabaseConfigure.getConfigure())
            {
                var loaddata = db.parties.Find(id);
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

        private void materialButton_add_Click(object sender, EventArgs e)
        {
            using (var db = Model.DatabaseConfigure.getConfigure())
            {

                party_ledgers ledger = new party_ledgers()
                {
                    date = INFO.currentdate,
                    amount = betterTextBox_amount.decVal,
                    type = "DR",
                    party_id = id,
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now,
                };
                db.party_ledgers.Add(ledger);
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


