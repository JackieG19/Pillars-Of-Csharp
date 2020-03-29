using System;

namespace Bulldozer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var man = new Man();
            var kart = new Kart();
            var alien = new Alien();
        }

       // using Inheritance to avoid writing too much code
        public class GeneralObject
        {
            public GeneralObject()
            {
                // constructor
            }
            // common properties
            public bool move { get; set; }
            public string color { get; set; }
        }

        // tranfer the properties from  to Man
        public class Man : GeneralObject
        {
            public Man ()
            {
                // constructor
            }

            public string name { get; set; }
        }

        public class Kart
        {
            public Kart()
            {
                // constructor
            }
            public string manufactor { get; set; }
        }

        public class Alien
        {
            public Alien()
            {
                // constructor
            }
            public string planet { get; set; }
        }
    }
}
