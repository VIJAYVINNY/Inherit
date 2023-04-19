using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherit
{
     class Class1:Details
    {
        public void Adderess()
        {
            string Address = "Hyderabad";
            Console.WriteLine("The Address is :"+ Address);
        }
        static void Main(string[] args)
        {
            Details d; //Initialized but don't have memory.
            Class1 c=new Class1(); //Initialized and having memory location
            d = c;
            c.Names();
            d.Names(); Console.WriteLine("-------------------");
            Console.ReadLine();

            d.Descriptions();
            c.Descriptions();
            Console.WriteLine("-------------------");
            Console.ReadLine();

            c.Adderess();
            Console.WriteLine("-------------------");
            Console.ReadLine();
        }
    }
}
