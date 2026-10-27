using System;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Transactions;

public class Word
{
    //attributes
    private string _word;
    private bool _visible;
    private double _length;



    //constructors
    public Word(string word, bool visible, int length)
    {
        _word = word;
        _visible = visible;
        _length = length;
    }

    //methods
    public void SetLetterCount() 
    {
        int length = _word.Length;
    }

    public void HideWord()
    {
        _visible = false;
    }

    public void ShowWord()
    {
        _visible = true;
    }
    public bool IsVisible()
    {
        return _visible;
    }
    public string GetWord()
    {
        return _word;
    }
    public void SetWord(string inputWord)
    {
        _word = inputWord;
    }
    public string GetLetters()
{
    if (_visible)
    {
        return _word;
    }

    return new string('_', _word.Length);
}

}