using System.Security.Cryptography.X509Certificates;

namespace Lab4_PigLatin
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool runAgain = true;
            Console.WriteLine("Hello, you! Welcome to the Pig Latin Translator. Enter a word to translate.");
            while (runAgain)
            {


                //char[] theVowels = { 'a', 'e', 'i', 'o', 'u' };
                //Console.WriteLine(theVowels);

                //Console.WriteLine("Hello, you! Welcome to the Pig Latin Translator. Enter a word to translate.");
                string input = Console.ReadLine();
                string lower = input.ToLower();
                string output = PiggyLatin(lower);
                Console.WriteLine(output);
                runAgain = AskToContinue();

            }
        }
        
        public static bool TheVowels(char theVowels)
        {
            char[] theVowel = { 'a', 'e', 'i', 'o', 'u' };
            return theVowels == 'a' || theVowels == 'e' || theVowels == 'i' || theVowels == 'o' || theVowels == 'u';
        }

        public static string PiggyLatin(string theWord)
        {
            int length = theWord.Length;
            int index = 0;

            if (TheVowels(theWord[0]))
            {
                return (theWord + "ay");
            }
            else
            {
             
                for (int i = 0; i < length; i++)
                {
                    if (TheVowels(theWord[i]))
                    {
                        index = i;
                        break;
                    }
                }
            }

            return theWord.Substring(index) + theWord.Substring(0, index) + "ay";

        }
        public static bool AskToContinue()
        {
            Console.WriteLine("Would you like to translate a different word? y/n");
            string input = Console.ReadLine().ToLower();
            
            if (input == "y")
            {   
                Console.WriteLine("Enter a new word!");
                return true;
            }
            else if (input == "n")
            {
                Console.WriteLine("Have a nice day!");
                return false;
            }
            else
            {
                Console.WriteLine("I didn't understand that, please try again.");
                return AskToContinue();
            }
        }

    }
}