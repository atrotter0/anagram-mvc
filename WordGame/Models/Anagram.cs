using System;
using System.Collections.Generic;

namespace WordGame.Models
{
    public class Anagram
    {
        private string _baseWord;
        private string _wordList;
        private int _charCounter = 0;
        private bool _sameLetters = false;
        private List<string> _wordMatches = new List<string>() {};
        private string _wordToCompare = "";

        public void SetBaseWord(string newWord)
        {
            _baseWord = newWord;
          }

        public string GetBaseWord()
        {
            return _baseWord;
        }

        public void SetWordList(string newList)
        {
            _wordList = newList;
        }

        public string GetWordList()
        {
            return _wordList;
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

        public void SetWordMatches(string word)
        {
            this.GetWordMatches().Add(word);
        }

        public List<string> GetWordMatches()
        {
            return _wordMatches;
        }

        public string GetWordToCompare()
        {
            return _wordToCompare;
        }

        public void SetWordToCompare(string word)
        {
            _wordToCompare = word;
        }

        // write new test for this
        public void FindAnagram()
        {
            char[] firstWordLetters = this.SortAndReturnChars(this.GetBaseWord());
            string[] words = this.GetWordList().Split(' ');
            foreach (string word in words)
            {
                this.SetWordToCompare(word);
                char[] secondWordLetters = this.SortAndReturnChars(word);
                if (secondWordLetters.Length == firstWordLetters.Length)
                {
                  this.CheckLettersAreEqual(firstWordLetters[this.GetCounter()], secondWordLetters[this.GetCounter()]);
                  this.IncrementCounter();
                }
            }
        }

        public char[] SortAndReturnChars(string word)
        {
            char[] lettersOfWord = this.CharactersInWord(word);
            Array.Sort(lettersOfWord);
            return lettersOfWord;
        }

        public char[] CharactersInWord(string word)
        {
            return word.ToCharArray();
        }

        public void CheckLettersAreEqual(char letterOne, char letterTwo)
        {
            if (letterOne == letterTwo)
            {
              this.SameLettersTrue();
              this.AddAnagram();
            }
        }

        public void AddAnagram()
        {
            if (this.GetSameLetters()) this.SetWordMatches(this.GetWordToCompare());
        }
    }
}
