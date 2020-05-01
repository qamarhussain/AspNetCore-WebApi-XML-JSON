using System.Collections.Generic;
using AspNetWebApiXMLJson.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetWebApiXMLJson.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet("get.{format}"),FormatFilter]
        public IEnumerable<Employee> Get()
        {
            var employees = new List<Employee>
            {
                new Employee{Id=1,FirstName="Qamar",LastName="Hussain"},
                new Employee{Id=1,FirstName="Ali",LastName="Abid"}
            };
            return employees;
        }

        [HttpPost("post.{format}"), FormatFilter]
        public Employee Post([FromBody]Employee employee)
        {
            if (ModelState.IsValid)
            {
                return employee;
            }
            return null;
        }
    }
}