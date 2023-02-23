﻿using System;

namespace Generics_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Generics Problems");
            Console.WriteLine("1.Find Max Integer\n2.Find Max Float or Double\n3.Find Maximum String");
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
                case 3:
                    Console.WriteLine("Enter the first string");
                    string First = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter the second string");
                    string Second = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Enter the third string");
                    string Third = Convert.ToString(Console.ReadLine());
                    FindMaxString findMaxString= new FindMaxString();
                    findMaxString.Find_Maximum_String(First, Second, Third);
                    break;
            }
        }
    }
}
