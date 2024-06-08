using Microsoft.EntityFrameworkCore;
using Pajeczyna_Filmowa.Models;

namespace Pajeczyna_Filmowa.SeedData
{
    public class MovieSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 1,
                    Title = "Ocean's Eleven",
                    Description = "A group of con artists plan a heist in Las Vegas.",
                    ImageUrl = "OceanEleven.jpg",
                    DirectorId = 1, // Director Steven Soderbergh
                    GenreId = 1 // Genre Action
                },
                new Movie
                {
                    Id = 2,
                    Title = "Pretty Woman",
                    Description = "A businessman falls in love with a prostitute he hired as an escort.",
                    ImageUrl = "PrettyWoman.jpg",
                    DirectorId = 2, // Director Garry Marshall
                    GenreId = 7 // Genre Romance
                },
                new Movie
                {
                    Id = 3,
                    Title = "Titanic",
                    Description = "A big boat crash on a iceberg and Leonardo Dicarpio sink and die",
                    ImageUrl = "Titanic.jpg",
                    DirectorId = 3, // Director James Cameron
                    GenreId = 7 // Genre Romance
                },
                new Movie
                {
                    Id = 4,
                    Title = "Spiderman",
                    Description = "Student got bitten by a spider and turned into SpiderMan",
                    ImageUrl = "Spiderman.jpg",
                    DirectorId = 4, // Director Sam Raimi
                    GenreId = 1 // Genre Action
                },
                new Movie
                {
                    Id = 5,
                    Title = "The Dark Knight",
                    Description = "Multi billionere running on the streets protecting good people in Gotham City",
                    ImageUrl = "Batman.jpg",
                    DirectorId = 5, // Director Christpher Nolan
                    GenreId = 1 // Genre Action
                }
            );

            // Seeding data for MovieActor table to establish many-to-many relationships
            modelBuilder.Entity<MovieActor>().HasData(
                new MovieActor { MovieId = 1, ActorId = 1 }, // Brad Pitt in Ocean's Eleven
                new MovieActor { MovieId = 1, ActorId = 2 }, // George Clooney in Ocean's Eleven
                new MovieActor { MovieId = 2, ActorId = 3 }, // Julia Roberts in Pretty Woman
                new MovieActor { MovieId = 2, ActorId = 4 }, // Richard Gere in Pretty Woman
                new MovieActor { MovieId = 2, ActorId = 5 }  // Laura San Giacomo in Pretty Woman
                // Add more relationships as needed
            );
        }
    }
}
