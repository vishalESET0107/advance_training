using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace smartmeter
{
    internal class smartmetersystem
    {
        public List<customer> customers = new List<customer>();
        public List<meter> meters = new List<meter>();
        public Dictionary<int, int> customermetermap = new Dictionary<int, int>();
        public List<reading> readings = new List<reading>();

        private const double rateperunit = 7.5;

 
        public void addcustomer()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Customer ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Address: ");
            string address = Console.ReadLine();

            customers.Add(new customer(id, name, address));
            Console.WriteLine("Customer Data added successfully.");
        }

        public void addsmartmeter()
        {
            Console.Write("Enter Meter Serial No: ");
            int serial = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Model: ");
            string model = Console.ReadLine();

            meters.Add(new meter(serial, model));
            Console.WriteLine("Meter Data added successfully.");
        }

 
        public void mapmeter()
        {
            Console.Write("Enter Customer ID: ");
            int cid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Meter Serial No: ");
            int mid = Convert.ToInt32(Console.ReadLine());

            customer cust = null;
            foreach (var c in customers)
            {
                if (c.customerid == cid)
                {
                    cust = c;
                    break;
                }
            }

            meter meter = null;
            foreach (var m in meters)
            {
                if (m.meterserialno == mid)
                {
                    meter = m;
                    break;
                }
            }




            if (cust == null)
            {
                Console.WriteLine("Customer not found!");
                return;
            }
            if (meter == null)
            {
                Console.WriteLine("Meter not found!");
                return;
            }

            bool found = false;

            foreach (var item in customermetermap)
            {
                if (item.Key == cid)
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                
                customermetermap[cid] = mid;
                Console.WriteLine("Customer mapped with meter successfully.");
            }
            else
            {
                Console.WriteLine("Customer already has a mapped meter.");
            }
        }
        public void addreading()
        {
            Console.Write("Enter Meter Serial No: ");
            int mid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Reading (kWh): ");
            double reading = Convert.ToDouble(Console.ReadLine());

            meter meter = null;

            foreach (meter m in meters)
            {
                if (m.meterserialno == mid)
                {
                    meter = m;
                    break;
                }
            }

            if (meter == null)
                Console.WriteLine("Meter not found!");
            else
                Console.WriteLine("Meter found: " + meter.model);

            if (meter == null)
            {
                Console.WriteLine("Meter not found!");
                return;
            }

            meter.totalreading += reading;
            readings.Add(new reading(mid, reading));
            Console.WriteLine("Reading received successfully.");
        }
        public void generatebill()
        {
            Console.Write("Enter Customer ID: ");
            int cid = Convert.ToInt32(Console.ReadLine());
            bool found = false;

            foreach (var pair in customermetermap)
            {
                if (pair.Key == cid)
                {
                    found = true;
                    break;
                }
            }


            if (!found)
            {
                Console.WriteLine("This customer has no meter mapped!");
                return;
            }
            int mid = Convert.ToInt32(Console.ReadLine());

            int meterid = customermetermap[cid];
            customer cust = null;
            foreach (var c in customers)
            {
                if (c.customerid == cid)
                {
                    cust = c;
                    break;
                }
            }

            meter meter = null;
            foreach (var m in meters)
            {
                if (m.meterserialno == mid)
                {
                    meter = m;
                    break;
                }
            }




            if (meter == null || cust == null)
            {
                Console.WriteLine("Invalid mapping data.");
                return;
            }

            double totalunits = meter.totalreading;
            double totalbill = totalunits * rateperunit;
            Console.WriteLine("");
                

            Console.WriteLine("\nYour current bill details are as follows:");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"Customer ID   : {cust.customerid}");
            Console.WriteLine($"Name           : {cust.name}");
            Console.WriteLine($"Meter ID       : {meter.meterserialno}");
            Console.WriteLine($"Total Units    : {totalunits} kWh");
            Console.WriteLine($"Rate per Unit  : ₹{rateperunit}");
            Console.WriteLine($"Total Bill     : ₹{totalbill}");
            Console.WriteLine("---------------------------------------------");
        }
        public void menu()
        {
            int choice;
            do
            {
                Console.WriteLine("\n----- Welcome to Smart Meter System -----");
                Console.WriteLine("1. Add Customer");
                Console.WriteLine("2. Add Smart Meter");
                Console.WriteLine("3. Map Meter");
                Console.WriteLine("4. Add Reading");
                Console.WriteLine("5. Generate Bill");
                Console.WriteLine("6. Exit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (choice)
                {
                    case 1: addcustomer(); break;
                    case 2: addsmartmeter(); break;
                    case 3: mapmeter(); break;
                    case 4: addreading(); break;
                    case 5: generatebill(); break;
                    case 6:
                        Console.WriteLine("Terminating...");
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }

                Console.WriteLine("------------------------------------------------");

            } while (choice != 6);
        }
    }
}
