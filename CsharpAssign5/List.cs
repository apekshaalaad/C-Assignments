using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssign5
{
    class Employee1
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpSal { get; set; }   
        public int Count { get; set; }
        public Employee1(int EmpId, string EmpName, int EmpSal)
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.EmpSal = EmpSal;
        }
    }
    internal class List
    {
        public static void Main()
        {
            List<Employee1> emp = new List<Employee1>();
            Employee1 e1 = new Employee1(1, "Malcom", 20000);
            Employee1 e2 = new Employee1(2, "Nidhi", 15000);
            Employee1 e3 = new Employee1(3, "Saba", 22000);
            Employee1 e4 = new Employee1(4, "Madhavi", 25000);
            emp.Add(e1);
            emp.Add(e2);
            emp.Add(e3);
            emp.Add(e4);
            foreach(Employee1 e in emp)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}",
                        e.EmpId, e.EmpName, e.EmpSal);
            }
            Console.WriteLine();
            
            

            Console.WriteLine("Total number of employees in the list are:" + emp.Count);
            

            Console.ReadKey();
        }
    }
}
