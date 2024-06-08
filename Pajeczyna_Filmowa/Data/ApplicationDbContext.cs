using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pajeczyna_Filmowa.Models;
using Pajeczyna_Filmowa.SeedData;

namespace Pajeczyna_Filmowa.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Pajeczyna_Filmowa.Models.Genre> Genre { get; set; } = default!;
        public DbSet<Pajeczyna_Filmowa.Models.Actor> Actor { get; set; } = default!;
        public DbSet<Pajeczyna_Filmowa.Models.Director> Director { get; set; } = default!;
        public DbSet<Pajeczyna_Filmowa.Models.Movie> Movie { get; set; } = default!;

        public DbSet<Pajeczyna_Filmowa.Models.MovieActor> MovieActor { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Konfiguracja relacji wiele do wielu
            modelBuilder.Entity<MovieActor>()
                .HasKey(ma => new { ma.MovieId, ma.ActorId });

            modelBuilder.Entity<MovieActor>()
                .HasOne(ma => ma.Movie)
                .WithMany(m => m.MovieActors)
                .HasForeignKey(ma => ma.MovieId);

            modelBuilder.Entity<MovieActor>()
                .HasOne(ma => ma.Actor)
                .WithMany(a => a.MovieActors)
                .HasForeignKey(ma => ma.ActorId);


            ActorSeed.Seed(modelBuilder);
            DirectorSeed.Seed(modelBuilder);
            GenreSeed.Seed(modelBuilder);
            MovieSeed.Seed(modelBuilder);
            ReviewSeed.Seed(modelBuilder);
            RatingSeed.Seed(modelBuilder);
        }
        public DbSet<Pajeczyna_Filmowa.Models.Rating> Rating { get; set; } = default!;
        public DbSet<Pajeczyna_Filmowa.Models.Review> Review { get; set; } = default!;
    }
}
