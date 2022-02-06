using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeDALLibrary;
using EmployeeModelLibrary;

namespace EmployeeConsoleSolution
{
    internal class ManageDepartment
    {
        List<Department> departments;
        DepartmentDAL departmentDAL;

        public ManageDepartment()
        {
            departmentDAL = new DepartmentDAL();
        }
        public void GetAllDepartment()
        {
            departments = null;
            try
            {
                departments = departmentDAL.GetAllDepartment().ToList();
            }
            catch (NoRecordException nre)
            {
                Console.WriteLine(nre.Message);
            }
            catch (Exception npe)
            {
                Console.WriteLine("Something went wrong. Will fix soon...");
                Console.WriteLine(npe.Message);
            }
        }
        public void AddDepartment()
        {
            Department department = new Department();
            department.GetDepartmentDetails();
            try
            {
                departmentDAL.InsertNewDepartment(department);
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not add the department");
                Console.WriteLine(e.Message);
            }
        }
        public void UpdateDepartmentName()
        {
            int id = GetDepartmentIdFromUser();
            Department department = GetDepartmentById(id);
            if (department == null)
            {
                Console.WriteLine("Invalid Id. Cannot edit");
                return;
            }
            try
            {
                department.GetDepartmentDetails();
                departmentDAL.UpdateDepartmentName(department);
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not update the department");
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Update department as below: ");
            PrintDepartment(department);
        }

        public void DeleteDepartment()
        {
            
            int id = GetDepartmentIdFromUser();
            Department department = GetDepartmentById(id);
            if (department == null)
            {
                Console.WriteLine("There's no such department.");
                return;
            }
            try
            {
                departmentDAL.DeleteDepartmentById(id);

            }
            catch (Exception e)
            {
                Console.WriteLine("Could not remove the department");
                Console.WriteLine(e.Message);
            }
            
            PrintDepartment(department);
        }
        public Department GetDepartmentById(int id)
        {
            GetAllDepartment();
            Department department = departments.SingleOrDefault(p => p.Id == id);
            return department;
        }

        public void PrintDepartments()
        {
            GetAllDepartment();
            var sortedEmployees = departments.OrderBy(p => p.Id);
            foreach (var item in sortedEmployees)
            {
                if (item != null)
                    PrintDepartment(item);
            }
        }
        private void PrintDepartment(Department item)
        {

            Console.WriteLine("-------------------------");
            Console.WriteLine(item);
            Console.WriteLine("-------------------------");
        }
        int GetDepartmentIdFromUser()
        {
            Console.WriteLine("Please enter the department id");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid entry ID. Please try again...");
            }
            return id;
        }

    }


}
