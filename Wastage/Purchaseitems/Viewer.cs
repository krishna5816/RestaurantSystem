using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace RestaurantSystem.Wastage.Purchaseitems
{
  public  class Viewer:ListViewItem
    {
        public int id { get; set; }
        public string name { get; set; }
        public decimal qty { get; set; }
        public string unit { get; set; }
        public int date { get; set; }



        Model.purchaseinvoiceitem purchaseinvoiceitem;
        public Viewer(Model.purchaseinvoiceitem _item, decimal _qty, string _unit,int _date)
        {
            for (int i = 0; i < 9; i++)
            {
                this.SubItems.Add(new ListViewSubItem());
            }
            purchaseinvoiceitem = _item;
            qty = _qty;
            unit = _unit;
            date = _date;
            refresh();
        }
        public void refresh()
        {
            id = purchaseinvoiceitem.id;
            name = purchaseinvoiceitem.purchaseitem.name;
           // SubItems[0].Text = sn.ToString();
            SubItems[1].Text = name;
            SubItems[2].Text = qty.ToString();
            SubItems[3].Text = unit;
            SubItems[4].Text = date.ToString();
            SubItems[5].Text = id.ToString();
            
        }
    }
}
