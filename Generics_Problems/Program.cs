using System;

namespace Generics_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Generics Problems");
            Console.WriteLine("1.Find Max Integer\n2.Find Max Float or Double");
            Console.WriteLine("Choose option from above:");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    Console.WriteLine("Enter the first value");
                    int firstval = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the second value");
                    int secondval = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the third value");
                    int thirdval = Convert.ToInt32(Console.ReadLine());
                    FindMaxInteger findMaxInteger= new FindMaxInteger();
                    findMaxInteger.Find_Maximum_Integer(firstval, secondval, thirdval);
                    break;
                case 2:
                    Console.WriteLine("Enter the first number");
                    double first = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the second number");
                    double second = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Enter the third number");
                    double third = Convert.ToDouble(Console.ReadLine());
                    FindMaxFloat findMaxFloat= new FindMaxFloat();
                    findMaxFloat.Find_Maximum_Float(first, second, third);
                    break;
            }
        }
    }
}
