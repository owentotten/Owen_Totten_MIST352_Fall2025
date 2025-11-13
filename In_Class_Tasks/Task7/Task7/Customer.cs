using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    public class Customer
    {
        private int _id;
        private string _name;
        private string _lastName;
        private string _Email;
        // ====================Properties=========================
        public int ID
        {
            //Here, we are basically saying once a customer is created, nobody can change their ID. No set.
            //Allow users to view customer ID
            get { return _id; }
            set
            { if (value <= 0)
                {
                    Console.WriteLine($"Customer ID must be positive. Customer ID remains {_id}. Try again");
                }
                else
                {
                    _id = value;
                }
            }
        }
        public string Name
        {
            //Here, we can change and view customer name
            //Allow users to view customer name
            get { return _name; }
            set
            {
                if (value is null || value.Equals(""))
                {
                    Console.WriteLine($"Name can not be null or empty. Customer name remains {_name}. Try again");
                }
                else
                    _name = value;
            }
        }
   
        
        public string Email
        { get { return _Email; }
            set { if (value.Contains("@"))
                {
                    _Email = value;
                }
                else
                {
                    Console.WriteLine($"Email must contain '@' and '.'. Customer email remains {_Email}. Try again");
                }
            }
        }


                public void DisplayInfo()
        {
            Console.WriteLine($"Customer ID: {_id}, Name: {_name}, Email: {_Email}");
        }

    }




}
