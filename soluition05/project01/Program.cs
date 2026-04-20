namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region array
            //int[] num = { 1, 2, 3, 4, 5, 6 };
            //foreach (int X in num)
            //{
            //    Console.WriteLine(X);
            //}

            #endregion

            #region string array:

            //int[] number = new int[4];
            //for (int x = 0; x < number.Length; x++)
            //{
            //    Console.WriteLine("Enter your number: ");

            //    number[x] = Convert.ToInt32(Console.ReadLine());
            //    foreach (int y in number)
            //    {
            //        Console.WriteLine(y);
            //    }
            //}

            #endregion

            #region Task1:

            //int[] numbers = {10,20,30,40,50};

            //for (int x=0; x<numbers.Length; x++)
            //{
            //    Console.WriteLine(numbers[x]);
            //}
            #endregion

            #region Task2:
            //int[] numbers = { 1, 20, 3, 40, 5 };
            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //}



            #endregion

            #region Task3:
            //Task5:
            //int[] num = new int[5];

            //    for(int i=0; i< num.Length; i++)
            //{
            //    Console.WriteLine("Enter Number: ");
            //    num[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //int max = num[0];
            //for (int i = 1; i < num.Length; i++)
            //{
            //    if (num[i] > max)
            //    {
            //        max = num[i];
            //    }
            //}

            //Console.WriteLine("The max number is : " + max);

            #endregion

            #region Task4:
            //Task7:

            //int[] number = new int[10];

            //for(int x =0; x < number.Length; x++)
            //{
            //    Console.WriteLine("Enter Your Number: ");
            //    number[x] = Convert.ToInt32(Console.ReadLine());
            //}

            //Console.WriteLine("Even numbers are: ");   

            //for (int x = 0; x < number.Length; x++)
            //{
            //    if (number[x] % 2 == 0)
            //    {
            //        Console.WriteLine(number[x]);
            //    }
            //}



            #endregion

            #region Task5:
            //Task6:

            int[] number = new int[6];

            for (int x = 0; x < number.Length; x++)
            {
                Console.WriteLine("Enter Your Number: ");
                number[x] = Convert.ToInt32(Console.ReadLine());
            }

            int min = number[0];
            for (int x = 1; x < number.Length; x++)
            {
                if (number[x] < min)
                {
                    min = number[x];

                }
            }

            Console.WriteLine("The Min numbers is: " + min);

            #endregion


        }
    }
}