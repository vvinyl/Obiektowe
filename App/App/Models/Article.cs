namespace App.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }
        public virtual Author Author { get; set; } = null!;
        public int AuthorId { get; set; }
        public virtual Category Category { get; set; } = null!;
        public int CategoryId { get; set; }
        public virtual ICollection<Comment> ?Comments { get; set; }
        public virtual ICollection<Tag> ?Tags { get; set; }
        public int TagId { get; set; }
        public virtual Match ?Match { get; set; }
        public int ?MatchId { get; set; }


    }
}
