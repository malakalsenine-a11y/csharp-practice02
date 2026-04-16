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

            for( int x = 1; x < 5; x++)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine($"({x}.{i}) ");

                }

                Console.WriteLine();
            }



            
        }
    }
}
