using System;
using System.IO;
using System.Diagnostics;

namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("quiz1.txt", "Q1: 2+2=?\nQ2: 3+3=?");
            File.WriteAllText("quiz2.txt", "Q1: Capital of Oman?\nQ2: Capital of France?");
            File.WriteAllText("quiz3.txt", "Q1: 5*5=?\nQ2: 10/2=?");

            Console.WriteLine("Choose Quiz (1, 2, 3): ");
            int choice = Convert.ToInt32(Console.ReadLine());

            string fileName = "";

            if (choice == 1)
                fileName = "quiz1.txt";
            else if (choice == 2)
                fileName = "quiz2.txt";
            else if (choice == 3)
                fileName = "quiz3.txt";
            else
            {
                Console.WriteLine("Invalid choice");
                return;
            }

            Process.Start("notepad.exe", fileName);
        }
    }
}