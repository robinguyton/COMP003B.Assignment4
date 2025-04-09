using System.Reflection;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment4.Controllers
{
    public class RegistrationController : Controller
    {
        // The [Route("product")] attribute specifies that the controller will handle requests that start with "/Register".

    

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

            [HttpGet]
            public IActionResult Success(RegistrationController model)
            { return View(model); }
        }


}

