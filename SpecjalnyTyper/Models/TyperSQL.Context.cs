﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SpecjalnyTyper.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SpecjalnyTyperEntities : DbContext
    {
        public SpecjalnyTyperEntities()
            : base("name=SpecjalnyTyperEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Set> Set { get; set; }
        public virtual DbSet<Teams> Teams { get; set; }
        public virtual DbSet<Game> Game { get; set; }
        public virtual DbSet<Vote> Vote { get; set; }
    }
}