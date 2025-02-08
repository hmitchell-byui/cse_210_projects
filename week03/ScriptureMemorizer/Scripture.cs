using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private string _text;
    private int _iteration;
    private int _originalWordCount;

    public string Text
    {
        get { return _text; }
        set { _text = value; }
    }

    public int Iteration
    {
        get { return _iteration; }
        set { _iteration = value; }
    }

    public Scripture(string text)
    {
        _text = text;
        _iteration = 1; // Initialize the iteration counter
        _originalWordCount = Word.GetWords(text).Count; // Calculate original word count
    }

    public string ReplaceWordsWithUnderscores()
    {
        List<string> words = Word.GetWords(_text);
        int wordsToReplaceCount = (int)Math.Ceiling(_originalWordCount * 0.20 * _iteration);
        List<int> positionsToReplace = Word.GetWordPositionsToReplace(words, wordsToReplaceCount);

        for (int i = 0; i < words.Count; i++)
        {
            if (positionsToReplace.Contains(i))
            {
                words[i] = new string('_', words[i].Length);
            }
        }

        _iteration++; // Increase the number of words to underscore for the next iteration
        return string.Join(" ", words);
    }
}

