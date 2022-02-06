using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using EmployeeModelLibrary;

namespace EmployeeDALLibrary
{
    public class EmployeeDAL
    {
        readonly EmployeeContext _employeeContext;
        public EmployeeDAL()
        {
            _employeeContext = new EmployeeContext();
        }

        public ICollection<Employee> GetAllEmployee()
        {
            List<Employee> employees = _employeeContext.Employees.ToList();
            if (employees.Count == 0)
                throw new NoRecordException();
            return employees;
        }

        public bool InsertNewEmployee(Employee employee)
        {
            _employeeContext.Employees.Add(employee);
            _employeeContext.SaveChanges();
            return true;
        }
        public bool UpdateEmployeeAge(Employee emp)
        {
            Employee employee = _employeeContext.Employees.SingleOrDefault(p => p.Id == emp.Id);
            if (employee == null)
                return false;
            employee.Age = emp.Age;
            _employeeContext.SaveChanges();
            return true;
        }

        public bool UpdateEmployeeDepartment(Employee emp)
        {
            Employee employee = _employeeContext.Employees.SingleOrDefault(p => p.Id == emp.Id);
            if (employee == null)
                return false;
            employee.Id = emp.Id;
            _employeeContext.SaveChanges();
            return true;
        }

        
        


    }
}
