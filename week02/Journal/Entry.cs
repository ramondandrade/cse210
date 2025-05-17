public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    public void Display()
    {
        DateTime parsedDate = DateTime.Parse(_date);
        _date = parsedDate.ToString("MMMM dd, yyyy");
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}\n{_entryText} \n");
    }
}