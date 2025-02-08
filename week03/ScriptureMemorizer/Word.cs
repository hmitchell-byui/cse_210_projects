using System.Collections.Generic;
using System.Linq;

public class Word
{
    public static List<string> GetWords(string scripture)
    {
        return scripture.Split(' ').ToList();
    }

    public static List<int> GetWordPositionsToReplace(List<string> words, int numberOfWords)
    {
        Random random = new Random();
        return words
            .Select((word, index) => new { word, index })
            .OrderBy(x => random.Next())
            .Take(numberOfWords)
            .Select(x => x.index)
            .ToList();
    }
}
