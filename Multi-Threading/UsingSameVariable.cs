using System;
using System.Threading;

namespace Multi_thread
{
    class UsingSameVariable
    {
        static int x = 0;
        static bool turnToUseX = false;
        static void Main(string[] args)
        {
            Thread th1 = new Thread(new ThreadStart(increment));
            Thread th2 = new Thread(new ThreadStart(decrement));
            th2.Start();
            th1.Start();
        }
        static void increment()
        {
            for (int i = 0; i < 100; i++)
            {
                while (turnToUseX)
                {

                }
                x += 1;
                Console.WriteLine($"incrementing x: {x}");
                turnToUseX = true;
            }
        }
        static void decrement()
        {
            for (int i = 0; i < 100; i++)
            {
                while (!turnToUseX)
                {

                }
                x -= 1;
                Console.WriteLine($"decrementing x: {x}");
                turnToUseX = false;
            }
        }
    }
}
