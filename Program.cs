using System;
using System.Reflection;

namespace CsharpAssign8
{
    class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public double EmpSalary { get; set; }

        public Employee(int EmpId, string EmpName, double EmpSalary)
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.EmpSalary = EmpSalary;
        }
        public void empDetails()
        {
            Console.WriteLine("Employee Id :" + EmpId);
            Console.WriteLine("Employee name :" + EmpName);
            Console.WriteLine("Employee Salary :" + EmpSalary);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(1, "Apeksha", 60000);

            Assembly executing = Assembly.GetExecutingAssembly();
            Type[] types = executing.GetTypes();
            emp.empDetails();
            foreach (var item in types)
            {
                Console.WriteLine(item.Name);
                MethodInfo[] mi = item.GetMethods();

                foreach (var method in mi)
                {
                    Console.WriteLine(method.Name);

                }
            }
            Console.ReadLine();
        }
    }
}
