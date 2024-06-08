using Microsoft.EntityFrameworkCore;
using Pajeczyna_Filmowa.Models;

namespace Pajeczyna_Filmowa.SeedData
{
    public class ActorSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor>().HasData(
                new Actor { Id = 1, Name = "Brad", SurName = "Pitt" },
                new Actor { Id = 2, Name = "George", SurName = "Clooney" },
                new Actor { Id = 3, Name = "Julia", SurName = "Roberts" },
                new Actor { Id = 4, Name = "Richard", SurName = "Gere" },
                new Actor { Id = 5, Name = "Laura", SurName = "San Giacomo" }
            );
        }
    }
}
