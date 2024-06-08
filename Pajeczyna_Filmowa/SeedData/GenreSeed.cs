using Microsoft.EntityFrameworkCore;
using Pajeczyna_Filmowa.Models;

namespace Pajeczyna_Filmowa.SeedData
{
    public class GenreSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(
                new Genre { Id = 1, Name = "Action" },
                new Genre { Id = 2, Name = "Comedy" },
                new Genre { Id = 3, Name = "Drama" },
                new Genre { Id = 4, Name = "Fantasy" },
                new Genre { Id = 5, Name = "Horror" },
                new Genre { Id = 6, Name = "Mystery" },
                new Genre { Id = 7, Name = "Romance" },
                new Genre { Id = 8, Name = "Science Fiction" },
                new Genre { Id = 9, Name = "Thriller" },
                new Genre { Id = 10, Name = "Western" }
            );
        }
    }
}
