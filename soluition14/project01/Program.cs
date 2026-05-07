namespace project01
{
    internal class Program
    {

        class Parent
        {
            public void Message()
            {
                Console.WriteLine("This is normal function from parent");
            }

            // Virtual Function 1:
            public virtual void Display()
            {
                Console.WriteLine("Display function from Parent");
            }

            // Virtual Function 2:
            public virtual void Show()
            {
                Console.WriteLine("Show function from Parent");
            }

        }

        class Child : Parent
        {
            // override  Function 1:
            public override void Display()
            {
                Console.WriteLine("Display function overridden in Child");
            }

            // override  Function 2:
            public override void Show()
            {
                Console.WriteLine("Show function overridden in Child");
            }
        }


        static void Main(string[] args)
        {
            // Create object from Child
            Child obj = new Child();

            // Call inherited normal function
            obj.Message();

            // Call overridden functions
            obj.Display();
            obj.Show();
        }
    }
}
