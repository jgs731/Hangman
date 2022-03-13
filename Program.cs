using System;
using System.Text;

namespace Hangman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<string> wordsToGuess = new List<string>() { "BOTTLE", "ORANGE", "RADAR", "ADD" };
            int remainingGuesses = 4;
            string wordToBlank = wordsToGuess[random.Next(0, wordsToGuess.Count)];
            string blankedWord = "";
            ConsoleKeyInfo guessLetter;

            for (int i = 0; i < wordToBlank.Length; i++) blankedWord += "_";

            while (wordToBlank != blankedWord || remainingGuesses != 0)
            {
                Console.WriteLine($"Enter a letter: {blankedWord}\n");
                guessLetter = Console.ReadKey();
                if (wordToBlank.Contains(guessLetter.Key.ToString()))
                {
                    for (int i = 0; i < blankedWord.Length; i++)
                    {
                        if (guessLetter.Key.ToString() == wordToBlank[i].ToString() && blankedWord[i] == '_')
                        {
                            Console.WriteLine("\nExists");
                            blankedWord = blankedWord.Remove(i, 1).Insert(i, guessLetter.Key.ToString()); // Remove underscore character + insert correct character in its place
                        }
                    }
                    Thread.Sleep(500);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("\nDoesn't Exist");
                    remainingGuesses--;
                    Console.WriteLine("Draw line here"); // Draw method to be implemented and called on this line
                    Thread.Sleep(1500);
                    Console.Clear();
                }
                if (wordToBlank == blankedWord)
                {
                    Console.WriteLine("Well done!");
                    break;
                }
                if (remainingGuesses == 0)
                {
                    Console.WriteLine($"Game Over - {wordToBlank} was the word. Thanks for playing");
                    break;
                }
            }
        }
    }
}