using System;
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
            Console.WriteLine("\n1:Arrayoperations\n2:Generic method\n3:Generic class\n4:Finding Integer min value\n5:Finding float min value\n6:finfing string min value\n22:Default");
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
                            ArrayOperations.CharDeleteElement(charArr, deletechar);
                            break;
                        default:
                            Console.WriteLine("Enter the above option");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter the Option the below");
                    Console.WriteLine("\n1:Integer element delete\n2:Double element delete\n3:char element delete");
                    int pick = Convert.ToInt32(Console.ReadLine());

                    switch (pick)
                    {
                        case 1:
                            Console.WriteLine("How many integer elements to add into method");
                            int size = Convert.ToInt32(Console.ReadLine());
                            int[] arr = new int[size];
                            Console.WriteLine("Adding elements into array");
                            for (int i = 0; i < size; i++)
                            {
                                arr[i] = Convert.ToInt32(Console.ReadLine());
                            }
                            Console.WriteLine("\nplease pickup any one element from this array");
                            int Intresult = Convert.ToInt32(Console.ReadLine());
                            GenericMethodOperations.DeleteElement<int>(arr, Intresult);
                            break;
                         case 2:
                            Console.WriteLine("How many integer elements to add into method");
                            int doublesize = Convert.ToInt32(Console.ReadLine());
                            double[] doublearr = new double[doublesize];
                            Console.WriteLine("Adding elements into array");
                            for (int i = 0; i < doublesize; i++)
                            {
                                doublearr[i] = Convert.ToDouble(Console.ReadLine());
                            }
                            Console.WriteLine("\nplease pickup any one element from this array");
                            double Doubleresult = Convert.ToDouble(Console.ReadLine());
                            GenericMethodOperations.DeleteElement<double>(doublearr, Doubleresult);
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
                            GenericMethodOperations.DeleteElement<char>(charArr, deletechar);
                            break;
                        default:
                            Console.WriteLine("Enter the above option");
                            break;
                    }
                    break;
                case 3:
                    Console.WriteLine("Enter the Option the below");
                    Console.WriteLine("\n1:Integer element delete\n2:Double element delete\n3:char element delete");
                    int pickout = Convert.ToInt32(Console.ReadLine());

                    switch (pickout)
                    {
                        case 1:
                            Console.WriteLine("How many integer elements to add into method");
                            int size = Convert.ToInt32(Console.ReadLine());
                            int[] arr = new int[size];
                            Console.WriteLine("Adding elements into array");
                            for (int i = 0; i < size; i++)
                            {
                                arr[i] = Convert.ToInt32(Console.ReadLine());
                            }
                            Console.WriteLine("\nplease pickup any one element from this array");
                            int Intresult = Convert.ToInt32(Console.ReadLine());
                            GenericClass<int> generic = new GenericClass<int>(arr, Intresult);
                            generic.DeleteElement();
                            break;
                        case 2:
                            Console.WriteLine("How many integer elements to add into method");
                            int doublesize = Convert.ToInt32(Console.ReadLine());
                            double[] doublearr = new double[doublesize];
                            Console.WriteLine("Adding elements into array");
                            for (int i = 0; i < doublesize; i++)
                            {
                                doublearr[i] = Convert.ToDouble(Console.ReadLine());
                            }
                            Console.WriteLine("\nplease pickup any one element from this array");
                            double Doubleresult = Convert.ToDouble(Console.ReadLine());
                            GenericClass<double> Doublegeneric = new GenericClass<double>(doublearr, Doubleresult);
                            Doublegeneric.DeleteElement();
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
                            GenericClass<char> chargeneric = new GenericClass<char>(charArr, deletechar);
                            chargeneric.DeleteElement();
                            break;
                        default:
                            Console.WriteLine("Enter the above option");
                            
                            break;
                    }
                break;
                case 4:
                    Console.WriteLine("Enter the three elements");
                    FindMinInteger min = new FindMinInteger();
                    int first = Convert.ToInt32(Console.ReadLine());
                    int second = Convert.ToInt32(Console.ReadLine());
                    int third = Convert.ToInt32(Console.ReadLine());
                    int minValue = min.FindMinNumber(first, second, third);
                    Console.WriteLine("The minimum number is: " + minValue);
                    break;
                case 5:
                    Console.WriteLine("Enter the three elements");
                    FindMinFloat floatmin = new FindMinFloat();
                    float firstvalue = float.Parse(Console.ReadLine());
                    float secondvalue = float.Parse(Console.ReadLine());
                    float thirdvalue = float.Parse(Console.ReadLine());
                    float minvalue = floatmin.FindfloatMinNumber(firstvalue, secondvalue, thirdvalue);
                    Console.WriteLine("The minimum number is: " + minvalue);
                    break;
                case 6:
                    Console.WriteLine("Enter three strings:");
                    FindMinString stringmin = new FindMinString();
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    string thirdString = Console.ReadLine();
                    string minString = stringmin.FindstringMinNumber(firstString, secondString, thirdString);
                    Console.WriteLine("The minimum string is: " + minString);
                    break;
                default:
                    Console.WriteLine("Enter the above option");
                    break;
            }
             Console.ReadLine();
        }
    }
}
