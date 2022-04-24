using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssign1
{
    internal class ArrayofIntegers
    {
        public static void SumofArrays()
        {
            int[] arr = new int[10];
            int i;
           
            Console.Write("Input 10 elements in the array :\n");
            for (i = 0; i < 10; i++)
            {
                
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nElements in array are: ");
            for (i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            int sum = 0;
            for ( i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];

            }
            Console.WriteLine("\nSum of all the integers of an array : " + sum);


            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            SumofArrays();
        }
    }
}
