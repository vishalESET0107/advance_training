namespace strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            /*string username = "vishal";
            string password = "ABCD";



            Console.WriteLine("enter username");
            string u =Console.ReadLine();
            Console.WriteLine("enter password");
            string p = Console.ReadLine();

            if (u == username && p == password)
            {

                Console.WriteLine("welcome vishal");

                string para = Console.ReadLine();

                Console.WriteLine(para.Length);

                Console.WriteLine($"no of words : {nwords(para)} ");

                Console.WriteLine($"spaces :{space(para)} ");

                string[] s = sen( para );
                display(s);
                Console.WriteLine("first occur of 'a' is " + para.IndexOf('a'));
                
                Console.WriteLine(para.Replace("student" , "STUDENT"));
                camel(para); //not working

                Console.WriteLine(para);


                Console.WriteLine(count(para));
                Console.WriteLine("number plate :");

                string plat = Console.ReadLine();
                Console.WriteLine(state(plat));

            }





        }

        static public void display(string[] s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
        }

        static public int nwords(string para)
        {

            int n = 0;
            for (int i = 0; i < para.Length; i++)
            {
                if (para[i] == ' ' && para[i+1] != ' ')
                {
                    n++;
                }

            }
            return n;
        }

        static public int space(string para)
        {
            int n = 0;
            for (int i = 0; i < para.Length; i++)
            {
                if (para[i] == ' ')
                {
                    n++;
                }
            }
            return n;
        }

        static public string[] sen(string para)
        {
            string[] s = new string[para.Length];

            s = para.Split( '.');

            return s;
        }

        static public string camel(string para)
        {
            char[] chars = para.ToCharArray(); 
            int num = 'a' - 'A';

            for (int i = 0; i < chars.Length - 1; i++)
            {
                if (chars[i] == ' ' && chars[i + 1] >= 'a' && chars[i + 1] <= 'z')
                {
                    chars[i + 1] = (char)(chars[i + 1] - num); 
                }
            }

            return new string(chars);
        }

        static public int count(string para)
        {
            int c = 0;
            for (int i = 0; i < para.Length; i++)
            {
                if (para[i] == 'a')
                {
                    c++;
                }


            }
            return c;
        }

        static public string state(string plate)
        {
            string sp = plate.Substring(0, 2);
            if (sp == "KA")
            {
                Console.WriteLine("state karnataka");

            }
            if(sp == "TS")
            {
                Console.WriteLine("state telangana");

            }
            if( sp == "TN")
            {
                Console.WriteLine("STATE TAMIL NADU");
            }
            return sp;
        }*/

            double[,] store = new double[100, 4];
            while (true)
            {
                string meter_data = Console.ReadLine();

                validate(meter_data);

                

                display(meter_data);

                // get in a 2d array;
                
               
                string[] s = meter_data.Split('|');
                string time = s[1].Substring(s[1].Length - 5);
                string[] tm = (time.Split(":"));
                int hr = int.Parse(tm[0]);
                int min = int.Parse(tm[1]);





            }




        }

        static public void validate(string meter_data) { 
            string[] s = meter_data.Split('|');
            if (s[0] == "SM12345")
            {
                Console.WriteLine("valid");

            }
            else
            {
                Console.WriteLine("invalid");
            }

        
        }
        static public void display(string meter_data)
        {
            string[] s = meter_data.Split('|');
            string date = s[1].Substring(0 ,10);
            string time = s[1].Substring(s[1].Length - 5);
            string usage = s[2];
            string numberu = "";

            for (int i = 0; i < usage.Length; i++)
            {
                if ((usage[i] >= '0' && usage[i] <= '9') || usage[i] == '.')
                {
                    numberu += usage[i];
                }
            }


            string[] fir = s[3].Split(':');

            string[] sec = fir[1].Split('-');
            string floor = sec[0];
            string building = sec[1];

            
            Console.WriteLine($"date : {date}");
            Console.WriteLine($"time : { time}");
            Console.WriteLine($"usage :{numberu}");
            Console.WriteLine($"floor : {floor}");
            Console.WriteLine($"building : {building}");





        }


    }
}