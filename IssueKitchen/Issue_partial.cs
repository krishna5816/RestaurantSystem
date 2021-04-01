
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantSystem.Model;
using CustomControls;
using System.Windows.Forms;
using System.Drawing;

namespace RestaurantSystem.IssueKitchen
{
   public partial class List
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
            public  string unit { get; set; }
            public int date { get; set; }
            public DateTime time { get; set; }

           
            public ListViewItem getLV()
            {

                return new ListViewItem(new string[]
                {
                    name,
                    qty.ToString("0.##"),
                    unit.ToString(),
                    date.ToString(),
                    time.ToString()
                });
            }
        }

        List<RItemviwer> rItemviwers;
        private void GroupByItem(List<int> billsid)
        {
            rItemviwers = new List<RItemviwer>();
            betterListView1.AddColumns(new string[] { "Item Name", "Qty", "Unit", "Date", "Time" });
            decimal total = 0;

            var p_item = db.issueitems.Where(o => billsid.Contains(o.id)).ToList();
            foreach (var p_itmes in p_item)
            {
                if (rItemviwers.Count(o => o.id == p_itmes.id) == 0)
                {
                    var viwer = new RItemviwer()
                    {
                        id = p_itmes.purchaseitem_id.Value,
                        name = p_itmes.purchaseitem.name,
                        qty = p_itmes.quantity,
                        unit=p_itmes.units,
                        date=p_itmes.date.Value,
                        time=p_itmes.issuetime

                    };
                    //viwer.pricing.Add(p_itmes.price.Value, p_itmes.qty.Value);
                    rItemviwers.Add(viwer);
                }
                else
                {
                    var viwer = rItemviwers.First(o => o.id == p_itmes.id);
                    //viwer.nettotal +=p_itmes.;
                    viwer.qty += p_itmes.quantity;
                    //if (viwer.pricing.ContainsKey(p_itmes.price.Value))
                    //{
                    //    viwer.pricing[p_itmes.price.Value] += p_itmes.qty.Value;

                    //}
                    //else
                    //{
                    //    viwer.pricing.Add(p_itmes.price.Value, p_itmes.qty.Value);

                    //}
                }
            }

            foreach (var viwer in rItemviwers)
            {
                betterListView1.Items.Add(viwer.getLV());
            }
            //betterListView1.Add(new string[] { "Total", rItemviwers.Sum(o => o.qty).ToString("0.###"), "--", rItemviwers.Sum(o => o.nettotal).ToString("0.###") });
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
            var billitems = db.issueitems.Where(o => invoices.Contains(o.purchaseitem_id.Value)).Join(db.purchaseitems, o => o.purchaseitem_id, p => p.id, (o, p) =>
                       new
                       {
                           o.quantity,
                           //o.nettotal,
                           p.purchasecategory
                       }).Join(db.purchasecategories, o => o.purchasecategory.id, p => p.id, (o, p) =>
                       new
                       {
                           p.id,
                           o.quantity,
                           p.name,
                           // o.nettotal
                       }).GroupBy(o => o.id).Select(o => new RCategoryViwer()
                       {
                           Id = o.Key,
                           amount = o.Sum(x => x.quantity),
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


    