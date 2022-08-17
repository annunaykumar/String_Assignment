using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    internal class Other_ExerciseQ4
    {
        public static void Main()
        {
            int r = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int g = Convert.ToInt32(Console.ReadLine());
            if (r != 0 & b == 0 & g == 0)
            {
                Console.WriteLine("Reddish");
            }
            else if (r == 0 & b != 0 & g == 0)
            {
                Console.WriteLine("Bluish");
            }
            else
            {
                Console.WriteLine("Greenish");
            }
            Console.ReadLine();
        }
    }
}
