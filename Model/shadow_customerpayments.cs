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
    
    public partial class shadow_customerpayments
    {
        public int id { get; set; }
        public int customerpayment_id { get; set; }
        public Nullable<decimal> amountreceived { get; set; }
        public int date { get; set; }
        public Nullable<int> customer_id { get; set; }
        public string bankname { get; set; }
        public string accountno { get; set; }
        public string receivedby { get; set; }
        public Nullable<decimal> returnamount { get; set; }
        public Nullable<int> admin_id { get; set; }
        public System.DateTime created_at { get; set; }
        public System.DateTime updated_at { get; set; }
        public Nullable<int> sync_id { get; set; }
        public string depositername { get; set; }
        public Nullable<decimal> dueamount { get; set; }
        public Nullable<decimal> paidamount { get; set; }
        public int actiontype { get; set; }
        public int C_V { get; set; }
    }
}
