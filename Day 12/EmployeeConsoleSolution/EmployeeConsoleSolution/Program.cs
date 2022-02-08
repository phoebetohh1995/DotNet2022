using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeConsoleSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to menu management");
            int choice = 0;
            ManageMenu menu = new ManageMenu();
            ManageDepartment md = new ManageDepartment();
            do
            {
                Console.WriteLine("=========EMPLOYEE=========");
                Console.WriteLine("1: Add Employee");
                Console.WriteLine("2: Edit Employee Age");
                Console.WriteLine("3: Edit Employee Department");
                Console.WriteLine("4: Print all Employees");
                Console.WriteLine("=========DEPARTMENT=========");
                Console.WriteLine("5: Add Department");
                Console.WriteLine("6: Edit Department Name");
                Console.WriteLine("7: Print Departments");
                Console.WriteLine("0: Exit");

                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Try again. Please enter a number");
                }
                try
                {
                    switch (choice)
                    {
                        case 1:
                            menu.AddEmployee();
                            break;
                        case 2:
                            menu.EditEmployeeAge();
                            break;
                        case 3:
                            menu.EditEmployeeDept();
                            break;
                        case 4:
                            menu.PrintEmployees();
                            break;
                        case 5:
                            md.AddDepartment();
                            break;
                        case 6:
                            md.UpdateDepartmentName();
                            break;
                        case 7:
                            md.PrintDepartments();
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again");
                            break;
                    }
                }
                catch (NullReferenceException nre)
                {
                    Console.WriteLine("Null by mistake");
                    Console.WriteLine(nre.Message);
                }
                catch (ArgumentOutOfRangeException aore)
                {
                    Console.WriteLine("The employee could not be found");
                    Console.WriteLine(aore.Message);
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("expecting a number");
                    Console.WriteLine(fe.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Something went wrong");
                    Console.WriteLine(e.Message);
                }
            } while (choice != 0);
        }
    }
}
