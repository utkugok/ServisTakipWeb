﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServisTakipWeb.Areas.FirmaYonetici.Context
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ServisTakipFirmaYoneticiDBEntities : DbContext
    {
        public ServisTakipFirmaYoneticiDBEntities()
            : base("name=ServisTakipFirmaYoneticiDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<FirmaCalisani> FirmaCalisani { get; set; }
        public virtual DbSet<FirmaYonetici> FirmaYonetici { get; set; }
        public virtual DbSet<Musteri> Musteri { get; set; }
        public virtual DbSet<MusteriCalisani> MusteriCalisani { get; set; }
        public virtual DbSet<MusteriYonetici> MusteriYonetici { get; set; }
        public virtual DbSet<Sozlesme> Sozlesme { get; set; }
        public virtual DbSet<SozlesmeYapma> SozlesmeYapma { get; set; }
    }
}