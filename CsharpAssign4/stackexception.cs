using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssign4
{
    internal class stackexception
    {
        private int[] element;
        private int top;
        private int max;
        public stackexception(int size)
        {
            element = new int[size];
            top = -1;
            max = size;
        }
        public void push(int item)
        {
            if (top == max - 1)
            {
                throw new Exception("Stack overflow can't perform push");
            }
            else
            {
                element[++top] = item;
            }
        }
        public int pop()
        {
            if (top == -1)
            {
                throw new Exception("Stack is Empty");
            }
            else
            {
                Console.WriteLine("Poped element is: " + element[top]);
                return element[top--];
            }
        }
        public void printstack()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            else
            {
                for (int i = 0; i <= top; i++)
                {
                    Console.WriteLine("Item[" + (i + 1) + "]:" + element[i]);
                }
            }
        }
    }
    class program
    {
        static void Main()
        {
            stackexception s = new stackexception(5);
            s.push(10);
            s.push(20);
            s.push(30);
            s.push(40);
            s.push(50);
            s.push(60);

            Console.WriteLine("Items are: ");
            s.printstack();

            s.pop();
            s.pop();
            s.pop();
            s.pop();
            s.pop();

            Console.WriteLine("Press any key");
            Console.ReadLine();
        }
    }
}
