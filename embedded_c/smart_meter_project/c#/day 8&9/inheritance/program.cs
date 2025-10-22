namespace inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            card card = new credcard( "fg" , 5);
            card.dis();

            credcard cc1 = new credcard();
            cc1.get_data();
            cc1.display();
            credcard cc2 = new credcard();
            cc2.get_data();
            cc2.display();
        }
    }
}