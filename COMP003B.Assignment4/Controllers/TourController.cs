using AspNetCoreGeneratedDocument;
using COMP003B.Assignment4.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment4.Controllers
{
    public class TourController : Controller
    {
        [HttpGet]
        public IActionResult Stars()
        {
            var stars = new List<ArsenalModel>
                {
                    new ArsenalModel { Id = 1, Title = "Declan Rice", Summary = "Man of the Match vs. Real Madrid" },
                    new ArsenalModel { Id = 2, Title = "Bukayo Saka", Summary = "Arsenal's most important attacking player" },
                    new ArsenalModel { Id = 3, Title = "Gabriel Magalhaes", Summary = "Arsenal's most important defender" },
                };

            return View(stars);
        }

        [HttpGet]
        public IActionResult Last3Games()
        {
            var arsenalModelList = new List<ArsenalModel>
                {
                    new ArsenalModel { Id = 1, Title = "Arsenal vs. Real Madrid", Summary = "3 - 0 WIN" },
                    new ArsenalModel { Id = 2, Title = "Arsenal vs. Everton", Summary = "1 - 1  Draw" },
                    new ArsenalModel { Id = 3, Title = "Arsenal vs. Fulham", Summary = "2 - 1 WIN" },
                };

            return View("Last3Games", arsenalModelList);
        }

        [HttpGet]
        public IActionResult Last3GamesDetails(int id)
        {
            var article = new ArsenalModel { Id = id, Title = $"Last3Games {id}", Summary = "Check out our most recent results!" };
            return View("Last3GamesDetails", article);
        }
    }

}
