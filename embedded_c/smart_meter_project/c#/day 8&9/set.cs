namespace settt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            HashSet<int> set1 = new HashSet<int>();

            set1.Add(10);
            set1.Add(20);
            set1.Add(30);
            set1.Add(40);
            set1.Add(10); 

            Console.WriteLine("HashSet Elements");
            foreach (int num in set1)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine();

            
            List<int> list1 = new List<int>();

            list1.Add(10);
            list1.Add(20);
            list1.Add(30); 


            list1.Add(40);
            list1.Add(10); 
            list1.Append(20);

            Console.WriteLine("List Elements :");
            foreach (int num in list1)
            {
                Console.WriteLine(num);
            }

           
        }
    }
}
