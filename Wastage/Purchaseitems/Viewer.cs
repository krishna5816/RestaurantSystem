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
        Model.ResturantManagementEntities db = new Model.ResturantManagementEntities();
        public int id { get; set; }
        public string name { get; set; }
        public decimal qty { get; set; }
        public string unit { get; set; }
        public int date { get; set; }



        Model.purchaseitem purchaseinvoiceitem;
        public Viewer(Model.purchaseitem _item, decimal _qty, string _unit,int _date)
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
            name = purchaseinvoiceitem.name;
            SubItems[0].Text = name;
            SubItems[1].Text = qty.ToString();
            SubItems[2].Text = unit;
            SubItems[3].Text = date.ToString();
            SubItems[4].Text = id.ToString();

        }
        public void save()
        {
            var load = db.purchaseitems.Find(id);
            load.qty -=qty;
            db.Entry(load).State = System.Data.Entity.EntityState.Modified;
            var billitem = new Model.wastagepurchaseitem()
            {
                purchaseitem_id = id,
                qty = qty,
                date = date,
                unit = unit,
                created_at = DateTime.Now,
                upadated_at = DateTime.Now,
                admins_id = INFO.admin_id,
                fiscalyear_id = INFO.currentFiscalYear.id
            };
            db.wastagepurchaseitems.Add(billitem);
            db.SaveChanges();
            

        }
    }
}
