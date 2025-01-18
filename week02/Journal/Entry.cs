public class Entry
{
    private string _date;
    private string _promptText;
    private string _entryText;

    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine();
    }

    public string GetEntryAsString()
    {
        return $"{_date}~|~{_promptText}~|~{_entryText}";
    }

    public static Entry ParseFromString(string entryString)
    {
        string[] parts = entryString.Split("~|~");
        if (parts.Length != 3)
        {
            throw new FormatException("Invalid entry format");
        }

        return new Entry(parts[0], parts[1], parts[2]);
    }
}