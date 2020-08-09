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
            var s = new Sales_Report();
            var t = new CustomControls.Modal(s);
            t.Show();
        }
    }
}
