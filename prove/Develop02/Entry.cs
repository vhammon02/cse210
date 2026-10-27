using System;

public class Entry
{
    //attributes
    private string _date;
    private string _prompt;
    private string _response;
    private string _name;

    //lets journal read name and date
    public string Date => _date;
    public string Name => _name;

    //behaviors
    public void Display()
    {
        Console.WriteLine($"Entry: {_name}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($" ");
        Console.WriteLine($"Response: {_response}");
    }
    public void UpdateResponse(string response)
    {
        _response = response;
    }
    public Entry( string date, string name, string prompt, string response)
    {
        _date = date;
        _name = name;
        _prompt = prompt;
        _response = response;

    }
    private const string Separator = "~|~";
    public string SaveString() 
    {
        return $"{_date}{Separator}{_name}{Separator}{_prompt}{Separator}{_response}";
    }
    
    public static Entry ImportString(string line)
    {
         string[] parts = line.Split(new string[] { Separator }, StringSplitOptions.None);

      if (parts.Length != 4)
      {
        throw new FormatException($"Bad journal line: {line}");
      }

      return new Entry(parts[0], parts[1], parts[2], parts[3]);
    }
}

