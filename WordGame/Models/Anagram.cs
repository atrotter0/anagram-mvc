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

        // public void CheckForAnagram()
        // {
        //     int charCounter = 0;
        //     bool sameLetters = true;
        //     for(int i = 0; i < this.GetUserWords().Length; i++)
        //     {
        //         char[] firstWordLetters = this.CharactersInWord(this.GetUserWords()[i]);
        //         firstWordLetters.Sort();
        //         for(int j = 1; i < this.GetUserWords().Length; j++)
        //         {
        //             char[] secondWordLetters = this.CharactersInWord(this.GetUserWords()[j]);
        //             secondWordLetters.Sort();
        //
        //             if (firstWordLetters[charCounter] != secondWordLetters[charCounter])
        //             {
        //                 sameLetters = false;
        //             }
        //             charCounter++;
        //         }
        //         this.AddWordToMatch(sameLetters);
        //     }
        // }

        public void AddWordToMatch(bool sameLetters, char[] secondWordLetters)
        {
            if (sameLetters)
            {
                string newWord = new string(secondWordLetters);
                this.SetWordMatches(newWord);
            }
        }

        public char[] CharactersInWord(string word)
        {
            return word.ToCharArray();
        }
    }
}
