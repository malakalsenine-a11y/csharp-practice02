using System;
using System.Collections.Generic;

namespace StudentServiceCenter
{
    internal class Program
    {
        static Dictionary<int, string> students = new Dictionary<int, string>();
        static Queue<int> serviceQueue = new Queue<int>();
        static Stack<string> serviceHistory = new Stack<string>();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n=== Student Service Center ===");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Update Student");
                Console.WriteLine("3. Remove Student");
                Console.WriteLine("4. Search Student");
                Console.WriteLine("5. Display All Students");
                Console.WriteLine("6. Add Student to Queue");
                Console.WriteLine("7. Serve Next Student");
                Console.WriteLine("8. Show Service History");
                Console.WriteLine("9. Exit");

                Console.Write("Choose: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        UpdateStudent();
                        break;
                    case 3:
                        RemoveStudent();
                        break;
                    case 4:
                        SearchStudent();
                        break;
                    case 5:
                        DisplayStudents();
                        break;
                    case 6:
                        AddToQueue();
                        break;
                    case 7:
                        ServeStudent();
                        break;
                    case 8:
                        ShowHistory();
                        break;
                    case 9:
                        return;
                }
            }
        }

        // ---------------- Dictionary ----------------

        static void AddStudent()
        {
            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            students[id] = name;
            Console.WriteLine("Student added!");
        }

        static void UpdateStudent()
        {
            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());

            if (students.ContainsKey(id))
            {
                Console.Write("Enter new name: ");
                students[id] = Console.ReadLine();
                Console.WriteLine("Updated!");
            }
            else
            {
                Console.WriteLine("Student not found!");
            }
        }

        static void RemoveStudent()
        {
            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());

            if (students.Remove(id))
                Console.WriteLine("Removed!");
            else
                Console.WriteLine("Student not found!");
        }

        static void SearchStudent()
        {
            Console.Write("Enter ID: ");
            int id = int.Parse(Console.ReadLine());

            if (students.ContainsKey(id))
                Console.WriteLine($"Name: {students[id]}");
            else
                Console.WriteLine("Not found!");
        }

        static void DisplayStudents()
        {
            foreach (var s in students)
            {
                Console.WriteLine($"ID: {s.Key} - Name: {s.Value}");
            }
        }

        // ---------------- Queue ----------------

        static void AddToQueue()
        {
            Console.Write("Enter Student ID: ");
            int id = int.Parse(Console.ReadLine());

            if (students.ContainsKey(id))
            {
                serviceQueue.Enqueue(id);
                Console.WriteLine("Added to queue!");
            }
            else
            {
                Console.WriteLine("Student not found!");
            }
        }

        static void ServeStudent()
        {
            if (serviceQueue.Count > 0)
            {
                int id = serviceQueue.Dequeue();
                string name = students[id];

                Console.WriteLine($"Serving: {name}");

                serviceHistory.Push(name); // حفظ في Stack
            }
            else
            {
                Console.WriteLine("Queue is empty!");
            }
        }

        // ---------------- Stack ----------------

        static void ShowHistory()
        {
            Console.WriteLine("Service History:");

            foreach (var item in serviceHistory)
            {
                Console.WriteLine(item);
            }
        }
    }
}