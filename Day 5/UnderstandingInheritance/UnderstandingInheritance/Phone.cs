using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingInheritance
{
    internal class Phone
    {
        public string PhoneNumber { get; set; }
        public Phone()
        {
            PhoneNumber = "9876543";
            Console.WriteLine("Hey its a phone");
        }
        public void MakeCall()
        {
            Console.WriteLine("We can make calls from teh number " + PhoneNumber);
        }
        public void ReceiveCall()
        {
            Console.WriteLine("Tring .... Tring");
            Console.WriteLine("We can receive calls  ");
        }
    }
}
