using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicModelsLibrary
{
    public class Appointment
    {
        public int id { get; set; }
        public int patientId { get; set; }
        public DateTime apptDate { get; set; }
        public DateTime apptTime { get; set; }
        public double Price { get; set; }
        public string remarks { get; set; }
        public string paymentStatus { get; set; }

        public void takeApptDetails()
        {

            bool valid = false;

            patientId = 1;

            while (valid == false)
            {
                Console.Write("Please enter the Appointment date (dd-mm-yy): ");
                valid = (DateTime.TryParseExact(Console.ReadLine(), "dd-MM-yy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime j));
                apptDate = j;
            }

            valid = false;

            while (valid == false)
            {
                Console.Write("Please enter the Appointment time (hh:mm): ");
                valid = (DateTime.TryParseExact(Console.ReadLine(), "HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime j));
                apptTime = j;
            }

            Console.Write("Please enter remarks :");
            remarks = Console.ReadLine();

            Price = 0;

            paymentStatus = "";


        }

        public string viewAppt(Appointment appt)
        {
            return "\n================================================="
               + "\n Appointment ID: " + appt.id
               + "\n Appointment Date: " + appt.apptDate.ToString("dd-MM-yy")
               + "\n Appointment Time: " + appt.apptTime.ToString("HH:mm")
               + "\n Remarks: " + appt.remarks
               + "\n Price: " + "$" + appt.Price
               + "\n Payment status: " + appt.paymentStatus
               + "\n=================================================";
        }

        public override string ToString()
        {
            return "\n--------------------------------------------------"
                + "\n Appointment ID: " + id
                + "\n Patient ID: " + patientId
                + "\n Appointment Date: " + apptDate.ToString("dd-MM-yy")
                + "\n Appointment Time: " + apptTime.ToString("HH:mm")
                + "\n Remarks: " + remarks
                + "\n Price: " + "$" + Price
                + "\n Payment status: " + paymentStatus
                + "\n--------------------------------------------------";
        }
    }
}
