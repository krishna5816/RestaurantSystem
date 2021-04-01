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
using RestaurantSystem.Model;
namespace RestaurantSystem.IssueKitchen
{
    public partial class List : Form
    {
        Model.ResturantManagementEntities db =Model.DatabaseConfigure.getConfigure();
        public List()
        {
            InitializeComponent();
            rangeSelector.comboBox_fy.Items.AddRange(db.fiscalyears.Select(o => new RangeSelector.FYViwer()
            {
                id = o.id,
                enddate = o.enddate,
                name = o.name,
                startdate = o.startdate
            }).ToArray());
        }

        private void betterListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label_totalamount_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialButton_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialButton_issuestock_Click(object sender, EventArgs e)
        {
            var s_i = new IssueKitchen.Issuekitchenitems();
            var t = new CustomControls.Modal(s_i);
            t.Show();
        }

        private void button_load_Click(object sender, EventArgs e)
        {
            var data = db.issueitems.Where(o => o.id > 0);
            if (!rangeSelector.valid)
            {
                Comformation.show(Text, "Please select a Duration", 1);
                return;
            }
            var r = rangeSelector.Range;
            var r1 = r[0];
            var r2 = r[1];

            var d = rangeSelector.DurationType;
            if (d == 1)
            {
                if (!rangeSelector.fyvalid)
                {
                    Comformation.show(Text, "Please select a Fiscalyear", 1);
                    return;
                }
                var fyid = rangeSelector.fy.id;
               // data = data.Where(o => o.fiscalyear_id == fyid);

            }
            else if (d == 5)
            {
                data = data.Where(o => o.date == r1);

            }
            else
            {
                data = data.Where(o => o.date >= r1 && o.date <= r2);

            }

            betterListView1.Clear();

            if (comboBox_grouping.SelectedIndex == 1)
            {
                GroupByItem(data.Select(o => o.id).ToList());
            }
            else if (comboBox_grouping.SelectedIndex == 2)
            {
                GroupByCategory(data.Select(o => o.id).ToList());
            }
            else if (comboBox_grouping.SelectedIndex == 3)
            {
            }
        }

        private void button_Reset_Click(object sender, EventArgs e)
        {
            betterListView1.Items.Clear();
        }
    }
}
