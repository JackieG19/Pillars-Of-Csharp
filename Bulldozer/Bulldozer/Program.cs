using System;

namespace Bulldozer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var worker = new Workers();
            worker.Count(4);
            worker.Count(5);
            
            worker.Count(4.5f); // run error
        }
            public Workers()
            {   
                // constructor
            }
        }
        
        public void Count(int number)
        {
            if (Total == null)
            {
                Total = 0;
            }
          
            //Total = Total + number;
            Total = Total + Convert.ToSingle(number);
            Console.WriteLine(Total.ToString());
        }
    
        // ***NOTE*** Don't name your methods the same - exception: putting a different type of variable

        // this method is only called whenever the main program passed a float
        public void Count(float number)
        {
            Total = Total + number;
            Console.WriteLine(Total.ToString());
        }
        
        // public int Total { get; set; }
        public float Total { get; set; }
    }
}
