using System;

namespace CsharpExamples
{
    class Test
    {
        static void Main(string[] args)
        {
            /*Unlike in Java, you don't need to write multiple lines for a reader, but you have to handle the Exceptions. I didn't in this code because we haven't reached to that part yet.*/
            Console.WriteLine("Please enter a numerical value");
            string input1 = Console.ReadLine();
            Console.WriteLine("String value: "+input1);
            int intInput1 = int.Parse(input1);
            Console.WriteLine("Parsed integer value:" +intInput1);
            int intInput2 = Convert.ToInt32(input1);
            Console.WriteLine("Converted integer value:" +intInput2);
            double doubleInput1 = double.Parse(input1);
            Console.WriteLine("Parsed double value:" + doubleInput1);

            /*
            
            For input 4325
            
            Output: 
            Please enter a numerical value
            4325
            String value: 4325
            Parsed integer value:4325
            Converted integer value:4325
            Parsed double value:4325
            
            For input Hello world!
            
            Output: 
            
            Please enter a numerical value
            Hello world!
            String value: Hello world!
            System.FormatException: 'Input string was not in a correct format.'
            
            */
        }
    }
}
