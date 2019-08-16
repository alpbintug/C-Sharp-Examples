namespace CSharpExamples
{
    class Test
    {
        static void main(string[] args)
        {
            string _string = "This is a string";
            System.Console.WriteLine(_string);
            char _char1 = 'a';
            System.Console.WriteLine(_char1);
            //char _char2 = 57;
            float _float = 15.235f;
            System.Console.WriteLine(_float);
            double _double = 1.42363463;
            System.Console.WriteLine(_double);
            var _var1 = "This is a variable";
            System.Console.WriteLine(_var1);
            var _var2 = 'b';
            System.Console.WriteLine(_var2);
            var _var3 = 16.235f;
            System.Console.WriteLine(_var3);
            var _var4 = 2.42363463;
            System.Console.WriteLine(_var4);
            byte _byte = 0x10;
            System.Console.WriteLine(_byte);
            object _object = _float;
            System.Console.WriteLine(_object);
            float _float2 = (float)_object;
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
