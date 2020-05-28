using System;
using System.Threading;

namespace Multi_thread
{
    class TakingTurnsOnSameVariable
    {
        static int x = 0;
        //Variable to specify which thread is allowed to use the common variable X
        static bool turnToUseX = false;
        static void Main(string[] args)
        {
            Thread th1 = new Thread(new ThreadStart(increment));
            Thread th2 = new Thread(new ThreadStart(decrement));
            //It does not matter which thread starts first, turnToUseX = false at first, which indicates thread 1 is permitted
            //to use value of X and thread 2 will wait until thread 1 is done.
            th2.Start();
            th1.Start();
        }
        static void increment()
        {
            for (int i = 0; i < 100; i++)
            {
                //If turnTouseX = true, thread 2 is permitted to use it so thread 1 waits
                while (turnToUseX)
                {

                }
                Console.WriteLine($"incrementing x: {++x}");
                //When its job is done, thread 1 gives the turn to thread 2
                turnToUseX = true;
            }
        }
        static void decrement()
        {
            for (int i = 0; i < 100; i++)
            {
                //If turnTouseX = false, thread 1 is permitted to use it so thread 2 waits
                while (!turnToUseX)
                {

                }
                Console.WriteLine($"decrementing x: {--x}");
                //When its job is done, thread 2 gives the turn to thread 1
                turnToUseX = false;
            }
        }
    }
}
