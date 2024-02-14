using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ProductBll
    {
        private readonly ProductDal _productDal;

        public ProductBll(ProductDal productDal)
        {
            _productDal = productDal;
        }

        public   List<DAL.model.Product> Get()
        {
            return _productDal.Get();
        }
        public DAL.model.Product GetById(int Id)
        {
            return _productDal.GetById(Id);
        }
        public void save(DAL.model.Product product)
        {
            _productDal.Save(product);
        }
        public void Update(DAL.model.Product product)
        {
            _productDal.update(product);
        }
        public void Delete(int Id)
        {
            _productDal.delete(Id);
        }
    }
}
