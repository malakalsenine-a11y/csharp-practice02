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

            //Task2 Evenor Odd:

            Console.WriteLine("Please Enter Any Enteger Number");
            int Num = Convert.ToInt32(Console.ReadLine());

            if (Num % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }

            //Task3 - Student Grade System:
            Console.WriteLine("Please Enter Student Score From 0 to 100");
            int Score = Convert.ToInt32(Console.ReadLine());

            if (Score >= 90 && Score <= 100)
            {
                Console.WriteLine("Excellent");
            }

            else if (Score >= 75 && Score <= 89)
            {
                Console.WriteLine("Very Good");
            }

            else if (Score >= 60 && Score <= 74)
            {
                Console.WriteLine("Good");
            }

            else if (Score >= 50 && Score <= 59)
            {
                Console.WriteLine("Pass");
            }

            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
