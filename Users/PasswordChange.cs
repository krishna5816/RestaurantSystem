using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RestaurantSystem.Users
{
    public partial class PasswordChange : CustomControls.MaterialForm
    {
        public Model.ResturantManagementEntities db;
        public int admin_id;
        public PasswordChange(int id)
        {
            InitializeComponent();
            db = Model.DatabaseConfigure.getConfigure();
            this.admin_id = id;

        }

        private void materialButton_save_Click(object sender, EventArgs e)
        {
            if (betterTextBox_password.Text.Trim() == "" || betterTextBox_retypepassword.Text.Trim() == "")
            {
                CustomControls.Alert.show("Password Change", "Password Cannot be blank", 3000);
                return;
            }

            if (betterTextBox_password.Text.Trim() != betterTextBox_retypepassword.Text.Trim() )
            {
                CustomControls.Alert.show("Password Change", "Please Rematch the password", 3000);
                return;
            }


            var user = db.admins.Find(this.admin_id);
            user.password = CustomControls.Encrypt.EncryptString(betterTextBox_password.Text.Trim(), "need12345");
            db.Entry(user).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            this.Close();
        }

        private void PAsswordChange_Save()
        {
            materialButton_save.PerformClick();
        }
    }
}
