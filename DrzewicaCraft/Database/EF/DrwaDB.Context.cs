﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DrzewicaCraft.Database.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DrwaDB : DbContext
    {
        public DrwaDB()
            : base("name=DrwaDB")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<Photo> Photo { get; set; }
        public virtual DbSet<User> User { get; set; }
    }
}
