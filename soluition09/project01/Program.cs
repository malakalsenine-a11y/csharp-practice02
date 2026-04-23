using System;

namespace project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator();
        }

        static void Calculator()
        {
            char again = 'y';

            do
            {
                Console.Write("Enter first number: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter second number: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Choose operation (+ - * /): ");
                char op = Convert.ToChar(Console.ReadLine());

                double result = 0;

                switch (op)
                {
                    case '+':
                        result = num1 + num2;
                        break;

                    case '-':
                        result = num1 - num2;
                        break;

                    case '*':
                        result = num1 * num2;
                        break;

                    case '/':
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                        {
                            Console.WriteLine("Cannot divide by zero!");
                            result = 0;
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid operation!");
                        result = 0;
                        break;
                }

                

        }
    }
}