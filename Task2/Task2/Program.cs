namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {//Owen Totten
            //In class task 2
            //9-8-25
            //Promt the user for information about a hero
            Console.WriteLine("What is the Hero's name?");
            string heroname = Console.ReadLine();
            Console.WriteLine("Whar is youre favorite place?");
            string favoriteplace = Console.ReadLine();
            Console.WriteLine("What is youre lucky Number?");
            string luckynumber = Console.ReadLine();
            heroname=heroname.Trim();
            favoriteplace=favoriteplace.Trim();

            // create strings for the output of the users data
            string line1 = "Meet" + heroname.ToUpper() + "!";
            string line2= "Today's quest starts in " + favoriteplace+ ".";
            string line3 = "Lucky number: " + luckynumber;

            string nick=heroname.Length>=3 ? heroname.Substring(0, 3).ToUpper() : heroname.ToUpper();
            string code = "#" + nick + luckynumber;
            
            //build report
            string report = line1 + Environment.NewLine + line2 + Environment.NewLine + line3 + Environment.NewLine + "QuestCode: " + code;
            Console.WriteLine(report);
            Console.WriteLine("Parse success: + parsedOkay");
            Console.WriteLine("Hero length: " + heroname.Length);
            Console.WriteLine("Place contains a space:"+ favoriteplace.Contains(" "));




        }
    }
}
