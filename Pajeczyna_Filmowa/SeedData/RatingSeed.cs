using Microsoft.EntityFrameworkCore;
using Pajeczyna_Filmowa.Models;

namespace Pajeczyna_Filmowa.SeedData
{
    public class RatingSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Rating>().HasData(
                new Rating {Id = 1, RatingNum =5 , MovieId = 1 },
                new Rating {Id = 2, RatingNum = 4, MovieId = 2 },
                new Rating {Id = 3, RatingNum = 3, MovieId = 3 },
                new Rating {Id = 4, RatingNum = 2, MovieId = 4 },
                new Rating {Id = 5, RatingNum = 1, MovieId = 5 }

            );
        }
    }
}
