using System.IO;

public class Journal
{
    private string _name;
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries yet.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }

    public Journal(string name)
    {
    _name = name;
    }
    public string Name => _name;
    public int EntryCount => _entries.Count;
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry.SaveString());
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        List<Entry> loaded = new List<Entry>();

        foreach (string line in lines)
        {
            if (line.Trim() != "")
            {
                loaded.Add(Entry.ImportString(line));
            }
        }

        _entries = loaded;
    }
}