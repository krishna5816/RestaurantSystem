using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.Setting.DayManagement
{
    public partial class CounterRequest : UserControl
    {
        Model.ResturantManagementEntities db;
        Model.counterstatus Counterstatus;
        public CounterRequest(int id)
        {
            InitializeComponent();
            db = Model.DatabaseConfigure.getConfigure();
            Counterstatus = db.counterstatuses.Find(id);
            label_id.Text = "#" + Counterstatus.id.ToString("000");
            label_counterno.Text = Counterstatus.counter.name;
            label_amount.Text = Counterstatus.requestedamount.Value.ToString("0.##");
            betterTextBox_accecpted.decVal = Counterstatus.requestedamount.Value;

        }

        private void materialButton_accecptAmount_Click(object sender, EventArgs e)
        {
            if (betterTextBox_accecpted.decVal == 0)
            {
                CustomControls.Alert.show("Counter Management", "Accecpted Value Cannot Be Zero", 5000);
                return;
            }
            if(CustomControls.Comformation.show("Counter Management", "Please Check Following Detail are Correct:\n" +
                "1. Counter Number is " + label_counterno.Text + "\n" +
                "2. Requested Amount is " + label_amount.Text+"\n" +
                "3. Accecpted Amount is"+betterTextBox_accecpted.Text)== DialogResult.OK)
            {
                this.Counterstatus.approved = true;
                this.Counterstatus.status = 1;
                db.Entry(this.Counterstatus).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                var dayopen = new Model.counteropening()
                {
                    date = this.Counterstatus.date,
                    admin_id = INFO.admin_id,
                    state = 1,
                    updated_at=DateTime.Now,
                    created_at=DateTime.Now,
                    amount = betterTextBox_accecpted.decVal,
                    counter_id=this.Counterstatus.counter_id
                };

                var counterstock = new Model.counterstock()
                {
                    date = this.Counterstatus.date,
                    admin_id = INFO.admin_id,
                    state = 1,
                    updated_at = DateTime.Now,
                    created_at = DateTime.Now,
                    amount = betterTextBox_accecpted.decVal,
                    counter_id = this.Counterstatus.counter_id,
                    
                };
                db.counteropenings.Add(dayopen);
                db.counterstocks.Add(counterstock);
                db.SaveChanges();

                this.Parent.Controls.Remove(this);
            }

        }

        private void materialButton_cancel_Click(object sender, EventArgs e)
        {
            db.Entry(this.Counterstatus).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            this.Parent.Controls.Remove(this);
        }
    }
}
