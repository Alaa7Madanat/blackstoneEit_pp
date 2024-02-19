using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace blackstoneEitAsg.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; } = null; 
        public string? MiddleName { get; set; } 
        public string LastName { get; set; } = null;

        public  string Nationality { get; set; }= null;
        public string DateOfBirth { get; set; } = null;
        public string Position { get; set; } = null;
        public int Salary { get; set; }
    }
}
