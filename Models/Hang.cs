using System;

namespace Hangman.Models
{
    public class Hang
    {
        private static string Word;
        public static string[] words = {"flannel", "phone", "water", "sanitizer", "plant", "gang"};
        public static char[] hiddenWord;
        

        public Hang()
        {
            RanWord();
        }

        public static void RanWord()
        {
            Random random = new Random();
            int picker = random.Next(0,6);
            Word = words[picker];
            hiddenWord = new char [Word.Length-1];
            for (int i =0; i<Word.Length-1;i++)
            {
                hiddenWord[i] = '_';
            }
        }

        public static void Guess(char guess)
        {
            for (int i = 0; i< Word.Length-1;i++)
            {
                if (guess == Word[i])
                    hiddenWord[i] = guess;
            }
        }

        public string Return()
        {
            string fixedWord = new string (hiddenWord);
            return fixedWord;
        }


    }
}