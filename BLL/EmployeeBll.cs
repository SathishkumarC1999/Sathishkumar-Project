using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EmployeeBll
    {
        private readonly EmployeeDal _employeeDal;
        public EmployeeBll(EmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public List<DAL.model.Employee> Get()
        {
            return _employeeDal.Get();
        }

        public DAL.model.Employee GetById(int empId)
        {
           return _employeeDal.GetById(empId);
        }
        public void save(DAL.model.Employee employee)
        {
             _employeeDal.Save(employee);
        }
        public void Update(DAL.model.Employee employee)
        {
            _employeeDal.update(employee);
        }
        public void Delete(int empId)
        {
            _employeeDal.delete(empId);
        }
    }
}
