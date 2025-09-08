namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String strData = "    Owen    Patrick Totten    ";
            Console.WriteLine(strData.Length);
            Console.WriteLine($"The orginal name is{strData}");
            // remove spaces before and after name.
            //strData =strData.Trim();    
            //Console.WriteLine(strData.Trim());
            //Console.WriteLine(strData.Length);
            //Removes spaces before and after name and makes everything lowercase



            Console.WriteLine(strData.ToLower());
            //Makes all letters lowercase

            Console.WriteLine(strData.ToUpper());
            //Makes all letters uppercase

            String strProcessedName = strData.Trim();
            Console.WriteLine($"Processed name is: {strProcessedName}");
            Console.WriteLine(strProcessedName.IndexOf(' '));
            Console.WriteLine(strProcessedName.Substring(10));
            //Finds the index of the first letter of the name


            //Lets find and print the first name only
            int intFirstSpace = strProcessedName.IndexOf(' ');
            Console.WriteLine(strProcessedName.Substring(0, intFirstSpace));

            //Lets find and print the middle name only
            int intLastSpace = strProcessedName.LastIndexOf(" " );
            Console.WriteLine($"First space is at {intFirstSpace} and last space is at {intLastSpace}");
            int intMidNameLength= intLastSpace - intFirstSpace;
           // Console.WriteLine(strProcessedName.Substring(intFirstSpace+1, intLastSpace));

            //Console.WriteLine(strProcessedName.Substring(intLastSpace+1));



            //Lets try making first part of mid name uppercase.
            String strMidName = strProcessedName.Substring(intFirstSpace, intMidNameLength);
            Console.WriteLine($"Mid name is {strMidName}");
            Console.WriteLine(String.Concat("OP", "LO"));
            char chrMidInitial = 'O';
            char  chrOtherChar = 'K';
            String strCombinedChar = String.Concat(chrMidInitial, chrOtherChar, "Howdy");

            //This prints out the first parrt of the name
            Console.WriteLine(strMidName.Substring(0, 1));

            //This prints out everything after first char.
            Console.WriteLine(strMidName.Substring(1));



        }

    }
}

