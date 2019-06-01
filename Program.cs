/* Disclaimer: The examples and comments from this program are from
   C#7 in a Nutshell and are written for learning purposes only. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Equality_and_Comparison_Operators
{
    class Program
    {
        static void Main()
        {
            int x = 1;
            int y = 2;
            Console.WriteLine(x == y);  // False, == is equal to
            Console.WriteLine(x != y);  // True, != is NOT equal to
            Console.WriteLine(x > y);   // False, > is greater than
            Console.WriteLine(x < y);   // True, < is less than
            Console.WriteLine(x >= y);  // False, >= is greater than OR equal to
            Console.WriteLine(x <= y);  // True, <= is less than OR equal to

            // For reference types, equality, by default, is based on reference, instead of the actual value of the underlying object
            Dude d1 = new Dude("John");
            Dude d2 = new Dude("John");
            Console.WriteLine(d1 == d2);    // False, same value, but different reference.
            Dude d3 = d1;
            Console.WriteLine(d1 == d3);    // True, same value, and same reference.
            Console.ReadKey();
        }
    }
    public class Dude
    {
        public string Name;
        public Dude(string n) { Name = n; }
    }
}
