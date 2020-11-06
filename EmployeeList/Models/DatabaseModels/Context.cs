using EmployeeList.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeList.Controllers
{
    public class Context : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
