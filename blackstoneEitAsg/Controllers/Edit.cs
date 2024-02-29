using blackstoneEitAsg.Models;
using blackstoneEitAsg.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace blackstoneEitAsg.Controllers
{
    public class Edit : Controller
    {
        private readonly Empinfo _context;
       

        public Edit(Empinfo context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Editemp(int id)
        {
            var employee = _context.Employees.FirstOrDefault(x => x.Id == id);

            return View(employee);
        }
   
        [HttpPost]
        public IActionResult Editemp(Employee model) {
            var employee = _context.Employees.FirstOrDefault(x => x.Id == model.Id);


            employee.FirstName = model.FirstName;
            employee.MiddleName = model.MiddleName;
            employee.LastName = model.LastName;
            employee.Nationality = model.Nationality;
            employee.DateOfBirth = model.DateOfBirth;
            employee.Position = model.Position;
            employee.Salary = model.Salary;
            _context.SaveChanges();
            return RedirectToAction("Home", "Home");
        }
    }
}
