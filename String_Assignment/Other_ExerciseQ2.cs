using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    internal class Other_ExerciseQ2
    {
        public static void Main()
        {
            Console.WriteLine("Eggs Solution");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{N / 144} gross");
            N = N % 144;
            Console.WriteLine($"{N / 12} dozen");
            Console.WriteLine($"{N % 12} eggs");
            Console.ReadLine();
        }
    }
}
