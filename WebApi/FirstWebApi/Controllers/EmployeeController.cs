using Microsoft.AspNetCore.Mvc;

namespace FirstWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        private static List<Employee> employees = new()
        {
            new Employee{ Id=1, Name="Shreya", Department="IT"},
            new Employee{ Id=2, Name="Rahul", Department="HR"},
            new Employee{ Id=3, Name="Priya", Department="Finance"}
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(employees);
        }
    }
}