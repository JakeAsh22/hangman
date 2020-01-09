using System;

namespace Hangman.Models
{
    public class Hang
    {
        public string Word { get; }
        private string[] words = new string [5]{"flannel", "phone", "water", "sanitizer", "plant", "gang"};
        public char[] hidddenWord;
        

        public Hang(char guess)
        {
            Letter = guess;
        }

        public void RanWord()
        {
            Random random = new Random();
            int picker = random.Next(0,6);
            Word = words[picker];
            hiddenWord = new char [Word.Length-1];
            for (int i =0; i<Word.Length-1;i++)
            {
                Word[i] = '_';
            }
        }

        public void Guess(char guess)
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