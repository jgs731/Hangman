using System;

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

            for (int i = 0; i < wordToBlank.Length; i++)
            {
                blankedWord += (wordToBlank[i].ToString().Replace(wordToBlank[i].ToString(), "_  "));
            }

            Console.WriteLine($"Enter a letter: {blankedWord}");
            string guessLetter = Console.ReadLine();
            for (int i = 0; i < wordToBlank.Length; i++)
            {
                if (wordToBlank.Equals(guessLetter))
                {
                    Console.WriteLine("Exists");
                    blankedWord += (wordToBlank[i].ToString().Replace("_", guessLetter));
                    Console.WriteLine(blankedWord);
                }
                else
                {
                    Console.WriteLine("Doesn't Exist");
                    remainingGuesses--;
                    Thread.Sleep(1000);
                    Console.WriteLine("Draw line here");
                }
            }
        }
    }
}