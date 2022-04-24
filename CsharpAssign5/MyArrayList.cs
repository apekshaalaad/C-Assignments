using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssign5
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpSal { get; set; }
        
    }
    internal class MyArrayList
    {
        static void Main(string[] args)
        {
            //object initilizer or collection initilizer
            //ArrayList e = new ArrayList();//non generic

            var list = new ArrayList()
                   {
new Employee{EmpId=1,EmpName="Malcom",EmpSal=10000},
new Employee{EmpId=2,EmpName="Nidhi",EmpSal=24000},
new Employee{EmpId=3,EmpName="Saba",EmpSal=21000},
new Employee{EmpId=3,EmpName="Madhavi",EmpSal=30000},


};
            foreach (Employee i in list)
            {
                Console.WriteLine(i.EmpId + " " + i.EmpName + " " + i.EmpSal);
            }
            Console.ReadKey();
        }
    }
}
