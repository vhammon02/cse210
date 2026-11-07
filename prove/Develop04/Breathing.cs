
namespace MindfulnessApp {
    public class Breathing : Activity
    {
        //attributes
        private int _inSeconds;
        private int _outSeconds;
        private int _holdSeconds;

        //methods
        public Breathing (int inSeconds, int holdSeconds, int outSeconds) : base("Breathing", "relax by focusing on your breathing")
        { 
            _inSeconds = inSeconds;
            _outSeconds = outSeconds;
            _holdSeconds = holdSeconds;
        }
        public void Run()
        {
            StartMessage();
            int duration = GetSavedDuration();
            int elapsed = 0;
            int count = 1;

            while (elapsed < duration)
            {
                Console.WriteLine("Breathe in...");
                for (count = _inSeconds; count > 0 && elapsed < duration; count-- ) {
                    Console.WriteLine($"{count}");
                    Thread.Sleep(1000);
                    elapsed++;
                }
                

                if (elapsed < duration && _holdSeconds > 0)
                {
                    Console.WriteLine("Hold...");
                    for (count = _holdSeconds; count > 0 && elapsed < duration; count-- ) {
                        Console.WriteLine($"{count}");
                        Thread.Sleep(1000);
                        elapsed++;
                    }
                }
                if (elapsed < duration)
                {
                    Console.WriteLine("Breathe out...");
                    for (count = _outSeconds; count > 0 && elapsed < duration; count-- ) {
                    Console.WriteLine($"{count}");
                    Thread.Sleep(1000);
                    elapsed++;
                }
                }
                if (elapsed < duration && _holdSeconds > 0)
                {
                    Console.WriteLine("Hold...");
                    for (count = _holdSeconds; count > 0 && elapsed < duration; count-- ) {
                        Console.WriteLine($"{count}");
                        Thread.Sleep(1000);
                        elapsed++;
                    }
                }

                
            }
            EndMessage();
        }
    }
}
