using System;

public class Journal
{
    public List<Entry> _entries = new List<Entry>{};

    public Journal()
    {
        
    }

    public void AddEntry(string date, string prompt, string entry)
    {
        Entry journalEntry = new Entry(date, prompt, entry);
        _entries.Add(journalEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry s in _entries)
        {
            s.Display();
        }
    }

    public void SaveToFile(string file_name)
    {
        //to tell the user that it is being saved
        Console.WriteLine("Saving to file…");

        //writing journal to file
        using (StreamWriter outputFile = new StreamWriter(file_name + ".txt"))
        {
        //each journal entry is added to file
            foreach (Entry p in _entries) 
            {
            outputFile.WriteLine($"{p._date}~~{p._promptText}~~{p._entryText}");
            }
        }

    }

    public void LoadFromFile(string file_name)
    {
        Console.WriteLine("Loading file…");
        try
        {
            string fileContents = File.ReadAllText(@$"{file_name}.txt");
            _entries = [];

            using (StringReader reader = new StringReader(fileContents))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Process the line (e.g., print it)
                    Entry entryline = new Entry();
                    List<string> temp = line.Split("~~").ToList();
                    // Console.WriteLine(temp[2]);
                    entryline._date = temp[0];
                    entryline._promptText = temp[1];
                    entryline._entryText = temp[2];
                    _entries.Add(entryline);
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
            _entries = [];
        } 
    }

    public List<Entry> CopyList()
    {
        return _entries;
    }
}