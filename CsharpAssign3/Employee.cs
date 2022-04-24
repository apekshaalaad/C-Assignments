using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
internal class Employee
{
    protected int empno { get; set; }
    protected string empname { get; set; }
    protected double salary { get; set; }
    protected double HRA { get; set; }
    protected double TA { get; set; }
    protected double DA { get; set; }
    protected double PF { get; set; }
    protected double TDS { get; set; }
    protected double netsalary { get; set; }
    protected double grosssalary { get; set; }
    public Employee(int number, string name, double sal)
    {
        empno = number;
        empname = name;
        salary = sal;
        if (salary < 5000)
        {
            HRA = salary * 10 / 100;
            TA = salary * 5 / 100;
            DA = salary * 15 / 100;
            grosssalary = salary + HRA + TA + DA;
        }
        else if (salary < 10000)
        {
            HRA = salary * 15 / 100;
            TA = salary * 10 / 100;
            DA = salary * 20 / 100;
            grosssalary = salary + HRA + TA + DA;
        }
        else if (salary < 15000)
        {
            HRA = salary * 20 / 100;
            TA = salary * 15 / 100;
            DA = salary * 25 / 100;
            grosssalary = salary + HRA + TA + DA;
        }
        else if (salary < 20000)
        {
            HRA = salary * 25 / 100;
            TA = salary * 20 / 100;
            DA = salary * 30 / 100;
            grosssalary = salary + HRA + TA + DA;
        }
        else
        {
            HRA = salary * 30 / 100;
            TA = salary * 25 / 100;
            DA = salary * 35 / 100;
            grosssalary = salary + HRA + TA + DA;
        }

    }
    public virtual void Calculatesalary()
    {
        PF = grosssalary * 10 / 100;
        TDS = grosssalary * 18 / 100;
        netsalary = grosssalary - (PF * TDS);
    }
    public virtual void Gsal()
    {
        Console.WriteLine(grosssalary);
    }
}
class Manager : Employee
{
    private double petrol { get; set; }
    private double food { get; set; }
    private double other { get; set; }
    public Manager(int number, string name, double sal) : base(number, name, sal)
    {
        petrol = salary * 8 / 100;
        food = salary * 13 / 100;
        other = salary * 3 / 100;
    }
    public override void Gsal()
    {
        grosssalary = (grosssalary + petrol + food + other);
        Console.WriteLine(grosssalary);
    }
    public override void Calculatesalary()
    {
        PF = grosssalary * 10 / 100;
        TDS = grosssalary * 18 / 100;
        netsalary = grosssalary - (PF + TDS);
        Console.WriteLine(netsalary);
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
        grosssalary = (grosssalary + tourallowance + telephoneallowance);
        Console.WriteLine(grosssalary);
    }
    public override void Calculatesalary()
    {
        PF = grosssalary * 10 / 100;
        TDS = grosssalary * 18 / 100;
        netsalary = grosssalary - (PF + TDS);
        Console.WriteLine(netsalary);
    }
}
class MainProgram
{
    static void Main(string[] args)
    {
        Manager MarkE1 = new Manager(2, "Apeksha", 15000);
        MarkE1.Gsal();


        Marketingexecutive MarkE2 = new Marketingexecutive(3, "Apeksha", 7000, 45);
        MarkE2.Gsal();

        
        Console.ReadKey();
    }
}



