namespace project02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Task 1- Positive, Negative, or Zero 

            Console.WriteLine("Please Enter Any Number");
            int Number = Convert.ToInt32(Console.ReadLine());

            if (Number > 0)
            {
                Console.WriteLine("Positive");
            }

            else if (Number < 0)
            {
                Console.WriteLine("Negative");
            }

            else
            {
                Console.WriteLine("Zero");
            }
        }
    }
}
