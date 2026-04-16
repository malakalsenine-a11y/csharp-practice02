using System.Net.Security;

namespace Soluition03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Task1
            // Task 1 For Loop:

            //for (int x = 1; x < 5; x++)
            //{
            //    Console.WriteLine("Hello, my name is Malak");
            //} 
            #endregion



            #region Task 2:

            // Task 2: ask user:
            //for (int i = 1;  i <= 5; i++)

            //    {

            //    Console.Write("Enter Any  number : ");
            //    int number = Convert.ToInt32(Console.ReadLine());
            //}


            // Task 3: loop inside loop:

            //for( int x = 1; x < 5; x++)
            //{
            //    for (int i = 0; i < 3; i++)
            //    {
            //        Console.WriteLine($"({x}.{i}) ");

            //    }

            //    Console.WriteLine();
            //} 
            #endregion




            #region Task4

            // Task 4: ask user enter any number then check if the number is prime or no:

            //Console.Write("Enter Any  number : ");
            //int number = Convert.ToInt32(Console.ReadLine());

            //bool isPrime = true;

            //for (int i = 2; i < number; i++)
            //{
            //    if (number % i == 0)
            //    {
            //        isPrime = false;
            //        break;
            //    }
            //}

            //if (number <= 1)
            //{
            //    isPrime = false;
            //}

            //if (isPrime)
            //{
            //    Console.WriteLine("Prime");
            //}
            //else
            //{
            //    Console.WriteLine("Not Prime");
            //}

            #endregion


            #region Task5
            //Random Number"
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 11);

            int number;
            int attempts = 0;

            Console.WriteLine("Guess the number (1 - 10):");
            number = Convert.ToInt32(Console.ReadLine());
            attempts++;

            while (number != randomNumber)
            {
                Console.WriteLine("Incorrect Number, Try Again:");
                number = Convert.ToInt32(Console.ReadLine());
                attempts++;
            }

            Console.WriteLine("Correct!");
            Console.WriteLine("Attempts: " + attempts);

            #endregion
        }
    }
}

