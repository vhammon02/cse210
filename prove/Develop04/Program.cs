using System;
namespace MindfulnessApp {
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            while (choice != 5)
            {
                choice = DisplayMenu();
                if (choice != 5)
                {
                    RunActivity(choice);
                }
            }
        }

        private static void RunActivity(int choice)
        {
            if (choice == 1)
            {
                Breathing breathing = new Breathing(3, 1, 3);
                breathing.Run();
            }
            else if (choice == 2)
            {
                Reflection reflection = new Reflection();
                reflection.Run();
            }
            else if (choice == 3)
            {
                Listing listing = new Listing();
                listing.Run();
            }
            else if (choice == 4)
            {
                // Creativity: Added a body scan meditation that guides attention through body parts.
                BodyScan bodyScan = new BodyScan();
                bodyScan.Run();
            }
        }

        private static int DisplayMenu()
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Welcome to your Mindfulness Assistant!");
                Console.WriteLine("  1. Breathing Activity");
                Console.WriteLine("  2. Reflection Activity");
                Console.WriteLine("  3. Listing Activity");
                Console.WriteLine("  4. Body Scan Meditation");
                Console.WriteLine("  5. Quit");
                Console.Write("What would you like to do? ");

                string input = Console.ReadLine();
                if (int.TryParse(input, out int choice) && choice >= 1 && choice <= 5)
                {
                    return choice;
                }

                Console.WriteLine("Please choose a number from 1 to 5.");
            }
        }
    }
}
