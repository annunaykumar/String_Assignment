using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    internal class Qi
    {
        public static void Main()
        {
            string str = "The quick brown fox jumps over the lazy dog";
            Console.WriteLine(str);

            string res = str.Replace("The ", "A ");
            Console.WriteLine("After replacing...");
            Console.WriteLine(res);
            Console.ReadLine();
        }
    }
}
