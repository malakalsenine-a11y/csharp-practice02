namespace project01
{
    internal class Program
    {
        class Car
        {
            public string color;
            public int model_year {  get; }
            private int temp = 10;
            
            public int Speed
            {
                get { return temp; }
                set
                {
                    if (value > 0)
                    {
                        temp = value;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Car my_car = new Car();
            Console.WriteLine(my_car.Speed);
        }
    }
}
