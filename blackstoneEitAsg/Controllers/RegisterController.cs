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
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Admin model)
        {
       

            _context.Admins.Add(model);
            _context.SaveChanges();

            return View();
        }
    }
}
