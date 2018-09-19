using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Salesman Sm1 = new Salesman();
            Manager M1 = new Manager();

            Sm1.SetSalesmanDetails();
            Console.WriteLine("-----emp details----");
            
            M1.SetManagerDetails();
            M1.GetManagerDetails();

            Console.ReadLine();
        }
    }
}
