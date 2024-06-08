using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Pajeczyna_Filmowa.Models
{
    public class Review
    {
        public int Id { get; set; }
        [Required]
        [RegularExpression(@"^(\b\w+\b\s*){1,250}$", ErrorMessage = "Review cannot be longer than 250 words.")]
        public string ReviewText { get; set; }
        public int MovieId { get; set; }
        public virtual Movie? Movie { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string? UserId { get; set; }
        public virtual IdentityUser? User { get; set; }
    }

}



