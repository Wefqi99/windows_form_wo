using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windows_form
{
    public class CustomerController
    {
        private List<Customer> customers;

        public CustomerController()
        {
            customers = null;
        }

        public CustomerController(List<Customer> customers)
        {
            this.customers = customers;
        }

        public void AddCustomer(string date, string cname, string address, string dname, string time, string instructions, string size, List<int> toppings, int tip)
        {
            Customer customer = new Customer(date, cname, address, dname, time, instructions, size, tip, toppings);
            customers.Add(customer);
        }

        public string GetCustomersAsString()
        {
            string result = "";
            foreach (Customer customer in customers)
            {
                result = result + customer + "\n";
            }
            return result;
            
        }


    }
}
