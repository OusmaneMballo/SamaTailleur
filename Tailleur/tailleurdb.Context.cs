﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tailleur
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class tailleurdbEntities : DbContext
    {
        public tailleurdbEntities()
            : base("name=tailleurdbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<admin> admins { get; set; }
        public DbSet<client> clients { get; set; }
        public DbSet<commande> commandes { get; set; }
        public DbSet<mesure> mesures { get; set; }
        public DbSet<femme> femmes { get; set; }
        public DbSet<homme> hommes { get; set; }
    }
}
