using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windows_form
{
    public class Customer
    {
        private string date;
        private string cname;
        private string address;
        private string dname;
        private string time;
        private string size;
        private string instructions;
        private int tip;  //0- 10%, 1- 15%, 2 - 18%
        private List<int> toppings; //0 - meat, 1- meat,  2 - veggie

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Cname
        {
            get { return cname; }
            set { cname = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Dname
        {
            get { return dname; }
            set { dname = value; }
        }

        public string Time
        {
            get { return time; }
            set { time = value; }
        }

        public string Instructions
        {
            get { return instructions; }
            set { instructions = value; }
        }

        public string Size
        {
            get { return size; }
            set { size = value; }
        }

        public int Tip
        {
            get { return tip; }
            set
            {
                if (value < 0 || value > 2)
                {
                    tip = 0; //10%
                } else
                {
                    tip = value;
                }
            }
        }

        public List<int> Toppings
        {
            get { return toppings; }
            private set
            {
                toppings = value;
            }
        }

        public void AddTopping (int topping)
        {
            if (!toppings.Contains(topping) && topping >= 0 && topping <= 2)
            {
                toppings.Add(topping);
            }
        }

        public void clearToppings()
        {
            toppings.Clear();
        }

        public Customer()
        {
            Date = "";
            Cname = "";
            Address = "";
            Dname = "";
            Time = "";
            Instructions = "";
            Size = "";
            Tip = 0;
            Toppings = new List<int>();
        }

        public Customer(string date, string cname, string address, string dname, string time, string instructions, string size, int tip, List<int> toppings)
        {
            Date = date;
            Cname = cname;
            Address = address;
            Dname = dname;
            Time = time;
            Size = size;
            Instructions = instructions;
            Tip = tip;
            Toppings = toppings;
        }

        public string TipAsString()
        {
            if (Tip == 0)
            {
                return "10%";
            } else if (Tip == 1 )
            {
                return "15%";
            } else
            {
                return "18%";
            }
        }

        public string ToppingsAsString()
        {
            string result = "";
            if (toppings.Contains(0))
            {
                result = result + "Cheese ";
            }
            if (toppings.Contains(1))
            {
                result = result + "Meat ";
            }
            if (toppings.Contains(2))
            {
                result = result + "Veggie ";
            }
            return result.Trim();

        }

        public override string ToString()
        {
            //return String.Format("Date: {0} Customer: {1} Address: {2} Size: {3} Topping: {4} Driver: {5) Time-Out: {6} Tip: {7} Special Instructions: {8}", Date, Cname, Address, Size, ToppingsAsString(), Dname, Time, TipAsString(), Instructions);
            //return String.Format("Topping: {0}, Tip: {1}, Customer Name: {2}, Date: {3}, Address: {4}, Driver: {5}, Time: {6}, Size: {7}, Instructions: {8}", ToppingsAsString(), TipAsString(), Cname, Date, Address, Dname, Time, Size, Instructions);
            //return String.Format("Size: {0}, Topping: {1}, Date {2} Customer: {3}, Address: {4}, Driver: {5}, Time-Out: {6}, Tip: {7}, Instructions: {8}", Size, ToppingsAsString(), Date, Cname,Address, Dname, Time, TipAsString(), Instructions);
            return String.Format("Date: {0}\n Customer: {1}\n Address {2}\n \n Pizza Size: {3}\n Toppings: {4}\n \n Driver: {5}\n Time-Out: {6}\n Tip: {7}\n \n Instructions: {8}\n \n", Date, Cname, Address, Size, ToppingsAsString(), Dname, Time, TipAsString(), Instructions);

        }

    }

}

