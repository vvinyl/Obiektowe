﻿namespace App.Models
{
    public class MatchPlayer
    {
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime DateTime { get; set; }
        public virtual Player Player { get; set; } = null!;
        public virtual Position Position { get; set; } = null!;
        public virtual Match Match { get; set; } = null!;
        public virtual ICollection<MatchEvent> ?MatchEvents { get; set; }
        public int MatchId { get; set; }
        public int PositionId { get; set; }
        public int PlayerId { get; set; }
    }
}
