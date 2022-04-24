using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssign1
{
    internal class AreaofCircle
    {
        static void Area()
        {
            //declaring variables
            double r, perimeter;

            //Pi value 
            double PI = 3.14;

            Console.WriteLine("Radius of the circle\n");

            // convert the string value to double 
            r = Convert.ToDouble(Console.ReadLine());

            //perimeter formula 
            perimeter = (2 * PI * r);

            Console.WriteLine("Perimeter of Circle is :\n " + perimeter);
            // area of circle formula 
            double area = (PI * r * r);

            Console.WriteLine("Area of circle :\n" + area);
        }
        public static void Main(String[] args)
        {
            // calling  the method from main method 
            Area();
            Console.ReadKey();
        }
    }
}
