namespace Journal;

class CLITool(JournalProcessing JournalProcessing)
{

    public int _userOption;
    public string _journalEntry;
    Random _randomGen = new Random();
    JournalProcessing JournalProcessing = JournalProcessing;
    public List<string> _promptOptions = new List<string>{"What was the bet part of your day?","What is something you'd like to do better tomorrow?","What Christ like Attribute did you see other display today?","What are you doing this week to accomplish your dream?","Tell me your favorite memory with your mom."};

    public int DisplayMenu()
    {
        Console.Write("""
        1. Write in journal
        2. Display all journal entires
        3. Load journal file
        4. Save entries to file
        5. Quit
        
        What would you like to do? 
        """);
        while (true)
        {
            try
            {

                _userOption = int.Parse(Console.ReadLine());

                if (!new List<int> { 1, 2, 3, 4, 5 }.Contains(_userOption))
                {
                    Console.WriteLine("\nNot a valid number option, try again.");
                }
                else
                {
                    break;
                }
            }
            catch
            {
                Console.WriteLine("\nNot an option was not a number, try again");
            }
        }
        return _userOption;
    }

    public void WriteToJournal(){
        int _random_num= _randomGen.Next(0,_promptOptions.Count);
        string r_prompt =_promptOptions[_random_num];

        Console.WriteLine(r_prompt);
        _journalEntry = Console.ReadLine();
        JournalEntry journalEntry = new JournalEntry();
        journalEntry._date =  DateTime.Today.ToString("MM/dd/yyyy");
        journalEntry._prompt = r_prompt;
        journalEntry._entry = _journalEntry;
        JournalProcessing.AddJournalEntry(journalEntry);
    }

    public void DisplayJournalEntry()
    {
        if(JournalProcessing._currnetJournalEntries.Count == 0)
        {
            Console.WriteLine("\nThere are currently no journal entries found.\n");
        }
        else
        {
            JournalProcessing._currnetJournalEntries.ForEach(entry =>{
                Console.WriteLine($"\nDate: {entry["date"]}");
                Console.WriteLine($"Prompt: {entry["prompt"]}");
                Console.WriteLine($"Entry: \n{entry["entry"]}\n");
        });
        }
    }

    public void LoadJournalData()
    {
        string fileName;
        Console.Write("\nPlease enter the file name to load from: ");
        fileName = Console.ReadLine();
        JournalProcessing.LoadJournalEntries(fileName);
    }

    public void SaveJournalEntries()
    {
        string fileName;
        Console.Write("\nPlease enter the file name to save to (make use it ends with .json): ");
        fileName = Console.ReadLine();
        JournalProcessing.SaveJournalEntries(fileName);
    }
}
