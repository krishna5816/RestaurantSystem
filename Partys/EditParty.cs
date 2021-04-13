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
    public partial class EditParty : Form
    {
        public delegate void  edithandle(Model.party party);
        public event edithandle edit;
        int id;
        public EditParty()
        {
            InitializeComponent();
           
        }
        private void betterTextBox1_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void betterTextBox1_name_KeyPress(object sender, KeyEventArgs e)
        {
           
        }

        private void betterTextBox1_address_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void betterTextBox3_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void betterTextBox2_phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void betterTextBox4_nationality_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&&!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void betterTextBox10_postalcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar)&&!char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void betterTextBox11_panNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&&!char.IsLetter(e.KeyChar)&&!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void betterTextBox13_advance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void betterTextBox12_deu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar)&&!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void betterTextBox1_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        
        private void materialButton1_update_Click(object sender, EventArgs e)
        {
            if (betterTextBox1_name.Text.Trim() == "")
            {
                CustomControls.Alert.show(" Name", "Enter Party Name ", 1500);
            }
            if (betterTextBox1_address.Text.Trim() == "")
            {
                CustomControls.Alert.show("Address", "Enter Party Address", 1500);
            }
            if (betterTextBox2_phone.Text.Trim() == "")
            {
                CustomControls.Alert.show("Phone", "Enter Party Phone", 1500);
            }
            if (betterTextBox11_panNumber.Text.Trim() == "")
            {
                CustomControls.Alert.show("Pan Number", "Enter Pan Number", 1500);
            }
            if (betterTextBox10_postalcode.Text.Trim() == "")
            {
                CustomControls.Alert.show("Postal Code", "Enter Postal Code", 1500);
            }
            if (betterTextBox12_deu.Text.Trim() == "")
            {
                CustomControls.Alert.show("Deu", "Enter Deu ", 1500);
            }
            if (betterTextBox13_advance.Text.Trim() == "")
            {
                CustomControls.Alert.show("Advance", "Enter Advance", 1500);
            }
            if (betterTextBox3_email.Text.Trim() == "")
            {
                CustomControls.Alert.show("Email", "Enter Email", 1500);
            } 
               using(var db= new ResturantManagementEntities())
            {

                party ptr = db.parties.Where(o => o.id == id).First();
                ptr.name = betterTextBox1_name.Text;
                ptr.address = betterTextBox1_address.Text;
                ptr.phone = betterTextBox2_phone.Text;
                ptr.pannumber = betterTextBox11_panNumber.Text;
                ptr.postalcode = betterTextBox10_postalcode.Text;
                ptr.email = betterTextBox3_email.Text;
                ptr.due = Convert.ToDecimal(betterTextBox12_deu.Text);
                ptr.advance = Convert.ToDecimal(betterTextBox13_advance.Text);            
                db.Entry(ptr).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
               
        }
        public void loaddata(int id)
        {
            using(var db =new  Model.ResturantManagementEntities())
            {
            party prt = db.parties.Where(o => o.id == id).First();
            betterTextBox1_name.Text = prt.name;
            betterTextBox1_address.Text = prt.address;
            betterTextBox2_phone.Text = prt.phone;
            betterTextBox3_email.Text = prt.email;       
            betterTextBox10_postalcode.Text = prt.postalcode;
            betterTextBox11_panNumber.Text = prt.pannumber;
            betterTextBox12_deu.Text = prt.due.ToString();
            betterTextBox13_advance.Text = prt.advance.ToString();
           
            this.id = id;

            }
        }

        private void materialButton2_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditParty_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
