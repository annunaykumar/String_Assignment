using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    internal class Qo
    {
        public static void Main()
        {
            string s1 = "The quick brown fox jumps over the lazy dog";
            int index = s1.LastIndexOf('e');
            Console.WriteLine("The Last Index Value of character 'e' is " + index);
            Console.ReadLine();
        }
    }
}
