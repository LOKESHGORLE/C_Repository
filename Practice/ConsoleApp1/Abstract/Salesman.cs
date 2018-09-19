using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPractice
{
    class Salesman:Employee
    {
        public string WorkingCity;
        public float Commission;

        public void SetSalesmanDetails()
        {
            Console.WriteLine("enter employee name: ");
            EmpName = Console.ReadLine();
            Console.WriteLine("enter employee ID: ");
            EmpID = int.Parse(Console.ReadLine());
            Console.WriteLine("enter employee salary: ");
            Salary = int.Parse(Console.ReadLine());
            Console.WriteLine("enter employee location: ");
            WorkingCity = (Console.ReadLine());
            Console.WriteLine("enter employee commisionn: ");
            Commission = int.Parse(Console.ReadLine());
        }
        public void GetSalesmanDetails()
        {
            Console.WriteLine(EmpName + "    " + EmpID + "    ");
            Console.WriteLine(SalaryDetails());
        }
        public override float SalaryDetails()
        {
            return Salary + Commission;
        }
    }
}
