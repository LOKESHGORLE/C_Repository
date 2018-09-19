using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A12Sep2018.ExceptionPractice
{
    class ParentClass
    {
        public float IntergerDivision(int pNumA, int pNumB)
        {
            int Quotient=0;
            try
            {
                Quotient = pNumA / pNumB;

                float Remainder = pNumA % pNumB;
                Console.WriteLine(Quotient);
                Console.WriteLine(Remainder);
                Console.WriteLine("Try block in parent method fully executed");
            }
            catch (Exception e1)
            {
                string StackTrace=e1.StackTrace;
                Console.WriteLine("StackTrace:   "+StackTrace);
                WriteLog.Write(e1);
                // TargetSite= e1.TargetSite;
                string MessFromParent=e1.Message+" in parent class method";
                Exception e2 = new Exception(MessFromParent);
                throw e2;
                //Quotient = 0;
            }
            return Quotient;
        }
    }
}
