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
        #region groub_by_itm
        public class RItemviwer
        {
            public int id { get; set; }
            public string name { get; set; }
            public decimal qty { get; set; }
            public Dictionary<decimal, decimal> pricing { get; set; }
            public decimal nettotal { get; set; }

            public string unit { get; set; }

            public string getPricing()
            {
                List<string> strs = new List<string>();
                foreach (var price in pricing)
                {
                    strs.Add(price.Key.ToString("0.##") + " X " + price.Value.ToString("0.###"));
                }
                var str = string.Join(",\n\r", strs.ToArray());
                return str;
            }
            public ListViewItem getLV()
            {

                return new ListViewItem(new string[]
                {
                    name,
                    qty.ToString("0.##"),
                    getPricing(),
                    nettotal.ToString("0.##")
                });
            }
        }

        List<RItemviwer> rItemviwers;
        private void GroupByItem(List<int> billsid) 
        {
            rItemviwers = new List<RItemviwer>();
            betterListView1.AddColumns(new string[] { "Item", "Qty", "Pricing", "Net Total" });
            decimal total = 0;

            var billitems = db.billitems.Where(o => billsid.Contains(o.bill_id.Value)).ToList();
            foreach (var billitem in billitems)
            {
                if (rItemviwers.Count(o => o.id == billitem.item_id) == 0)
                {
                    var viwer = new RItemviwer()
                    {
                        id = billitem.item_id.Value,
                        name = billitem.menuitem.name,
                        nettotal = billitem.nettotal,
                        pricing = new Dictionary<decimal, decimal>(),
                        qty = billitem.qty.Value

                    };
                    viwer.pricing.Add(billitem.unitrate.Value, billitem.qty.Value);
                    rItemviwers.Add(viwer);
                }
                else
                {
                    var viwer = rItemviwers.First(o => o.id == billitem.item_id);
                    viwer.nettotal += billitem.nettotal;
                    viwer.qty += billitem.qty.Value;
                    if (viwer.pricing.ContainsKey(billitem.unitrate.Value))
                    {
                        viwer.pricing[billitem.unitrate.Value] += billitem.qty.Value;

                    }
                    else
                    {
                        viwer.pricing.Add(billitem.unitrate.Value, billitem.qty.Value);

                    }
                }
            }

            foreach (var viwer in rItemviwers)
            {
                betterListView1.Items.Add(viwer.getLV());
            }
            betterListView1.Add(new string[] { "Total", rItemviwers.Sum(o => o.qty).ToString("0.###"), "--", rItemviwers.Sum(o => o.nettotal).ToString("0.###") });
        }
    }
        #endregion

    
}
