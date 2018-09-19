using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface IEmployees
    {
        void SetSalary();
        void SetEmployeeDetails();
        void GetEmployeeDetails();

    }
    interface ISalesman : IEmployees
    {
         float CalculateBonus();
        float SubmitExpenses();
    }
    interface IManager : IEmployees
    {
        void SetStock();
    }
}
