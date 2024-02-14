using BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductBll _productBll;

        public ProductController(ProductBll productBll)
        {
            _productBll = productBll;
        }

        [HttpGet("All")]
        public List<DAL.model.Product> Get()
        {
            return _productBll.Get();
        }
        [HttpGet("GetById")]
        public DAL.model.Product GetById(int Id)
        {
            return _productBll.GetById(Id);
        }
        [HttpPost("Save")]
        public void Save(DAL.model.Product product)
        {
            _productBll.save(product);
        }
        [HttpPut("Update")]
        public void Update(DAL.model.Product product)
        {
            _productBll.Update(product);
        }
        [HttpDelete("Delete")]
        public void Delete(int Id)
        {
            _productBll.Delete(Id); 
        }
    }
}
