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
    
    public partial class systemsetting
    {
        public int id { get; set; }
        public Nullable<int> fiscalyear_id { get; set; }
        public Nullable<int> currentmode { get; set; }
        public bool dateopened { get; set; }
        public int currentdate { get; set; }
    
        public virtual fiscalyear fiscalyear { get; set; }
    }
}
