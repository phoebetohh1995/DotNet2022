using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace ClinicModelsLibrary
    {
        public class User
        {
            public int id { get; set; }
            public string name { get; set; }
            public string password { get; set; }
            public int age { get; set; }
            public string type { get; set; }

        public User()
        {
            type = "Patient";
        }

        public virtual void takeUserInfo()
        {
            Console.WriteLine("Please enter user ID  : ");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter user name  : ");
            name = Console.ReadLine();

            Console.WriteLine("Please enter user password  : ");
            password = Console.ReadLine();

            Console.WriteLine("Please enter user age  : ");
            age = Convert.ToInt32(Console.ReadLine());
        }
        public virtual void displayUserInfo()
        {
            Console.WriteLine("User Id       :  {0}\n" +
                              "User Name     :  {1}\n" +
                              "User Password :  {2}\n" +
                              "User Age      :  {3}\n" +
                              "User Type     :  {4}\n",
                              id, name, password, age, type);
        }

    }
 
    }


