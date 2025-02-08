using System.Collections.Generic;
using System.Linq;

public class Word
{
    public static List<string> GetWords(string text)
    {
        return text.Split(' ').ToList();
    }

    public static List<int> GetPositions(List<string> words, int count)
    {
        Random rand = new Random();
        return words
            .Select((word, index) => new { word, index })
            .OrderBy(x => rand.Next())
            .Take(count)
            .Select(x => x.index)
            .ToList();
    }
}
