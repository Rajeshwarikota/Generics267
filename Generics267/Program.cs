﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics267
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(".....Generics.....");
            Console.WriteLine("Enter the Option the below");
            Console.WriteLine("\n1:Arrayoperations");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Enter the Option the below");
                    Console.WriteLine("\n1:Integer element delete\n2:Double element delete\n3:char element delete");
                    int choose = Convert.ToInt32(Console.ReadLine());

                    switch (choose)
                    {
                        case 1:
                            Console.WriteLine("How many integer elements to add into array");
                            int size = Convert.ToInt32(Console.ReadLine());
                            int[] arr = new int[size];
                            Console.WriteLine("Adding elements into array");
                            for (int i = 0; i < arr.Length; i++)
                            {
                                arr[i] = Convert.ToInt32(Console.ReadLine());
                            }
                            Console.WriteLine("\nplease pickup any one element from this array");
                            int delete = Convert.ToInt32(Console.ReadLine());
                            ArrayOperations.DeleteElement(arr, delete);
                            break;
                        case 2:
                            Console.WriteLine("How many double elements to add into array");
                            int doublesize = Convert.ToInt32(Console.ReadLine());
                            double[] doubleArr = new double[doublesize];
                            Console.WriteLine("Adding elements into array");
                            for (int i = 0; i < doubleArr.Length; i++)
                            {
                                doubleArr[i] = Convert.ToDouble(Console.ReadLine());
                            }
                            Console.WriteLine("\nplease pickup any one element from this array");
                            double deleteDouble = Convert.ToDouble(Console.ReadLine());
                            ArrayOperations.DoubleDeleteElement(doubleArr, deleteDouble);
                            break;
                        case 3:
                            Console.WriteLine("How many char elements to add into array");
                            int charsize = Convert.ToInt32(Console.ReadLine());
                            char[] charArr = new char[charsize];
                            Console.WriteLine("Adding elements into array");
                            for (int i = 0; i < charArr.Length; i++)
                            {
                                charArr[i] = Convert.ToChar(Console.ReadLine());
                            }
                            Console.WriteLine("\nplease pickup any one element from this array");
                            char deletechar = Convert.ToChar(Console.ReadLine());
                           // char[] updatedArray = ArrayOperations.CharDeleteElement(charArr, deletechar);
                            //Console.WriteLine($"Updated array: {string.Join(", ", updatedArray)}");
                            ArrayOperations.CharDeleteElement(charArr, deletechar);
                            break;
                        default:
                            Console.WriteLine("Enter the above option");
                            break;
                    }
                    break;
            }
             Console.ReadLine();
        }
    }
}
