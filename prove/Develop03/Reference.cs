using System;

public class reference
{
    private string _book;
    private int _chapter;
    private int _beginVerse;
    private int _endVerse;

    public reference(string book, int chapter, int beginVerse, int endVerse)
    { 
        this. _book = book;
        this. _chapter = chapter;
        this. _beginVerse = beginVerse;
        this. _endVerse = endVerse;
    }
    public override string ToString()
    {
        if (_beginVerse == _endVerse)
        { 
            return $"{_book} {_chapter} : {_beginVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_beginVerse}-{_endVerse}";
        }
    }
}

