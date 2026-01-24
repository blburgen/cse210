public class LoadScripture
{
    private List<string> _entries = new List<string>{};

    public LoadScripture(string file_name)
    {
        Console.WriteLine("Loading file…");
        try
        {
            string fileContents = File.ReadAllText(@$"{file_name}");
            _entries = [];

            using (StringReader reader = new StringReader(fileContents))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Process the line (e.g., print it)
                    _entries.Add(line);
                    List<string> temp = line.Split("~~").ToList();
                    // Console.WriteLine(temp[2]);
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine("An error occurred: " + e.Message);
            _entries = [];
        }
    }

    public List<string> RandomScripture()
    {
        Random rnd = new Random();
        int randomNumber = rnd.Next(_entries.Count);
        return _entries[randomNumber].Split("~~").ToList();
    }
}