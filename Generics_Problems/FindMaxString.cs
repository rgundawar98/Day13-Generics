using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Problems
{
    public class FindMaxString
    {
        public void Find_Maximum_String(string First, string Second, string Third)
        {
            if (First.CompareTo(Second) > 0 && First.CompareTo(Third) > 0)
            {
                Console.WriteLine("{0} is maximum string", First);
            }
            else if (Second.CompareTo(First) > 0 && Second.CompareTo(Third) > 0)
            {
                Console.WriteLine("{0} is maximum string", Second);
            }
            else
            {
                Console.WriteLine("{0} is maximum string", Third);
            }
        }
    }
}
