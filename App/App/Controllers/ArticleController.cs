using Microsoft.AspNetCore.Mvc;
using App.Models;

namespace App.Controllers
{
    public class ArticleController : Controller
    {
        public IActionResult Index(int id=1)
        {            
            var articles = new List<Article> {
                new Article {
                Id = 1,
                Title = "Artykuł jak Marcinek jest zjebany",
                Content = "Otoz jest zjebany w chuj",
                CreationDate = DateTime.Now
                },
                new Article {
                Id = 2,
                Title = "Artykul 2",
                Content = "Content dla artykułu drugiego",
                CreationDate = DateTime.Now
                },
                new Article {
                Id = 3,
                Title = "Artykuł 3",
                Content = "alez ja nienawidze tych studiów",
                CreationDate = DateTime.Now
                }
            };
            return View(articles[id-1]);
        }
    }
}