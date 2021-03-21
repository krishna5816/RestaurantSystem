using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Wastage.Purchaseitems
{
    public class ItemNameViwer
    {
        public Model.purchaseinvoiceitem Item { get; set; }
        public ItemNameViwer(Model.purchaseinvoiceitem _item)
        {
            Item = _item;
        }
        public override string ToString()
        {
            return this.Item.purchaseitem.name;
        }
    }
}
