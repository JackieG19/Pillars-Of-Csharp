using System;

namespace Bulldozer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var dozer = new BullDozer("yellow", "mini");
            //dozer.color = "yellow";
            //dozer.size = "mini";
            Console.WriteLine("Bulldozer 1 is " + dozer.color);

            var dozer2 = new BullDozer("red", "large");
            //dozer.color = "red";
            //dozer.size = "large";
            Console.WriteLine("Bulldozer 2 is " + dozer2.color);
        }
        
        public class BullDozer
        { 
            // use a constructor to create a new bulldozer
            public BullDozer(string _color, string _size) {
                this.color = _color;
                this.size = _size;
            }
            
            public string color { get; set;}
            public string size { get; set; }
        }
    }
}
