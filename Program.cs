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
            StringBuilder stringBuilder = null;

            for (int i = 0; i < wordToBlank.Length; i++)
            {
                blankedWord += "_  ";
            }

            for (int i = 0; i < wordToBlank.Length; i++)
            {
                Console.Write($"Enter a letter: {blankedWord}");
                string guessLetter = Console.ReadLine().ToUpper();

                if (wordToBlank[i].ToString() == guessLetter)
                {
                    Console.WriteLine("Exists");
                    stringBuilder = new StringBuilder(blankedWord);
                    stringBuilder.Insert(i, guessLetter);
                    Console.WriteLine(stringBuilder.ToString());
                }
                else
                {
                    Console.WriteLine("Doesn't Exist");
                    remainingGuesses--;
                    Thread.Sleep(1000);
                    Console.WriteLine("Draw line here");
                }
            }
            Console.WriteLine(stringBuilder.ToString());
        }
    }
}