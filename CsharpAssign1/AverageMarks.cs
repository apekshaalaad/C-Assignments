using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssign1
{
    internal class AverageMarks
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0, highest = 0;

            double avg;

            Console.Write("Enter 5 numbers : \n");
            for (i = 1; i <= 5; i++)
            {
                Console.Write("Number -{0} :", i);
                n = Convert.ToInt32(Console.ReadLine());
                sum += n;
                if(n > highest)
                {
                    highest = n;
                }

            }
            avg = sum / 5.0;
           
            
            
            Console.Write("The Average of 5 numbers is: {0}\n", avg);
            Console.Write("The Highest Mark is: {0}\n", highest);
           
            Console.ReadKey();
        }
    }
}
