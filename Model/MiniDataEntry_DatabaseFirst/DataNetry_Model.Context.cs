﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MiniDataEntry
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SistemplanEntities : DbContext
    {
        public SistemplanEntities()
            : base("name=SistemplanEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CAMPO> CAMPOes { get; set; }
        public virtual DbSet<DEFINICAO> DEFINICAOs { get; set; }
        public virtual DbSet<DOCUMENTO> DOCUMENTOes { get; set; }
        public virtual DbSet<INDEXACAO_CAMPOS> INDEXACAO_CAMPOS { get; set; }
        public virtual DbSet<TRABALHO> TRABALHOes { get; set; }
    }
}
