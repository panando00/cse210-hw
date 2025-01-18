public class Journal
{
    private List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries found in the journal.");
            return;
        }

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        List<string> lines = new List<string>();
        foreach (Entry entry in _entries)
        {
            lines.Add(entry.GetEntryAsString());
        }
        
        try
        {
            File.WriteAllLines(file, lines);
            Console.WriteLine("Journal saved successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error saving journal: {ex.Message}");
        }
    }

    public void LoadFromFile(string file)
    {
        try
        {
            string[] lines = File.ReadAllLines(file);
            _entries.Clear();
            
            foreach (string line in lines)
            {
                Entry entry = Entry.ParseFromString(line);
                _entries.Add(entry);
            }
            
            Console.WriteLine("Journal loaded successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading journal: {ex.Message}");
        }
    }
}