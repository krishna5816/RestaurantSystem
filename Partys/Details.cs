using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.Party
{
    public partial class Details : Form
    {
        int id;
        int purchaseinvoiece_id;
        public Details(int id)
        {
            InitializeComponent();
            using (var db = Model.DatabaseConfigure.getConfigure())
            {
                var load = db.parties.Find(id);
                id = load.id;
                name = load.name;
                address = load.address;
                phone = load.phone;
                email = load.email;
                pannumber = load.pannumber;
                dueamount = load.due.Value;
                betterTextBox_dueamount.decVal = load.due.Value;
                this.id = id;
            }
            using (var db = Model.DatabaseConfigure.getConfigure())
            {
                foreach (Model.purchaseinvoice listdata in db.purchaseinvoices.Where(o => o.parties_id == id).ToList())
                {
                    var loaddata = new ListViewItem(new string[]
                     { sn.ToString(),listdata.id.ToString(), listdata.grosstotal.ToString(),listdata.discount.ToString(),listdata.tax.ToString(),listdata.nettotal.ToString(),listdata.paid.ToString(),listdata.due.ToString(),listdata.date.ToString()
                    });
                    betterListView1.Items.Add(loaddata);
                    sn += 1;
                    purchaseinvoiece_id = listdata.id;
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
           
            
        }
        
        private void materialButton_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int sn = 1;
        private void materialButton_refresh_Click(object sender, EventArgs e)
        {
            //using (var db = Model.DatabaseConfigure.getConfigure())
            //{
            //    var load = db.parties.Find(id);
            //    id = load.id;
            //    name = load.name;
            //    address = load.address;
            //    phone = load.phone;
            //    email = load.email;
            //    pannumber = load.pannumber;
            //    dueamount = load.due.Value;
            //    betterTextBox_dueamount.decVal = load.due.Value;
            //}
            //using (var db = Model.DatabaseConfigure.getConfigure())
            //{
            //    foreach (Model.purchaseinvoice listdata in db.purchaseinvoices.Where(o => o.parties_id == id).ToList())
            //    {
            //        var loaddata = new ListViewItem(new string[]
            //         { sn.ToString(),listdata.id.ToString(), listdata.grosstotal.ToString(),listdata.discount.ToString(),listdata.tax.ToString(),listdata.nettotal.ToString(),listdata.paid.ToString(),listdata.due.ToString(),listdata.date.ToString()
            //        });
            //        betterListView1.Items.Add(loaddata);
            //        sn += 1;
            //    }
            //}
        }

        private void materialButton_paymentmode_Click(object sender, EventArgs e)
        {
            var payment = new Partys.PaymentMode(id);
            var trace = new CustomControls.Modal(payment);
            trace.Show();
        }

        private void betterListView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
           
        }

        private void betterListView1_DoubleClick(object sender, EventArgs e)
        {
            if (betterListView1.SelectedItems.Count > 0)
            {
            var listitem = new Partys.PartyPurchasseitemList(Convert.ToInt32(betterListView1.SelectedItems[0].SubItems[1].Text));
            var tracne = new CustomControls.Modal(listitem);
            tracne.Show();

            }
        }
    }
}
