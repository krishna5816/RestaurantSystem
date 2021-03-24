
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
    public partial class Purchase_Reports
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

            var p_item = db.purchaseinvoiceitems.Where(o => billsid.Contains(o.purchaseinvoice_id.Value)).ToList();
            foreach (var p_itmes in p_item)
            {
                if (rItemviwers.Count(o => o.id == p_itmes.purchaseitems_id) == 0)
                {
                    var viwer = new RItemviwer()
                    {
                        id = p_itmes.purchaseitems_id.Value,
                        name = p_itmes.purchaseitem.name,

                        pricing = new Dictionary<decimal, decimal>(),
                        qty = p_itmes.qty.Value

                    };
                    viwer.pricing.Add(p_itmes.price.Value, p_itmes.qty.Value);
                    rItemviwers.Add(viwer);
                }
                else
                {
                    var viwer = rItemviwers.First(o => o.id == p_itmes.purchaseitems_id);
                    //viwer.nettotal +=p_itmes.;
                    viwer.qty += p_itmes.qty.Value;
                    if (viwer.pricing.ContainsKey(p_itmes.price.Value))
                    {
                        viwer.pricing[p_itmes.price.Value] += p_itmes.qty.Value;

                    }
                    else
                    {
                        viwer.pricing.Add(p_itmes.price.Value, p_itmes.qty.Value);

                    }
                }
            }

            foreach (var viwer in rItemviwers)
            {
                betterListView1.Items.Add(viwer.getLV());
            }
            betterListView1.Add(new string[] { "Total", rItemviwers.Sum(o => o.qty).ToString("0.###"), "--", rItemviwers.Sum(o => o.nettotal).ToString("0.###") });
        }


        #endregion
        #region
        public class RCategoryViwer
        {
            public int Id { get; set; }
            public string name { get; set; }
            public decimal amount { get; set; }

            public decimal total { get; set; }
        }
        public void GroupByCategory(List<int> invoices)
        {
            decimal nettotal = 0;
            betterListView1.AddColumns(new string[] { "Category", "Total Qty", "Net Total" });
            var billitems = db.purchaseinvoiceitems.Where(o => invoices.Contains(o.purchaseinvoice_id.Value)).Join(db.purchaseitems, o => o.purchaseitems_id, p => p.id, (o, p) =>
                       new
                       {
                           o.qty,
                           //o.nettotal,
                           p.purchasecategory
                       }).Join(db.purchasecategories, o => o.purchasecategory.id, p => p.id, (o, p) =>
                       new
                       {
                           p.id,
                           o.qty,
                           p.name,
                           // o.nettotal
                       }).GroupBy(o => o.id).Select(o => new RCategoryViwer()
                       {
                           Id = o.Key,
                           amount = o.Sum(x => x.qty).Value,
                           // total = o.Sum(x => x.nettotal),
                           name = o.FirstOrDefault(x => x.id == o.Key).name
                       }).ToList();




            foreach (var bi in billitems)
            {
                betterListView1.Add(new string[] { bi.name, bi.amount.ToString("0.###"), bi.total.ToString("0.##") });
            }
            betterListView1.Add(new ListViewItem(new string[] { "Total", billitems.Sum(o => o.amount).ToString("0.###"), billitems.Sum(o => o.total).ToString("0.##") })
            {
                BackColor = Color.Blue,
                ForeColor = Color.White
            });


        }

        #endregion


    }
}

