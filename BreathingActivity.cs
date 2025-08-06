using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", 
        "This activity will help you relax by walking you through breathing in and out slowly.\nClear your mind and focus on your breathing.")
    { }

    public void Run()
    {
        DisplayStartingMessage();

        int cycleTime = 6; // seconds per cycle (3 in, 3 out)
        int cycles = _duration / cycleTime;

        for (int i = 0; i < cycles; i++)
        {
            Console.Write("\nBreathe in...");
            ShowCountdown(3);

            Console.Write("\nNow breathe out...");
            ShowCountdown(3);

            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}
