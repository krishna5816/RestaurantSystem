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
    public partial class DashboardUserMenu : Form
    {
        public DashboardUserMenu()
        {
            InitializeComponent();
            this.Height = Screen.PrimaryScreen.Bounds.Height;
            this.Left = Screen.PrimaryScreen.Bounds.Width-this.Width;
            this.Top = 0;
            


        }

        


        private void materialButton2_closeX_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void pictureBox1_ParentChanged(object sender, EventArgs e)
        {

        }

        int time = 0;
        Pen p = new Pen(Brushes.Red, 3);
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            var r = e.ClipRectangle;
            g.FillClosedCurve(Brushes.Red, new Point[] { 
                new Point(0,r.Height),
               
                new Point(r.Width-30,0),
                new Point(r.Width,r.Height/6),
                new Point(r.Width,0),
                new Point(0,0)

            });

            
        }

        private void materialButton_setting_Click(object sender, EventArgs e)
        {
            var s = new Setting.Settings();
            var t = new CustomControls.Modal(s);
            t.Show();
        }
    }
}
