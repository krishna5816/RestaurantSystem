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
    
    public partial class order_tables
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public order_tables()
        {
            this.order_items = new HashSet<order_items>();
        }
    
        public int id { get; set; }
        public string table_name { get; set; }
        public Nullable<bool> isorder { get; set; }
        public System.DateTime updated_at { get; set; }
        public System.DateTime created_at { get; set; }
        public Nullable<int> admin_id { get; set; }
        public Nullable<int> sync_id { get; set; }
    
        public virtual admin admin { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<order_items> order_items { get; set; }
    }
}
