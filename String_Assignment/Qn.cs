using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    internal class Qn
    {
        public static void Main()
        {
            string str = "The quick brown fox jumps over the lazy dog";

            // Finding the index of character
            // which is present in string and
            // this will show the value 5
            int index1 = str.IndexOf('a');

            Console.WriteLine("The Index Value of character 'a' is " + index1);
            Console.ReadLine();
        }
    }
}
