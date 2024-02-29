using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using blackstoneEitAsg.Data;
using blackstoneEitAsg.Models;

namespace blackstoneEitAsg.Controllers
{
    public class HomeController : Controller
    {
        private readonly Empinfo _context;

        public HomeController(Empinfo context)
        {
            _context = context;
        }

  

        public IActionResult Home()
        {
            var employees = _context.Employees.ToList();
            return View(employees);
        }

    

        public IActionResult Delete(int id)
        {
            var employee = _context.Employees.FirstOrDefault(x => x.Id == id);
            if (employee == null)
            {
                return NotFound(); 
            }
            _context.Employees.Remove(employee);

            _context.SaveChanges();

            return RedirectToAction("Home");
        }
  


        public IActionResult Search(string query)
        {
            if (query is null)
            {
                return RedirectToAction("Home");
            }
            var employees = _context.Employees.Where(e => e.FirstName.Contains(query)).ToList();

            return View("~/Views/Home/Home.cshtml", employees);
            
          
        }

     
        }
    }

