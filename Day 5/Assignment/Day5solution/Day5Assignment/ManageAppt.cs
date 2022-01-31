using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicModelsLibrary;

namespace Day5Assignment
{
    public class ManageAppt
    {
        Appointment appt = new Appointment();
        List<Appointment> apptList = new List<Appointment>();

        public void addItemstoList()
        {
            apptList.Add(new Appointment
            {
                id = 101,
                patientId = 1,
                apptDate = DateTime.Parse("26-01-22"),
                apptTime = DateTime.Parse("13:00"),
                remarks = "",
                Price = double.Parse("50"),
                paymentStatus = "Paid"
            });

            apptList.Add(new Appointment
            {
                id = 102,
                patientId = 1,
                apptDate = DateTime.Parse("25-01-22"),
                apptTime = DateTime.Parse("12:00"),
                remarks = "",
                Price = double.Parse("100"),
                paymentStatus = "Pending"
            });

        }
        public Appointment this[int index]
        {
            get { return apptList[index]; }
            set { apptList[index] = value; }
        }
        public ManageAppt()
        {
            apptList = new List<Appointment>();
        }
        public ManageAppt(int size)
        {
        }
        public void addAppt()
        {
            Appointment appt = new Appointment();
            appt.id = GenerateId();
            appt.takeApptDetails();
            apptList.Add(appt);
            string viewNew = appt.viewAppt(appt);
            Console.WriteLine(viewNew);
            Console.WriteLine("Booking is Confirmed! Please check upcoming appointment to review..");
        }

        private int GenerateId()
        {

            if (apptList.Count == 0)
                return 101;
            return apptList.Count + 101;
        }
        public Appointment GetApptById(int searchid)
        {

            Appointment appt = apptList.Find(p => p.id == searchid);

            return appt;
        }

        public void editAppt()
        {
            bool apptExist = false;

            apptExist = viewApptByID();

            if (apptExist == true)
            {
                int id = GetIdFromUser();

                Appointment appt = GetApptById(id);
                if (appt == null)
                {
                    Console.WriteLine("Invalid Id. Cannot edit");
                    editAppt();
                }
                else
                {
                    Console.WriteLine("\nEditing for appointment " + id + ". Choose from the options");
                    int choice = 0;
                    do
                    {
                        Console.WriteLine("1: Edit price");
                        Console.WriteLine("2: Edit remarks");
                        //Console.WriteLine("3: Edit payment status");
                        Console.WriteLine("0: Exit");

                        Console.Write("Choice: ");
                        while (!int.TryParse(Console.ReadLine(), out choice))
                        {
                            Console.WriteLine("Try again. Please enter a number");
                        }
                        switch (choice)
                        {
                            case 1:
                                editPrice(apptList, id);
                                break;
                            case 2:
                                editRemarks(apptList, id);
                                break;
                            case 3:
                                editPaymentStatus(apptList, id);
                                break;
                            case 0:
                                return;
                            default:
                                Console.WriteLine("Invalid choice. Please try again");
                                break;
                        }
                    }
                    while (choice != 0);
                }
            }
        }

        public void editPrice(List<Appointment> apptList, int id)
        {
            double price;
            Console.WriteLine("\nPlease enter the new price: ");
            while (!double.TryParse(Console.ReadLine(), out price))
            {
                Console.WriteLine("Invalid entry for price. Please try again: ");
            }

            var index = apptList.FindIndex(r => r.id == id);
            apptList[index].Price = price;
            apptList[index].paymentStatus = "Pending";
            Console.WriteLine("\nUpdated new price. New Details: ");
            PrintAppt(apptList[index]);
        }

        public void editRemarks(List<Appointment> apptList, int id)
        {
            Console.WriteLine("\nPlease enter remarks: ");
            string remarks = Console.ReadLine();


            var index = apptList.FindIndex(r => r.id == id);
            apptList[index].remarks = remarks;
            Console.WriteLine("\nUpdated new remarks. New Details: ");
            PrintAppt(apptList[index]);
        }

        public void editPaymentStatus(List<Appointment> apptList, int id)
        {
            Console.WriteLine("\nPlease enter payment status: ");
            string paymentStatus = Console.ReadLine();

            var index = apptList.FindIndex(r => r.id == id);
            apptList[index].paymentStatus = paymentStatus;
            Console.WriteLine("\nUpdated new payment status. New Details: ");
            PrintAppt(apptList[index]);
        }

        int GetIdFromUser()
        {
            Console.Write("Please enter the appointment id: ");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.Write("Invalid appointment ID. Please try again: ");
            }
            return id;
        }

        public void viewApptById()
        {
            if (apptList.Count == 0)
            {
                Console.WriteLine("\nThere are no appointments");
            }
            else
            {
                apptList = apptList.OrderBy(o => o.id).ToList();

                foreach (var item in apptList)
                {
                    if (item != null)
                    {
                        PrintAppt(item);
                    }
                }
            }
        }

