using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Array
{
    class SortingArray
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please enter the size of array");
            int ArraySize = int.Parse(Console.ReadLine());
            int[] Array = new int[ArraySize];
            for (int i =0; i< ArraySize; i++)
            {
                Console.WriteLine("Please enter a value");
                Array[i] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Please enter 1. for Ascending Order\n2. For Descending order");
                int Order = int.Parse(Console.ReadLine());
            if (Order == 1)
            {

                AscendingOrder(Array);
                Console.WriteLine("ascending order is \n");
               
            }

            else if (Order == 2)
            {
                DescendingOrder(Array);
                Console.WriteLine("descending order is \n");
            }



            foreach (int i in Array)
            {
                Console.WriteLine(i + "  ");
            }
            Console.ReadLine(); 
             
            
        }

        public static void DescendingOrder(int[] InputArray)
        {
            for(int i = 0; i < InputArray.Length; i++)
            {
                for (int j =i+1;j<InputArray.Length; j++)
                {
                    if (InputArray[j] > InputArray[i])
                    {
                        int temp = InputArray[i];
                        InputArray[i] = InputArray[j];
                        InputArray[j] = temp;
                    }
                }
                
                            
            }
        }

        public static void AscendingOrder(int[] InputArray)
        {
            for (int i = InputArray.Length-1; i >=0 ; i--)
            {
                for (int j = i; j < InputArray.Length - i - 1; j--)
                {
                    if (InputArray[j] < InputArray[i])
                    {
                        int temp = InputArray[j];
                        InputArray[i] = InputArray[j];
                        InputArray[j] = temp;
                    }
                }


            }
        }

    }
   
}
