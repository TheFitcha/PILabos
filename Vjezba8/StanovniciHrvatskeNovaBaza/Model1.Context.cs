﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StanovniciHrvatskeNovaBaza
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class LabsEntities : DbContext
    {
        public LabsEntities()
            : base("name=LabsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Adrese> Adrese { get; set; }
        public virtual DbSet<Mjesta> Mjestas { get; set; }
        public virtual DbSet<Stanovnici> Stanovnicis { get; set; }
    }
}