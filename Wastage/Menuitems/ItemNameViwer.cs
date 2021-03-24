using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Wastage.Menuitems
{
    public class ItemNameViwer
    {
        public Model.menuitem Item { get; set; }
        public ItemNameViwer(Model.menuitem _item)
        {
            Item = _item;
        }
        public override string ToString()
        {
            return this.Item.name;
        }
    }
}
