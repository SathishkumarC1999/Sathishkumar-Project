using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public  class OrderBll
    {
        private readonly OrderDal _orderDal;

        public OrderBll(OrderDal orderdal)
        {
            _orderDal = orderdal;
        }

        public List<DAL.model.Order> Get()
        {
            return _orderDal.Get();
        }
        public DAL.model.Order GetById(int Id)
        {
            return _orderDal.GetById(Id);
        }
        public void  save(DAL.model.Order order)
        {
            _orderDal.Save(order);
        }
        public void Update(DAL.model.Order order)
        {
            _orderDal.update(order);
        }
        public void Delete(int Id)
        {
            _orderDal.delete(Id);
        }
    }
}
