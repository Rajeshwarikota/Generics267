using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics267
{
    class GenericMethodOperations
    {
        public static void DeleteElement<T>(T[] ar, T delete)
        {
            int k = 0;
            T[] result = new T[ar.Length - 1];

            for (var i = 0; i < ar.Length; i++)
            {
                if (!delete.Equals(ar[i]))
                {
                    result[k] = ar[i];
                    k++;
                }
            }
            Console.WriteLine("After Deletion remaining Elements are: ");
            foreach (var j in result)
            {
                Console.WriteLine(j + " ");
            }

        }

    }
}
