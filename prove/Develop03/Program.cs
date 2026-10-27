using System;

//To go beyond what was requestted, I added a scripture manager that
//can select a random scripture from a library.
class Program
{
    static void Main(string[] args)
    {
        ScriptureManager manager = new ScriptureManager();
        var selected = manager.GetRandomScripture();

        Reference reference = selected.reference;
        Scripture scripture = selected.scripture;

        while (true)
        {
            Console.Clear();
            Console.WriteLine(reference.GetReference());
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine();
                Console.WriteLine("All words are hidden. Goodbye!");
                break;
            }

            Console.WriteLine();
            Console.WriteLine("Press Enter to hide words, or type quit to exit.");
            string input = Console.ReadLine();

            if (input != null &&
                input.Trim().Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            if (string.IsNullOrEmpty(input))
            {
                scripture.HideWords(3);
            }
        }
    }
}