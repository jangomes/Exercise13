using System;
using System.Linq;

namespace Exercise13
{
    class Program
    {
        /*  Create a game like Hangman in which a player guesses letters to try to replicate a hidden 
            word. Store at least eight words in an array, and randomly select one to be the hidden word. 
            Initially, display the hidden word using asterisks to represent each letter. Allow the user to 
            guess letters to replace the asterisks in the hidden word until the user completes the entire 
            word. If the user guesses a letter that is not in the hidden word, display an appropriate 
            message. If the user guesses a letter that appears multiple times in the hidden word, make 
            sure that each correct letter is placed*/
        static void Main(string[] args)
        {
            string[] words = { "coffee", "bread", "butter", "milk", "cake", "toast", "tea", "juice" };
            string word = "", letter = "";
            int error = 0, done = 0, position = 0;

            bool exit = false;
            const int limit = 5;
            Random rnd = new Random();


            int choice = rnd.Next(0, 8);
            word = words[choice];

            string[] broke = new string[word.Length];

            while (true)
            {

                for (int i = 0; i < broke.Length; i++)
                {
                    if (broke[i] != null)
                    {
                        Console.Write(broke[i] + "");
                    }
                    else
                    {
                        Console.Write("* ");
                    }
                }
                Console.WriteLine("\nChoose the position: ");
                position = int.Parse(Console.ReadLine());

                Console.WriteLine("\nChoose the letter: ");
                letter = Console.ReadLine();
                Console.WriteLine("\nError: {0} of {1}\n", error, limit);

               

                if (word.ElementAt(position - 1) == letter.ElementAt(0))
                {

                    broke[position - 1] = letter;
                    done++;
                }
                else
                {
                    error++;
                }
                if (error >= limit)
                {
                    exit = true;
                }
                if (done == word.Length)
                {
                    exit = true;
                }

                if (done == word.Length)
                {
                    Console.Clear();
                    Console.WriteLine("Congratulations");
                }
                else if (error == limit)
                {
                    Console.WriteLine("Limit exceeded");
                    Console.WriteLine("Error: {0} of {1}, the word was {2}", error, limit,word);
                }
            }
        }
    }
}