using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05092561_Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            base_class base_class = new base_class();
            base_class.report();

            derived_class derived_class = new derived_class();
            derived_class.report();
        }
    }
    class base_class
    {
        public int a = 10;
        public void report() { Console.WriteLine("base class {0}", a); }
    }
    class derived_class : base_class
    {
        new public int a = 20;
        new public void report() { Console.WriteLine("derived class {0}", a); }
    }
}
