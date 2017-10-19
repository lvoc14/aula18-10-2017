using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication.Models;

namespace WebApplication.Context
{
    public class CinemaContext : DbContext
    {
        public CinemaContext():base ("name=strCinema")
        {
            
        }

        public DbSet<Sessao> Sessoes  { get; set; }

        public DbSet<Sala> Salas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sessao>()
                .HasKey(x => x.Codigo);
        }

    }
}