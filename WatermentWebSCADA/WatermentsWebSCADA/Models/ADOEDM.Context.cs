﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WatermentsWebSCADA.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class watermentdbEntities : DbContext
    {
        public watermentdbEntities()
            : base("name=watermentdbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<alarms> alarms { get; set; }
        public DbSet<country> country { get; set; }
        public DbSet<equipment> equipment { get; set; }
        public DbSet<facilities> facilities { get; set; }
        public DbSet<location> location { get; set; }
        public DbSet<maintenance> maintenance { get; set; }
        public DbSet<measurement> measurement { get; set; }
        public DbSet<sessions> sessions { get; set; }
        public DbSet<useraccounts> useraccounts { get; set; }
    }
}
