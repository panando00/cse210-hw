using System;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        /*
        My program exceeds the base requirements in several ways:
        1. Added a new Gratitude Activity that helps users focus on thankfulness
        2. Implemented activity tracking with statistics and file logging
        3. Enhanced animations including growing or shrinking text for breathing
        */

        bool quit = false;
        while (!quit)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Start gratitude activity");
            Console.WriteLine("  5. View activity statistics");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    new BreathingActivity().RunActivity();
                    break;
                case "2":
                    new ReflectionActivity().RunActivity();
                    break;
                case "3":
                    new ListingActivity().RunActivity();
                    break;
                case "4":
                    new GratitudeActivity().RunActivity();
                    break;
                case "5":
                    Activity.DisplayStats();
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                    break;
                case "6":
                    quit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    Thread.Sleep(2000);
                    break;
            }
        }
    }
}