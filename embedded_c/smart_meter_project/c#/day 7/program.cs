using System.Security.Cryptography.X509Certificates;

namespace data_types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            /* int i = -5;
             bool b = true;
             char c = 'a';
             string s = "abc";
             float f = 1.11f;
             double d = 2.0223;
             long l = 923423423L;
             uint u = 101U;
             byte by = 255;

             Console.WriteLine("-------------welcome--------------");


             string[] names = new string[3];
             int[] Class = new int[3];
             int[] marks = new int[9];



             Console.WriteLine("enter name1");
             names[0] = Console.ReadLine();
             Console.WriteLine("enter class");
             Class[0] = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("enter sub1 marks");
             marks[0] = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("enter sub2 marks");
             marks[1] = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("enter sub3 marks");
             marks[2] = Convert.ToInt32(Console.ReadLine());

             int total1 = marks[0] + marks[1] + marks[2];
             int avg1 = total1 / 3;


             Console.WriteLine("enter name2");
             names[1] = Console.ReadLine();
             Console.WriteLine("enter class");
             Class[1] = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("enter sub1 marks");
             marks[3] = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("enter sub2 marks");
             marks[4] = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("enter sub3 marks");
             marks[5] = Convert.ToInt32(Console.ReadLine());


             int total2 = marks[3] + marks[4] + marks[5];
             int avg2 = total2 / 3;

             Console.WriteLine("enter name3");
             names[2] = Console.ReadLine();
             Console.WriteLine("enter class");
             Class[2] = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("enter sub1 marks");
             marks[6] = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("enter sub2 marks");
             marks[7] = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("enter sub3 marks");
             marks[8] = Convert.ToInt32(Console.ReadLine());

             int total3 = marks[6] + marks[7] + marks[8];
             int avg3 = total3 / 3;

             Console.WriteLine($"{"Name",-10} {"Class",-7} {"Sub1",-6} {"Sub2",-6} {"Sub3",-6} {"Total",-7} {"Average",-7}");
             Console.WriteLine("-----------------------------------------------------------");
             Console.WriteLine($"{names[0],-10} {Class[0],-7} {marks[0],-6} {marks[1],-6} {marks[2],-6} {total1,-7} {avg1,-7}");
             Console.WriteLine($"{names[1],-10} {Class[1],-7} {marks[3],-6} {marks[4],-6} {marks[5],-6} {total2,-7} {avg2,-7}");
             Console.WriteLine($"{names[2],-10} {Class[2],-7} {marks[6],-6} {marks[7],-6} {marks[8],-6} {total3,-7} {avg3,-7}");








             int[] arr = { 0, 3, 5 };
             int sum = arr_add(arr);
             Console.WriteLine(sum);

             int[] new_arr = push();

             display_data(new_arr);



         }

         static public void addition(int first,int  second)
         {
             int c = first + second; ;
             Console.WriteLine(c);
         }

         static public int add(int first, int second)
         {
             int c = first + second; ;
             return c;
         }

         static public double addition()
         {
             double first = Convert.ToDouble(Console.ReadLine()); 
             int second = Convert.ToInt32(Console.ReadLine());

             double sum = first + second;



             return sum;
         }

         static public int arr_add(int[] arr)
         {
             return arr[0] + arr[1] + arr[2];
         }


         static int[] push()
         {
             int[] arr = new int[5];
             Console.WriteLine("enter 5");
             arr[0] = Convert.ToInt32(Console.ReadLine());
             arr[1] = Convert.ToInt32(Console.ReadLine());
             arr[2] = Convert.ToInt32(Console.ReadLine());
             arr[3] = Convert.ToInt32(Console.ReadLine());
             arr[4] = Convert.ToInt32(Console.ReadLine());

             return arr;
         }

         static void display_data(int[] arr)
         {
             Console.WriteLine($"{arr[0]}, {arr[1]}, {arr[2]}, {arr[3]}, {arr[4]}");

         }*/



            

            student stud1 = new student();
            student stud2 = new student();
            student stud3 = new student();
            student stud4 = new student();
            student stud5 = new student();

            student[] s = {stud1 , stud2 , stud3 ,stud4 , stud5}; 

            for (int i = 0; i < s.Length; i++)      

                   
            {
                s[i].get_data();
                s[i].display();
                Console.WriteLine(s[i].total());
                Console.WriteLine(s[i].avg());
                Console.WriteLine("----------------");




            }


        }

        

        






        

    }
}
