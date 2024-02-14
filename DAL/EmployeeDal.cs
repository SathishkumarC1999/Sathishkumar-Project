using DAL.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class EmployeeDal
    {
        private readonly ClothSellingBusinessContext _context;

        public EmployeeDal(ClothSellingBusinessContext context)
        {
            _context = context;
        }

        public List<Employee> Get()
        {
           var employeeList = _context.Employees.ToList();
            if (employeeList == null || employeeList.Count <= 0)
                return null;
            return employeeList;
        }
        public Employee GetById(int EmpId)
        {
            var employeeDetails = _context.Employees.Where(x => x.EmpId == EmpId).FirstOrDefault();
            if (employeeDetails == null)
                return null;
            return employeeDetails;
        }
        public Employee Save(Employee employee)
        {
            if (employee == null)
                return null;
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return employee;
        }
        public Employee update(Employee employee)
        {
            if (employee == null)
                return null;

            var employeeDal = _context.Employees.Where(x => x.EmpId == employee.EmpId).FirstOrDefault();
            if (employeeDal == null)
                return null;

             employeeDal.EmpAddress=employee.EmpAddress;
            _context.SaveChanges();


            return employee;
        }
        public bool delete(int EmpId)
        {
            var employee = _context.Employees.Where(x => x.EmpId == EmpId).FirstOrDefault();
            if (employee == null)
                return false;
            _context.Remove(employee);
            _context.SaveChanges();

            return true;
        }
    }
}
