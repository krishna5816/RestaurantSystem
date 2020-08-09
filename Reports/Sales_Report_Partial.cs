using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantSystem.Model;
using CustomControls;
namespace RestaurantSystem.Reports
{
    
    public partial class Sales_Report
    {
        #region groub_by_bill
        private void GroupByBill(IQueryable<bill> bills)
        {
            betterListView1.AddColumns(new string[] { "Bill No", "Date", "Net Total" });
            foreach (var item in bills.ToList())
            {
                betterListView1.Items.Add(item.id.ToString(), item.date.ToString(), item.amount.ToString());
            }
        }
        #endregion

    }

}
