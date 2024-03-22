using System.Diagnostics;

namespace App.Models
{
    public class MatchEvent
    {
        public int Id { get; set; }
        public int Minute { get; set; }
        public virtual EventType EventType { get; set; } = null!;
        public virtual Match Match { get; set; } = null!;
        public virtual MatchPlayer? MatchPlayer { get; set; }
        public int MatchId { get; set; }
        public int EventTypeId { get; set; }
        public int ?MatchPlayerId { get; set; }

    }
}
