using System;
using System.Diagnostics;
using System.Threading;

public class StopWatch
{
    public void stopWatch()
    {
        // Create new stopwatch.
        Stopwatch stopwatch = new Stopwatch();

        // Begin timing.
        stopwatch.Start();

        // Do something.
        for (int i = 0; i < 1000; i++)
        {
            Thread.Sleep(1);
        }

        // Stop timing.
        stopwatch.Stop();

        // Write result.
        Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);

        Stopwatch stop = Stopwatch.StartNew();
        Thread.Sleep(1000);
        stop.Restart();
        Thread.Sleep(1000);
        Console.WriteLine(stop.ElapsedMilliseconds);

        stop = Stopwatch.StartNew();

        // Capture the elapsed ticks and write them to the console.
        long ticks1 = stopwatch.ElapsedTicks;
        Console.WriteLine(ticks1);

        // Capture the ticks again.
        // ... This will be a larger value.
        long ticks2 = stopwatch.ElapsedTicks;
        Console.WriteLine(ticks2);
    }
}