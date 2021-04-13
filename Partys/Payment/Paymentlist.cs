using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.Partys.Payment
{
    public partial class Paymentlist : Form
    {
        Model.ResturantManagementEntities db = new Model.ResturantManagementEntities();
        public class PartyLedgerViwer
        {
            public int ID { get; set; }
            public string Date { get; set; }
            public string InvoiceNo { get; set; }
            public Decimal? Cr { get; set; }
            public Decimal? Dr { get; set; }
            public string Balance { get; set; }
        }
        List<PartyLedgerViwer> partyLedgerViwers;
        public int cu_id { get; set; }

        public int id;
        public Paymentlist(int id)
        {
            InitializeComponent();
            
                partyLedgerViwers = new List<PartyLedgerViwer>();
                var load = db.parties.Find(id);
                id = load.id;
                name = load.name;
                address = load.address;
                phone = load.phone;
                email = load.email;
                //pannumber = load.panno;
               

                this.id = id;
            
            using (var db = Model.DatabaseConfigure.getConfigure())
            {
                var ledgers = db.party_ledgers.Where(o => o.party_id == id).ToList();
                decimal balance = 0;

                foreach (var ledger in ledgers)
                {
                    var clv = new PartyLedgerViwer();
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
                        clv.Balance = (-1 * balance).ToString() + " CR";
                    }
                    else if (balance > 0)
                    {
                        clv.Balance = (balance).ToString() + " DR";

                    }
                    else
                    {
                        clv.Balance = "---";
                    }

                    partyLedgerViwers.Add(clv);
                }

                dataGridView1.DataSource = partyLedgerViwers;

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
       

        private void materialButton_AddPayment_Click(object sender, EventArgs e)
        {
            var payment = new Partys.Payment.AddPayment(id);
            var trace = new CustomControls.Modal(payment);
            trace.Show();
        }

        private void materialButton_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

