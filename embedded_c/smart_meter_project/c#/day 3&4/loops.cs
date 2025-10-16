namespace loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            /* for (int i = 0; i < 5; i++)
             {

                 for (int j = 0; j <= i; j++)
                 {
                     if (i == 4 && j == 4)
                     {
                         continue;
                     }
                     Console.Write("*");

                 }
                 Console.WriteLine();

                 ;

             }
             ;

             string[,] img = new string[2, 3];

             for(int i=0; i<2; i++)
             {
                 for(int j = 0; j < 3; j++)
                 {
                     int c = i + j;
                     if (c % 2 != 0)
                     {
                         Console.Write("*");
                     }
                     else
                     {
                         Console.Write(" ");
                     }
                 }
                 Console.WriteLine();

             } 

            int[] arr1 = new int[3];
            int[] arr2 = new int[3];
            int[] arrfin = new int[3];


            arr1 = get_data(arr1);
            arr2 = get_data(arr2);

            arrfin = addi(arr1, arr2);
            for (int i = 0; i < arrfin.Length; i++)
            {

                Console.Write(arrfin[i] + " ");
            }

            int sum = sumeven(arrfin);
            Console.WriteLine(sum);

            int sumd = sumdig(sum);
            Console.WriteLine(sumd);



        }

        static public int[] get_data(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }

        static public int[] addi(int[] arr1, int[] arr2)
        {

            int[] fin = new int[arr1.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                fin[i] = arr1[i] + arr2[i];
            }
            return fin;



        }

        static public int sumeven(int[] arrfin)
        {
            int sum = 0;
            for(int i = 0;i < arrfin.Length; i++)
            {
                if(arrfin[i]%2 == 0)
                {
                    sum += arrfin[i];
                }
            }
            return sum;

        }

        static public int sumdig(int sumx)
        {

            int sumf = 0;
            while (sumx > 0)
            {
                

                int dig;
                dig = sumx % 10;
                sumx /= 10;

                sumf += dig;
            }

            return sumf;

        }

            int[] arr1 = new int[5];
            int[] arr2 = new int[5];

            arr1 = get_data(arr1);
            arr2 = get_data(arr2);

            int x = 0;
           x = Math.Max(findodd(arr1) , x);
            x = Math.Max(findeven(arr1), x);
            x = Math.Max(findodd(arr2), x);
            x = Math.Max(findeven(arr2), x);
            Console.WriteLine($"max : {x}");

            int[] arr1odd = new int[x];
            int [] arr1even = new int[x];
            int[] arr2odd = new int[x];
            int[] arr2even = new int[x];

            arr1odd = insertodd(arr1 ,x);
            arr1even = inserteven(arr1 , x);
            arr2odd = insertodd(arr2 , x);
            arr2even = inserteven(arr2 , x);

            display(arr1even);
            display(arr1odd);







        }
        static public int[] get_data(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }

        static public int findodd(int[] arr) {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] % 2 != 0)
                {
                    count++;
                }
                

            }
            return count;

            
        
        }
        static public int findeven(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] % 2 == 0)
                {
                    count++;
                }
                

            }
            return count;



        }

        static public int[] insertodd(int [] arr , int x)
        {
            int [] result = new int[x];
            int index = 0;
            for(int i  = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    result[index] = arr[i];
                }


            }
            return result;
        }

        static public int[] inserteven(int[] arr, int x)
        {
            int[] result = new int[x];
            
            for (int i = 0; i < arr.Length; i++)
            {
                int index = 0;
                if (arr[i] % 2 == 0)
                {
                    result[index] = arr[i];
                }
                index ++;


            }
            return result;
        }
        static public void display(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {

                Console.WriteLine(arr[i] + " ");
            } 




            int x = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[x];
            int[] arr_rev = new int[x];


            arr = get_data(arr);

            arr_rev = arr_reverse(arr);

            display(arr);
            Console.WriteLine();
            display(arr_rev);



        }

        static public int[] get_data(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }
        static public int[] arr_reverse(int[] arr)
        {
            int i = 0, j = arr.Length-1;
            int temp = 0;

            while ( i < j)
            {
                temp = arr[j];
                arr[j] = arr[i];
                arr[i] = temp;
                i++;
                j--;


            }
            return arr;


        }




        static public void display(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {

                Console.Write(arr[i] + " ");
            }
        }


            int x = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[x];
            int[] arr_rev = new int[x];

            arr = get_data(arr);
            arr_rev = arr_reverse(arr);

            display(arr);
            Console.WriteLine();
            display(arr_rev);

        static int[] get_data(int[] arr)
        {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                return arr;
        }

            static int[] arr_reverse(int[] arr)
            {
                int[] rev = new int[arr.Length];
                for (int i = 0, j = arr.Length - 1; i < arr.Length; i++, j--)
                {
                    rev[i] = arr[j];
                }
                return rev;
            }

            static void display(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }*/

            int x = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[x];

            arr = get_data(arr);
            arr_reverse(arr);   // reverses the same array

            Console.WriteLine("Reversed array:");
            display(arr);

            static int[] get_data(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                return arr;
            }

            static int[] arr_reverse(int[] arr)
            {
                int i = 0, j = arr.Length - 1;
                int temp;

                while (i < j)
                {
                    temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                    i++;
                    j--;
                }
                return arr;
            }

            static void display(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }




        }

    }