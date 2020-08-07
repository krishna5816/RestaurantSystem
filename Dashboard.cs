using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControls;
namespace RestaurantSystem
{
    public partial class Dashboard : Form
    {
        public static Dashboard instance;
        DashboardUserMenu u = new DashboardUserMenu();

        public Dashboard()
        {
            InitializeComponent();
            label_username.Text = RoleManagement.CurrentRole.instance.roles.username;
            u.materialButton_logout.Click += materialButton2_logout_Click;
            u.materialButton_setting.Click += MaterialButton_setting_Click;
        }

        private void MaterialButton_setting_Click(object sender, EventArgs e)
        {
            
        }

        private void materialButton2_logout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialButton_Fiscalyear_Click(object sender, EventArgs e)
        {
            FiscalYear.List.show(panel_menu);
        }
        public string image = "";
        private void imageLoader1_Load(object sender, EventArgs e)
        {


        }

        private void materialButton_partiesmanage_Click(object sender, EventArgs e)
        {
            var p = new Parties.List();
            p.Dock = DockStyle.Fill;
            p.TopLevel = false;
            panel_menu.Controls.Add(p);
            p.Show();
            p.BringToFront();

        }

        private void materialButton_daymanage_Click(object sender, EventArgs e)
        {
            Setting.DayManagement.Daily_Setting.show(this.panel_menu);
        }

        private void materialButton_managecounter_Click(object sender, EventArgs e)
        {
            Counters.CounterManager.show(this.panel_menu);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void materialButton_categories_Click(object sender, EventArgs e)
        {
            var c = new Category.List();
            c.TopLevel = false;
            c.Dock = DockStyle.Fill;
            panel_menu.Controls.Add(c);
            c.Show();
            c.BringToFront();
        }

        private void materialButton_items_Click(object sender, EventArgs e)
        {
            var i = new Items.List();
            i.TopLevel = false;
            i.Dock = DockStyle.Fill;
            panel_menu.Controls.Add(i);
            i.Show();
            i.BringToFront();
        }

        private void materialButton_customers_Click(object sender, EventArgs e)
        {
            var i = new Customer.List();
            i.TopLevel = false;
            i.Dock = DockStyle.Fill;
            panel_menu.Controls.Add(i);
            i.Show();
            i.BringToFront();
        }

        private void materialButton_purchase_Click(object sender, EventArgs e)
        {
            var i = new PurchaseItems.List();
            i.TopLevel = false;
            i.Dock = DockStyle.Fill;
            panel_menu.Controls.Add(i);
            i.Show();
            i.BringToFront();
        }
        private void materialButton_kitchenstockitem_Click(object sender, EventArgs e)
        {
        }

        private void materialButton_managepitems_Click(object sender, EventArgs e)
        {
        }

        private void materialButton_reportlist_Click(object sender, EventArgs e)
        {
            var i = new Reports.ReportsList();
            i.TopLevel = false;
            i.Dock = DockStyle.Fill;
            panel_menu.Controls.Add(i);
            i.Show();
            i.BringToFront();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            label_username.Left = panel2.Width - label_username.Width - 50;
        }

        private void pictureBox_dashboardusermenu_Click(object sender, EventArgs e)
        {
            u.Show();
            u.BringToFront();
        }
    }
}