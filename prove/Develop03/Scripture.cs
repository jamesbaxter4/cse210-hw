using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _scriptureReference;
    private List<Word> _scripture;

    public Scripture(Reference reference, string scripture)
    {
        _scriptureReference = reference;
        _scripture = new List<Word>();

        string[] words = scripture.Split(
            new char[] { ' ' },
            StringSplitOptions.RemoveEmptyEntries
        );

        foreach (string word in words)
        {
            _scripture.Add(new Word(word));
        }
    }

    public string GetDisplayText()
    {
        string display = _scriptureReference.GetReference() + " ";
        
        for (int i = 0; i < _scripture.Count; i++)
        {
            display += _scripture[i].GetDisplayText();

            if (i < _scripture.Count - 1)
            {
                display += " ";
            }
        }

        return display;
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<int> visibleIndexes = new List<int>();

        for (int i = 0; i < _scripture.Count; i++)
        {
            if (!_scripture[i].IsHidden())
            {
                visibleIndexes.Add(i);
            }
        }

        int amount = Math.Min(numberToHide, visibleIndexes.Count);
        
        for (int i = 0; i < amount; i++)
        {
            int randomPosition = random.Next(visibleIndexes.Count);
            int wordIndex = visibleIndexes[randomPosition];

            _scripture[wordIndex].Hide();
            visibleIndexes.RemoveAt(randomPosition);
        }
    }

    public bool IsCompletelyHidden()
    {
        for (int i = 0; i < _scripture.Count; i++)
        {
            if (!_scripture[i].IsHidden())
            {
                    return false;
            }
        }

        return true;
    }

}