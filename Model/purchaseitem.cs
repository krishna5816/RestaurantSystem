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
    
    public partial class purchaseitem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public purchaseitem()
        {
            this.issueitems = new HashSet<issueitem>();
            this.manufactureditems = new HashSet<manufactureditem>();
            this.manufacturingestimations = new HashSet<manufacturingestimation>();
            this.manufacureduseitems = new HashSet<manufacureduseitem>();
            this.purchaseaddstocks = new HashSet<purchaseaddstock>();
            this.purchasebillitems = new HashSet<purchasebillitem>();
            this.purchaseinvoiceitems = new HashSet<purchaseinvoiceitem>();
            this.wastagepurchaseitems = new HashSet<wastagepurchaseitem>();
        }
    
        public int id { get; set; }
        public string name { get; set; }
        public string unit { get; set; }
        public Nullable<decimal> price { get; set; }
        public Nullable<int> purchase_Cat_id { get; set; }
        public System.DateTime updated_at { get; set; }
        public System.DateTime created_at { get; set; }
        public Nullable<int> sync_id { get; set; }
        public Nullable<int> admin_id { get; set; }
        public decimal qty { get; set; }
    
        public virtual admin admin { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<issueitem> issueitems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<manufactureditem> manufactureditems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<manufacturingestimation> manufacturingestimations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<manufacureduseitem> manufacureduseitems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<purchaseaddstock> purchaseaddstocks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<purchasebillitem> purchasebillitems { get; set; }
        public virtual purchasecategory purchasecategory { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<purchaseinvoiceitem> purchaseinvoiceitems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<wastagepurchaseitem> wastagepurchaseitems { get; set; }
    }
}
