// For full 100% I am reading data from a JSON file
class Program
{
    static void Main(string[] args)
    {
        int userResponse = -1;
        Journal journal = new Journal();
        CLITool cli = new CLITool(journal);

        while(userResponse != 5)
        {   
            userResponse = cli.DisplayMenu();

            switch(userResponse){
                case 1:
                    cli.WriteToJournal();
                    break;
                case 2:
                    cli.DisplayJournalEntry();
                    break;
                case 3:
                    cli.LoadJournalData();
                    break;
                case 4:
                    cli.SaveJournalEntries();
                    break;
            }
        }
    }
}