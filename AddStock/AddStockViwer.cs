using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantSystem.Model;
namespace RestaurantSystem.AddStock
{
  
   public class AddStockViwer:ListViewItem
    {
        
        public int id { get; set; }
        public string name { get; set; }
        public decimal qty { get; set; }

        public decimal rate { get; set; }
        public decimal tax { get; set; }
        public decimal discount { get; set; }
        public decimal total { get; set; }
        public decimal grosstotal { get; set; }

        public Model.purchaseitem purchaseitem;


        public AddStockViwer(Model.purchaseitem _purchaseitem,decimal _quantity,decimal _rate)
        {
            for(int i = 0; i <= 10; i++)
            {
                this.SubItems.Add(new ListViewSubItem());
            }
            purchaseitem = _purchaseitem;
            qty = _quantity;
            rate = _rate;
        }
        public AddStockViwer(int id, decimal _quantity, decimal _rate)
        {
            for (int i = 0; i <= 10; i++)
            {
                this.SubItems.Add(new ListViewSubItem());
            }
            var db = DatabaseConfigure.getConfigure();
            purchaseitem = db.purchaseitems.Find(id);
            qty = _quantity;
            rate = _rate;
        }
    }
}
