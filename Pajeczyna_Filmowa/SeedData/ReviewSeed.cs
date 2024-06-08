using Microsoft.EntityFrameworkCore;
using Pajeczyna_Filmowa.Models;

namespace Pajeczyna_Filmowa.SeedData
{
    public class ReviewSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            string id = "3d6f5732-111a-4546-ae19-7b9ae85e3159";
            modelBuilder.Entity<Review>().HasData
                (
                    new Review
                    {
                        Id = 1,
                        ReviewText = "Fajny film",
                        MovieId = 1,
                        CreatedAt = DateTime.Now,
                        UserId = id
                    },
                    new Review
                    {
                        Id = 2,
                        ReviewText = "Szkoda że taki krótki film pozdro",
                        MovieId = 1,
                        CreatedAt = DateTime.Now,
                        UserId = id
                    },
                     new Review
                     {
                         Id = 3,
                         ReviewText = "Mogło być lepiej",
                         MovieId = 2,
                         CreatedAt = DateTime.Now,
                         UserId = id
                     },
                    new Review
                    {
                        Id = 4,
                        ReviewText = "Niezatapialny statek XD",
                        MovieId = 3,
                        CreatedAt = DateTime.Now,
                        UserId = id
                    },
                     new Review
                     {
                         Id = 5,
                         ReviewText = "Spider man Spider man ....",
                         MovieId = 4,
                         CreatedAt = DateTime.Now,
                         UserId = id
                     },
                    new Review
                    {
                        Id = 6,
                        ReviewText = "Gdzie jest joker co to za batman bez jokera",
                        MovieId = 5,
                        CreatedAt = DateTime.Now,
                        UserId = id
                    }





                );
        }
    }
}
