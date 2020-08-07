using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.Account.DaytoDay
{
    public partial class CurrentRequests : Form
    {
        public CurrentRequests()
        {
            InitializeComponent();
            this.Height = Screen.PrimaryScreen.Bounds.Height - 100;
            this.Width = Screen.PrimaryScreen.Bounds.Width - 100;
            this.Top = 50;
            this.Left = 50;
            var db = Model.DatabaseConfigure.getConfigure();
            foreach (var item in db.counterstatuses.Where(o => o.status == 0 && o.date == INFO.currentdate).ToList())
            {
                flowLayoutPanel1.Controls.Add(new Setting.DayManagement.CounterRequest(item.id));
            }
            
        }

        private void button_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
