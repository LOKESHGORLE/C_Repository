using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A12Sep2018.ExceptionPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumA = 50;
            int NumB = 0;
            float Result = 0;
            try
            {
                ParentClass P1 = new ParentClass();
              Result=  P1.IntergerDivision(NumA, NumB);
                Console.WriteLine("Try block in main method fully executed");
            }
            catch(Exception e2)
            {
                Console.WriteLine(e2.Message + " from main method");
            }

            Console.ReadLine();
        }
    }
}
