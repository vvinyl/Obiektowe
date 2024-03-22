using Microsoft.AspNetCore.Mvc;
using App.Models;

namespace App.Controllers
{
    public class StudentController : Controller
    {
        private List<Student> students = new List<Student>{
                new Student{
                    Id = 1,
                    Name = "Adrian",
                    Surname = "Puchacki",
                    Index = "11",
                    DateOfBirth = new DateTime(1990,1,1),
                    Direction = "Mechatronika"
                },
                new Student{
                    Id = 2,
                    Name = "Bogdan",
                    Surname = "Boner",
                    Index = "66",
                    DateOfBirth = new DateTime(1980,6,6),
                    Direction = "Remonty i egzorcyzmy",
                },
                new Student{
                    Id = 3,
                    Name = "Domino",
                    Surname = "Jachaś",
                    Index = "123",
                    DateOfBirth = new DateTime(1850,2,2),
                    Direction = "Galakpizza"
                }
            };
        public IActionResult Index() {
            return View(students);
        }
        
        public IActionResult Details(int id)
        {
            var student = students.FirstOrDefault(x => x.Id == id);
            return View(student);
        }
    }
}
