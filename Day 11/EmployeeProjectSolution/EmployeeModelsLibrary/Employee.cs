using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeModelsLibrary
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public int Age { get; set; }

        public void GetEmployeeDetails()
        {
            Console.WriteLine("Please enter the employee name :");
            Name = Console.ReadLine();

            Console.WriteLine("Please enter the employee's age :");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age))
                {
                Console.WriteLine("Invalid Age. Please enter again: ");
                }
            Age = age;
        }

        public override string ToString()
        {
            return "Employee ID " + Id
                +  "\nEmployee Name " + Name
                +  "\nEmployee Age" + Age;
        }
    }
}
