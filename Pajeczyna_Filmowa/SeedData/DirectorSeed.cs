using Microsoft.EntityFrameworkCore;
using Pajeczyna_Filmowa.Models;

namespace Pajeczyna_Filmowa.SeedData
{
    public class DirectorSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Director>().HasData(
               new Director { Id = 1 , Name = "Steven", SurName = "Soderbergh"},
               new Director { Id = 2 , Name = "Garry", SurName = "Marshall"},
               new Director { Id = 3, Name = "James", SurName = "Cameron" },
               new Director { Id = 4, Name = "Sam", SurName = "Raimi" },
               new Director { Id = 5, Name = "Christopher", SurName = "Nolan" }
            );
        }
    }
}
