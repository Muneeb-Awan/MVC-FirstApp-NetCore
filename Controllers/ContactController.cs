using Microsoft.AspNetCore.Mvc;
using MyWebApp.Models;
namespace MyWebApp.Controllers
{
    public class ContactController : Controller
    {
        public Contact Contact = new Contact();
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Submit(Contact model)
        {
            Contact = model;

            return View(model);
        }
    }
}
