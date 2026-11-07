

namespace MindfulnessApp {    
    public class Activity
    {
        //attributes
        private string _name;
        private string _description;
        private int _duration;

        //methods
        public Activity(string name, string description )
        {
            _name = name;
            _description = description;
        }

        public void StartMessage()
        {
            Console.WriteLine("");
            DisplayMessage($"Welcome to the {_name} activity.", 1);
            DisplayMessage($"In this activity, you will {_description}", 1);
            int duration = GetDuration();
            SetDuration(duration);
            DisplayMessage("Please take a moment to pause and prepare...", 3);
        }

        public void EndMessage()
        {
            Console.WriteLine("Good Job");
            ShowSpinner(1);
            Console.WriteLine($"Your {_name} activity has concluded");
            ShowSpinner(1);
            Console.WriteLine($"You spent {_duration} seconds exercising mindfulness!");
            ShowSpinner(1);
        }

        public void ShowSpinner(int seconds)
        {   
            string[] spinner = { "/", "-", "\\", "|" };
            int steps = seconds * 4;

            for (int step = 0; step < steps; step++)
            {
                Console.Write(spinner[step % spinner.Length]);
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
           
        }

        public int GetDuration()
        {
            
            int duration;

            while (true){
                Console.WriteLine("Please enter a duration (in seconds): ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out duration) && duration > 0)
                {
                    return duration;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a whole number greater than 0.");
                }
            }
           
        }
        
        public int GetSavedDuration()
        {
            return _duration;
        }

        public void SetDuration(int duration)
        {
            _duration = duration;
        }

        public void DisplayMessage(string message, int seconds)
        {
            Console.WriteLine(message);
            ShowSpinner(seconds);

        }

    }
}
