using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pajeczyna_Filmowa.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public int DirectorId { get; set; }
 
        public virtual Director? Director { get; set; }

        [Required]
        public int GenreId { get; set; }

      
        public virtual Genre? Genre { get; set; }

        public ICollection<MovieActor> MovieActors { get; set; }

    }
}
