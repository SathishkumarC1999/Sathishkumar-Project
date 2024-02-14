using BLL;
using DAL;
using DAL.model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerBll _customerBll;
        public CustomerController(CustomerBll customerBll)
        {
            _customerBll = customerBll;
        }

        [HttpGet("All")]
        public List<DAL.model.Customer> Get()
        {
            return _customerBll.Get();

        }
        [HttpGet("GetById")]
        public DAL.model.Customer GetById(int Id)
        {// test
            return _customerBll.GetById(Id);
        }
        [HttpPost("Save")]
        public void Save(DAL.model.Customer customer)
        {
            _customerBll.Save(customer);
        }

        [HttpPut("Update")]
        public void Update(DAL.model.Customer customer)
        {
            _customerBll.Update(customer);

        }

        [HttpDelete("Delete")]
        public void Delete(int Id)
        {
            _customerBll.Delete(Id);
        }

       
    }
}
