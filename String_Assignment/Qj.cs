using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    internal class Qj
    {
        public static void Main()
        {
            // Taking a string
            String str = "The quick brown fox ,jumps over the lazy dog";

            String[] spearator = { "," };

            // using the method
            String[] strlist = str.Split(spearator, StringSplitOptions.RemoveEmptyEntries);

            foreach (String s in strlist)
            {
                Console.WriteLine(s);
            }
            Console.ReadLine();
        }
    }
}
