﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace gpw.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class gpwEntities : DbContext
    {
        public gpwEntities()
            : base("name=gpwEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<cat> cats { get; set; }
        public virtual DbSet<friend> friends { get; set; }
        public virtual DbSet<hoc_van> hoc_van { get; set; }
        public virtual DbSet<news> news { get; set; }
        public virtual DbSet<nghe_nghiep> nghe_nghiep { get; set; }
        public virtual DbSet<quan_he> quan_he { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<thanh_vien> thanh_vien { get; set; }
        public virtual DbSet<quan_he_thanh_vien> quan_he_thanh_vien { get; set; }
    }
}
