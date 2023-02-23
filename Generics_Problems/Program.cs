using System;

namespace Generics_Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Generics Problems");
            Console.WriteLine("1.Find Max Integer");
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
            }
        }
    }
}
