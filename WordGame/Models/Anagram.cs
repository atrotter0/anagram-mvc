using System;
using System.Collections.Generic;

namespace WordGame.Models
{
    public class Anagram
    {
        private string _baseWord;
        private string _wordList;
        private bool _sameLetters = true;
        private List<string> _wordMatches = new List<string>() {};
        private string _wordToCompare = "";

        public void SetBaseWord(string newWord)
        {
            string lowercaseWord = newWord.ToLower();
            _baseWord = lowercaseWord;
          }

        public string GetBaseWord()
        {
            return _baseWord;
        }

        public void SetWordList(string newList)
        {
            string cleanedList = this.DowncaseAndScrub(newList);
            _wordList = cleanedList;
        }

        public string GetWordList()
        {
            return _wordList;
        }

        public void SameLettersFalse()
        {
            _sameLetters = false;
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

        public string DowncaseAndScrub(string wordList)
        {
            string[] words = wordList.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = this.ScrubPunctuation(words[i].ToLower());
            }
            string lowercaseAndScrubbed = string.Join(" ", words);
            return lowercaseAndScrubbed;
        }

        public string ScrubPunctuation(string phrase)
        {
            char[] letters = phrase.ToCharArray();
            List<char> lettersAndSpaces = new List<char>() {};
            foreach (char letter in letters)
            {
                this.AddLettersAndSpaces(letter, lettersAndSpaces);
            }
            string scrubbedWord = string.Join("", lettersAndSpaces);
            return scrubbedWord;
        }

        public void AddLettersAndSpaces(char letter, List<char> lettersAndSpaces)
        {
            if (Char.IsLetter(letter) || Char.IsWhiteSpace(letter)) lettersAndSpaces.Add(letter);
        }

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
                  this.SameLettersTrue();
                  for (int i = 0; i < firstWordLetters.Length; i++)
                  {
                    this.CheckLettersAreEqual(firstWordLetters[i], secondWordLetters[i]);
                  }
                  this.AddAnagram();
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
            if (letterOne != letterTwo)
            {
              this.SameLettersFalse();
            }
        }

        public void AddAnagram()
        {
            if (this.GetSameLetters()) this.SetWordMatches(this.GetWordToCompare());
        }
    }
}
