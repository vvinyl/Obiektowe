namespace App.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public string Index { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string Direction { get; set; } = null!;
    }
}
