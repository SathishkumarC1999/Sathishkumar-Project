using DAL;

namespace BLL
{
    public class CustomerBll
    {
        private readonly CustomerDal _customerdal;
        public CustomerBll(CustomerDal customerDal)
        {
            _customerdal = customerDal;
        } 

        public List<DAL.model.Customer> Get()
        {
           return _customerdal.Get();
            
        }
        public DAL.model.Customer GetById(int Id)
        {
            return _customerdal.GetById(Id);
        }
        public void Update(DAL.model.Customer customer)
        {
            _customerdal.update(customer);
         
        }
        public void Delete(int Id)
        {
            _customerdal.delete(Id);
        }
        public void Save(DAL.model.Customer customer)
        {
            _customerdal.Save(customer);
        }

    }
}
