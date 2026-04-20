namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region array
            int[] num = { 1, 2, 3, 4, 5, 6 };
            foreach (int X in num)
            {
                Console.WriteLine(X);
            }

            #endregion

            #region string array:

            int[] age = new int[4];
            for (int x = 0; x < age.Length; x++)
            {
                Console.WriteLine("Enter your age: ");
                age[x] = Convert.ToInt32(Console.ReadLine());
                foreach (int y in age)
                {
                    Console.WriteLine(y);
                }

            #endregion

            }
        }
    }
}