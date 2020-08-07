using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.Setting
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void materialButton_fiscalyear_Click(object sender, EventArgs e)
        {
            var fy = new FiscalYear.List();
            var t = new CustomControls.Modal(fy);
            t.Show();
        }

        private void materialButton_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
