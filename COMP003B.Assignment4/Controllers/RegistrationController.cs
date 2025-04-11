using System.Reflection;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment4.Controllers
{
    public class RegistrationController : Controller
    {
        [HttpGet("Register/Tickets")]
        public IActionResult Tickets()
        {
            return View();
        }

        [HttpPost("Register/Tickets")]
        public IActionResult Tickets([FromForm] RegisterModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            return RedirectToAction("GameTime");
        }

        [HttpGet]
        public IActionResult GameTime()
        {
            return View();
        }

        [HttpPost("Views/Register/FanClub")]
        public IActionResult FanClub([FromForm] object model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return RedirectToAction("GameTime");
        }

        [HttpGet("Views/Register/FanClub")]
        public IActionResult FanClub()
        {
            return View();
        }
    }


}