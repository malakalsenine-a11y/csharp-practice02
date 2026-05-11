namespace project01
{
    internal class Program
    {
        //Association
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

        //Aggregation
        class Player
        {
            public string Name;

            public Player(string name)
            {
                Name = name;
            }
        }

        class Team
        {
            public Player player;

            public Team(Player p)
            {
                player = p;
            }

            public void Show()
            {
                Console.WriteLine(player.Name);
            }
        }



        //Composition

        class Engine
        {
            public void Start()
            {
                Console.WriteLine("Engine Started");
            }
        }

        class Car
        {
            private Engine engine;

            public Car()
            {
               
                engine = new Engine();
            }

            public void Run()
            {
                engine.Start();
                Console.WriteLine("Car is Running");
            }
        }



        static void Main(string[] args)
        {
            #region Association
            Student st = new Student();
            st.Name = "Malak";

            Teacher t = new Teacher();

            // Association
            t.Teach(st);
            #endregion


            #region Aggregation
            Player p1 = new Player("Ahmed");

            Team t1 = new Team(p1);

            t1.Show();
            #endregion

            #region Composition

            Car c1 = new Car();

            c1.Run();

            #endregion

        }
    }
}
