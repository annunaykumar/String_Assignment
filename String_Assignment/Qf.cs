using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    internal class Qf
    {
        public static void Main()
        {
            string str1 = "The quick brown Fox jumps over the lazy Dog";
            string str2 = "THE QUICK BROWN FOX JUMPS OVER THE LAZY DOG";


            // Here we use == operator to check
            // the equality of the strings
            Console.WriteLine(str1 == str2);
            Console.ReadLine();
        }
    }
}
