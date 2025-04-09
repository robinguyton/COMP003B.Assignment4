using Microsoft.AspNetCore.Mvc;

namespace COMP003B.TourController.Controllers
{
    public class RegisterModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }

        public IActionResult Index()
        {
            var registerModel = new List<RegisterModel>
        {
            new RegisterModel { Id = 1, Title = "Last 3 Games", Summary = "Team performance over the last 3 games" },
            new RegisterModel{ Id = 2, Title = "Arsenal Stars", Summary = "Who are the top performing players at the club right now?" }

        };

            return view ();
        }

        private IActionResult view()
        {
            throw new NotImplementedException();
        }

        public IActionResult Stars(int id)
        {
            var registermodel = new RegisterModel { Id = id, Title = $"Article {id}", Summary = "Detailed content coming soon." };
            return view();
        }

        private IActionResult View(RegisterModel article)
        {
            throw new NotImplementedException();
        }
    }

}
