using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;
namespace RestaurantSystem.FiscalYear
{
    public partial class List : Form
    {
        Model.ResturantManagementEntities db;
        public static List instance;
        public List()
        {
            InitializeComponent();
            db = Model.DatabaseConfigure.getConfigure();
            foreach (var item in db.fiscalyears.Select(o=>o.id).ToList())
            {
                flowLayoutPanel.Controls.Add(new Viwer(item));
            }
            instance = this;
            this.FormClosed += (o, e) =>
            {
                instance = null;
            };
        }

        private void materialButton_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialButton_addnew_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Add(new Viwer());
        }

        public static void show(Panel p)
        {
            if (instance == null)
            {
                var newlist = new List();
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
    }
}
