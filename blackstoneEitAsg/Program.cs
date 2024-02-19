using System;
using System.Net.Http.Headers;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using blackstoneEitAsg.Data;
using blackstoneEitAsg.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder
    .Services
    .AddDbContext<Empinfo>(options =>
    {
        string connectionString = builder.Configuration.GetConnectionString("DefaultConnection")!;
        options.UseSqlServer(connectionString);
    });

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
