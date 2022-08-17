using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    internal class Qh
    {
        public static void Main()
        {
            String str = "The quick brown fox jumps over the lazy dog";
            String substr = "The quick brown Fox jumps over the lazy Dog";
            

            // using String.Contains() Method
            Console.WriteLine(str.Contains(substr));
            Console.ReadLine();
        } 
    }
}
