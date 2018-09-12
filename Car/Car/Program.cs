using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Car _car = new Car();
            _car.FrontLeft = new Door();
            _car.FrontRight = new Door();
            _car.RearLeft = new Door();
            _car.RearRight = new Door();
            Console.ReadKey();
        }
    }

    public class Car
    {
        // composition #1 Engine -> create class Engine inside class Car
        public class Engine
        {
            public int hoursePower;
        }
        // composition #2 Battery -> create class Battery inside class Batterty
        public class Batterty
        {
            public int voltage;
        }
        
        // create reference of composition components
        protected Engine _engine;
        protected Batterty _battery;

        public Car()
        {
            _engine = new Engine();
            _battery = new Batterty();
        }

        // aggregation #3 Door -> create class Door outside class Car
        public Door FrontRight;
        public Door FrontLeft;
        public Door RearRight;
        public Door RearLeft;
        internal object _door;
    }

    public class Door
    {
        public int position;
        public static int _position;

        public Door()
        {
            _position++;
            position = _position;
        }
    }
}
