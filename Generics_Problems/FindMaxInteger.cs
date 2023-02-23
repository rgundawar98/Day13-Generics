using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Problems
{
    public class FindMaxInteger
    {
        public void Find_Maximum_Integer(int firstval , int secondval , int thirdval)
        {
            if(firstval.CompareTo(secondval) > 0 && firstval.CompareTo(thirdval)>0 )
            {
                Console.WriteLine("{0} is maximum number", firstval);
            }
            else if(secondval.CompareTo(firstval)>0 && secondval.CompareTo(thirdval)>0)
            {
                Console.WriteLine("{0} is maximum number", secondval);
            }
            else
            {
                Console.WriteLine("{0} is maximum number", thirdval);
            }
        }
    }
}
