using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantSystem.Model;
using CustomControls;
using System.Windows.Forms;
using System.Drawing;
namespace RestaurantSystem.Reports
{
    public partial class Purchase_Report
    {
        #region groub_by_bill
        private void GroupByBill(IQueryable<purchaseinvoice> purchaseinvoices)
        {
            betterListView1.AddColumns(new string[] { "Bill No", "Date", "G.Total", "Dis", "Paid", "Due" });
            foreach (var item in purchaseinvoices.ToList())
            {
                var b_list = new List<string>();
                b_list.Add(item.id.ToString());
                b_list.Add(item.date.ToString());
                b_list.Add(item.grosstotal.ToString());
                b_list.Add(item.discount.ToString());
                b_list.Add(item.paid.ToString());
                b_list.Add(item.due.ToString());

                betterListView1.Items.Add(new ListViewItem(b_list.ToArray()));
            }
        }
        #endregion
    }
}