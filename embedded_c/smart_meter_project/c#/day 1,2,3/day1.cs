using System.Security.Cryptography.X509Certificates;

namespace billing_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Hello, World!");

             Console.WriteLine("--------------billing system---------------");

             while (true)
             {
                 Console.WriteLine("enter your zone code : [z1-> press 1 /z2 -> press 2 /z3 -> press 3]");
                 int zone = Convert.ToInt32(Console.ReadLine());

                 switch (zone)
                 {
                     case 1:

                         Console.WriteLine("enter tariff plan [tf1 -> enter 1 / tf2 -> enter 2 / tf3 -> enter 3]");
                         int tariff = Convert.ToInt32(Console.ReadLine());

                         switch (tariff)
                         {
                             case 1:
                                 double bill;
                                 Console.WriteLine("home plan");
                                 double units_cons = Convert.ToDouble(Console.ReadLine());
                                 if (units_cons < 200)
                                 {
                                     Console.WriteLine("zero bill");
                                     bill = 0;

                                 }
                                 else
                                 {
                                     bill = (units_cons - 200) * 3;
                                     Console.WriteLine(bill);

                                 }
                                 break;

                             case 2:


                                 Console.WriteLine("agriculture plan");
                                 units_cons = Convert.ToDouble(Console.ReadLine());
                                 if (units_cons < 500)
                                 {
                                     Console.WriteLine("zero bill");
                                     bill = 0;

                                 }
                                 else
                                 {
                                     bill = (units_cons - 500) * 2;
                                     Console.WriteLine(bill);

                                 }
                                 break;

                             case 3:
                                 Console.WriteLine("business plan");
                                 units_cons = Convert.ToDouble(Console.ReadLine());
                                 bill = units_cons * 3;
                                 Console.WriteLine(bill);
                                 break;

                             default:
                                 Console.WriteLine("invalid");
                                 break;
                         }
                         break;


                     case 2:

                         Console.WriteLine("enter tariff plan [tf1 -> enter 1 / tf2 -> enter 2 / tf3 -> enter 3]");
                         tariff = Convert.ToInt32(Console.ReadLine());

                         switch (tariff)
                         {
                             case 1:
                                 double bill;
                                 Console.WriteLine("home plan");
                                 double units_cons = Convert.ToDouble(Console.ReadLine());
                                 if (units_cons < 200)
                                 {
                                     Console.WriteLine("zero bill");
                                     bill = 0;

                                 }
                                 else
                                 {
                                     bill = (units_cons - 200) * 5;
                                     Console.WriteLine(bill);

                                 }
                                 break;

                             case 2:


                                 Console.WriteLine("agriculture plan");
                                 units_cons = Convert.ToDouble(Console.ReadLine());
                                 if (units_cons < 500)
                                 {
                                     Console.WriteLine("zero bill");
                                     bill = 0;

                                 }
                                 else
                                 {
                                     bill = (units_cons - 500) * 3;
                                     Console.WriteLine(bill);

                                 }
                                 break;

                             case 3:
                                 Console.WriteLine("business plan");
                                 units_cons = Convert.ToDouble(Console.ReadLine());
                                 bill = units_cons * 5;
                                 Console.WriteLine(bill);
                                 break;

                             default:
                                 Console.WriteLine("invalid");
                                 break;
                         }
                         break;

                     case 3:

                         Console.WriteLine("enter tariff plan [tf1 -> enter 1 / tf2 -> enter 2 / tf3 -> enter 3]");
                         tariff = Convert.ToInt32(Console.ReadLine());

                         switch (tariff)
                         {
                             case 1:
                                 double bill;
                                 Console.WriteLine("home plan");
                                 double units_cons = Convert.ToDouble(Console.ReadLine());
                                 if (units_cons < 200)
                                 {
                                     Console.WriteLine("zero bill");
                                     bill = 0;

                                 }
                                 else
                                 {
                                     bill = (units_cons - 200) * 1;
                                     Console.WriteLine(bill);

                                 }
                                 break;

                             case 2:


                                 Console.WriteLine("agriculture plan");
                                 units_cons = Convert.ToDouble(Console.ReadLine());
                                 if (units_cons < 500)
                                 {
                                     Console.WriteLine("zero bill");
                                     bill = 0;

                                 }
                                 else
                                 {
                                     bill = (units_cons - 500) * 1;
                                     Console.WriteLine(bill);

                                 }
                                 break;

                             case 3:
                                 Console.WriteLine("business plan");
                                 units_cons = Convert.ToDouble(Console.ReadLine());
                                 bill = units_cons * 2;
                                 Console.WriteLine(bill);
                                 break;

                             default:
                                 Console.WriteLine("invalid");
                                 break;
                         }
                         break;


                     default:
                         Console.WriteLine("invalid input");
                         break;

                 }


             }*/
            /*int zone, tariff;
            double units;
            while (true) {

                (zone, tariff, units) = get_data();

                double bill = CalculateBill(zone, tariff, units);
                if (bill > 0)
                {
                    Console.WriteLine($"Your total bill = ₹{bill}\n");
                }
            }
        }

        static public (int zone, int tariff, double units) get_data()
        {
            Console.WriteLine("enter your zone code : [z1-> press 1 /z2 -> press 2 /z3 -> press 3]");
            int zone = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter tariff plan [tf1 -> 1 / tf2 -> 2 / tf3 -> 3]");
            int tariff = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter units consumed:");
            double units = Convert.ToDouble(Console.ReadLine());

            return (zone,tariff,units);

        }


        static public double CalculateBill(int zone , int tariff , double units)
        {
            if (zone < 1 || zone > 3 || tariff < 1 || tariff > 3)
            {
                Console.WriteLine("invalid output");
                return 0.0;

            }
            else
            {

                double[,] z_t = new double[4, 4]
                {
                { 0, 0, 0, 0 },
                { 0, 3, 2, 3 },
                { 0, 5, 3, 5 },
                { 0, 1, 1, 2 }
                };

                int[] free = { 0, 200, 500, 0 };
                if (units > free[tariff])
                {

                    double bill = z_t[zone, tariff] * (units - free[tariff]);
                    return bill;

                }
                else
                {
                    return 0;
                }
                
            }*/



            




        }
        static int[] GetNumbers()
        {
            Console.Write("Enter 3 numbers ");
            int[] inputs = new int[3];
            inputs[0] = Convert.ToInt32(Console.ReadLine());
            inputs[1] = Convert.ToInt32(Console.ReadLine());
            inputs[2] = Convert.ToInt32(Console.ReadLine());



            static public int get_number()
            {

            }

            static public bool checknumberrange()

            {

            }
            static public int compare()
            {

            }
        }

       

           


        
        


    }

          
}