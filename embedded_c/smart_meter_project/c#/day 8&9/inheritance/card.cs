using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    internal abstract class card
    {
        
        protected string name;
        public string description;
        public string number;
        public string expirydate;
        public int cvv;
        public string cname;

        public card(string Name , int Cvv )

        {
            name = Name;
            cvv = Cvv;
        }

        public virtual void dis()
        {
            Console.WriteLine("readline card");


        }
        public abstract void basereq();






    }
}
