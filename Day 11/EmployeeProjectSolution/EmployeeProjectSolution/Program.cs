using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProjectSolution
{
    class Program
    {
       

         void manageMenu()
        {
            ManageMenu mm = new ManageMenu();
            Console.WriteLine("Welcome to Employee Menu Management");
            int choice = 0;

            do
            {
                Console.WriteLine("1: Add Employee : ");
                Console.WriteLine("2: Edit Employee Age : ");
                Console.WriteLine("3: Print Employee Details : ");
                Console.WriteLine("4: Delete an Employee : ");
                Console.WriteLine("5: Exit");
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Please enter a number");
                }
                
                switch (choice)
                {
                    case 1:
                        mm.AddEmployee();
                        break;
                    case 2:
                        mm.EditEmployeeAge();
                        break;
                    case 3:
                        mm.GetAllEmployee();
                        break;
                    case 4:
                        mm.DeleteEmployee();
                        break;
                    case 0:
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again");
                        break;
                }
            }
            while (choice != 0);
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.manageMenu();
            Console.ReadKey();
        }
    }
}
