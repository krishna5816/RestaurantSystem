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
    
    public partial class shadow_counteropenings
    {
        public int id { get; set; }
        public int cointeropening_id { get; set; }
        public Nullable<int> date { get; set; }
        public Nullable<decimal> amount { get; set; }
        public int state { get; set; }
        public string ip { get; set; }
        public Nullable<int> counter_id { get; set; }
        public Nullable<int> admin_id { get; set; }
        public System.DateTime updated_at { get; set; }
        public System.DateTime created_at { get; set; }
        public Nullable<int> sync_id { get; set; }
        public int actiontype { get; set; }
        public int C_V { get; set; }
    }
}
