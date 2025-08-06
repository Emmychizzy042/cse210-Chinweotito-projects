// I added three unique animations and counted total sessions to exceed requirements.s
using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("-------------------");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflection Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                BreathingActivity ba = new BreathingActivity();
                ba.Run();
            }
            else if (input == "2")
            {
                ReflectionActivity ra = new ReflectionActivity();
                ra.Run();
            }
            else if (input == "3")
            {
                ListingActivity la = new ListingActivity();
                la.Run();
            }
            else if (input == "4")
            {
                Console.WriteLine("Goodbye!");
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Press enter to continue.");
                Console.ReadLine();
            }
        }
    }
}
