using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
namespace RestaurantSystem.Counters
{
    public partial class AddCounter : CustomControls.MaterialForm
    {
        Model.ResturantManagementEntities db;
        public delegate void addHandler(Model.counter counter);
        public event addHandler add;
        public AddCounter()
        {

            InitializeComponent();

        }

        private void materialButton_addnew_Click(object sender, EventArgs e)
        {
            if (betterTextBox_counterno.Text.Trim() == "")
            {
                INFO.ShowAlert(Text, "Please Enter Counter No", 3000);
                betterTextBox_counterno.Focus();
                return;
            }



            try
            {
                using (var db = Model.DatabaseConfigure.getConfigure())
                {

                    var counter = new Model.counter()
                    {
                        name = betterTextBox_counterno.Text,
                        counterstatus = -1,
                        created_at = DateTime.Now,
                        updated_at = DateTime.Now,
                        admin_id = INFO.admin_id

                    };
                    db.counters.Add(counter);
                    db.SaveChanges();
                    add?.Invoke(counter);
                }


                this.Close();

            }
            catch (Exception)
            {
                CustomControls.Alert.show("Error", "this data is not saved ", 1500);
            }


        }

        private void AddCounter_Save()
        {
            materialButton_addnew.PerformClick();
        }
    }
}
