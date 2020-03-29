using System;

namespace Bulldozer
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var worker = new Workers();
            var result = worker.AddNumber(1, 2);
            Console.WriteLine(result.ToString());
        }

    }

    public class Workers
    {
        public Workers()
        {
            // constructor
        }

        public int AddNumber(int num1, int num2)
        {
            var result = num1 + num2;
            return result;
        }
    }
}
