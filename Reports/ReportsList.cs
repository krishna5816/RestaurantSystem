using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantSystem.Model;
namespace RestaurantSystem.Reports
{
    public partial class ReportsList : Form
    {
        
        Model.ResturantManagementEntities db= new ResturantManagementEntities();
        public ReportsList()
        {
            InitializeComponent();

        }

        private void materialButton_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ReportsList_Load(object sender, EventArgs e)
        {

        }

        private void materialButton_salesreport_Click(object sender, EventArgs e)
        {
            var i = new Sales_Report();
            i.TopLevel = false;
            i.Dock = DockStyle.Fill;
            Dashboard.instance.panel_menu.Controls.Add(i);
            i.Show();
            i.BringToFront();

        }

        private void materialButton_close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialButton_purchasereport_Click(object sender, EventArgs e)
        {
            var p = new Purchase_Reports();
            p.TopLevel = false;
            p.Dock = DockStyle.Fill;
            Dashboard.instance.panel_menu.Controls.Add(p);
            p.Show();
            p.BringToFront();
        }
    }
}
