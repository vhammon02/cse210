using System.IO;

public class Library
{
    private List<Journal> _journals = new List<Journal>();
    private const string FolderName = "journals";

    public Library()
    {
        Directory.CreateDirectory(FolderName);
        LoadLibrary();
    }

    private string PathFor(string name)
    {
        return Path.Combine(FolderName, name + ".txt");
    }

    public void LoadLibrary()
    {
        _journals.Clear();

        foreach (string path in Directory.GetFiles(FolderName, "*.txt"))
        {
            string name = Path.GetFileNameWithoutExtension(path);
            Journal journal = new Journal(name);

            try
            {
                journal.LoadFromFile(path);
                _journals.Add(journal);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Skipped '{name}': the file is damaged.");
            }
        }
    }

    public void SaveLibrary()
    {
        foreach (Journal journal in _journals)
        {
            journal.SaveToFile(PathFor(journal.Name));
        }
    }

    public void DisplayJournals()
    {
        if (_journals.Count == 0)
        {
            Console.WriteLine("You have no journals yet.");
            return;
        }

        for (int i = 0; i < _journals.Count; i++)
        {
            Journal journal = _journals[i];
            Console.WriteLine($"  {i + 1}. {journal.Name} ({journal.EntryCount} entries)");
        }
    }

    public Journal SelectJournal(int number)
    {
        if (number < 1 || number > _journals.Count)
        {
            return null;
        }
        return _journals[number - 1];
    }

    public Journal CreateNewJournal(string name)
    {
        name = name.Trim();

        bool badName = name == "" || name.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0;
        bool duplicate = _journals.Any(j => j.Name.ToLower() == name.ToLower());

        if (badName || duplicate)
        {
            return null;
        }

        Journal journal = new Journal(name);
        _journals.Add(journal);
        return journal;
    }

    public Journal ImportJournal(string filename)
    {
        Journal journal = CreateNewJournal(Path.GetFileNameWithoutExtension(filename));
        if (journal == null)
        {
            return null;
        }

        try
        {
            journal.LoadFromFile(filename);
        }
        catch
        {
            _journals.Remove(journal);
            throw;
        }
        return journal;
    }
}