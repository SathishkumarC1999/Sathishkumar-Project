using BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductionController : ControllerBase
    {
        private readonly ProductionBll  _productionBll;

        public ProductionController(ProductionBll productionBll)
        {
            _productionBll = productionBll;
        }
        [HttpGet("All")]
        public List<DAL.model.Production> Get()
        {
            return _productionBll.Get();
        }
        [HttpGet("GetById")]
        public DAL.model.Production GetById(int Id)
        {
            return _productionBll.GetById(Id);
        }
        [HttpPost("Save")]
        public void Save(DAL.model.Production production)
        {
            _productionBll.Save(production);
        }
        [HttpPut("Update")]
        public void Update(DAL.model.Production production)
        {
            _productionBll.Update(production);
        }
        [HttpDelete("Delete")]
        public void Delete(int Id)
        {
            _productionBll.Delete(Id);
        }
    }
}
