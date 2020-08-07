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
namespace RestaurantSystem.Parties
{
    public partial class AddParty : Form
    {
        public delegate void addHandler(Model.party party );
        public event addHandler adddata;
        public AddParty()
        {
            InitializeComponent();
            
        }
        
        private void materialButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Model.ResturantManagementEntities db = new ResturantManagementEntities();
        private void materialButton1_save_Click(object sender, EventArgs e)
        {
            if(betterTextBox1_name.Text.Trim()=="")
            {
                CustomControls.Alert.show(" Name", "Enter Party Name ",1500);
                return;
            }
            if(betterTextBox1_address.Text.Trim()=="")
            {
                CustomControls.Alert.show("Address", "Enter Party Address", 1500);
                return;
            }
            if(betterTextBox2_phone.Text.Trim()=="")
            {
                CustomControls.Alert.show("Phone", "Enter Party Phone", 1500);
                return;
            }
            if(betterTextBox11_panNumber.Text.Trim() == "")
            {
                CustomControls.Alert.show("Pan Number", "Enter Pan Number", 1500);
                return;
            }         
           
         
            try
            { 
            party i = new party()
            {
                name = betterTextBox1_name.Text,
                address = betterTextBox1_address.Text,
                phone = betterTextBox2_phone.Text,
                email = betterTextBox3_email.Text,
                postalcode = betterTextBox10_postalcode.Text,
                pannumber = betterTextBox11_panNumber.Text,
                advance = betterTextBox13_advance.decVal,
                due =betterTextBox12_deu.decVal,
                created_at = DateTime.Now,
                updated_at = DateTime.Now
                    };
            db.parties.Add(i);
            db.SaveChanges();
            adddata?.Invoke(i);
            this.Close();
             }
               
            
            catch(Exception ex)
            {
                MessageBox.Show("error");
            };
           
        }

        private void materialButton2_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void betterTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void betterTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void betterTextBox1_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void betterTextBox2_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void betterTextBox1_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void betterTextBox2_address_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void betterTextBox2_email_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void betterTextBox2_nationality_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void betterTextBox2_postalcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void betterTextBox2_panNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void betterTextBox2_advance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void betterTextBox12_deu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AddParty_Load(object sender, EventArgs e)
        {

        }
    }
}
