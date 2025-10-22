using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal class credcard : card
    {
        public int limit;
        public int taplimit;
        public int onlinelimit;

        public void get_data()
        {
            Console.WriteLine("enter number");
            number = Console.ReadLine();
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("enter description");
            description = Console.ReadLine();
            Console.WriteLine("enter expirydate");
            expirydate = Console.ReadLine();
            Console.WriteLine("enter cvv");
            cvv = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter cname");
            cname = Console.ReadLine();
            Console.WriteLine("enter limit");
            limit = Convert.ToInt32(Console.ReadLine());



        }
        public void display()
        {
            Console.WriteLine(number);
            Console.WriteLine(name);
            Console.WriteLine(description);
            Console.WriteLine(expirydate);
            Console.WriteLine(cvv);
            Console.WriteLine(cname);
            Console.WriteLine(limit);



        }
        public credcard(string name ) { 
            Console.WriteLine("readline");
        
        
        }

        public override void dis()
        {


        }
        public credcard(string a , int b) : base(a ,b)
        {

        }



        
            


    }
}
