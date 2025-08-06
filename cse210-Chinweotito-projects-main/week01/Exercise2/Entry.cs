public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    // ✅ Constructor to allow creation with 3 values
    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
    }
}
