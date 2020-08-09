using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantSystem.Model;
using CustomControls;
using System.Windows.Forms;

namespace RestaurantSystem.Reports
{

    public partial class Sales_Report
    {
        #region groub_by_bill
        private void GroupByBill(IQueryable<bill> bills)
        {
            betterListView1.AddColumns(new string[] { "Bill No", "Date", "G.Total", "Dis", "Paid", "Due", "Return" });
            foreach (var item in bills.ToList())
            {
                var b_list = new List<string>();
                b_list.Add(item.id.ToString());
                b_list.Add(item.date.ToString());
                b_list.Add(item.grosstotal.ToString());
                b_list.Add(item.discount.ToString());
                b_list.Add(item.paidamount.ToString());
                b_list.Add(item.dueamount.ToString());
                b_list.Add(item.returnamount.ToString());
                betterListView1.Items.Add(new ListViewItem(b_list.ToArray()));
            }
        }
        #endregion

    }

}
