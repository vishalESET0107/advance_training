using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception
{
    internal class agenotsufficient : Exception
    {
       
        
            public int age;
        public DateTime time;

        public agenotsufficient(int a)
            
        { 
            age = a;
            time = DateTime.Now;
        }

        public  string display()
        {
            int disyear = 18 - age;

            return $"[Error Occurred: {time:dd-MM-yyyy HH:mm}] " +
                   "exception Code: 100 . Age Not Sufficient .  Your age is not sufficient to cast vote." +
                   $"Please try again after {disyear} year.";
        }






    }
        
}
