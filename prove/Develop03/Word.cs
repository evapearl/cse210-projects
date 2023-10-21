using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        this. _text = text;
        _isHidden = false;
    }
    // To hide the text
    public void Hide ()
    {
        _isHidden = true;
    }
    public string Show()
    {
        _text = true;
    }
    //get and show the text
    public string GetRenderedText()
    {
        return _text;
    }
    public bool isHidden()
    {
        return _isHidden;
    }

}