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

        public class Man
        {
            public Man ()
            {
                // constructor
            }

            // define if the man can move or not move
            public bool move { get; set;}
            public string name { get; set; }
            public string color { get; set; }
        }

        public class Kart
        {
            public Kart()
            {
                // constructor
            }
            public bool move { get; set; }
            public string manufactor { get; set; }
            public string color { get; set; }
        }

        public class Alien
        {
            public Alien()
            {
                // constructor
            }
            public bool move { get; set; }
            public string planet { get; set; }
            public string color { get; set; }
        }
    }
}
