using System;
using System.Collections.Generic;

class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int? _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = null;
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }
    public override string ToString()
    {
        string referenceString = $"{_book} {_chapter}:{_verse}";
        
        if (_endVerse.HasValue)
        {
            referenceString += $"-{_endVerse}";
        }

        return referenceString;
    }
}