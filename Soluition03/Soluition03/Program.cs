using System.Net.Security;

namespace Soluition03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Task 1 For Loop:

            //for (int x = 1; x < 5; x++)
            //{
            //    Console.WriteLine("Hello, my name is Malak");
            //}




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



            // Task 4: ask user enter any number then check if the number is prime or no:

               Console.Write("Enter Any  number : ");
               int number = Convert.ToInt32(Console.ReadLine());

            bool isPrime = true;

            for(int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if(number <= 1)
            {
                isPrime = false;
            }

            if (isPrime)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
}
