using DAL.model;

namespace DAL
{
    public class CustomerDal
    {
        private readonly ClothSellingBusinessContext _context;

        public CustomerDal(ClothSellingBusinessContext context)
        {
            _context = context;
        }
 
        public List<Customer> Get()
        {
            var customerList = _context.Customers.ToList();
             
            if (customerList == null || customerList.Count <= 0) 
                return null;
            return customerList;
        }
        public Customer GetById(int Id)
        {
            var customerDetail = _context.Customers.Where(x => x.Id == Id).FirstOrDefault();
            if (customerDetail == null)
                return null;
            return customerDetail;

        }
        public Customer Save(Customer customer)
        {
            if (customer == null)
                return null;
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return customer;

        }
        public Customer update(Customer customer)
        {
            if (customer == null)
                return null;

            var customerdal = _context.Customers.Where(x => x.Id == customer.Id).FirstOrDefault();

            if (customerdal == null)
                return null;

            customerdal.PhoneNumber = customer.PhoneNumber;

            _context.SaveChanges();

            return customer;
        }
        public bool delete(int id)
        {
            var customer = _context.Customers.Where(x => x.Id == id).FirstOrDefault();
            if (customer == null)
                return false;
            _context.Remove(customer);
            _context.SaveChanges();
            return true;

        }
    }
}
