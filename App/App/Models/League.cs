namespace App.Models
{
    public class League
    {
        public int Id { get; set; }
        public string? Name { get; set; } = null!;
        public string? Country { get; set; } = null!;
        public int Level { get; set; }
        public virtual ICollection<Team> ?Teams { get; set; }
    }
}
