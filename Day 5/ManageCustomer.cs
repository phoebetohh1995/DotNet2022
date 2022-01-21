using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaModels_Library;

namespace PizzaFEConsoleApp
{
    internal class ManageCustomer
    {
        Customer customer = new Customer();
        public void RegisterCustomer()
        {

            customer.TakeCustomerDetailsFromUser();
        }
        public void DisplayCustomer()
        {
            customer.PrintCustomerDetails();
        }


    }
}
