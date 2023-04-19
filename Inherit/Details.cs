using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Inherit
{
    public class Details
    {
        //public Details()
        //{
        //    Console.WriteLine("constructor is calling");
        //    Console.ReadLine();
        //}
        public void Names()
        {
            string Fname = "Sanjay";
            string Lname = "Kumar";
            Console.WriteLine("The Name of the Candidate is :" +Fname+" "+ Lname);
        }
        public void Descriptions()
        {
            string Qualification = "MTech";
            Console.WriteLine("Qualification is :" +Qualification);
            string Description = "QA Lead";
            Console.WriteLine("Description is :" +Description);

        }

    }
}
