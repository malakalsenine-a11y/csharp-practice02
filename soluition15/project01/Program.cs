using System;

namespace OOPArrays
{
    class Student
    {
        public string Name;
        public int Grade;

        public void Display()     // دالة العرض
        {
            Console.WriteLine($"Name: {Name}, Grade: {Grade}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // إنشاء Array من نوع Student
            Student[] students = new Student[3];

            // إضافة Objects داخل الـ Array
            students[0] = new Student();
            students[0].Name = "Ali";
            students[0].Grade = 90;

            students[1] = new Student();
            students[1].Name = "Sara";
            students[1].Grade = 85;

            students[2] = new Student();
            students[2].Name = "Omar";
            students[2].Grade = 95;

            // طباعة البيانات
            foreach (Student s in students)
            {
                s.Display();
            }
        }
    }
}


//==========================================================================================================================

using System;
using System.Collections.Generic;

namespace OOPList
{
    class Student
    {
        public string Name;
        public int Grade;

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Grade: {Grade}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           
            List<Student> students = new List<Student>();

            
            students.Add(new Student { Name = "Ali", Grade = 90 });
            students.Add(new Student { Name = "Sara", Grade = 85 });
            students.Add(new Student { Name = "Omar", Grade = 95 });

            
            foreach (Student s in students)
            {
                s.Display();
            }
        }
    }
}
