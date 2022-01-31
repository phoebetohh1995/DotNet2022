using ClinicModelsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ClinicModelsLibrary;


namespace Day5Assignment
{
    class Program
    {

        ManageAppt appts = new ManageAppt();
        public bool added = false;

        public void MainMenu()
        {
            int choice = 0;

            string username = "";
            string password = "";

            do
            {
                if (added == false)
                {
                    appts.addItemstoList();
                    added = true;
                }

                Console.WriteLine("\nWelcome to the clinic");
                Console.WriteLine("Key in 1 if you are a doctor :");
                Console.WriteLine("Key in 2 if you are a patient :");
                Console.WriteLine("Key in 0 to exit");
                Console.Write("Choice: ");
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    if (choice == 1)
                    {
                        Console.WriteLine("\nHello Doctor");
                        Console.Write("Please enter your username: ");
                        username = Console.ReadLine();
                        Console.Write("Please enter your password: ");
                        password = Console.ReadLine();

                        if (username.Trim().Equals("phoebe") && password.Trim().Equals("456456"))
                        {
                            Console.WriteLine("\nHello Dr Phoebe");
                            doctorMenu();
                        }
                        else
                        {
                            Console.WriteLine("Incorrect details, please try again");
                            MainMenu();
                        }
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("\nHello Patient ");

                        Console.Write("Please enter your username: ");
                        username = Console.ReadLine();
                        Console.Write("Please enter your password: ");
                        password = Console.ReadLine();

                        if (username.Trim().Equals("brandon") && password.Trim().Equals("123123"))
                        {
                            Console.WriteLine("\nHello Patient Brandon");
                            patientMenu();
                        }
                        else
                        {
                            Console.WriteLine("Incorrect details, please try again.");
                            MainMenu();
                        }
                    }
                    else if (choice == 0)
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice, please try again.");
                        MainMenu();
                    }
                }
                else
                {
                    Console.WriteLine("Try again. Please enter a number.");
                    MainMenu();

                }
            }
            while (choice != 0);
        }

        public void doctorMenu()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("\nChoose from the options");
                Console.WriteLine("1: View upcoming appointments :");
                Console.WriteLine("2: View past appointments :");
                Console.WriteLine("3: Edit details of an Appointment :");
                //Console.WriteLine("4: Delete an Appointment :");
                Console.WriteLine("0: Logout");
                Console.Write("Choice: ");

                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.Write("Try again. Please enter a number.");
                }
                switch (choice)
                {
             
                    case 1:
                        appts.viewUpcomingAppt();
                        break;
                    case 2:
                        appts.viewPastAppts();
                        break;
                    case 3:
                        appts.editAppt();
                        break;
                    //case 4:
                    //    appts.deleteAppt();
                    //    break;
                    case 0:
                        MainMenu();
                        break;
                    default:
                        Console.Write("Invalid choice. Please try again: ");
                        break;
                }
            } while (choice != 0);
        }

        public void patientMenu()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("\nChoose from the options");
                Console.WriteLine("1: View upcoming appointments :");
                Console.WriteLine("2: View past appointments :");
                Console.WriteLine("3: Pay for appointment :");
                Console.WriteLine("4: Create appointment :");
                Console.WriteLine("0: Logout");
                Console.Write("Choice: ");
                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.Write("Try again. Please enter a number: ");
                }
                switch (choice)
                {
                    case 1:
                        appts.viewUpcomingAppt();
                        break;
                    case 2:
                        appts.viewPastAppts();
                        break;
                    case 3:
                        appts.payAppt();
                        break;
                    case 4:
                        appts.addAppt();
                        break;
                    case 0:
                        MainMenu();
                        break;
                    default:
                        Console.Write("Invalid choice. Please try again: ");
                        break;
                }
            } while (choice != 0);
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.MainMenu();
            Console.ReadKey();
        }
    }
}
