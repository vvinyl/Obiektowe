namespace App.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public virtual Article Article { get; set; } = null!;
        public int ArticleId { get; set; }
    }
}
