﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Wastage.Purchaseitems
{
    public class ItemNameViwer
    {
        public Model.purchaseitem Item { get; set; }
        public ItemNameViwer(Model.purchaseitem _item)
        {
            Item = _item;
        }
        public override string ToString()
        {
            return this.Item.name;
        }
    }
}
