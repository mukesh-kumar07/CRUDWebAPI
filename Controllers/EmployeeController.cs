using FirstWebAPI.Model;
using FirstWebAPI.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private EmployeeRepository employeeRepository = new EmployeeRepository();
        
        [HttpGet]
        public ActionResult<IEnumerable<EmployeeClass>> GetEmployees()
        {
            return employeeRepository.GetEmployees();
        }

        [HttpGet("{id}")]
        public ActionResult<EmployeeClass> GetEmployee(int id)
        {
            if(GetEmployee(id) == null)
            {
                return NotFound("Sorry, Not Found!!!");
            }
            return employeeRepository.GetEmployee(id);
        }    
    }
}
