using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeModelLibrary;

namespace EmployeeDALLibrary
{
    public class DepartmentDAL
    {
        readonly EmployeeContext _employeeContext;

        public DepartmentDAL()
        {
            _employeeContext = new EmployeeContext();
        }
        public ICollection<Department> GetAllDepartment()
        {
            List<Department> departments = _employeeContext.Departments.ToList();
            if (departments.Count == 0)
                throw new NoRecordException();
            return departments;
        }

        public bool InsertNewDepartment(Department dept)
        {
            _employeeContext.Departments.Add(dept);
            _employeeContext.SaveChanges();
            return true;
        }
        public bool UpdateDepartmentName(Department dept)
        {
            Department department = _employeeContext.Departments.SingleOrDefault(p => p.Id == dept.Id);
            if (department == null)
                return false;
            department.Name = dept.Name;
            _employeeContext.SaveChanges();
            return true;
        }
        public void DeleteDepartmentById(int id)
        {
            _employeeContext.Departments.Remove(_employeeContext.Departments.Single(d => d.Id == id));
            _employeeContext.SaveChanges();
        }

    }
}
