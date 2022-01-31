using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicModelsLibrary;

namespace Day5Assignment
{
    public class ManageUser
    {
        User newUser = new User();

        public void GetUserDetails()
        {
            Console.WriteLine("Please enter the user type Patient/Doctor :  ");
            newUser.type = Console.ReadLine();

            switch (newUser.type)
            {
                case "Doctor":
                    newUser = new Doctor();
                    ((Doctor)newUser).takeUserInfo();
                    ((Doctor)newUser).takeDoctorInfo();
                    break;

                case "Patient":
                    newUser = new Patient();
                    ((Patient)newUser).takeUserInfo();
                    ((Patient)newUser).takePatientInfo();
                    break;

                default:
                    Console.WriteLine("Invalid Entry. Treating as patient");
                    newUser = new Patient();
                    ((Patient)newUser).takeUserInfo();
                    ((Patient)newUser).takePatientInfo();
                    break;
            }

        }
        public void PrintUserDetails()
        {

            Console.WriteLine(newUser);
        }
    }
}

