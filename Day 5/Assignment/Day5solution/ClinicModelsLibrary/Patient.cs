using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicModelsLibrary
{
     class Patient : User
    {
        public string remarks { get; set; }
        public string status { get; set; }

        public Patient()
        {
            type = "Patient";
        }

        public override void takeUserInfo()
        {
            base.takeUserInfo();
            Console.WriteLine("Please enter remarks :");
            remarks = (Console.ReadLine());
            Console.WriteLine("Please enter status :");
            status = Console.ReadLine();
        }
        public override void displayUserInfo()
        {
            base.displayUserInfo();
            Console.WriteLine("Remarks  :{0}\n" +
                              "Status  : {1}\n", remarks, status);
        }
    }

    
}
