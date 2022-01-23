using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicModelsLibrary
{
    public class Doctor : User
    {
        public int experience { get; set; }
        public string specialty { get; set; }

     public Doctor()
        {
            type = "Doctor";
        }

        public void takeDoctorInfo()
        {
            
            Console.WriteLine("Please enter years of experience :");
            experience = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter specialty :");
            specialty = Console.ReadLine();
        }
        public override string ToString()
        {
            return base.ToString() + "\n User Type :" + type + "\n Experience year(s) : " + experience + "\n Speciality : " + specialty;
        }
    }

 

    
}
