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
    public partial class Add : Form
    {
        public delegate void addhandler(Model.account account);
        public event addhandler add;
        Model.ResturantManagementEntities db;


        public Add()
        {
            InitializeComponent();
            db = Model.DatabaseConfigure.getConfigure();
        }

        private void Add_Load(object sender, EventArgs e)
        {

        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (betterTextBox_name.Text.Trim() == "")
            {
                CustomControls.Alert.show("name", "enter item name", 1500);
                return;
            }

            if (betterTextBox_address.Text.Trim() == "")
            {
                CustomControls.Alert.show("address", "enter address", 1200);
                return;
            }
            if (betterTextBox_phone.Text.Trim() == "")
            {
                CustomControls.Alert.show("phone", "enter phone", 1500);
                return;
            }
            if (betterTextBox_email.Text.Trim() == "")
            {
                CustomControls.Alert.show("email", "enter email", 1500);
                return;
            }
                        
            if (betterTextBox_nationality.Text.Trim() == "")
            {
                CustomControls.Alert.show("nationality", "enter nationality", 1500);
                return;
            }
            account customer = new account();
            customer.name = betterTextBox_name.Text;
            customer.address = betterTextBox_address.Text;
            customer.email = betterTextBox_email.Text;
            customer.panno = betterTextBox_panno.Text;
            customer.phone = betterTextBox_phone.Text;
            customer.currentadvance = (betterTextBox_currentAdvance.decVal);
            customer.currentdue = (betterTextBox_currentdue.decVal);
            customer.nationlity = betterTextBox_nationality.Text;
            customer.admin_id = INFO.admin_id;
            customer.created_at = DateTime.Now;
            customer.updated_at = DateTime.Now;
            db.accounts.Add(customer);
            db.SaveChanges();
            add?.Invoke(customer);
            this.Close();
        }

        private void betterTextBox_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void betterTextBox_panno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void betterTextBox_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void betterTextBox_totaltransaction_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void betterTextBox_currentdue_KeyPress(object sender, KeyPressEventArgs e)
        {
                  }

        private void betterTextBox_currentAdvance_KeyPress(object sender, KeyPressEventArgs e)
        {
           }

        private void betterTextBox_nationality_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void materialButton_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

