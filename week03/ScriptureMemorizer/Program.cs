// 1. Pulls a random scripture from the Book of Mormon. 
    // Had to create multiple classes to create this. 
// 2. Use has the option to reset, get new scripture or quit. 
using System.Dynamic;
using System.Text.Json;
using ScriputreMemorizer;

class Program
{
    static void Main(string[] args)
    {   
        string userOption = "";
        bool newVerse = false;
        Scripture scripture = GetScripture();
        

        while(userOption != "quit"){
            if(newVerse){
                scripture = GetScripture();
                newVerse = false;
            }

            Console.WriteLine(scripture.GetDisplayText());  

            if(scripture.allDone()){
                Console.WriteLine("All words have been hidden! You can 'reset', 'new' scripture or 'quit'");
                userOption = Console.ReadLine().Trim().ToLower();
            }else{

            Console.WriteLine("Press 'Enter' to contine or type 'quit' to finish");
            userOption = Console.ReadLine().Trim().ToLower();
            }
            if(userOption == ""){
                scripture.HideRandomWord();

            }
            if(userOption == "new"){
                newVerse = true;
            }
            if(userOption == "reset"){
                scripture.Reset();
            }

        }
    }


    static Scripture GetScripture(){

            int MaxBookIndex;
            int MaxChapterIndex;
            int MaxVerseIndex;

            int RandomBookIdx;
            int RandomChapterIdx;
            int RandomVerseIdx;

            string randomScripture;
            string book ;
            int chapter;
            int verse ;

            string json = File.ReadAllText("book-of-mormon.json");

            Collections bom = JsonSerializer.Deserialize<Collections>(json);

            Random rand = new Random();
            List<Book> books = bom.GetBooks(); 

            MaxBookIndex = books.Count - 1;
            RandomBookIdx = rand.Next(0,MaxBookIndex);

            MaxChapterIndex = books[RandomBookIdx].chapters.Count -1 ;
            RandomChapterIdx = rand.Next(0, MaxChapterIndex);

            MaxVerseIndex = books[RandomBookIdx].chapters[RandomChapterIdx].verses.Count -1 ;
            RandomVerseIdx = rand.Next(0,MaxVerseIndex);

            book =  books[RandomBookIdx].book;
            chapter =  books[RandomBookIdx].chapters[RandomChapterIdx].chapter;
            verse =  books[RandomBookIdx].chapters[RandomChapterIdx].verses[RandomVerseIdx].verse;
            randomScripture = books[RandomBookIdx].chapters[RandomChapterIdx].verses[RandomVerseIdx].text;
    
            Reference reference = new Reference(book,chapter,verse);
            Scripture scripture = new Scripture(reference,randomScripture);
            
            return scripture;
        }
}