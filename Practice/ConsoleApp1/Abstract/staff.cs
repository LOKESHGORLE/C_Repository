using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractPractice
{
    class Staff
    {
        abstract class Shape
        {
            public Shape(string name = "NoName")
            {
                PetName = name;
            }
            public string PetName { get; set; }
            // A single virtual method.  
            public virtual void Draw()
            {
                Console.WriteLine("Inside Shape.Draw()");  } 


        }
    }
}
