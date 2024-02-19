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
            return View("~/Views/Home/AddEmp.cshtml");
        }

        [HttpPost]
        public IActionResult Add(Employee model)
        {
            var employee = new Employee
            {
                FirstName = model.FirstName,
                MiddleName = model.MiddleName,
                LastName = model.LastName,
                Nationality = model.Nationality,
                DateOfBirth = model.DateOfBirth,
                Position = model.Position,
                Salary = model.Salary,
            };

            _context.Employees.Add(employee);
            _context.SaveChanges();

            return RedirectToAction("Home", "Home");
        }
    }
}
