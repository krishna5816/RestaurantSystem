using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.Counters
{
    public partial class CounterManager : Form
    {

        Model.ResturantManagementEntities db;
        public static CounterManager instance;

        public CounterManager()
        {
            InitializeComponent();
            db = Model.DatabaseConfigure.getConfigure();
            instance = this;
            this.FormClosed += (o, e) =>
            {
                instance = null;
            };

            foreach (var counter in db.counters.ToList())
            {
                flowLayoutPanel.Controls.Add(new Viwer(counter.id));

            }

        }

        public static void show(Panel p)
        {
            if (instance == null)
            {
                var newlist = new CounterManager();
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
            var addcounter = new AddCounter();
            addcounter.add += (counter) =>
            {
                flowLayoutPanel.Controls.Add(new Viwer(counter.id));
            };
            CustomControls.Modal.Show(addcounter);
        }

        private void materialButton_requests_Click(object sender, EventArgs e)
        {
            var nreq = new Account.DaytoDay.CurrentRequests();
            
            CustomControls.Modal.Show(nreq);
        }

        private void materialButton_close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void betterTextBox_search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
