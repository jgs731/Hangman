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

            for (int i = 0; i < wordToBlank.Length; i++)
            {
                blankedWord += "_";
            }

            while (remainingGuesses != 0)
            {
                Console.WriteLine($"Enter a letter: {blankedWord}");
                string guessLetter = Console.ReadLine().ToUpper();
                for (int i = 0; i < blankedWord.Length; i++)
                {
                    if (wordToBlank[i].ToString() == guessLetter)
                    {
                        Console.WriteLine("Exists");
                        blankedWord = blankedWord.Remove(i, 1).Insert(i, guessLetter).ToString(); // Remove underscore character + insert correct character in its place
                    }
                    else
                    {
                        Console.WriteLine("Doesn't Exist");
                        remainingGuesses--;

                        Thread.Sleep(1000);
                        Console.WriteLine("Draw line here"); // Draw method to be implemented and called on this line
                    }
                }
                Console.WriteLine(blankedWord);
            }
        }
    }
}