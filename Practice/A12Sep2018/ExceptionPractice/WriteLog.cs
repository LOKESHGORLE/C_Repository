using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace A12Sep2018.ExceptionPractice
{
     class WriteLog
    {
        public static void Write(Exception pErrorMessage)
        {
            string FilePath = @"D:\LOKESH\Practice\A12Sep2018\ExceptionPractice\ErrorrLogFile.txt";
            string ErrorMessage = "-------Eroor-----" + DateTime.Now + "----" + pErrorMessage.Message;
            File.AppendAllText(FilePath, ErrorMessage);
        }
    }
}
