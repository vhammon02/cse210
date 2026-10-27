using System;

//To exceed requirements I added an extra level of the library for multiple journals.
//Entries and Journals will have their own name, date prompt etc.
//Loading has error handling
class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();
        PromptGenerator generator = new PromptGenerator();
        string choice = "";

        while (choice != "4")
        {
            DisplayLibraryMenu();
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    OpenJournal(library, generator);
                    break;
                case "2":
                    CreateJournal(library, generator);
                    break;
                case "3":
                    ImportJournal(library, generator);
                    break;
                case "4":
                    library.SaveLibrary();
                    Console.WriteLine("All journals saved. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Please choose 1-4.");
                    break;
            }
        }
    }

    static void DisplayLibraryMenu()
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to your journal library!");
        Console.WriteLine("Please select an option:");
        Console.WriteLine("  1. Open journal");
        Console.WriteLine("  2. Create new journal");
        Console.WriteLine("  3. Import journal from file");
        Console.WriteLine("  4. Save and quit");
        Console.Write("What would you like to do? ");
    }

    static void OpenJournal(Library library, PromptGenerator generator)
    {
        library.DisplayJournals();
        Console.Write("Journal number: ");

        Journal journal = null;
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            journal = library.SelectJournal(number);
        }

        if (journal == null)
        {
            Console.WriteLine("That journal doesn't exist.");
            return;
        }

        RunJournalMenu(journal, generator);
    }

    static void CreateJournal(Library library, PromptGenerator generator)
    {
        Console.Write("Name for the new journal: ");
        Journal journal = library.CreateNewJournal(Console.ReadLine());

        if (journal == null)
        {
            Console.WriteLine("That name is blank, invalid, or already used.");
            return;
        }

        RunJournalMenu(journal, generator);
    }

    static void ImportJournal(Library library, PromptGenerator generator)
    {
        Console.Write("File to import: ");
        string filename = Console.ReadLine();

        try
        {
            Journal journal = library.ImportJournal(filename);
            if (journal == null)
            {
                Console.WriteLine("A journal with that name already exists, or the name is invalid.");
                return;
            }
            Console.WriteLine($"Imported '{journal.Name}'.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("That file was not found.");
        }
        catch (FormatException)
        {
            Console.WriteLine("That file isn't a valid journal.");
        }
    }

    static void RunJournalMenu(Journal journal, PromptGenerator generator)
    {
        string choice = "";

        while (choice != "5")
        {
            DisplayJournalMenu(journal);
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteEntry(journal, generator);
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    Console.Write("Filename to save to: ");
                    journal.SaveToFile(Console.ReadLine());
                    Console.WriteLine("Journal saved.");
                    break;
                case "4":
                    LoadIntoJournal(journal);
                    break;
                case "5":
                    break;
                default:
                    Console.WriteLine("Please choose 1-5.");
                    break;
            }
        }
    }

    static void DisplayJournalMenu(Journal journal)
    {
        Console.WriteLine();
        Console.WriteLine($"Journal: {journal.Name}");
        Console.WriteLine("  1. Write a new entry");
        Console.WriteLine("  2. Display the journal");
        Console.WriteLine("  3. Save the journal to a file");
        Console.WriteLine("  4. Load the journal from a file");
        Console.WriteLine("  5. Back to library");
        Console.Write("What would you like to do? ");
    }

    static void WriteEntry(Journal journal, PromptGenerator generator)
    {
        string prompt = generator.ReturnPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Press Enter to answer, or type 's' to skip to a new prompt: ");

        while (Console.ReadLine().Trim().ToLower() == "s")
        {
            prompt = generator.ReturnPrompt();
            Console.WriteLine($"Prompt: {prompt}");
            Console.Write("Press Enter to answer, or type 's' to skip to a new prompt: ");
        }

        Console.Write("Entry name: ");
        string name = Console.ReadLine();
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        string date = DateTime.Now.ToShortDateString();

        journal.AddEntry(new Entry(date, name, prompt, response));
        Console.WriteLine("Entry added.");
    }

    static void LoadIntoJournal(Journal journal)
    {
        Console.Write("Filename to load: ");
        string filename = Console.ReadLine();

        try
        {
            journal.LoadFromFile(filename);
            Console.WriteLine("Journal loaded.");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("That file was not found.");
        }
        catch (FormatException)
        {
            Console.WriteLine("That file isn't a valid journal. Nothing was changed.");
        }
    }
}