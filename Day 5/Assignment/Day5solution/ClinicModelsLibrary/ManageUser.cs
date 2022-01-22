using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicModelsLibrary;

namespace ClinicModelsLibrary
{
    public class ManageUser
    {
        User[] users = new User[2];

        public void registerUser()
        {
            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine("Please enter the user type Patient/Doctor :  ");
                User userr;
                string type = Console.ReadLine();
                switch (type)
                {
                    case "Doctor":
                        userr = new Doctor();
                        break;
                    case "Patient":
                        userr = new Patient();
                        break;
                }
                //users[i] = userr;
                users[i].takeUserInfo();

            }
            
        }
        public void displayUserInfo()
        {
            
            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine(users[i]);
            }
        }


    }
}
