//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RestaurantSystem.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class issueitem
    {
        public int id { get; set; }
        public Nullable<int> purchaseitem_id { get; set; }
        public decimal quantity { get; set; }
        public string issuedby { get; set; }
        public Nullable<int> date { get; set; }
        public System.DateTime issuetime { get; set; }
        public Nullable<int> admin_id { get; set; }
        public System.DateTime created_at { get; set; }
        public System.DateTime updated_at { get; set; }
    
        public virtual admin admin { get; set; }
        public virtual purchaseitem purchaseitem { get; set; }
    }
}