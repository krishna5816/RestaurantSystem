using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomControls;
using System.Drawing;
namespace RestaurantSystem.ManifacturedMenuitems
{

  public partial  class List
    {
        #region groub_by_itm
        public class RItemviwer
        {
            public int id { get; set; }
            public string name { get; set; }
            public decimal qty { get; set; }
            public string unit { get; set; }

           
            public ListViewItem getLV()
            {

                return new ListViewItem(new string[]
                {
                    name,
                    qty.ToString("0.##"),
                    unit
                   
                });
            }
        }

        List<RItemviwer> rItemviwers;
        private void GroupByItem(List<int> billsid)
        {
            rItemviwers = new List<RItemviwer>();
            betterListView1.AddColumns(new string[] { "Item", "Qty", "Unit", });
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
                        unit=billitem.menuitem.unit,
                        qty = billitem.qty.Value

                    };
                   
                    rItemviwers.Add(viwer);
                }
                else
                {
                    var viwer = rItemviwers.First(o => o.id == billitem.item_id);
                    
                    viwer.qty += billitem.qty.Value;
                    
                }
            }

            foreach (var viwer in rItemviwers)
            {
                betterListView1.Items.Add(viwer.getLV());
            }
           
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
        public void GroupByCategory(List<int> bills)
        {
            decimal nettotal = 0;
            betterListView1.AddColumns(new string[] { "Category", "Total Qty", "Net Total" });
            var billitems = db.billitems.Where(o => bills.Contains(o.bill_id.Value)).Join(db.menuitems, o => o.item_id, p => p.id, (o, p) =>
                       new
                       {
                           o.qty,
                           o.nettotal,
                           p.category_id
                       }).Join(db.categories, o => o.category_id, p => p.id, (o, p) =>
                       new
                       {
                           p.id,
                           o.qty,
                           p.name,
                           o.nettotal
                       }).GroupBy(o => o.id).Select(o => new RCategoryViwer()
                       {
                           Id = o.Key,
                           amount = o.Sum(x => x.qty).Value,
                           total = o.Sum(x => x.nettotal),
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
