public class Entry
{
    public string _date = "";
    public string _promptText = "";
    public string _entryText = "";

    public Entry()
    {
    
    }
    public Entry(string date, string prompt, string entry)
    {
        _date = date;
        _promptText = prompt;
        _entryText = entry;
    }

    public void Display()
    {
        Console.WriteLine($"{_date} -- {_promptText} ");
        Console.WriteLine();
        Console.WriteLine(_entryText);
        Console.WriteLine();
    }

}