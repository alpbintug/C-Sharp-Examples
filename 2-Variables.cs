namespace CSharpExamples
{
    class Test
    {
        static void main(string[] args)
        {
            string _string = "This is a string";
            char _char1 = 'a';
            //char _char2 = 57;
            float _float = 15.235f;
            double _double = 1.42363463;
            var _var1 = "This is a variable";
            var _var2 = 'b';
            var _var3 = 16.235f;
            var _var4 = 2.42363463;
            byte _byte = 0x10;
            object _object = _float;
            float _float2 = (float)_object;
        }
    }
}
