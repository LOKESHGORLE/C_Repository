using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace identity_matrix
{
    class IdentityMatrix
    {
        static void Main4(string[] args)
        {
            Console.WriteLine("enter the dimension of square matrix");
            int dim = int.Parse(Console.ReadLine());
            string row = "";

            for (int i = 1; i <= dim; i++)
            {
                for (int j=1; j <= dim; j++)
                {
                    if(i==j) { row= row+" 1"; }
                    else { row= row+" 0"; }
                }
                Console.WriteLine(row);
                row = "";
            }
            Console.ReadLine();
        }
    }
}
