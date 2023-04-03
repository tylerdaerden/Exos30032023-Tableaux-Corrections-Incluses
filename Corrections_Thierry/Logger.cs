using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F23L034_Methods
{
    class Logger
    {
        public static void Log(string message)
        {
            Console.WriteLine(message);
        }

        public static void Log(double? x1, double? x2)
        {
            Console.WriteLine($"x1 : {x1} | x2 : {x2}");
        }
    }
}
