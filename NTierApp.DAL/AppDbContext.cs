using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NTierApp.Domain;

namespace NTierApp.DAL
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer
                ("Data Source=DESKTOP-6QTPFUC;Initial Catalog=FilmDB;User Id=sa;Password=mssqlserverbey;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new FilmMapping().Configure(modelBuilder.Entity<Film>());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Film> Films { get; set; }
        public DbSet<FilmDetail> FilmDetails { get; set; }
        public DbSet<FilmCategory> FilmCategories { get; set; }
        public DbSet<Actor> Actors{ get; set; }
        public DbSet<ActorFilm> ActorFilms { get; set; }
    }
}
