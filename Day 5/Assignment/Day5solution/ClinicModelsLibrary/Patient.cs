using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicModelsLibrary
{
     public class Patient : User
    {
        public string remarks { get; set; }
        public string status { get; set; }

        public Patient()
        {
            type = "Patient";
        }

        public void takePatientInfo()
        {
            
            Console.WriteLine("Please enter remarks :");
            remarks = Console.ReadLine();
            Console.WriteLine("Please enter status :");
            status = Console.ReadLine();
        }
        public override string ToString()
        {
            return base.ToString() + "\n User Type : " + type + "\n  Remarks : " + remarks + "\n Status : " + status;
        }
    }

    
}
