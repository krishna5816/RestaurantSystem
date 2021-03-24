using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace RestaurantSystem.Wastage.Menuitems
{
    
    public class Viewer : ListViewItem
    {
        Model.ResturantManagementEntities db = new Model.ResturantManagementEntities();
        public int id { get; set; }
        public string name { get; set; }
        public decimal qty { get; set; }
        public string unit { get; set; }
        public int date { get; set; }



        Model.menuitem purchaseinvoiceitem;
        public Viewer(Model.menuitem _item, decimal _qty, string _unit, int _date)
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
            // SubItems[0].Text = sn.ToString();
            SubItems[0].Text = name;
            SubItems[1].Text = qty.ToString();
            SubItems[2].Text = unit;
            SubItems[3].Text = date.ToString();
            SubItems[4].Text = id.ToString();

        }
        public void save()
        {
            var billitem = new Model.wastagefood()
            {
                menuitem_id = id,
                qty = qty,
                date = date,
                unit = unit,
                created_at = DateTime.Now,
                upadated_at = DateTime.Now,
                admins_id = INFO.admin_id,
                fiscalyear_id = INFO.currentFiscalYear.id
            };
            db.wastagefoods.Add(billitem);
            db.SaveChanges();

        }
    }
}

