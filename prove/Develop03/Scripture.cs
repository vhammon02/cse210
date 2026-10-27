using System.Runtime.InteropServices;

public class Scripture
{
    //attribute
    public Word[] _words;
    private bool _isMemorized = false;
    private int _numberHidden;
    private List<Word[]> _verses;


    //constructor
    public Scripture(string[] verseTexts)
    {
    _verses = new List<Word[]>();

    foreach (string verseText in verseTexts)
        {
        string[] words = verseText.Split(
            ' ',
            StringSplitOptions.RemoveEmptyEntries);

        Word[] verseWords = new Word[words.Length];

        for (int i = 0; i < words.Length; i++)
        {
            verseWords[i] = new Word(words[i], true, words[i].Length);
        }

        _verses.Add(verseWords);
        }
    }
    //behaviors
    public string GetDisplayText()
    {
        List<string> lines = new List<string>();

        foreach (Word[] verse in _verses)
        {
            List<string> words = new List<string>();

            foreach (Word word in verse)
            {
                words.Add(word.GetLetters());
            }

            lines.Add(string.Join(" ", words));
        }

        return string.Join(Environment.NewLine, lines);
    }
    public void HideWords(int numberToHide)
    {
        Random random = new Random();
        List<Word> visibleWords = new List<Word>();

        foreach (Word[] verse in _verses)
        {
            foreach (Word word in verse)
            {
                if (word.IsVisible())
                {
                    visibleWords.Add(word);
                }
            }
        }

        int countToHide = Math.Min(numberToHide, visibleWords.Count);

        for (int i = 0; i < countToHide; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].HideWord();
            visibleWords.RemoveAt(index);
        }
    }
        public bool IsCompletelyHidden()
    {
        foreach (Word[] verse in _verses)
        {
            foreach (Word word in verse)
            {
                if (word.IsVisible())
                {
                    return false;
                }
            }
        }

        return true;
    }


}