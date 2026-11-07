namespace MindfulnessApp {
    public class BodyScan : Activity
    {
        //attributes

        private List<string> _bodyParts = [
            "Bring your attention to your forehead and face. Notice any tension and let it soften.",
            "Notice your shoulders and allow them to relax.",
            "Pay attention to your arms and hands. Notice how they feel.",
            "Notice your chest and the gentle movement of your breathing.",
            "Bring your attention to your abdomen and let it soften.",
            "Notice your legs and allow them to rest comfortably.",
            "Finally, notice your feet and the support beneath them."
        ];

        //methods

        public BodyScan() : base("Body Scan", "relax by noticing how different parts of your body feel")
        {
        }

        public void Run()
        {
            StartMessage();
            int duration = GetSavedDuration();
            DateTime startTime = DateTime.Now;
            int partIndex = 0;

            while ((DateTime.Now - startTime).TotalSeconds < duration)
            {
                int elapsed = (int)(DateTime.Now - startTime).TotalSeconds;
                int messageSeconds = Math.Min(2, duration - elapsed);
                DisplayMessage(_bodyParts[partIndex], messageSeconds);
                partIndex++;
                if (partIndex >= _bodyParts.Count)
                {
                    partIndex = 0;
                }
            }

            EndMessage();
        }
    }
}
