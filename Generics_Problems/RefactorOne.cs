using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Problems
{
    public class GenericRefactor<T> where T :IComparable
    {
        public static T FindMax(T First_val , T Second_Val, T Third_Val)
        {
            if(First_val.CompareTo(Second_Val)>0 && First_val.CompareTo(Third_Val)>0)
            {
                Console.WriteLine("Greater is:"+First_val);
                return First_val;
            }
            else if(Second_Val.CompareTo(Third_Val)>0 && Second_Val.CompareTo(First_val)>0)
            {
                Console.WriteLine("Greater is:" + Second_Val);
                return Second_Val;
            }
            else
            {
                Console.WriteLine("Greater is:" + Third_Val);
                return Third_Val;
            }
        }
    }
}
