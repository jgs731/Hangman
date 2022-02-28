using System;

namespace Hangman
{
    internal class Program
    {
        public class HangmanGame
        {
            int remainingGuesses = 4;
            
            public string WordToBlank { get; set; }

            public string selectRandomWordAndHide()
            {
                string blankedWord = "";
                for (int i = 0; i < WordToBlank.Length; i++)
                {
                    blankedWord += (WordToBlank[i].ToString().Replace(WordToBlank[i].ToString(), "_  "));
                }
                return blankedWord;
            }

            public void evaluateCharacter(string word, string guess)
            {
                for (int i = 0; i < word.Length; i++)
                    if (word.Contains(guess))
                    {
                        Console.WriteLine("Exists");
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
        
        static void Main(string[] args)
        {
            HangmanGame hmg = new HangmanGame();
            Random random = new Random();
            List<string> wordsToGuess = new List<string>() { "BOTTLE", "ORANGE", "RADAR", "ADD" };

            hmg.WordToBlank = wordsToGuess[random.Next(0, wordsToGuess.ToArray().Length)];

            Console.WriteLine($"Enter a letter: {hmg.selectRandomWordAndHide()}");
            string guessLetter = Console.ReadLine();
            hmg.evaluateCharacter(hmg.WordToBlank, guessLetter.ToUpper());
        }
    }
}