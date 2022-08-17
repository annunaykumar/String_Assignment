using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace String_Assignment
{
    internal class Qp
    {
        public static void Main()
        {
            Console.WriteLine("add another path");
            Console.WriteLine(@"WebApps/MyApps/Images");
            //Both the below statements are same.
            string jsonString = File.ReadAllText(@"D:\Json.json");
           
            Console.ReadLine();
            
        }
    }
}
