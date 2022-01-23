using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicModelsLibrary;

//Create the methods to take input in each class
//Override it in the inherited calss so that it takes teh appropriate details
//Hint : Keep the common ones in the base
//Override teh tostring method so that the details printed are complete

namespace Day5Assignment
{
    class Program
    {

        static void Main(string[] args)
        {
            ManageUser program = new ManageUser();
            program.GetUserDetails();
            program.PrintUserDetails();
            Console.ReadKey();
        }
    }
}
