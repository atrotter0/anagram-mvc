using System;
using System.Collections.Generic;

namespace WordGame
{
    public class Anagram
    {
        private List<string> _userWords = new List<string>() {};
        private List<string> _wordMatches = new List<string>() {};
        private int _charCounter = 0;
        private bool _sameLetters = false;
        private string _wordToCompare = "";

        public void SetUserWords(string word)
        {
            this.GetUserWords().Add(word);
        }

        public List<string> GetUserWords()
        {
            return _userWords;
        }

        public void SetWordMatches(string word)
        {
            this.GetWordMatches().Add(word);
        }

        public List<string> GetWordMatches()
        {
            return _wordMatches;
        }

        public void IncrementCounter()
        {
            _charCounter++;
        }

        public int GetCounter()
        {
            return _charCounter;
        }

        public void SameLettersTrue()
        {
            _sameLetters = true;
        }

        public bool GetSameLetters()
        {
            return _sameLetters;
        }

        public string GetWordToCompare()
        {
            return _wordToCompare;
        }

        public void SetWordToCompare(string word)
        {
            _wordToCompare = word;
        }

        public void CheckForAnagram()
        {
            int charCounter = 0;
            bool sameLetters = true;
            string originalWord = "";
            char[] firstWordLetters = this.SortAndReturnChars(this.GetUserWords()[0]);
            for(int j = 1; j < this.GetUserWords().Count; j++)
            {
                originalWord = this.GetUserWords()[j];
                char[] secondWordLetters = this.SortAndReturnChars(this.GetUserWords()[j]);
                if (secondWordLetters.Length == firstWordLetters.Length)
                {
                    sameLetters = this.CheckLettersAreEqual(firstWordLetters[charCounter], secondWordLetters[charCounter]);
                    charCounter++;
                    this.AddAnagram(sameLetters, originalWord);
                }
            }
            for (int k = 0; k < this.GetWordMatches().Count; k++)
            {
              Console.WriteLine(this.GetWordMatches()[k]);
            }
        }

        public char[] SortAndReturnChars(string word)
        {
            char[] lettersOfWord = this.CharactersInWord(word);
            Array.Sort(lettersOfWord);
            return lettersOfWord;
        }

        public bool CheckLettersAreEqual(char letterOne, char letterTwo)
        {
            bool sameLetters = true;
            if (letterOne != letterTwo) sameLetters = false;
            return sameLetters;
        }

        public void AddAnagram(bool sameLetters, string originalWord)
        {
            if (sameLetters) this.SetWordMatches(originalWord);
        }

        public char[] CharactersInWord(string word)
        {
            return word.ToCharArray();
        }
    }
}
