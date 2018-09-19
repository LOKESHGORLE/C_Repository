using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finding_operator
{
    class OperatorID
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("enter operator");
            string oper = Console.ReadLine();
            switch (oper)
            {
                case "+":
                case "-":
                case "*":
                case "/":
                case "%":
                    Console.WriteLine("its arithmatic operator");
                    break;
                case "&&":
                case "||":
                case "!":
                  
                    Console.WriteLine("its logical operator");
                    break;

                case "=":
                case "+=":
                case "*=":
                case "-=":
                case "/=":
                case ">>":
                case "<<=":
                case ">>=":
                case "%=":
                case "^=":
                    Console.WriteLine("its assignment operator");
                    break;
                default:
                    Console.WriteLine("not an operator");
                    break;
            }
            Console.ReadLine();
        }
    }
}
