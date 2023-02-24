using System;

namespace Generics_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Generics Problems");
            Console.WriteLine("1.Find Max Integer\n2.Find Max Float or Double\n3.Find Maximum String\n4.Generic Refactor one" +
                "\n5.Generic Refactor Two\n6.Extend Max Method MoreThan Three Parameters");
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
                case 4:
                    GenericRefactor<int>.FindMax(120, 222, 333);
                    GenericRefactor<double>.FindMax(45.6, 55.8, 20.5);
                    GenericRefactor<string>.FindMax("Apple", "Banana", "Pineapple");
                    break;
                case 5:
                    GenericsRefactorTwo<int> genericsRefactorTwo = new GenericsRefactorTwo<int>(40, 55, 80);
                    genericsRefactorTwo.TestMaximum();
                    break;
                case 6:
                    Console.WriteLine("Enter first number");
                    int First_val = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second number");
                    int Second_val = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter third number");
                    int Third_val = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the fourth number");
                    int Fourth_val =Convert.ToInt32(Console.ReadLine());
                    Extend_Max_Method<int>.FindMax(First_val,Second_val,Third_val,Fourth_val);
                    break;
            }
        }
    }
}
