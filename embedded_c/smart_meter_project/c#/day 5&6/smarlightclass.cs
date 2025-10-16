using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classestut
{
    internal class smartlight
    {

        public string color { get; set; }
        public int brightness { get; set; }
        public bool ison { get; set; }
        public void turnon() {
        
        }
        public void turnoff() { }

        public void setbrightness(int level) {
            if (level < 0 || level > 100)
            {
                Console.WriteLine("Brightness must be between 0 and 100");
                return;
            }
            brightness = level;
            Console.WriteLine($"Brightness set to {brightness}%");
        }

        public void changecolor(string newcolor) { }

        public void displaystatus()
        {

            Console.WriteLine(ison);
            Console.WriteLine(brightness);
            Console.WriteLine(color);




        }

        public void getstatus()
        {
            Console.WriteLine("enter on/off -> 1/0 ");
            ison = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("enter brightness level");
            brightness = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("enter colour ");
            color = Console.ReadLine();
        }
        



    }

}