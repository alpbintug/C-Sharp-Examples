namespace CSharpExamples
{
    class Test
    {
        static void main(string[] args)
        {
            string _string = "This is a string";
            System.Console.WriteLine(_string);//You can use Console.WriteLine without writing "using Console;" at the start of the code.
                                              //You can use any method from any library without "using" code, you just need to tell the program which library you are using before the method. So program goes and searches through that library to find the method you are using.
            char _char1 = 'a';
            System.Console.WriteLine(_char1);
            //char _char2 = 57;//Unlike in C, you can't assign integer values to a char and print the ASCII value.
            float _float = 15.235f;//If you want to use a float value instead of double -double is bigger in size- you have to write 'F' at the end of your value.
            System.Console.WriteLine(_float);
            double _double = 1.42363463;
            System.Console.WriteLine(_double);
            var _var1 = "This is a variable";//You don't have to define your variable type in C#, this can be used in elements from Lists, or objects from classes.
            System.Console.WriteLine(_var1);
            var _var2 = 'b';
            System.Console.WriteLine(_var2);
            var _var3 = 16.235f;
            System.Console.WriteLine(_var3);
            var _var4 = 2.42363463;
            System.Console.WriteLine(_var4);
            byte _byte = 0x10;//Byte is another variable type which stores a numerical value with size of one byte.
            System.Console.WriteLine(_byte);
            object _object = _float; //You can use "object" definition too. This process is called as "boxing"
            System.Console.WriteLine(_object);
            float _float2 = (float)_object;//And this process is called as "unboxing"
            System.Console.WriteLine(_float2);
            
            
            /*Output:
            This is a string
            a
            15,235
            1,42363463
            This is a variable
            b
            16,235
            2,42363463
            16
            15,235
            15,235*/
        }
    }
}
