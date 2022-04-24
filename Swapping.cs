using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssign1
{
    internal class Swapping
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;
            Console.Write("Enter the first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            num2 = int.Parse(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.Write("\n First Number : " + num1);
            Console.Write("\n Second Number : " + num2);
            Console.Read();

            
            Console.ReadKey();
        }
    }
}
