using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ETicket.Models;

namespace ETicket.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Moive>().HasKey(am=>new  
            { 
                am.ActorId,
                am.MovieId
            });

            modelBuilder.Entity<Actor_Moive>().HasOne(m => m.Movie).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<Actor_Moive>().HasOne(m => m.Actor).WithMany(am => am.Actor_Moives).HasForeignKey(m => m.ActorId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Cinema> cinemas { get; set; }
        public DbSet<Actor_Moive> Actor_Moives { get; set; }
        public DbSet<Producer> producers { get; set; }


    }
}
