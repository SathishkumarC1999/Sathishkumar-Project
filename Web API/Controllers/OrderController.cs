using BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly OrderBll _orderBll;

        public OrderController(OrderBll orderBll)
        {
            _orderBll = orderBll;
        }

        [HttpGet("All")]
        public List<DAL.model.Order> Get()
        {
            return _orderBll.Get();
        }
        [HttpGet("GetById")]
        public DAL.model.Order GetById(int Id)
        {
           return _orderBll.GetById(Id);
        }
        [HttpPost("Save")]
        public void Save(DAL.model.Order order)
        {
            _orderBll.save(order);
        }
        [HttpPut("Update")]
        public void Update(DAL.model.Order order)
        {
            _orderBll.Update(order);
        }
        [HttpDelete("Delete")]
        public void Delete(int Id)
        {
            _orderBll.Delete(Id);
        }
            
    }
}
