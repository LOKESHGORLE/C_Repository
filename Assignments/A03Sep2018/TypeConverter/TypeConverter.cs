using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace type_converter
{
    class TypeConverter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the data");
            var V = Console.ReadLine();
            Console.WriteLine("select the required format \n 1.int \n 2.double\n 3.char\n 4.boolean ");
            int Inp = int.Parse(Console.ReadLine());
            float Op = 0;
            bool Bo  ;
            string Str;
            float Dou;
            char Ch;

            switch (Inp)
            {
                case 1:
                    
                    float.TryParse(V, out Op);
                    if(Op==0 && V != "0")
                    {
                        Console.WriteLine("conversion failed");
                    }
                    else
                    {
                        Console.WriteLine(Convert.ToInt64(Op));
                    }
                    break;
                case 2:
                    float.TryParse(V, out Dou);
                    if (Dou == 0 && V != "0")
                    {
                        Console.WriteLine("conversion failed");
                    }
                    else
                    {
                        Console.WriteLine(Dou);
                    }
                    break;
                case 3:
                    char.TryParse(V, out Ch);
                    Console.WriteLine(Ch);
                    break;
            }
            
            Console.ReadLine();

        }
    }
}
