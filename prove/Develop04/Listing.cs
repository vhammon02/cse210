namespace MindfulnessApp {
    public class Listing : Activity
    {
        //attributes

        private List<string> _prompts = [
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
            "Who has encouraged you recently?",
            "What is something in nature that you enjoy?",
            "What is one thing you are grateful for today?"
        ];
        private List<string> _responses = [];

        //methods

        public Listing() : base("Listing", "list positive things in your life")
        {
        }

        public void Run()
        {
            StartMessage();
            Random random = new Random();
            int index = random.Next(_prompts.Count);

            DisplayMessage(_prompts[index], 0);
            for (int count = 6; count > 0; count--)
            {
                Console.WriteLine(count);
                Thread.Sleep(1000);
            }

            int duration = GetSavedDuration();
            DateTime startTime = DateTime.Now;
            DateTime lastDisplay = startTime;
            string response = "";
            int remaining = duration;

            Console.WriteLine("Begin listing. Press Enter after each item:");
            Console.Write($"Time remaining: {remaining} seconds | ");

            while ((DateTime.Now - startTime).TotalSeconds < duration)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);

                    if (key.Key == ConsoleKey.Enter)
                    {
                        if (response.Trim() != "")
                        {
                            _responses.Add(response.Trim());
                        }
                        response = "";
                    }
                    else if (key.Key == ConsoleKey.Backspace)
                    {
                        if (response.Length > 0)
                        {
                            response = response.Substring(0, response.Length - 1);
                        }
                    }
                    else if (!char.IsControl(key.KeyChar))
                    {
                        response += key.KeyChar;
                    }

                    Console.Write($"\rTime remaining: {remaining} seconds | {response} ");
                }

                if ((DateTime.Now - lastDisplay).TotalSeconds >= 1)
                {
                    remaining = duration - (int)(DateTime.Now - startTime).TotalSeconds;
                    if (remaining < 0)
                    {
                        remaining = 0;
                    }
                    Console.Write($"\rTime remaining: {remaining} seconds | {response} ");
                    lastDisplay = DateTime.Now;
                }

                Thread.Sleep(50);
            }

            if (response.Trim() != "")
            {
                _responses.Add(response.Trim());
            }

            Console.WriteLine();
            Console.WriteLine($"You listed {_responses.Count} items.");
            EndMessage();
        }
    }
}
