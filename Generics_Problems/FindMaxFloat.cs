using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Problems
{
    public class FindMaxFloat
    {
        public void Find_Maximum_Float(double first, double second, double third) 
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                Console.WriteLine("{0} is maximum number", first);
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                Console.WriteLine("{0} is maximum number", second);
            }
            else
            {
                Console.WriteLine("{0} is maximum number", third);
            }
        }
    }
}
