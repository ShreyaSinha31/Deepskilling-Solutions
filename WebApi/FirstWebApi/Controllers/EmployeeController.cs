using Microsoft.AspNetCore.Mvc;
using FirstWebApi.Filters;

namespace FirstWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    //[CustomAuthFilter]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new()
        {
            new Employee
            {
                Id = 1,
                Name = "Shreya",
                Salary = 50000,
                Permanent = true,
                DateOfBirth = new DateTime(2004,1,1),
                Department = new Department
                {
                    Id = 1,
                    Name = "IT"
                },
                Skills = new List<Skill>
                {
                    new Skill
                    {
                        Id = 1,
                        Name = "C#"
                    }
                }
            }
        };

        [HttpGet]
        public ActionResult<List<Employee>> Get()
        {
            return Ok(employees);
        }

        [HttpPut("{id}")]
        public ActionResult<Employee> UpdateEmployee(
            int id,
            [FromBody] Employee employee)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid employee id");
            }

            var existingEmployee =
                employees.FirstOrDefault(e => e.Id == id);

            if (existingEmployee == null)
            {
                return BadRequest("Invalid employee id");
            }

            existingEmployee.Name = employee.Name;
            existingEmployee.Salary = employee.Salary;
            existingEmployee.Permanent = employee.Permanent;
            existingEmployee.Department = employee.Department;
            existingEmployee.Skills = employee.Skills;
            existingEmployee.DateOfBirth = employee.DateOfBirth;

            return Ok(existingEmployee);
        }
    }
}