using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace AutoVenta.Models
{
    public class AutoVentaContext : DbContext
    {
        public DbSet<Vehiculos> Vehiculo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Pluraliza
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}