using System;
using System.Collections.Generic;

public class scripture
{
    private List<word> _words;
    private List <reference> _reference;

    public scripture(string book,int chapter, int verse, string text)
    {
        _words = new List<word> ();
        _reference =new reference(book, chapter, verse);
    }

    public void HideWords()
    {
        _words = true;
    }

    public string GetRenderedText ()
    {
        string words = $"{reference} >>> {_text}";
        return words;
    }
    string[] splitText = text.split(' ');
        foreach (string word in splitText)
    {
        _word.Add(word);
    }

    public void isCompletelyHidden()
    {
        return _words;
    }
}