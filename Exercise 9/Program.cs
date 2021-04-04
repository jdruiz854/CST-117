//correted By Joshua Ruiz

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //make some sets
            Set A = new Set();
            Set B = new Set();

            //put some stuff in the sets
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                A.addElement(r.Next(4));
                B.addElement(r.Next(12));
            }

            //display each set and the union
            Console.WriteLine("A: " + A);
            Console.WriteLine("B: " + B);
            //changed to union before the A 
            A.union(B);

            Console.WriteLine("After Union operation");
            //Console.WriteLine("A union B: " + A)
            Console.WriteLine("A union B: " + A);
            

            //Removed this portion of code as it was redundant and did not display correctly.
            //Console.WriteLine("After union operation");
            //Console.WriteLine("A: " + A);
            //Console.WriteLine("B: " + B);

        }
    }
}
