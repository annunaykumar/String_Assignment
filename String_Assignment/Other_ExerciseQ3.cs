using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    internal class Other_ExerciseQ3
    {
        public static void Main()
        {
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0)
            {
                Console.WriteLine("Entered year is Leap year");
            }
            else
            {
                Console.WriteLine("Entered Year is not a Leap year");
            }
            Console.ReadLine();
        }
    }
}
