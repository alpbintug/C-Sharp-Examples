namespace CSharpExamples
{
    class Test
    {
        static void main(string[] args)
        {
            string _string = "This is a string";
            //You can use Console.WriteLine without writing "using Console;" at the start of the code.
            //You can use any method from any library without "using" code, you just need to tell the program which library you are using before the method. So program goes and searches through that library to find the method you are using
            System.Console.WriteLine(_string);
            //Output: This is a string

            char _char1 = 'a';
            System.Console.WriteLine(_char1);
            //Output: a
            
            //char _char2 = 57;//ILLEGAL! Unlike in C, you can't assign integer values to a char and print the ASCII value.
            
            float _float = 15.235f;//If you want to use a float value instead of double -double is bigger in size- you have to write 'F' at the end of your value.
            System.Console.WriteLine(_float);
            //Output: 15,235
            
            double _double = 1.42363463;
            System.Console.WriteLine(_double);
            //Output: 1,42363463
            
            var _var1 = "This is a variable";//You don't have to define your variable type in C#, this can be used in elements from Lists, or objects from classes.
            System.Console.WriteLine(_var1);
            //Output: This is a variable
            
            var _var2 = 'b';
            System.Console.WriteLine(_var2);
            //Output: b
            
            var _var3 = 16.235f;
            System.Console.WriteLine(_var3);
            //Output: 16,235
            
            var _var4 = 2.42363463;
            System.Console.WriteLine(_var4);
            //Output: 2,42363463
            
            byte _byte = 0x10;//Byte is another variable type which stores a numerical value with size of one byte.
            System.Console.WriteLine(_byte);
            //Output: 16 (0x10 in hexadecimal equals to 16 in decimal)
            
            object _object = _float; //You can use "object" definition too. This process is called as "boxing"
            System.Console.WriteLine(_object);
            //Output: 15,235
            
            float _float2 = (float)_object;//And this process is called as "unboxing"
            System.Console.WriteLine(_float2);
            //Output: 15,235
            
            char[] charArray = {'H','e','l','l','o','!' };
            System.Console.WriteLine(charArray);
            //Output: Hello!
            
            char[] charArray1 = _string.ToCharArray();
            System.Console.WriteLine(charArray1);
            //Output: This is a string
            
            int[] intArray = new int[10];
            for (int i = 0; i < 10; i++)
            {
                intArray[i] = i + 1;
            }
            System.Console.WriteLine(intArray);//Output: System.Int32[] You can't write int arrays like char arrays
            for (int i = 0; i < intArray.Length; i++)
            {
                System.Console.WriteLine(intArray[i]);
            }
            /*Output:
            1
            2
            3
            4
            5
            6
            7
            8
            9
            10 
            */

        }
    }
}
