namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Number of array:

            //Console.WriteLine("Enter Number of Rows: ");
            //int rows = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Enter Number of Columns: ");
            //int columns = Convert.ToInt32(Console.ReadLine());

            //int[,] numbers = new int[rows, columns];

            //for (int x = 0; x < rows; x++)
            //{
            //    for (int i = 0; i < columns; i++)
            //    {
            //        Console.WriteLine($"Enter Value For ({x},{i}) : ");
            //        numbers[x, i] = Convert.ToInt32(Console.ReadLine());

            //    }

            //}

            //Console.WriteLine("The Number of Array is:");
            //for (int x = 0; x < rows; x++)
            //{
            //    for (int i = 0; i < columns; i++)
            //    {
            //        Console.Write(numbers[x, i] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Part01 - Student Names(One Dimensional Array)

            string[] names = new string[5];

            Console.WriteLine("--- Part 1: Student Names ---");


            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter name of student {i + 1}: ");
                names[i] = Console.ReadLine();
            }

            Console.WriteLine("\nStudent Names:");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(names[i]);
            }

            #endregion

            #region Part 2 – Student Grades (Multi-Dimensional Array)

            //  الدرجات
            int[,] grades = new int[5, 3];

            string[] subjects = { "Math", "Science", "English" };

            Console.WriteLine("--- Part 2: Student Grades ---");


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Grades for {names[i]}:");

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Enter {subjects[j]} grade: ");
                    grades[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Final Result:");

            for (int i = 0; i < 5; i++)
            {
                Console.Write(names[i] + ": ");

                for (int j = 0; j < 3; j++)
                {
                    Console.Write(grades[i, j] + " ");
                }

                Console.WriteLine();
            }


            #endregion

            #region Part 3 – Display Student Grades
            Console.WriteLine("--- Part 3: Student Grades Table ---");

            for (int j = 0; j < 3; j++)
            {
                Console.Write(subjects[j] + "/t");
            }

            Console.WriteLine();

            Console.WriteLine("------------------------------------------");

            // البيانات
            for (int i = 0; i < 5; i++)
            {
                Console.Write(names[i] + "");

                for (int j = 0; j < 3; j++)
                {
                    Console.Write(grades[i, j] + "|");
                   

                }

                Console.WriteLine();
            }


            #endregion






        }
    }
    }

