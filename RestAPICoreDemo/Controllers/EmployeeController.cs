using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestAPICoreDemo.Model;
using RestAPICoreDemo.Service;

namespace RestAPICoreDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Employee/GetEmployees")]
        public IEnumerable<Employee> GetEmployees()
        {
            return _employeeService.GetEmployees();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Employee/AddEmployee")]
        public IActionResult AddEmployee(Employee employee)
        {
            _employeeService.AddEmployee(employee);
            return Ok();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Employee/UpdateEmployee")]
        public IActionResult UpdateEmployee(Employee employee)
        {
            _employeeService.UpdateEmployee(employee);
            return Ok();
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/Employee/DeleteEmployee")]
        public IActionResult DeleteEmployee(int id)
        {
            var existingEmployee = _employeeService.GetEmployee(id);
            if (existingEmployee != null)
            {
                _employeeService.DeleteEmployee(existingEmployee.Id);
                return Ok();
            }
            return NotFound($"Employee Not Found with ID : {existingEmployee.Id}");
        }

        [HttpGet]
        [Route("GetEmployee")]
        public Employee GetEmployee(int id)
        {
            return _employeeService.GetEmployee(id);
        }

    }
}
