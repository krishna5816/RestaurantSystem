﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ResturantManagementEntities : DbContext
    {
        public ResturantManagementEntities()
            : base("name=ResturantManagementEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<account> accounts { get; set; }
        public virtual DbSet<accounttransaction> accounttransactions { get; set; }
        public virtual DbSet<admin> admins { get; set; }
        public virtual DbSet<billitem> billitems { get; set; }
        public virtual DbSet<bill> bills { get; set; }
        public virtual DbSet<category> categories { get; set; }
        public virtual DbSet<countercloseing> countercloseings { get; set; }
        public virtual DbSet<counteropening> counteropenings { get; set; }
        public virtual DbSet<counter> counters { get; set; }
        public virtual DbSet<counterstatus> counterstatuses { get; set; }
        public virtual DbSet<counterstock> counterstocks { get; set; }
        public virtual DbSet<customer_ledgers> customer_ledgers { get; set; }
        public virtual DbSet<customerpayment> customerpayments { get; set; }
        public virtual DbSet<customer> customers { get; set; }
        public virtual DbSet<fiscalyear> fiscalyears { get; set; }
        public virtual DbSet<issueitem> issueitems { get; set; }
        public virtual DbSet<manufactureditem> manufactureditems { get; set; }
        public virtual DbSet<manufacturingestimation> manufacturingestimations { get; set; }
        public virtual DbSet<manufacturingitem> manufacturingitems { get; set; }
        public virtual DbSet<manufacureduseitem> manufacureduseitems { get; set; }
        public virtual DbSet<manufaturedsubitem> manufaturedsubitems { get; set; }
        public virtual DbSet<menuitem> menuitems { get; set; }
        public virtual DbSet<order_items> order_items { get; set; }
        public virtual DbSet<order_tables> order_tables { get; set; }
        public virtual DbSet<party> parties { get; set; }
        public virtual DbSet<party_payments> party_payments { get; set; }
        public virtual DbSet<partypayment> partypayments { get; set; }
        public virtual DbSet<purchaseaddstock> purchaseaddstocks { get; set; }
        public virtual DbSet<purchasebillitem> purchasebillitems { get; set; }
        public virtual DbSet<purchasecategory> purchasecategories { get; set; }
        public virtual DbSet<purchaseinvoiceitem> purchaseinvoiceitems { get; set; }
        public virtual DbSet<purchaseinvoice> purchaseinvoices { get; set; }
        public virtual DbSet<purchaseitem> purchaseitems { get; set; }
        public virtual DbSet<purchseexpens> purchseexpenses { get; set; }
        public virtual DbSet<shadow_accounts> shadow_accounts { get; set; }
        public virtual DbSet<shadow_bills> shadow_bills { get; set; }
        public virtual DbSet<shadow_billsitems> shadow_billsitems { get; set; }
        public virtual DbSet<shadow_counterclosings> shadow_counterclosings { get; set; }
        public virtual DbSet<shadow_counteropenings> shadow_counteropenings { get; set; }
        public virtual DbSet<shadow_counters> shadow_counters { get; set; }
        public virtual DbSet<shadow_counterstatus> shadow_counterstatus { get; set; }
        public virtual DbSet<shadow_counterstocks> shadow_counterstocks { get; set; }
        public virtual DbSet<shadow_fiscalyears> shadow_fiscalyears { get; set; }
        public virtual DbSet<shadow_issueitems> shadow_issueitems { get; set; }
        public virtual DbSet<shadow_parties> shadow_parties { get; set; }
        public virtual DbSet<shadow_purchaseaddstocks> shadow_purchaseaddstocks { get; set; }
        public virtual DbSet<shadow_purchasebillitems> shadow_purchasebillitems { get; set; }
        public virtual DbSet<shadow_purchasecates> shadow_purchasecates { get; set; }
        public virtual DbSet<shadow_purchaseexps> shadow_purchaseexps { get; set; }
        public virtual DbSet<shadow_purchaseinvoiceitems> shadow_purchaseinvoiceitems { get; set; }
        public virtual DbSet<shadow_purchaseinvoices> shadow_purchaseinvoices { get; set; }
        public virtual DbSet<shadow_purchaseitems> shadow_purchaseitems { get; set; }
        public virtual DbSet<shadow_systemsettings> shadow_systemsettings { get; set; }
        public virtual DbSet<systemsetting> systemsettings { get; set; }
        public virtual DbSet<wastagefood> wastagefoods { get; set; }
        public virtual DbSet<wastagepurchaseitem> wastagepurchaseitems { get; set; }
        public virtual DbSet<shadow_admins> shadow_admins { get; set; }
        public virtual DbSet<shadow_categories> shadow_categories { get; set; }
        public virtual DbSet<shadow_customerpayments> shadow_customerpayments { get; set; }
        public virtual DbSet<shadow_menuitems> shadow_menuitems { get; set; }
        public virtual DbSet<shadow_partypayments> shadow_partypayments { get; set; }
    }
}
