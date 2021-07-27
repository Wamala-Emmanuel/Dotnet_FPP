using RestAPICoreDemo.Model;
using System.Collections.Generic;
using System.Linq;

namespace RestAPICoreDemo.Service
{
    public class EmployeeService : IEmployeeService
    {
        public EmployeeContext _employeeDbContext;
        public EmployeeService(EmployeeContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
        }
        public Employee AddEmployee(Employee employee)
        {
            _employeeDbContext.Employees.Add(employee);
            _employeeDbContext.SaveChanges();
            return employee;
        }
        public List<Employee> GetEmployees()
        {
            return _employeeDbContext.Employees.ToList();
        }

        public void UpdateEmployee(Employee employee)
        {
            _employeeDbContext.Employees.Update(employee);
            _employeeDbContext.SaveChanges();
        }

        public void DeleteEmployee(int Id)
        {
            var employee = _employeeDbContext.Employees.FirstOrDefault(x => x.Id == Id);
            if (employee != null)
            {
                _employeeDbContext.Remove(employee);
                _employeeDbContext.SaveChanges();
            }
        }

        public Employee GetEmployee(int Id)
        {
            return _employeeDbContext.Employees.FirstOrDefault(x => x.Id == Id);
        }

    }
}
