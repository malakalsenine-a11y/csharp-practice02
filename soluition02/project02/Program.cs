//namespace project02
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hello, World!");

//            //Task 1- Positive, Negative, or Zero 

//            Console.WriteLine("Please Enter Any Number");
//            int Number = Convert.ToInt32(Console.ReadLine());

//            if (Number > 0)
//            {
//                Console.WriteLine("Positive");
//            }

//            else if (Number < 0)
//            {
//                Console.WriteLine("Negative");
//            }

//            else
//            {
//                Console.WriteLine("Zero");
//            }

//            //Task2 Evenor Odd:

//            Console.WriteLine("Please Enter Any Enteger Number");
//            int Num = Convert.ToInt32(Console.ReadLine());

//            if (Num % 2 == 0)
//            {
//                Console.WriteLine("Even Number");
//            }
//            else
//            {
//                Console.WriteLine("Odd Number");
//            }

//            //Task3 - Student Grade System:
//            Console.WriteLine("Please Enter Student Score From 0 to 100");
//            int Score = Convert.ToInt32(Console.ReadLine());

//            if (Score >= 90 && Score <= 100)
//            {
//                Console.WriteLine("Excellent");
//            }

//            else if (Score >= 75 && Score <= 89)
//            {
//                Console.WriteLine("Very Good");
//            }

//            else if (Score >= 60 && Score <= 74)
//            {
//                Console.WriteLine("Good");
//            }

//            else if (Score >= 50 && Score <= 59)
//            {
//                Console.WriteLine("Pass");
//            }

//            else
//            {
//                Console.WriteLine("Fail");
//            }

//            //Task4 Simple Login System:

//            Console.WriteLine("Enter User Name: ");
//            string userName = Console.ReadLine();

//            Console.WriteLine("Enter Password: ");
//            int Password = Convert.ToInt32(Console.ReadLine());

//            if (userName == "admin" && Password == 1234)
//            {
//                Console.WriteLine("Login Successful");
//            }

//            else
//            {
//                Console.WriteLine("Invaild user Name or Password");
//            }

//            // Task 5:

//            int balance = 1000;
//            Console.WriteLine("Enter Your withdrawal amount");
//            int amount = Convert.ToInt32(Console.ReadLine());

//            if (amount <= 0)
//            {
//                Console.WriteLine("Invalid Amount");
//            }
//            else if (amount > balance)
//            {
//                Console.WriteLine("Insufficient Balance");
//            }

//            else
//            {
//                balance -= amount;
//                Console.WriteLine("Withdrawal Successful");
//                Console.WriteLine("Remaining balance");
//            }

//        }
//    }
//}






#region Task1: Day Name Printer
//Task 1 – Day Name Printer//


//Console.Write("Enter a number from 1 to 7: ");
//int day = Convert.ToInt32(Console.ReadLine());

//switch (day)
//{

//    case 1:
//        Console.WriteLine("Monday");
//        break;

//    case 2:
//        Console.WriteLine("Tuesday");
//        break;

//    case 3:
//        Console.WriteLine("Wednesday");
//        break;


//    case 4:
//        Console.WriteLine("Thursday");
//        break;

//    case 5:
//        Console.WriteLine("Friday");
//        break;

//    case 6:
//        Console.WriteLine("Saturday");
//        break;

//    case 7:
//        Console.WriteLine("Sunday");
//        break;

//    default:
//        Console.WriteLine("Invalid day number");
//        break;
//}


#endregion



#region Task2: Multiplication Table (foor loop)
//Task 2 – Multiplication Table (foor loop) //

//Console.Write("Enter your number: ");
//int number = Convert.ToInt32(Console.ReadLine());

//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine(number + "*" + i + "=" + (number * i));
//}
#endregion


#region Task3: Countdown Timer (while loop)
//Task 3 – Countdown Timer (while loop) //

//Console.Write("Enter a positive number: ");
//int number = Convert.ToInt32(Console.ReadLine());

//if (number <= 0)
//{
//    Console.WriteLine("Please enter a positive number");
//}

//else
//{
//    while (number >= 1)
//    {
//        Console.WriteLine(number);
//        number--;
//    }
//}
#endregion


#region Task 4: Season Detector with Month Validation

//Console.Write("Enter a month number (1-12): ");
//int month = Convert.ToInt32(Console.ReadLine());

//switch (month)
//{
//    case 12:
//    case 1:
//    case 2:
//        Console.WriteLine("Winter");
//        break;

//    case 3:
//    case 4:
//    case 5:
//        Console.WriteLine("Spring");
//        break;

//    case 6:
//    case 7:
//    case 8:
//        Console.WriteLine("Summer");
//        break;

//    case 9:
//    case 10:
//    case 11:
//        Console.WriteLine("Autumn");
//        break;

//    default:
//        Console.WriteLine("Invalid month number");
//        break;
//}
#endregion

#region Task5: Sum of Even and Odd Numbers

Console.Write("Enter a positive number: ");
int n = Convert.ToInt32(Console.ReadLine());

int evenSum = 0;
int oddSum = 0;

for (int i = 1; i <= n; i++)
{
    if (i % 2 == 0)
    {
        evenSum += i;
    }
    else
    {
        oddSum += i;
    }
}

Console.WriteLine("Sum of even numbers: " + evenSum);
Console.WriteLine("Sum of odd numbers: " + oddSum);
#endregion