namespace App.Models
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public virtual ICollection<Player> ?Players { get; set; }
        public virtual ICollection<MatchPlayer> ?MatchPlayers { get; set; }
    }
}
