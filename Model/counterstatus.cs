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
    
    public partial class counterstatus
    {
        public int id { get; set; }
        public Nullable<int> counter_id { get; set; }
        public int date { get; set; }
        public Nullable<decimal> requestedamount { get; set; }
        public Nullable<bool> approved { get; set; }
        public int status { get; set; }
        public int state { get; set; }
        public string ip { get; set; }
        public decimal closeingamount { get; set; }
        public Nullable<int> sync_id { get; set; }
        public System.DateTime crated_at { get; set; }
        public System.DateTime updated_at { get; set; }
        public Nullable<int> admin_id { get; set; }
    
        public virtual admin admin { get; set; }
        public virtual counter counter { get; set; }
    }
}
