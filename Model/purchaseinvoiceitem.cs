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
    
    public partial class purchaseinvoiceitem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public purchaseinvoiceitem()
        {
            this.manufacturingitems = new HashSet<manufacturingitem>();
            this.manufaturedsubitems = new HashSet<manufaturedsubitem>();
        }
    
        public int id { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<decimal> qty { get; set; }
        public string unit { get; set; }
        public string image { get; set; }
        public Nullable<int> admin_id { get; set; }
        public System.DateTime updated_at { get; set; }
        public System.DateTime created_at { get; set; }
        public Nullable<int> sync_id { get; set; }
        public Nullable<int> party_id { get; set; }
        public Nullable<int> purchaseitems_id { get; set; }
        public Nullable<int> purchaseinvoice_id { get; set; }
        public Nullable<int> date { get; set; }
    
        public virtual admin admin { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<manufacturingitem> manufacturingitems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<manufaturedsubitem> manufaturedsubitems { get; set; }
        public virtual party party { get; set; }
        public virtual purchaseitem purchaseitem { get; set; }
        public virtual purchaseinvoice purchaseinvoice { get; set; }
    }
}
