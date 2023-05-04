using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] textWords = text.Split(' ');
        _words = new List<Word>();

        foreach (string word in textWords)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideWords(int numberWordsToHide)
    {
        Random random = new Random();
        for (int i = 0; i < numberWordsToHide; i++)
        {
            if (IsCompletelyHidden())
            {
                break;
            }
            int randomIndex = random.Next(_words.Count);
            while (_words[randomIndex].IsHidden())
            {
                randomIndex = random.Next(_words.Count);
            }
            _words[randomIndex].Hide();
        }
    }
    
    public string GetRenderedText()
    {
        List<string> renderedWords = new List<string>();

        foreach (Word word in _words)
        {
            renderedWords.Add(word.GetRenderedText());
        }

        return string.Join(" ", renderedWords);
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}