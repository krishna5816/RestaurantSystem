using System;
using System.Drawing;
using System.Windows.Forms;

namespace RestaurantSystem.Users
{
    public partial class Viwer : UserControl
    {
        Model.ResturantManagementEntities db;
        Model.admin user;
        bool init;
        public Viwer(int id)
        {
            InitializeComponent();
            db = Model.DatabaseConfigure.getConfigure();
            this.ForeColor = Color.Black;

            this.user = db.admins.Find(id);
            label_username.Text = this.user.name;
            label_role.Text = RoleManagement.CurrentRole.rolename[this.user.role];
            checkBox_enabled.Checked = this.user.enabled;
            checkColor();
            init = true;
        }

        private void Viwer_Load(object sender, EventArgs e)
        {

        }

        private void materialButton_ChangePassword_Click(object sender, EventArgs e)
        {
            CustomControls.Modal.Show(new PasswordChange(this.user.id));
        }

        private void checkBox_enabled_CheckedChanged(object sender, EventArgs e)
        {
            if (init)
            {
                if (this.user.name == "Admin")
                {
                    CustomControls.Alert.show("Manage Users", "This is primary Account You Cannot Edit This Account", 4000);
                    return;
                }
                this.user.enabled = checkBox_enabled.Checked;
                db.Entry(this.user).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                checkColor();

            }

        }

        void checkColor()
        {
            if (checkBox_enabled.Checked)
            {
                this.BackColor = Color.FromArgb(0, 122, 204);
            }
            else
            {
                this.BackColor = Color.FromArgb(253, 76, 63);
            }
            panel_fill.BackColor = Color.White;
        }


    }
}
