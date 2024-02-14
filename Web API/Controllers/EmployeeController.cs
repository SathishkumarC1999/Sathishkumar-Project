using BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeBll _employeeBll;

        public EmployeeController(EmployeeBll employeeBll)
        {
            _employeeBll = employeeBll;
        }
        [HttpGet("All")]
        public List<DAL.model.Employee> Get()
        {
            return _employeeBll.Get();
        }
        [HttpGet("GetById")]
        public DAL.model.Employee GetById(int EmpId)
        {
            return _employeeBll.GetById(EmpId); 
        }
        [HttpPost("Save")]
        public void Save(DAL.model.Employee employee)
        {
            _employeeBll.save(employee);
        }
        [HttpPut("Update")]
        public void Update(DAL.model.Employee employee)
        {
            _employeeBll.Update(employee);
        }
        [HttpDelete("Delete")]
        public void Delete(int EmpId)
        {
            _employeeBll.Delete(EmpId);
        }
    }
}
