using Microsoft.AspNetCore.Mvc;
using blackstoneEitAsg.Data;
using blackstoneEitAsg.Models;

namespace blackstoneEitAsg.Controllers
{
    public class AddEmployee : Controller
    {
        private readonly Empinfo _context;

        public AddEmployee(Empinfo context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult AddEmp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Employee model)
        {
      


            _context.Employees.Add(model);
            _context.SaveChanges();

            return RedirectToAction("Home", "Home");
        }
    }
}
