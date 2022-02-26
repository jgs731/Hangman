using System;

namespace Hangman
{
    internal class Program
    {
        public class HangmanGame
        {
            int remainingGuesses = 4;
            Random random = new Random();
            public string selectRandomWordAndHide()
            {
                var wordsToGuess = new List<string>() { "bottle", "orange", "radar", "add" };
                string wordToBlank = wordsToGuess[random.Next(0, 5)];
                string blankedWord = "";
                for (int i = 0; i < wordToBlank.Length; i++)
                {
                    blankedWord += (wordToBlank[i].ToString().Replace(wordToBlank[i].ToString(), "_  "));
                }
                Console.Write(blankedWord);
                return blankedWord;
            }

            public string evaluateCharacter(string guess)
            {
                // if character exists in string
                // replace blank tile(s) with actual character
                // else 
                // Inform player that it doesn't exist
                // Draw the hangman
                // Decrement guesses remaining
                return "";
            }


        }
        
        static void Main(string[] args)
        {
            HangmanGame hmg = new HangmanGame();
            hmg.selectRandomWordAndHide();

            Console.WriteLine($"Enter a letter: {hmg.selectRandomWordAndHide()}");
            string guessLetter = Console.ReadLine();
        }
    }
}