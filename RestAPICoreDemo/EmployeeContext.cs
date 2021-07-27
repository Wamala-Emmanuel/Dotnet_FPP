using Microsoft.EntityFrameworkCore;
using RestAPICoreDemo.Model;

namespace RestAPICoreDemo
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Company {get; set;}
    }
}
