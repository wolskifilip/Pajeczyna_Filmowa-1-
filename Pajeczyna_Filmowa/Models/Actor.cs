namespace Pajeczyna_Filmowa.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }

        public ICollection<MovieActor> MovieActors { get; set; }
    }
}
