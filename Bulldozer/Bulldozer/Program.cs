using System;

namespace Bulldozer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
        }

        public class Workers
        {   
            public Workers()
            {   
                // constructor
            }
        }
        // worker count the number of things
        public void Count(int number)
        {
            // if total is equal to null is not ready yet
            if (Total == null)
                Total = 0;
           

            Total = Total + number;
            Console.WriteLine(Total.ToString());

        }

        // to store the number and add it, create a class variable
        public int Total { get; set; }
    }
}
