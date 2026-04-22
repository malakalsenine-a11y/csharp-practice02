namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //File.Create("test01.txt");

            //File.WriteAllText("test01.txt", "Hello My File");

            //File.AppendAllText("test01.txt" , "\n Thisa the new line");

            //string myFile = File.ReadAllText("test01.txt");
            //Console.WriteLine(myFile);

            string[] mylines = File.ReadAllLines("test01.txt");
            Console.WriteLine(mylines[4]);



        }
    }
}
