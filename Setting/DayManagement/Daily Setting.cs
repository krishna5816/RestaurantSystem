using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RestaurantSystem.Setting.DayManagement
{
    public partial class Daily_Setting : Form
    {
        Model.ResturantManagementEntities db;
        Model.systemsetting Systemsetting { get; set; }
        public static Daily_Setting instance;
        public Daily_Setting()
        {
            InitializeComponent();
            db = Model.DatabaseConfigure.getConfigure();
            if (db.systemsettings.Count() > 0)
            {
                this.Systemsetting = db.systemsettings.FirstOrDefault();
                refreshUI();
                
            }
            else
            {
                nepaliCalender.DateTime = DateTime.Now;
                materialButton_changeStatus.Text = "Open Day";
                materialButton_changeStatus.BackColor = Color.FromArgb(252, 65, 54);
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
                Daily_Setting newlist = new Daily_Setting();
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

        private void materialButton_changeStatus_Click(object sender, EventArgs e)
        {

        }

        private void refreshUI()
        {
            if (this.Systemsetting.dateopened)
            {
                nepaliCalender.Datestamp = this.Systemsetting.currentdate;
                materialButton_changeStatus.Text = "Close Day";
                materialButton_changeStatus.BackColor = Color.FromArgb(0, 122, 204);
                label_status.Text = "Day Opened";

            }
            else
            {
                nepaliCalender.DateTime = DateTime.Now;
                materialButton_changeStatus.Text = "Open Day";
                materialButton_changeStatus.BackColor = Color.FromArgb(252, 65, 54);
                label_status.Text = "Day Closed";
            }
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Daily_Setting_Load(object sender, EventArgs e)
        {
          
        }

        private void materialButton_changeStatus_Click_1(object sender, EventArgs e)
        {
            int opencountercount = db.counters.Count(o => o.counterstatus == 2);

            if (opencountercount > 0)
            {
                CustomControls.Comformation.show("Day Management", "Please Ensure That all Counter Have been Closed");
                return;
            }

            if (this.Systemsetting == null)
            {
                this.Systemsetting = new Model.systemsetting();
                this.Systemsetting.currentdate = nepaliCalender.Datestamp;
                this.Systemsetting.dateopened = true;
                db.systemsettings.Add(this.Systemsetting);
            }
            else
            {

                if (this.Systemsetting.dateopened)
                {
                    if (CustomControls.Comformation.show("Day Management", "Are You Sure, you want To Close Day") == DialogResult.Yes)
                    {
                        this.Systemsetting.dateopened = false;
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    if (CustomControls.Comformation.show("Day Management", "Check Following things-\n1.Date is Correct\nPress yes to Open Day ") == DialogResult.Yes)
                    {
                        this.Systemsetting.currentdate = nepaliCalender.Datestamp;
                        this.Systemsetting.dateopened = true;
                    }
                    else
                    {
                        return;
                    }
                }
                db.Entry(this.Systemsetting).State = System.Data.Entity.EntityState.Modified;
            }

            db.SaveChanges();
            refreshUI();

        }
    }
}
