using AspNetCoreGeneratedDocument;
using COMP003B.Assignment4.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment4.Controllers
{
    public class TourController : Controller // Inherit from Controller to use View()
    {
        public int? Id { get; set; }
        public string? Title { get; set; }
        public string? Summary { get; set; }

        public IActionResult Privacy()
        {
            var ArsenalModel = new List<ArsenalModel>
                           {
                               new ArsenalModel { Id = 1, Title = "Last 3 Games", Summary = "Team performance over the last 3 games" },
                               new ArsenalModel { Id = 2, Title = "Arsenal Stars", Summary = "Who are the top performing players at the club right now?" }
                           };

            return View("Stars");
        }

        public class AboutArsenalController : Controller
        {
            [HttpGet("AboutArsenal/Last3Games")]
            public IActionResult Last3Games()
            {
                return View();
            }
        }

        public IActionResult Details(int id)
        {
         
            var article = new ArsenalModel { Id = id, Title = $"Article {id}", Summary = "Detailed content coming soon." };
            return View(article);
        }
    }

}
