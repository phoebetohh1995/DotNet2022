using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModelLibrary
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Employee> Employees { get; set; }

        public void GetDepartmentDetails()
        {
            Console.WriteLine("Please enter department name : ");
            string name = Console.ReadLine();
            while (string.IsNullOrEmpty(name))
            { 
                Console.WriteLine("Department name cannot be empty.");
            }
            Name = name;
        }

        public override string ToString()
        {
            return "Department ID: " + Id
                + "\nDepartment Name: " + Name;
        }
    }
}
