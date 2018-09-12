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
            person p1 = new person();
            p1.name = "prayuth";
            student s1 = new student();
            s1.name = "Pracha";
            s1.major = "comp";
            Console.WriteLine("p1.name = {0}", p1.name);
            Console.WriteLine("s1.name = {0}, s1.major = {1}", s1.name, s1.major);
            s1.name = "Prasong";
            //person ps1 = (person)s1;
        }
    }
    class person // base
    {
        public string name;
    }
    class student : person // derived
    {
        public string major;
    }
}
