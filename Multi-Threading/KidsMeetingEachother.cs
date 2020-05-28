using System;
using System.Threading;

namespace Multi_thread
{
    class KidsMeetingEachother
    {
        static int numberOfKids = 4;
        static bool[,] kidsKnowingOthers;
        static Random rand;
        static void Main(string[] args)
        {
            rand = new Random();
            kidsKnowingOthers = new bool[numberOfKids, numberOfKids];
            for (int i = 0; i < numberOfKids; i++)
            {
                kidsKnowingOthers[i, i] = true;
            }

            Thread th1 = new Thread(new ThreadStart(kidMeets));
            Thread th2 = new Thread(new ThreadStart(kidMeets));
            Thread th3 = new Thread(new ThreadStart(kidMeets));
            Thread th4 = new Thread(new ThreadStart(kidMeets));
            th1.Start();
            Console.WriteLine("Thread 1 started");
            th2.Start();
            Console.WriteLine("Thread 2 started");
            th3.Start();
            Console.WriteLine("Thread 3 started");
            th4.Start();
            Console.WriteLine("Thread 4 started");
        }
        static void kidMeets()
        {
            int currentKid = rand.Next(0, numberOfKids);
            int kidToMeet = rand.Next(0, numberOfKids);
            while(kidToMeet == currentKid)
            {
                kidToMeet = rand.Next(0, numberOfKids);
            }
            if (!kidsKnowingOthers[currentKid, kidToMeet])
            {
                kidsKnowingOthers[currentKid, kidToMeet] = true;
                kidsKnowingOthers[kidToMeet, currentKid] = true;
                Console.WriteLine($"Kid {currentKid} met kid {kidToMeet}");
            }
            else
                Console.WriteLine($"Kid {currentKid} and kid {kidToMeet} already met");
        }
    }
}
