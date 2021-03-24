using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantSystem.Model;
using CustomControls;
using System.Windows.Forms;
using System.Drawing;

namespace RestaurantSystem.Wastage.Menuitems
{

    public partial class List
    {
       
        private void GroupByitem(IQueryable<wastagefood>  wastagefoods)
        {
            betterListView1.AddColumns(new string[] { "Date", "Item", "Qty", "Unit" });
            foreach (var item in wastagefoods.ToList())
            {
                var b_list = new List<string>();
                b_list.Add(item.date.ToString());
                b_list.Add(item.menuitem.name.ToString());
                b_list.Add(item.qty.ToString());
                b_list.Add(item.unit.ToString());
                b_list.Add(item.id.ToString());
                betterListView1.Items.Add(new ListViewItem(b_list.ToArray()));
            }
        }
    }
}