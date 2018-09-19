using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace A12Sep2018.EmpBonusException
{

    /// <summary>
    /// interfaces created
    /// </summary>
    interface IEmployee
    {
        void SetEmployeeDetails();
        void SetSalary();
        float GetSalary();
        void SetFestiveBonus();
    }
    interface ISalesman:IEmployee
    {
        void SetLocation();
        void SetComission();
    }
    interface IManager : IEmployee
    {
        void SetDepartment();
        void SetStock();
    }


    /// <summary>
    /// classes created
    /// </summary>


    abstract public class ClassCreation:IEmployee
    {
        string EmpName { get; set; }
        int EmpID { get; set; }
        protected int Salary { get; set; }
        float FestiveBonus { get; set; }

        public void SetEmployeeDetails()
        {
            Console.WriteLine("enter employee name");
            EmpName = Console.ReadLine();
            Console.WriteLine("enter employee ID: ");
            EmpID = int.Parse(Console.ReadLine());

        }
        public virtual float GetSalary()
        {
            return Salary + FestiveBonus;
        }
        public void SetSalary()
        {
            Console.WriteLine( "enter employee salary : ");
            Salary = int.Parse(Console.ReadLine());
            if (Salary <= 0)
            {
                
                throw new EmployeeException(Salary);
            }
        }
        public void SetFestiveBonus()
        {
            
            
                Console.WriteLine("Enter the Festive Bonus");
                FestiveBonus = float.Parse(Console.ReadLine());
            if (FestiveBonus > Salary / 10)
            {
                throw new EmployeeException(FestiveBonus);
            }
            
        }

    }
    public class Salesman : ClassCreation, ISalesman
    {
       public string WorkingCity;
        float Comm;
       public void SetLocation()
        {
            Console.WriteLine("Enter the working Location");
            WorkingCity = Console.ReadLine();
        }
        public void SetComission()
        {
            Console.WriteLine("Enter the working Location");
            WorkingCity = Console.ReadLine();
        }
    }
    class Manager : ClassCreation, IManager
    {
        string HodOf;
        int StockAssigned;
        public void SetDepartment()
        {
            
            Console.WriteLine("enter Manager Department: ");
            HodOf = (Console.ReadLine());
            Console.WriteLine("enter Manager StockAssigned: ");
            StockAssigned = int.Parse(Console.ReadLine());
        }
        public void SetStock()
        {
            Console.WriteLine("enter Manager StockAssigned: ");
            StockAssigned = int.Parse(Console.ReadLine());
        }
        public override float GetSalary()
        {
            return Salary + StockAssigned * 50;
        }
    }

    class EmployeeException : Exception
    {
        public EmployeeException(Exception pEx):base()
        {
            WriteErrorLog.Write(pEx);

        }

        public EmployeeException(float msg) 
        {
            this.BonusException();
            
        }
        public void BonusException()
        {
            Console.WriteLine("bonus is not valid");
        }
        public EmployeeException(int salary)
        {
            this.SalaryException();
        }
        public void SalaryException()
        {
            Console.WriteLine("salary is not valid");
        }
    }

}
