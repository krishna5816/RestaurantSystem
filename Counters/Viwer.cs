using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.Counters
{
    public partial class Viwer : UserControl
    {
       
        Model.ResturantManagementEntities db;
        Model.counter Counter;
        public Viwer(int id)
        {
            InitializeComponent();
            nepaliCalender.Datestamp = INFO.currentdate;
            db = Model.DatabaseConfigure.getConfigure();
            this.Counter = db.counters.Find(id);
            label_counter.Text = this.Counter.name;
            if (this.Counter.counterstatus == 1)
            {
                pictureBox.Image = Properties.Resources.Rms_connection_on;
            }
            else
            {
                pictureBox.Image = Properties.Resources.Rms_Connection_off;
            }

            refreshdailydata();
            
        }

        void refreshdailydata()
        {
            var date = nepaliCalender.Datestamp;
            var counter_id = this.Counter.id;

            if(db.counterstatuses.Count(o => o.date == nepaliCalender.Datestamp && o.counter_id == counter_id) > 0)
            {
                var counterstatus= db.counterstatuses.First(o => o.date == nepaliCalender.Datestamp && o.counter_id == counter_id);
                label_dailystatus.Text = INFO.counterstatuses[counterstatus.status];
                label_dailyrequestedAmount.Text = counterstatus.requestedamount.Value.ToString();

                if(db.counteropenings.Count(o=>o.date==nepaliCalender.Datestamp && o.counter_id == counter_id) > 0)
                {
                    var counteropening = db.counteropenings.First(o => o.date == nepaliCalender.Datestamp && o.counter_id == counter_id);
                    label_dailyopeningamount.Text = counteropening.amount.Value.ToString();
                }
                else
                {
                    label_dailyopeningamount.Text = "---";
                }

                if (db.counterstocks.Count(o => o.date == nepaliCalender.Datestamp && o.counter_id == counter_id) > 0)
                {
                    var counterstock = db.counterstocks.First(o => o.date == nepaliCalender.Datestamp && o.counter_id == counter_id);
                    label_dailystockamount.Text = counterstock.amount.Value.ToString();
                }
                else
                {
                    label_dailystockamount.Text = "---";
                }
                if (db.counteropenings.Count(o => o.date == nepaliCalender.Datestamp && o.counter_id == counter_id) > 0)
                {
                    var counterclosing = db.counteropenings.First(o => o.date == nepaliCalender.Datestamp && o.counter_id == counter_id);
                    label_dailyclosingamount.Text = counterclosing.amount.Value.ToString();
                }
                else
                {
                    label_dailystockamount.Text = "---";
                }

            }
            else
            {
                label_dailystatus.Text = "---";
                label_dailyrequestedAmount.Text = "---";
            }

            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label_dailyrequestedAmount_Click(object sender, EventArgs e)
        {

        }

        private void nepaliCalender_dateChange(int year, int month, int day)
        {
            refreshdailydata();
        }

        private void materialButton_Edit_Click(object sender, EventArgs e)
        {
            if (Counter.counterstatus == 1)
            {
                CustomControls.Alert.show("Counter Viwer", "This Counter Is Currently Running, You Cannot Edit it.", 3000);

            }
            else
            {
                var edit = new Edit(this.Counter.id);
                edit.edit += (counter)=>{
                    db.Entry(this.Counter).Reload();

                };
                label_counter.Text = this.Counter.name;
                if (this.Counter.counterstatus == 1)
                {
                    pictureBox.Image = Properties.Resources.Rms_connection_on;
                }
                else
                {
                    pictureBox.Image = Properties.Resources.Rms_Connection_off;
                }
                CustomControls.Modal.Show(edit);
            }
        }
    }
}
