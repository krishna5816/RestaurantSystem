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
    public partial class Edit : Form
    {
        public delegate void edithandler(Model.account account);
        public event edithandler edit;
        Model.ResturantManagementEntities db= new ResturantManagementEntities();
        int id;
        public Edit()
        {
            InitializeComponent();
           
        }

        private void materialButton_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            var editcustomer = db.accounts.Find(id);
            editcustomer.name = betterTextBox_name.Text;
            editcustomer.address = betterTextBox_address.Text;
            editcustomer.panno=betterTextBox_panno.Text;
            editcustomer.phone=betterTextBox_phone.Text;
            editcustomer.email = betterTextBox_email.Text;
            editcustomer.currentdue=betterTextBox_currentDue.decVal;
            editcustomer.currentadvance=betterTextBox_currentAdvance.decVal;
            editcustomer.nationlity=betterTextBox_nationality.Text;
            editcustomer.created_at = DateTime.Now;
            editcustomer.updated_at = DateTime.Now;
            editcustomer.admin_id = INFO.admin_id;
            db.Entry(editcustomer).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            edit?.Invoke(editcustomer);
            this.Close();

        }
        public void loaddata(int id)
        {
            account item = db.accounts.Find(id);
            betterTextBox_name.Text = item.name;
            betterTextBox_address.Text = item.address;
            betterTextBox_panno.Text = item.panno;
            betterTextBox_phone.Text = item.phone;
            betterTextBox_email.Text = item.email;
            betterTextBox_currentAdvance.Text = item.currentadvance.ToString();
            betterTextBox_currentDue.Text = item.currentdue.ToString();
            betterTextBox_nationality.Text = item.nationlity;
            this.id = id;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
