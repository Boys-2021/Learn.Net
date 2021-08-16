using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using My_training.Models;

namespace My_training.services
{
    public class CharacterService : ICharacterService
    {
        private static List<Employee> employeeList = new List<Employee>{
            new Employee{Name = "Adrian"},
            new Employee{Name = "Kevin"}
        };
        public async Task<ServiceResponse<List<Employee>>> AddEmployee(Employee newEmployee)
        {
            employeeList.Add(newEmployee);
            var response = new ServiceResponse<List<Employee>>{Data = employeeList};
            return response;
        }

        public async Task<ServiceResponse<Employee>> GetEmployeeById(int Id)
        {
            var response = new ServiceResponse<Employee>();
                Employee temp = employeeList.FirstOrDefault(c=> c.Id == Id);
                if(temp!=null){
                response.Data = temp;
                }else{
                response.Message = "No Entry Found";
                response.Success = false;}
            return response;
        }

        public async Task<ServiceResponse<List<Employee>>> GetAllEmployees(){
            var response = new ServiceResponse<List<Employee>>{Data = employeeList};
            return response;
        }
    }
}