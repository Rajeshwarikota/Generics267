using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics267
{
    class ArrayOperations
    {
        public static void DeleteElement(int[] ar, int delete)
        {
            int k = 0;
            int[] result = new int[ar.Length - 1];

            for (int i = 0; i < ar.Length; i++)
            {
                if (delete != ar[i])
                {
                    result[k] = ar[i];
                    k++;
                }
            }
            foreach (int j in result)
            {
                Console.Write(j + " ");
            }

        }
        public static void DoubleDeleteElement(double[] ar, double delete)
        {
            int k = 0;
            double[] result = new double[ar.Length - 1];

            for (int i = 0; i < ar.Length; i++)
            {
                if (delete != ar[i])
                {
                    result[k] = ar[i];
                    k++;
                }
            }
            foreach (double j in result)
            {
                Console.Write(j + " ");
            }

        }
        public static void CharDeleteElement(char[] ar, char delete)
        {
            int k = 0;
            char[] result = new char[ar.Length - 1];

            for (int i = 0; i < ar.Length; i++)
            {
                if (delete != ar[i])
                {
                    result[k] = ar[i];
                    k++;
                }
            }
            foreach (char j in result)
            {
                Console.Write(j + " ");
            }

        }
    }
}