        public void viewUpcomingAppt()
        {
            int notUpcoming = 0;

            string appointments = "";

            if (apptList.Count == 0)
            {
                Console.WriteLine("\nThere are no appointments.");
            }
            else
            {
                apptList = apptList.OrderBy(o => o.apptDate).ToList();

                for (int i = 0; i < apptList.Count; i++)
                {
                    if (apptList[i].apptDate > DateTime.Today)
                    {
                        appointments += appt.viewAppt(apptList[i]);
                    }
                    else if (apptList[i].apptDate == DateTime.Today && apptList[i].apptTime > DateTime.Now)
                    {
                        appointments += appt.viewAppt(apptList[i]);
                    }
                    else
                    {
                        notUpcoming++;
                    }
                }

                Console.WriteLine(appointments);

                if (notUpcoming == apptList.Count)
                {
                    Console.WriteLine("\nThere are no upcoming appointments.");
                }
            }

        }

        public bool displayPayingAppt()
        {
            int paidAppts = 0;
            bool unpaidAppts = false;

            if (apptList.Count != 0)
            {
                string appointments = "";

                for (int i = 0; i < apptList.Count; i++)
                {
                    if (!apptList[i].paymentStatus.Equals("Paid"))
                    {
                        appointments += appt.viewAppt(apptList[i]);
                        unpaidAppts = true;

                    }
                    else
                    {
                        paidAppts++;
                    }
                }

                Console.WriteLine(appointments);
            }
            else
            {
                Console.WriteLine("\nThere are no appointments.");
            }

            if (paidAppts == apptList.Count && apptList.Count > 0)
            {
                Console.WriteLine("\nAll appointments are paid.");
                unpaidAppts = false;
            }

            return unpaidAppts;
        }


        public void payAppt()
        {
            bool unpaidAppts = displayPayingAppt();
            bool valid = false;

            if (unpaidAppts == true)
            {
                int id = GetIdFromUser();

                var index = apptList.FindIndex(r => r.id == id);

                if (index == -1)
                {
                    Console.WriteLine("\nInvalid Id. Cannot make payment.");
                    payAppt();
                }
                else
                {
                    while (valid == false)
                    {
                        if (apptList[index].paymentStatus.Contains("Balance"))
                        {
                            Console.Write("Please enter amount to pay: $ ");
                            valid = double.TryParse(Console.ReadLine(), out double j);

                            string status = apptList[index].paymentStatus;
                            Array split = status.Split('$');
                            double balance = double.Parse(status.Split('$')[1]);

                            if (balance == j || j > balance)
                            {
                                apptList[index].paymentStatus = "Paid";
                            }
                            else if (j < balance)
                            {
                                balance = balance - j;
                                apptList[index].paymentStatus = "Balance: $" + balance;
                            }
                        }
                        else
                        {
                            Console.Write("Please enter amount to pay: $ ");
                            valid = double.TryParse(Console.ReadLine(), out double j);

                            if (apptList[index].Price == j || j > apptList[index].Price)
                            {
                                apptList[index].paymentStatus = "Paid";
                            }
                            else if (j < apptList[index].Price)
                            {
                                double price = apptList[index].Price;
                                double balance = price - j;
                                apptList[index].paymentStatus = "Balance: $" + balance;
                            }
                        }
                    }

                    string showStatus = appt.viewAppt(apptList[index]);

                    Console.Write(showStatus);

                }
            }
        }

        public void viewPastAppts()
        {
            int notPast = 0;

            string appointments = "";

            if (apptList.Count == 0)
            {
                Console.WriteLine("\nThere are no appointments.");
            }
            else
            {
                apptList = apptList.OrderBy(o => o.apptDate).ToList();

                for (int i = 0; i < apptList.Count; i++)
                {
                    if (apptList[i].apptDate < DateTime.Today)
                    {
                        appointments += appt.viewAppt(apptList[i]);
                    }
                    else if (apptList[i].apptDate == DateTime.Today && apptList[i].apptTime < DateTime.Now)
                    {
                        appointments += appt.viewAppt(apptList[i]);
                    }
                    else
                    {
                        notPast++;
                    }
                }

                Console.WriteLine(appointments);

                if (notPast == apptList.Count)
                {
                    Console.WriteLine("\nThere are no past appointments.");
                }
            }

        }

        public bool viewApptByID()
        {
            bool apptExist = false;

            if (apptList.Count == 0)
            {
                Console.WriteLine("\nThere are no appointments");
                apptExist = false;
            }
            else
            {
                apptExist = true;

                apptList = apptList.OrderBy(o => o.id).ToList();

                foreach (var item in apptList)
                {
                    if (item != null)
                    {
                        PrintAppt(item);
                    }
                }
            }

            return apptExist;
        }

        public void deleteAppt()
        {
            bool apptExist = false;

            apptExist = viewApptByID();

            if (apptExist == true)
            {
                int id = GetIdFromUser();

                Appointment appt = GetApptById(id);
                if (appt == null)
                {
                    Console.WriteLine("Invalid Id. Cannot delete");
                    return;
                }
                else
                {
                    apptList = apptList.Where(apptList => apptList.id != id).ToList();
                    Console.WriteLine("\nDeleted appointment " + id);
                    viewApptByID();
                }
            }
        }

        private void PrintAppt(Appointment item)
        {
            Console.WriteLine(item);
        }

    }


}
