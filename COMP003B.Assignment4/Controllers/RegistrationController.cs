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

        [HttpPost]
        public IActionResult Register([FromForm] RegistrationController model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return RedirectToAction("GameTime", model);
        }

        [HttpGet("Register/FanClub")]
        public IActionResult FanClub()
        {
            return View("~/Views/Register/FanClub.cshtml");
        }

        [HttpPost]
        public IActionResult FanClub([FromForm] RegistrationController model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Add a return statement to handle all code paths
            return RedirectToAction("GameTime", model);
        }

        [HttpGet]
        public IActionResult GameTime(RegistrationController model)
        {
            return View(model);
        }
    }


}