using System;

namespace CsharpExamples
{
    class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a numerical value");
            string input1 = Console.ReadLine();
            Console.WriteLine("String value: "+input1);
            int intInput1 = int.Parse(input1);
            Console.WriteLine("Parsed integer value:" +intInput1);
            int intInput2 = Convert.ToInt32(input1);
            Console.WriteLine("Converted integer value:" +intInput2);
            double doubleInput1 = double.Parse(input1);
            Console.WriteLine("Parsed double value:" + doubleInput1);

        }
    }
}
