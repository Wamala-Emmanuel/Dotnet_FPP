using RestAPICoreDemo.Model;
using System.Collections.Generic;

namespace RestAPICoreDemo.Service
{
    public interface IEmployeeService
    {

        Employee AddEmployee(Employee employee);

        List<Employee> GetEmployees();

        void UpdateEmployee(Employee employee);

        void DeleteEmployee(int Id);

        Employee GetEmployee(int Id);
    }
}
