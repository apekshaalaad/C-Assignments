using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssign5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int i, j;
            int[] arr1 = new int[5];
            Console.Write("Input 5 elements in the 1st array :\n");
            for (i = 0; i < 5; i++)
            {
                Console.Write(" ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nElements in 1st array are: ");
            for (i = 0; i < 5; i++)
            {
                Console.Write("{0}  ", arr[i]);
            }
            Console.Write("\nInput 5 elements in the 2nd array :\n");
            for (j = 0; j < 5; j++)
            {
                Console.Write(" ", i);
                arr1[j] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\nElements in 2nd array are: ");
            for (j = 0; j < 5; j++)
            {
                Console.Write("{0}  ", arr1[j]);
            }
            System.Array.Sort(arr);
            System.Array.Sort(arr1);
            foreach (int value in arr)
            {
                Console.Write("\nSorted 1st Array " + value);
            }
            foreach (int value1 in arr1)
            {
                Console.Write("\nSorted 2nd Array " + value1);
            }
            System.Array.Copy(arr, 0, arr1, 0, 5);
            Console.WriteLine("\nCopied 2nd Array: ");
            foreach (int res in arr1)
            {
                Console.WriteLine(res);
            }
            System.Array.Reverse(arr);

            Console.WriteLine(String.Join("\nReversed 1st Array: ", arr));
            Array.Clear(arr, 0, arr.Length);
            Console.WriteLine("\n1st Array (After using Clear): ");
            foreach (int val in arr)
            {
                Console.WriteLine(val);
            }
            Console.Write("\n");





           

            Console.ReadKey();
        }
    }
}
