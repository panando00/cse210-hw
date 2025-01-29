using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _random;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
        _random = new Random();
    }

    public void HideRandomWords()
    {
        var wordsToHide = _words.Where(w => !w.IsHidden()).ToList();
        
        if (wordsToHide.Count > 0)
        {
            int wordsToHideCount = Math.Min(3, wordsToHide.Count);
            for (int i = 0; i < wordsToHideCount; i++)
            {
                int index = _random.Next(wordsToHide.Count);
                wordsToHide[index].Hide();
                wordsToHide.RemoveAt(index);
            }
        }
    }

    public string GetDisplayText()
    {
        string referenceText = _reference.GetDisplayText();
        string scriptureText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{referenceText} {scriptureText}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}