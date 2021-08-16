using System.Collections.Generic;
using System.Threading.Tasks;
using My_training.Models;

namespace My_training.services
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<Employee>>>  AddEmployee(Employee newEmployee);
        Task<ServiceResponse<Employee>> GetEmployeeById(int Id);
        Task<ServiceResponse<List<Employee>>> GetAllEmployees();
    }
}