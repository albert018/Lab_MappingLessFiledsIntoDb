﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lab_MappingLessFiledsIntoDb
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BillingEntities : DbContext
    {
        public BillingEntities()
            : base("name=BillingEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<BillTag> BillTag { get; set; }
        public virtual DbSet<BillType> BillType { get; set; }
        public virtual DbSet<DailyBilling> DailyBilling { get; set; }
        public virtual DbSet<DailyBillingTags> DailyBillingTags { get; set; }
    }
}
