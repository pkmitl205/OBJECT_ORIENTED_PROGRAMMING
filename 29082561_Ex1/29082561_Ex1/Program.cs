using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29082561_Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ex12
            double myDouble = 12.345678;
            Console.WriteLine("{0, -10:G} -- General", myDouble);   // 12.345678 -- General
            Console.WriteLine("{0, -10} -- Default, same as General", myDouble); // 12.345678 -- Default, same as General
            Console.WriteLine("{0, -10:F4} -- Fixed Point, 4 dec places", myDouble); // 12.3457 -- Fixed Point, 4 dec places
            Console.WriteLine("{0, -10:C} -- Currency", myDouble); // ฿12.35 -- Currency
            Console.WriteLine("{0, -10:E3} -- Sci. Notation, 3 dec places", myDouble); // 1.235E+001-- Sci.Notation, 3 dec places
            Console.WriteLine("{0, -10:x} -- Hexadecimal integer", 1194719); // 123adf -- Hexadecimal integer
        }
    }
}
