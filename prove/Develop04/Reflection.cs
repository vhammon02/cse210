namespace MindfulnessApp {
    public class Reflection : Activity
    {
        //attributes

        private List<string> _prompts = [
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        ];
        private List<string> _questions = [
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        ];

        //methods

        public Reflection() : base("Reflection", "reflect on times you showed strength and resilience")
        {
        }

        public void Run()
        {
            StartMessage();
            int duration = GetSavedDuration();
            Random random = new Random();
            int promptIndex = random.Next(_prompts.Count);
            DisplayMessage(_prompts[promptIndex], 0);

            DateTime startTime = DateTime.Now;
            while ((DateTime.Now - startTime).TotalSeconds < duration)
            {
                int questionIndex = random.Next(_questions.Count);
                int elapsed = (int)(DateTime.Now - startTime).TotalSeconds;
                int pauseSeconds = Math.Min(5, duration - elapsed);

                if (pauseSeconds > 0)
                {
                    DisplayMessage(_questions[questionIndex], pauseSeconds);
                }
            }

            EndMessage();
        }
    }
}
