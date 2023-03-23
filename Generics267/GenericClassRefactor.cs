using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics267
{
    internal class GenericClassRefactor<T> where T : IComparable
    {
            public T first, second, third;
            public GenericClassRefactor(T first, T second, T third)
            {
                this.first = first;
                this.second = second;
                this.third = third;
            }
            public static T FindMinValue(T first, T second, T third)
            {

                if (first.CompareTo(second) < 0 && first.CompareTo(third) < 0)
                {
                    return first;
                }
                else if (second.CompareTo(first) < 0 && second.CompareTo(third) < 0)
                {
                    return second;
                }
                else if (third.CompareTo(second) < 0 && third.CompareTo(first) < 0)
                {
                    return third;
                }
                throw new Exception("2 or 3 Values are Equal");
            }
        }
}
