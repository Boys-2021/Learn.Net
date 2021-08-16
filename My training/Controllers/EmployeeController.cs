using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using My_training.Models;
using My_training.services;

namespace My_training.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly ICharacterService _service;
        public EmployeeController(ICharacterService service)
        {
            _service = service;

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<Employee>>> GetEmployeeById(int Id)
        {
            ServiceResponse<Employee> response = await _service.GetEmployeeById(Id);
            if(response.Success==false){
                return NotFound(response);
            }
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Employee>>>> AddEmployee(Employee newEmployee){
            return await _service.AddEmployee(newEmployee);
        }

        public async Task<ActionResult<ServiceResponse<List<Employee>>>> GetAllEmployee(){
            return await _service.GetAllEmployees();
        }
    }
}