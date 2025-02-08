using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private string _scriptureText;
    private int _iterationCount;
    private int _originalWordCount;

    public string ScriptureText
    {
        get { return _scriptureText; }
        set { _scriptureText = value; }
    }

    public int IterationCount
    {
        get { return _iterationCount; }
        set { _iterationCount = value; }
    }

    public Scripture(string text)
    {
        _scriptureText = text;
        _iterationCount = 1; // Initialize the iteration counter
        _originalWordCount = Word.GetWords(text).Count; // Calculate original word count
    }

    public string ReplaceWords()
    {
        List<string> words = Word.GetWords(_scriptureText);
        int wordCount = (int)Math.Ceiling(_originalWordCount * 0.25 * _iterationCount);
        List<int> positions = Word.GetPositions(words, wordCount);

        for (int i = 0; i < words.Count; i++)
        {
            if (positions.Contains(i))
            {
                words[i] = new string('_', words[i].Length);
            }
        }

        _iterationCount++; // Increase the number of words to underscore for the next iteration
        return string.Join(" ", words);
    }
}
