using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A07Sep2018.Static
{
    class Static
    {
        
                    static void Main(string[] args)
            {
                bank.SavingInterest = 15;
                accountHolder x = new accountHolder("x", 1000);
                Console.ReadLine();

            }
        }
        public class accountHolder
        {
            public accountHolder(string accName, float accBal)
            {
                Console.WriteLine(accName);
                Console.WriteLine(accBal);
                Console.WriteLine(accBal * bank.SavingInterest);
            }
        }

        static class bank
        {
            public static int SavingInterest;
            public static float IntCal(float pAmount)
            {
                return pAmount * SavingInterest;

            }
        }

    }

