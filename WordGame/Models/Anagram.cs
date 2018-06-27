using System;
using System.Collections.Generic;

namespace WordGame
{
    public class Anagram
    {
        private List<string> _userWords = new List<string>() {};
        private List<string> _wordMatches = new List<string>() {};

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

        public char[] CharactersInWord(string word)
        {
            return word.ToCharArray();
        }
    }
}
