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

        public List<string> GetCustomerName()
        {
            List<string> result = new List<string>();
            foreach (Customer customer in customers)
            {
                result.Add(customer.Cname);
            }
            return result;
        }

        public Dictionary<string, string> GetDataForCustomerByName(string cname)
        {
            Dictionary<string, string> result = new Dictionary<string, string>();
            string toppingString;
            foreach (Customer customer in customers)
            {
                if (customer.Cname.Equals(cname))
                {
                    result.Add("Date", customer.Date);
                    result.Add("Customer Name", customer.Cname);
                    result.Add("Address", customer.Address);
                    result.Add("Driver Name", customer.Dname);
                    result.Add("Time-Out", customer.Time);
                    result.Add("Size", customer.Size);
                    result.Add("Information", customer.Instructions);
                    result.Add("Tip", Convert.ToString(customer.Tip));
                    toppingString = "";
                    if (customer.Toppings.Contains(0))
                    {
                        toppingString = toppingString + "0 ";
                    }
                    if (customer.Toppings.Contains(1))
                    {
                        toppingString = toppingString + "1 ";
                    }
                    if (customer.Toppings.Contains(2))
                    {
                        toppingString = toppingString + "2 ";
                    }
                    toppingString = toppingString.Trim();
                    result.Add("Toppings", toppingString);
                    return result;

                }
            }
            return null;
        }


    }
}
