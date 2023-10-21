using System;
using System.Collections.Generic;

public class Scripture
{
    private List<Word> _words;
    private List <Reference> _reference;

    public Scripture(string book,int chapter, int verse, string text)
    {
        _words = new List<Word> ();
        _reference =new Reference(book, chapter, verse);
    }

    public void HideWords()
    {
        _words = true;
    }

    public string GetRenderedText ()
    {
        string words = $"{Reference} >>> {_text}";
        return words;
    }
    string[] splitText = text.split(' ');
    foreach (string word in splitText)
    {
        _word.Add(word);
    }

    public void IsCompletelyHidden()
    {
        return _words;
    }
}