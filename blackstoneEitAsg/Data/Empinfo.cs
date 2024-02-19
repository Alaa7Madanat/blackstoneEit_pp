using blackstoneEitAsg.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Intrinsics.Arm;

namespace blackstoneEitAsg.Data;

    public class Empinfo : DbContext
    {
    public Empinfo()
    {
    }

    public Empinfo(DbContextOptions options) :base(options) 
    { 

    }
   
    public DbSet<Employee> Employees { get; set; } = null;
    public DbSet<Admin> Admins { get; set; } = null;

 
   
    }


