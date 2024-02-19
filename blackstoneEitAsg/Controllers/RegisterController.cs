using blackstoneEitAsg.Data;
using blackstoneEitAsg.Models;
using Microsoft.AspNetCore.Mvc;

namespace blackstoneEitAsg.Controllers
{
    public class RegisterController : Controller
    {
        private readonly Empinfo _context;

        public RegisterController(Empinfo context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Signup(Admin model)
        {
            var admin = new Admin
            {
                Username = model.Username,
                Email = model.Email,
                Password = model.Password,
            };

            _context.Admins.Add(admin);
            _context.SaveChanges();

            return View("~/Views/Home/Index.cshtml");
        }
    }
}
