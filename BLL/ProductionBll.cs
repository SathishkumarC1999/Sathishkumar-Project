using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductionBll
    {
        private readonly ProductionDal _productionDal;

        public ProductionBll(ProductionDal productionDal)
        {
            _productionDal = productionDal;
        }

        public List<DAL.model.Production> Get()
        {
            return _productionDal.Get();
        }
        public DAL.model.Production GetById(int Id)
        {
            return _productionDal.GetById(Id);
        }
        public void Update(DAL.model.Production production)
        {
            _productionDal.update(production);
        }
        public void Save(DAL.model.Production production)
        {
            _productionDal.save(production);
        }
        public void Delete(int Id)
        {
            _productionDal.delete(Id);
        }
    }
}
