using System.ComponentModel.DataAnnotations;

namespace Pajeczyna_Filmowa.Models
{
    public class Rating
    {
        public int Id { get; set; }
        [Range(1, 10, ErrorMessage = "Rating must be between 1 and 10.")]
        public double RatingNum {  get; set; }
        public int MovieId { get; set; }

        public virtual Movie? Movie { get; set; }
    }
}



