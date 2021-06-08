using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using seiksLab1.Models;

namespace seiksLab1.DAL
{
    public class GamesContext : DbContext
    {
        public GamesContext() : base("GamesContext") // The name of the connection string (which you'll add to the Web.config file later) is passed in to the constructor. 
        {
        }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Juego> Juegos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}