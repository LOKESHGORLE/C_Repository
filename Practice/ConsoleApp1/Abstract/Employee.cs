using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPractice
{
    abstract class Employee
    {
        public virtual string EmpName { get; set; }
        public int EmpID { get; set; }
        public float Salary { get; set; }
        public virtual float SalaryDetails()
        {
            return Salary;
        }

}
}
