using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    abstract class Employee:IEmployees
    {
        public string EmpName { get; set; }
        public int EmpID { get; set; }
        public float Salary { get; set; }
        public virtual float SalaryDetails()
        {
            return Salary;
        }
        public void SetSalary()
        {
            Console.WriteLine("enter employee salary");
             Salary = int.Parse(Console.ReadLine());
        }
        public void SetEmployeeDetails()
        {
            Console.WriteLine("enter employee name");
            EmpName = Console.ReadLine();
            Console.WriteLine("enter employee ID: ");
            EmpID = int.Parse(Console.ReadLine());
          
        }
        public void GetEmployeeDetails()
        {
            Console.WriteLine(EmpName + "    " + EmpID + "    ");
            Console.WriteLine(SalaryDetails());
        }
       

    }
    class Salesman: Employee,IEmployees,ISalesman
    {
        public string WorkingCity;
        public float Commission;
        public override float SalaryDetails()
        {
            return Salary + Commission+CalculateBonus();
        }
        public float CalculateBonus()
        {
            return 100;
        }
        public float SubmitExpenses()
        {
            return 100;
        }
    }
    class Manager : Employee,IManager
    {
        string HodOf;
        int StockAssigned;
        public void SetManagerDetails()
        {
            Console.WriteLine("enter Manager name: ");
            EmpName = Console.ReadLine();
            Console.WriteLine("enter Manager ID: ");
            EmpID = int.Parse(Console.ReadLine());
            Console.WriteLine("enter Manager salary: ");
            Salary = int.Parse(Console.ReadLine());
            Console.WriteLine("enter Manager Department: ");
            HodOf = (Console.ReadLine());
            Console.WriteLine("enter Manager StockAssigned: ");
            StockAssigned = int.Parse(Console.ReadLine());
        }
        public void SetStock()
        {
            StockAssigned = 50;
        }
        public override float SalaryDetails()
        {
            return Salary + StockAssigned*50;
        }
    }
       public class interfacepractice
    {

        public static void Main(string[] args)
        {
            Employee emp1 = new Salesman();
            emp1.SetEmployeeDetails();
            emp1.SetSalary();
            emp1.GetEmployeeDetails();
           Console.WriteLine( emp1.SalaryDetails());
            

        }
    }
}
