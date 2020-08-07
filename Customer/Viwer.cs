using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantSystem.Model;

namespace RestaurantSystem.Customer
{
    public partial class Viwer : UserControl
    {
       Model.ResturantManagementEntities db = new ResturantManagementEntities();
        public Viwer()
        {
            InitializeComponent();
        }
        public int id { get; set; }
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
       
        public string panno
        {
            get
            {
                return label_panno.Text;
            }
            set
            {
                label_panno.Text = value;
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

        public decimal advance
        {
            get
            {
                return Convert.ToDecimal(label_advance.Text);
            }
            set
            {
                label_advance.Text = value.ToString();
            }
        }
        public decimal due
        {
            get
            {
                return Convert.ToDecimal(label_due.Text);
            }
            set
            {
                label_due.Text = value.ToString();
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Viwer_Load(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            Edit edititem = new Edit();
            edititem.loaddata(this.id);
            edititem.edit += Edititem_editdata;
            var trans = new CustomControls.Modal(edititem);
            trans.Show();

        }

        private void Edititem_editdata(account account)
        {
            var viwer = new  Customer.Viwer();
            viwer.id = account.id;
            viwer.name = account.name;
            viwer.address = account.address;
        }

        private void Viwer_Load_1(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new Model.ResturantManagementEntities())
                {
                    var i = db.accounts.Find(id);
                    db.Entry(i).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                }
                this.Parent.Controls.Remove(this);
            }
            catch(Exception ex)
            {
                MessageBox.Show("not deleted");
            }
        }

        private void materialButton_details_Click(object sender, EventArgs e)
        {

           
            var details = new Customer.Details(this.id);
            var trance = new CustomControls.Modal(details);
            trance.ShowDialog();
          
        }
    }
}
