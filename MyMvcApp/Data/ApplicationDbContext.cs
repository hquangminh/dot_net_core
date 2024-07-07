using Microsoft.EntityFrameworkCore;
using MyMvcApp.Controllers;
using MyMvcApp.Models;

namespace MyMvcApp
{
  public class ApplicationDbContext : DbContext
  {
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {

    }
    public DbSet<Category> Categories
    {
      get; set;
    }
  }
}