public class Reference
{
    //atributes
    private string _book;
    private string _chapter;
    private string _verse;

    //constructor
    public Reference(string book, string chapter, int singleVerse)
    {
        _book = book;
        _chapter = chapter;
        SetVerse(singleVerse);
    }
    public Reference(string book, string chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        SetVerses(startVerse, endVerse);
    }

    //behaviors


    public string GetReference()
    {
        return $"{_book} {_chapter}:{_verse}";
    }

    public void SetVerse(int singleVerse)
    {
        _verse =  singleVerse.ToString();
    }

    public void SetVerses(int startVerse, int endVerse)
    {
        _verse = $"{startVerse} - {endVerse}";
    }

    
}