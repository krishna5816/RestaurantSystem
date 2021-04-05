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
        int id;
        public Viwer(int id)
        {
            InitializeComponent();
            db = Model.DatabaseConfigure.getConfigure();
            using (var db = Model.DatabaseConfigure.getConfigure())
            {
                this.Counter = db.counters.Find(id);
                label_counter.Text = this.Counter.name;

            }
            nepaliCalender.Datestamp = INFO.currentdate;
            if (this.Counter.counterstatus == 1)
            {
                pictureBox.Image = Properties.Resources.Rms_connection_on;
            }
            else
            {
                pictureBox.Image = Properties.Resources.Rms_Connection_off;
            }

            refreshdailydata();
            this.id = id;
        }
        void refreshdailydata()
        {
            var date = nepaliCalender.Datestamp;
            var counter_id = this.Counter.id;

            if (db.counterstatuses.Count(o => o.date == nepaliCalender.Datestamp && o.counter_id == counter_id) > 0)
            {
                var counterstatus = db.counterstatuses.First(o => o.date == nepaliCalender.Datestamp && o.counter_id == counter_id);
                label_dailystatus.Text = INFO.counterstatuses[counterstatus.status];
                label_dailyrequestedAmount.Text = counterstatus.requestedamount.HasValue ? counterstatus.requestedamount.Value.ToString("0.##") : "---";
                label_dailyopeningamount.Text = counterstatus.approvedamount.HasValue ? counterstatus.approvedamount.Value.ToString("0.##") : "---";
                lbl_approvedamount.Text = counterstatus.approvedamount.HasValue? counterstatus.approvedamount.Value.ToString("0.##"):"---";
                label_dailystockamount.Text = counterstatus.currentstock.HasValue ? counterstatus.currentstock.Value.ToString("0.##") : "---";
                label_dailyclosingamount.Text = counterstatus.closeingamount.HasValue ? counterstatus.closeingamount.Value.ToString("0.##") : "---";
            }
            else
            {
                label_dailystatus.Text = "NOT IN USE";
                label_dailyrequestedAmount.Text = "---";
                label_dailyopeningamount.Text = "---";
                lbl_approvedamount.Text = "---";
                label_dailystockamount.Text = "---";
                label_dailyclosingamount.Text = "---";
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
                edit.edit += (counter) =>
                {
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

        private void materialButton_daily_detail_Click(object sender, EventArgs e)
        {
            var trasaction = new Counters.Transaction(id, nepaliCalender.Datestamp);
            var t = new CustomControls.Modal(trasaction);
            t.Show();

        }
    }
}
