using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace A12Sep2018.EmpBonusException
{
    class Program
    {
        static void Main(string[] args)
        {
            Salesman sm1 = new Salesman();
            Salesman Sm2;

            Sm2.WorkingCity = "nothing";
            sm1.SetSalary();
                sm1.SetFestiveBonus();
            Sm2.WorkingCity = "nothing";
            Console.WriteLine(Sm2.WorkingCity);
            Console.WriteLine("************");
            //catch (Exception ex1)
            //{
            //    WriteErrorLog.Write(ex1);
            //}
            Console.ReadKey();
        }
    }
    public static class WriteErrorLog
    {
       public static  void Write(Exception pException)
        {
            string LogPath = @"D:\LOKESH\Assignments\A12Sep2018\EmpBonusException\ErrorLog.txt";
            string ExceptMess = pException.Message;

            File.AppendAllText(LogPath, ExceptMess);
        }
    }
}
