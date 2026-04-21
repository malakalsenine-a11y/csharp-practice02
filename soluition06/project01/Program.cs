namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Number of array:

            Console.WriteLine("Enter Number of Rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Number of Columns: ");
            int columns = Convert.ToInt32(Console.ReadLine());

            int[,] numbers = new int[rows, columns];

            for (int x = 0; x < rows; x++)
            {
                for (int i = 0; i < columns; i++)
                {
                    Console.WriteLine($"Enter Value For ({x},{i}) : ");
                    numbers[x, i] = Convert.ToInt32(Console.ReadLine());

                }

            }

            Console.WriteLine("The Number of Array is:");
            for (int x = 0; x < rows; x++)
            {
                for (int i = 0; i < columns; i++)
                {
                    Console.Write(numbers[x, i] + " ");
                }
                Console.WriteLine();
            }
            #endregion

            #region Part01 - Student Names:

            string[] student = new string[5];

            for (int x = 0; x < student.Length; x++ )
            {
                Console.WriteLine("Enter Name for the students : ");
                student[x] = Console.ReadLine();
            }

            Console.WriteLine("Students Name ;");
            for (int x = 0; x < student.Length; x++ )
            {
                Console.WriteLine(student[x]);
            }

            #endregion

        }
    }
}
