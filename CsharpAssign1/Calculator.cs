using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssign1
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            float num1 = 0; float num2 = 0;
            Console.WriteLine("Type First number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type Second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose an option");
            Console.WriteLine("\ta Addition");
            Console.WriteLine("\ts Subtract");
            Console.WriteLine("\tm Multiply");
            Console.WriteLine("\td Divition");
            Console.WriteLine("Your option?");

            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            
            Console.ReadKey();
        }
    }
}
