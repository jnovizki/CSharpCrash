
using System;
using System.Threading;
namespace MultithreadingApplication;
class ThreadCreationProgram
{
    public static void CallToChildThread()
    {
        Console.WriteLine("Child Thread started");
        try
        {
            int sleepfor = 5000;
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(sleepfor);
                Console.WriteLine(i);
            }
        }
        catch (ThreadInterruptedException ex) { Console.WriteLine(ex.Message); }
        finally
        {
            Console.WriteLine("Couldn't catch the ThreadAbortException");
        }
    }
    static void Main(string[] args)
    {
        ThreadStart childref = new ThreadStart(CallToChildThread);
        Console.WriteLine("In Main: Creating the child Thread");
        Thread childThread = new Thread(childref);
        childThread.Start();

        // the thread is paused for 5000 milliseconds
        int sleepfor = 5000;

        Console.WriteLine("Child Thread Paused for {0} seconds", sleepfor / 1000);
        Thread.Sleep(sleepfor);
        Console.WriteLine("Child thread resumes");
        //now abort the child
        Console.WriteLine("In Main: Interrupting the Child thread");
        childThread.Interrupt();

        Console.ReadKey();
    }
}
