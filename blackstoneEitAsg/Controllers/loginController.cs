using Microsoft.AspNetCore.Mvc;
using blackstoneEitAsg.Data;
using blackstoneEitAsg.Models;


namespace blackstoneEitAsg.Controllers
{
    public class LoginController : Controller
    {
        private readonly Empinfo _context;

        public LoginController(Empinfo context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [Route("/")]
        public IActionResult Login(Admin model)
        {
            var admin = _context
                .Admins
                .FirstOrDefault(a => a.Username == model.Username && a.Password == model.Password);

            if (admin is not null)
            {
                return RedirectToAction("Home", "Home");
            }
            ViewBag.WrongPassword = "The password is wrong";
            return View();
        }
    }
}
