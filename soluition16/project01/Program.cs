namespace project01
{
    internal class Program
    {

        class Student
        {
            public string Name;
        }

        class Teacher
        {
            public void Teach(Student s)
            {
                Console.WriteLine("Teacher teaches " + s.Name);
            }
        }



        static void Main(string[] args)
        {
            Student st = new Student();
            st.Name = "Malak";

            Teacher t = new Teacher();

            // Association
            t.Teach(st);
        }
    }
}
