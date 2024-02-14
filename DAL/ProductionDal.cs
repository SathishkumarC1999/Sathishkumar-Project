using DAL.model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProductionDal
    {
        private readonly ClothSellingBusinessContext _context;

        public ProductionDal(ClothSellingBusinessContext context)
        {
            _context = context;
        }

        public List<Production> Get()
        {
            var productionList = _context.Productions.ToList();
            if (productionList == null || productionList.Count <=0)
                return null;
            return productionList;
        }
        public Production GetById(int Id)
        {
            var productionDetails = _context.Productions.Where(x => x.Id == Id).FirstOrDefault();
            if (productionDetails == null)
                return null;
            return productionDetails;
        }
        public Production save(Production production)
        {
            if (production == null)
                return null;
            _context.Productions.Add(production);
            _context.SaveChanges();
            return production;
        }
        public Production update(Production production)
        {
            if (production == null)
                return null;

            var productionDal = _context.Productions.Where(x => x.Id == production.Id).FirstOrDefault();
            if (productionDal == null)
                return null;
            productionDal.Productname = production.Productname;
            _context.SaveChanges();

            return production;
        }
        public bool delete(int Id)
        {
            var production = _context.Productions.Where(x => x.Id == Id).FirstOrDefault();
            if (production == null)
                return false;
            _context.Remove(production);
            _context.SaveChanges();

            return true;
        }

    }
}
