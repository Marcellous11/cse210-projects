// For full 100% I am reading data from a JSON file
namespace Journal;
class Program
{
    static void Main(string[] args)
    {
        int userResponse = -1;
        JournalProcessing JournalProcessing = new JournalProcessing();
        CLITool cli = new CLITool(JournalProcessing);

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