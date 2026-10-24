using System;

public class Reference
{
    public string _book;
    public int _chapter;
    public int _startVerse;
    public int _endVerse;

    public Reference(string book, int chapter, int startVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = startVerse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string GetReference()
    {
        if (_startVerse == _endVerse)
        {
            return _book + " " + _chapter + ":" + _startVerse;
        }

        return _book + " " + _chapter + ":" + _startVerse + "-" + _endVerse;
    }
}