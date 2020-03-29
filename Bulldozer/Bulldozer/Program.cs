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

       // Inheritance the properties from GeneralObject
        public class Human : GeneralObject
        {
            public Human()
            {
                // constructor
            }

            public string name { get; set; }
        }

        // will Inheritance 2 classes
        public class Man : Human
        {
            public Man ()
            {
                // constructor
            }

            //public string name { get; set; }
        }

        public class Woman : Human
        {
            public Woman ()
            {
                // constructor
            }

            //public string name { get; set; }
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
