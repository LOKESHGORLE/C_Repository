using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class LeapYear
    {
        static void Main(string[] args)
        {
            
            int flag = 1;
            do
            {
                Console.WriteLine("enter the year");
                int a = int.Parse(Console.ReadLine());
                if (a % 4 == 0)
                {

                    if (a % 100 == 0 && a % 400 != 0)
                    {
                        Console.WriteLine(a + " is not a leap year");
                    }
                    else Console.WriteLine(a + " is  a leap year");
                }
                else Console.WriteLine(a + " is not a leap year");
                Console.WriteLine("enter any key to continue \n enter 0 to exit");
                flag = int.Parse(Console.ReadLine());
            } while (flag != 0);

           
            Console.ReadLine();
        }
    }
}
