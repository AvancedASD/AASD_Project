﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AASD_Data_Access_Layer.DataProvider
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AASD_DBEntities1 : DbContext
    {
        public AASD_DBEntities1()
            : base("name=AASD_DBEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<AASD_DB_Query> AASD_DB_Query { get; set; }
        public DbSet<AASD_DB_Result> AASD_DB_Result { get; set; }
    }
}
