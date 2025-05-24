

public class Scripture
{

    private Reference _reference;

    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {

        _reference = reference;
        foreach (var word in text.Split(' '))
        {
            _words.Add(new Word(word));
        }

    }

    public void HideRandomWords(int numberToHide)
    {

        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();
        var random = new Random();

        for (int i = 0; i < numberToHide; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }

    }

    // New method to restart and show all words
    public void ShowAllWords()
    {
        foreach (var word in _words)
        {
            word.Show();
        }
    }

    public string GetDisplayText()
    {
        string wordsText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()}\n{wordsText}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }

}