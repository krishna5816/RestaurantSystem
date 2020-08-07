using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.Users
{
    public partial class List : Form
    {
        public delegate void addHandler(int id);
        public event addHandler add;
        public static List instance;
        Model.ResturantManagementEntities db;
        public List()
        {
            InitializeComponent();
            foreach (var item in RoleManagement.CurrentRole.rolename)
            {
                comboBox_roles.Items.Add(item);
            }
            db = Model.DatabaseConfigure.getConfigure();

            foreach (var user in db.admins.ToList())
            {
                flowLayoutPanel.Controls.Add(new Viwer(user.id));
            }



            instance = this;
            this.FormClosed += (o, e) =>
            {
                instance = null;
            };
        }

        public static void show(Panel p)
        {
            if (instance == null)
            {
                List newlist = new List();
                newlist.TopLevel = false;
                newlist.Dock = DockStyle.Fill;
                p.Controls.Add(newlist);
                newlist.Show();
                newlist.BringToFront();
            }
            else
            {
                instance.BringToFront();
            }
        }



        private void materialButton_close_Click(object sender, EventArgs e)
        {
            this.Close();


        }

        private void materialButton_addnew_Click(object sender, EventArgs e)
        {

            if (betterTextBox_username.Text.Trim() == "")
            {
                CustomControls.Alert.show("Add User", "Please Enter Username", 3000);
                return;
            }
            if (betterTextBox_password.Text.Trim() == "" || betterTextBox_retypepassword.Text.Trim() == "")
            {
                CustomControls.Alert.show("Add User", "Password Cannot be blank", 3000);
                return;
            }

            if (betterTextBox_password.Text.Trim() != betterTextBox_retypepassword.Text.Trim())
            {
                CustomControls.Alert.show("Add User", "Please Rematch the password", 3000);
                return;
            }

            if (comboBox_roles.SelectedIndex < 0)
            {
                CustomControls.Alert.show("Add User", "Please Select The Role", 3000);
                return;
            }
            var password= CustomControls.Encrypt.EncryptString(betterTextBox_password.Text.Trim(), "need12345");

            var user = new Model.admin()
            {
                name = betterTextBox_username.Text.Trim(),
                password = password,
                role = comboBox_roles.SelectedIndex,
                updated_at = DateTime.Now,
                created_at = DateTime.Now,
                enabled = true
            };
            db.admins.Add(user);
            db.SaveChanges();
            add?.Invoke(user.id);

            betterTextBox_username.Clear();
            betterTextBox_password.Clear();
            betterTextBox_retypepassword.Clear();
            comboBox_roles.SelectedIndex = -1;
            flowLayoutPanel.Controls.Add(new Viwer(user.id));
        }
    }
}
