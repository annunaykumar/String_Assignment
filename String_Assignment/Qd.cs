using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    internal class Qd
    {
        public static void Main()
        {
            string str = "The quick brown fox jumps over the lazy dog";
            
            bool x;

            // Implement EndsWith() method
            x = str.EndsWith("dogs");
          

            // Return  match string "True"
            Console.WriteLine(x.ToString());
            Console.ReadLine();

            // Return no match string "False"
            
        }
    }
    
}
