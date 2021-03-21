using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystem.Wastage
{
    public partial class Manu : Form
    {
        public Manu()
        {
            InitializeComponent();
        }

        private void materialButton_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            var add = new Wastage.Add();
            var t = new CustomControls.Modal(add);
            t.Show();
        }

        private void button_wastagefood_Click(object sender, EventArgs e)
        {
            var add = new Wastage.AddItems();
            var t = new CustomControls.Modal(add);
            t.Show();
        }
    }
}
