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

namespace RestaurantSystem.Category
{
    public partial class List : Form
    {
        public List()
        {
            InitializeComponent();
            var db = new Model.ResturantManagementEntities();
            foreach (var id in db.categories.Select(o => o.id))
            {
                flowLayoutPanel1.Controls.Add(new Viwer(id));
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Add(new Viwer());
        }

        private void materialButton_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialButton_close_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
