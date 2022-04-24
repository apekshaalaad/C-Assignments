using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAssign6
{
    public delegate void Delagate();
    internal class Employee
    {
        private int EmpNo;
        private string EmpName;
        private double Salary;
        private double HRA;
        private double TA;
        private double DA;
        private double PF;
        private double TDS;
        private double NetSalary;
        private double GrossSalary;
        public Employee(int EmpNum, string EmpNm, double Sal)
        {
            EmpNo = EmpNum;
            EmpName = EmpNm;
            Salary = Sal;
            if (Salary < 5000)
            {
                HRA = Salary * 10 / 100;
                TA = Salary * 5 / 100;
                DA = Salary * 15 / 100;
                GrossSalary = Salary + HRA + TA + DA;
            }
            else if (Salary < 10000)
            {
                HRA = Salary * 15 / 100;
                TA = Salary * 10 / 100;
                DA = Salary * 20 / 100;
                GrossSalary = Salary + HRA + TA + DA;
            }
            else if (Salary < 15000)
            {
                HRA = Salary * 20 / 100;
                TA = Salary * 15 / 100;
                DA = Salary * 25 / 100;
                GrossSalary = Salary + HRA + TA + DA;
            }
            else if (Salary < 20000)
            {
                HRA = Salary * 25 / 100;
                TA = Salary * 20 / 100;
                DA = Salary * 30 / 100;
                GrossSalary = Salary + HRA + TA + DA;
            }
            else
            {
                HRA = Salary * 30 / 100;
                TA = Salary * 25 / 100;
                DA = Salary * 35 / 100;
                GrossSalary = Salary + HRA + TA + DA;
            }

        }
        public virtual void Calculatesalary()
        {
            PF = GrossSalary * 10 / 100;
            TDS = GrossSalary * 18 / 100;
            NetSalary = GrossSalary - (PF * TDS);
        }
        public virtual void Gsal()
        {
            Console.WriteLine(GrossSalary);
        }
        class Manager : Employee
        {
            private double petrol { get; set; }
            private double food { get; set; }
            private double other { get; set; }
            public Manager(int number, string name, double sal) : base(number, name, sal)
            {
                petrol = Salary * 8 / 100;
                food = Salary * 13 / 100;
                other = Salary * 3 / 100;
            }
            public override void Gsal()
            {
                GrossSalary = (GrossSalary + petrol + food + other);
                Console.WriteLine(GrossSalary);
            }
            public override void Calculatesalary()
            {
                PF = GrossSalary * 10 / 100;
                TDS = GrossSalary * 18 / 100;
                NetSalary = GrossSalary - (PF + TDS);
                Console.WriteLine(NetSalary);
            }
        }
        class Marketingexecutive : Employee
        {
            private double kilometertravel { get; set; }
            private double tourallowance { get; set; }
            private double telephoneallowance { get; set; }

            public Marketingexecutive(int number, string name, double sal, double kit) : base(number, name, sal)
            {
                kilometertravel = kit;
                tourallowance = kilometertravel * 5;
                telephoneallowance = 1000;
            }
            public override void Gsal()
            {
                GrossSalary = (GrossSalary + tourallowance + telephoneallowance);
                Console.WriteLine(GrossSalary);
            }
            public override void Calculatesalary()
            {
                PF = GrossSalary * 10 / 100;
                TDS = GrossSalary * 18 / 100;
                NetSalary = GrossSalary - (PF + TDS);
                Console.WriteLine(NetSalary);
            }
           
        }
        class MainProgram
        {
            static void Main(string[] args)
            {
                Manager M1 = new Manager(1, "Madhavi", 10000);
                Delagate MD = new Delagate(M1.Gsal);
                MD += new Delagate(M1.Calculatesalary);
                MD();

                Marketingexecutive M2 = new Marketingexecutive(1, "Nidhi", 10000,45);
                Delagate MED = new Delagate(M2.Gsal);
                MED += new Delagate(M2.Calculatesalary);
                MED();
                /*Manager MarkE1 = new Manager(2, "Apeksha", 15000);
                MarkE1.Gsal();


                Marketingexecutive MarkE2 = new Marketingexecutive(3, "Apeksha", 7000, 45);
                MarkE2.Gsal();*/


                Console.ReadKey();
            }
        }
    }
}
