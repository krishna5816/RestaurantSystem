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
    public partial class Edit: CustomControls.MaterialForm
    {
        public delegate void editHandler(Model.counter counter);
        public event editHandler edit;
        Model.ResturantManagementEntities db;
        Model.counter Counter;
        public Edit(int id)
        {
            InitializeComponent();
            db = Model.DatabaseConfigure.getConfigure();
            this.Counter = db.counters.Find(id);

        }

        private void materialButton_addnew_Click(object sender, EventArgs e)
        {
            if (betterTextBox_counterno.Text.Trim() == "")
            {
                INFO.ShowAlert(Text, "Please Enter Counter Name", 3000);
                betterTextBox_counterno.Focus();
                return;
            }           
            //try
            //{

            this.Counter.name = betterTextBox_counterno.Text;
            this.Counter.updated_at = DateTime.Now;
            this.Counter.created_at = DateTime.Now;
            db.Entry(this.Counter).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            edit?.Invoke(Counter);        
            this.Close();
            //}
            ////catch (Exception)
            //{

            //    CustomControls.Alert.show("Error", "data is not edited", 1500);
            //}


        }

        private void AddCounter_Save()
        {
            materialButton_addnew.PerformClick();
        }
    }
}
