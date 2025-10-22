namespace exception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

   

            try
            {
                if (age < 18)
                {
                    throw new agenotsufficient(age);
                }

                Console.WriteLine("eligible to vote");
            }
            catch (agenotsufficient ex)
            {
                Console.WriteLine(ex.display());
            }
            finally
            {
                Console.WriteLine("Program terminated.");
            }
        }
    }
}
