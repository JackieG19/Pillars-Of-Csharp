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
        }

        public class Workers
        {   
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
            Total = Total + number;
            Console.WriteLine(Total.ToString());

        }

        // so every time Count is run adds one to the Total
        public int Total { get; set; }
    }
}
