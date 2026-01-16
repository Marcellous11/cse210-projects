using System.Text.Json;

class Journal
{
    public string _date;
    public string _entry;
    public string _prompt;
    public List<Dictionary<string,string>> _currnetJournalEntries = new List<Dictionary<string, string>>(); 

    public void AddJournalEntry(string journalText,string prompt)
    {
        Dictionary<string,string> journalEntry = new Dictionary<string, string>
        {
            { "date", DateTime.Today.ToString("MM/dd/yyyy") },
            { "prompt", prompt },
            { "entry", journalText }
        };
        _currnetJournalEntries.Add(journalEntry);
    }

    public void LoadJournalEntries(string path)
    {
        string fullPath = Path.Join("data",path);
        string jsonText;

        if(Path.Exists(fullPath)){
            jsonText = File.ReadAllText(fullPath);
            List<Dictionary<string,string>> entires = JsonSerializer.Deserialize<List<Dictionary<string,string>>>(jsonText);
            _currnetJournalEntries = entires;
            Console.WriteLine("\nYour data has been loaded!\n");
        }
        else{
            Console.WriteLine("\nUnable to find file path.\n");
        }
    }
    public void SaveJournalEntries(string path)
    {
        string fullPath = Path.Join("data",path);
        string jsonText;

        jsonText = JsonSerializer.Serialize(_currnetJournalEntries);
        File.WriteAllText(fullPath,jsonText);
        if(File.Exists(fullPath)){
            Console.WriteLine($"\nData has been saved to {fullPath}\n");
        }

    }
}