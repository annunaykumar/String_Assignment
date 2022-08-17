using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    internal class Qb
    {
        public static void Main()
        {
            string s = "The quick brown fox jumps over the lazy dog";
            if (s.Contains("is") == true)
            {
                Console.WriteLine("Word found!");
            }
            else
            {
                Console.WriteLine("Word not found!");
            }
            Console.ReadLine(); 
        }
    }
    
}
