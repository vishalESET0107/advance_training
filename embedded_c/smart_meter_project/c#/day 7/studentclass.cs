using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data_types
{
    internal class student
    {

        string name;
        string classname;
        int sub1, sub2, sub3;

        public student(string name, string classname, int sub1, int sub2, int sub3)
        {
            this.name = name;
            this.classname = classname;
            this.sub1 = sub1;
            this.sub2 = sub2;
            this.sub3 = sub3;
        }



        public void get_data()
        {
            Console.WriteLine("name :");
            name = Console.ReadLine();
            
            Console.WriteLine("classname :");
            classname = Console.ReadLine();
            Console.WriteLine("sub1 :");
            sub1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sub2 :");
            sub2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("sub3 :");
            sub3 = Convert.ToInt32(Console.ReadLine());

        }
        public void display()
        {
            Console.WriteLine(" name :" + name);
            Console.WriteLine(" classname : " +classname );
            Console.WriteLine(" sub1 :" + sub1);
            Console.WriteLine(" sub2 :" +sub2);
            Console.WriteLine(" sub3 :" + sub3);

        }
        public int total() {
            int t = sub1 + sub2 + sub3;
            return t;
        }
        public double avg()
        {
            int t = sub1 + sub2 + sub3;
            return t/3.00;

        }
        

        

    }
}