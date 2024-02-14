using DAL.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class OrderDal
    {
        private readonly ClothSellingBusinessContext _context;

        public OrderDal(ClothSellingBusinessContext context)
        {
            _context = context;
        }

        public List<Order> Get()
        {
            var orderList = _context.Orders.ToList();
            if (orderList == null || orderList.Count <= 0)
                return null;
            return orderList;
        }
        public Order GetById(int Id)
        {
            var orderDetails = _context.Orders.Where(x => x.Id == Id).FirstOrDefault();
            if (orderDetails == null)
                return null;
            return orderDetails;
        }
        public Order Save(Order order)
        {
            if (order == null)
                return null;
            _context.Orders.Add(order);
            _context.SaveChanges();

            return order;
        }
        public Order update(Order order)
        {
            if (order == null)
                return null;

            var orderDal = _context.Orders.Where(x => x.Id == order.Id).FirstOrDefault();
            if (orderDal == null)
                return null;
            orderDal.CoreProducts = order.CoreProducts;
            _context.SaveChanges();

            return order;
        }
        public bool delete(int Id)
        {
            var order = _context.Orders.Where(x => x.Id == Id).FirstOrDefault();
            if (order == null)
                return false;
            _context.Remove(order);
            _context.SaveChanges();

            return true;
        }
    }
}
