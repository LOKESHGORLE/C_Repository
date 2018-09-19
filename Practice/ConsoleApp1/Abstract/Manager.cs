using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPractice
{
    class Manager: Employee
    {
        string HodOf;
        int StockAssigned;

        public override string EmpName { get; set; }

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
        public void GetManagerDetails()
        {
            Console.WriteLine(EmpName + "    " + EmpID + "    ");
            Console.WriteLine(SalaryDetails());
        }
        public override float SalaryDetails()
        {
            return Salary + StockAssigned*100;
        }
        
    }
}
