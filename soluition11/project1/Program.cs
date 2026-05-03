namespace project1
{
    internal class Program
    {

        #region Sum Functions
        //Add sum functions using method overloading:
        //static int Sum(int a, int b)
        //{
        //    return a + b;
        //}

        //static int Sum(int a, int b, int c)
        //{
        //    return a + b + c;
        //}

        //static int Sum(int a, int b, int c, int d)
        //{
        //    return a + b + c + d;
        //}


        //static void Main(string[] args)
        //{
        //    Console.WriteLine(Sum(5, 10));
        //    Console.WriteLine(Sum(1, 2, 3));
        //    Console.WriteLine(Sum(2, 4, 6, 8));

        //}

        #endregion

        #region New Function

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static double Sum(double a, double b)
        {
            return a + b ;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Sum(5, 10));
            Console.WriteLine(Sum(5.1, 10.2));

        }
        #endregion

    }
}
