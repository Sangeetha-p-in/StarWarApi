﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StarWarApi
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StarWar : DbContext
    {
        public StarWar()
            : base("name=StarWar")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<film> films { get; set; }
        public virtual DbSet<person> people { get; set; }
        public virtual DbSet<planet> planets { get; set; }
        public virtual DbSet<species> species { get; set; }
        public virtual DbSet<starship> starships { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<transport> transports { get; set; }
        public virtual DbSet<vehicle> vehicles { get; set; }
    }
}