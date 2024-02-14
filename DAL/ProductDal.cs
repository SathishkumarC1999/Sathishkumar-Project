using DAL.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductDal
    {
        private readonly ClothSellingBusinessContext _context;

        public ProductDal(ClothSellingBusinessContext context)
        {
            _context = context;
        }

        public List<Product> Get()
        {
            var productList = _context.Products.ToList();
            if (productList == null || productList.Count <= 0)
                return null;
            return productList;
        }
        public Product GetById(int Id)
        {
            var productDetails = _context.Products.Where(x => x.Id == Id).FirstOrDefault();
            if (productDetails == null)
                return null;
            return productDetails;
        }
        public Product Save(Product product)
        {
            if (product == null)
                return null;
            _context.Products.Add(product);
            _context.SaveChanges();

            return product;
        }
        public Product update(Product product)
        {
            if (product == null)
                return null;

            var productDal = _context.Products.Where(x => x.Id == product.Id).FirstOrDefault();
            if (productDal == null)
                return null;
            productDal.Color = product.Color;
            _context.SaveChanges();

            return product;
        }
        public bool delete(int Id)
        {
            var product = _context.Products.Where(x => x.Id == Id).FirstOrDefault();
            if (product == null)
                return false;
            _context.Remove(product);
            _context.SaveChanges();
            return true;  
        }
    }
}
