namespace Pajeczyna_Filmowa.Models
{
    public class MovieCreateViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public int DirectorId { get; set; }
        public int GenreId { get; set; }
        public List<int> ActorIds { get; set; }
    }
}
