using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        IEmployeeDal _employeeDal;
        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public void AddEmployee(Employee employee)
        {
            _employeeDal.Add(employee);
        }

        public void DeleteEmployee(Employee employee)
        {
            _employeeDal.Delete(employee);
        }

        public List<Employee> GetAll()
        {
            return _employeeDal.GetAll();
        }

        public List<Employee> GetAllEmployeesWithCity()
        {
            return _employeeDal.GetAllWithCity();
        }

        public Employee GetById(int id)
        {
            return _employeeDal.Get(p=>p.EmployeeID==id);
        }

        public void UpdateEmployee(Employee employee)
        {
            _employeeDal.Update(employee);
        }
    }
}
