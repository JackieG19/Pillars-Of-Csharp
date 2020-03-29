using System;

namespace Bulldozer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // create a new bulldozer with the blueprint
            var dozer = new BullDozer();

            // assign color and size to the bulldozer
            dozer.color = "yellow";
            dozer.size = "mini";
            Console.WriteLine("Bulldozer is " + dozer.color);
        }
        
        public class BullDozer
        { 
            // 2 properties

            // define a color and size
            public string color { get; set;}
            public string size { get; set; }
        }
    }
}
