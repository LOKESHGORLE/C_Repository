using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "lokes";
           
            string b = "lokesh";
            string c = " ";
            int lena = a.Length;
            int lenb = b.Length;
            string d = string.Copy(b);
            int e = a.LastIndexOf('e');


            Console.WriteLine(string.Equals(a, b));
            Console.WriteLine(lena+","+lenb);
            Console.WriteLine(string.Concat(a, c,b));
            //Console.WriteLine(string.Format("ABC", a));
            Console.WriteLine(string.IsNullOrEmpty(c));
            Console.WriteLine(string.IsNullOrWhiteSpace(c));
            Console.WriteLine(string.Join(",",a,c,b));
            Console.WriteLine(string.Intern(a));//assign the value of given string to another string//
            Console.WriteLine(string.Compare(b,a));
            Console.WriteLine("position of L= " + a.LastIndexOf('l'));
            Console.WriteLine(e);
            //Console.WriteLine(a.LastIndexOfAny('e,s,o'));

             Console.WriteLine(a.PadLeft(10));
            Console.WriteLine(a.Remove(3));// removes all the characters after the passed index number;//
            Console.WriteLine(a.Replace('e', 'a'));
            //Console.WriteLine(a.Reverse(l));

            Console.WriteLine("d="+d);
            Console.WriteLine(a.Substring(1, 3));
            //Console.WriteLine(a.Distinct());
            Console.WriteLine(a + "h");
            Console.WriteLine("1\n");
            Console.WriteLine(a[2]);
            Console.WriteLine("\n");
           // Console.WriteLine(""lokesh"");// how to insert double quotes?

            Console.WriteLine(a.Contains("es"));
            Console.WriteLine("\n");

            string[] ar = { "ab","bc" };
            Console.WriteLine(ar.Contains("ab"));


            Console.ReadLine();
        }
    }
}
