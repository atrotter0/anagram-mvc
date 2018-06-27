using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordGame;

namespace WordGame.Tests
{
    [TestClass]
    public class AnagramTest
    {
        [TestMethod]
        public void GetSetUserWords_GetsSetsUserWords_String()
        {
            Anagram testAnagram = new Anagram();
            string word = "test";
            testAnagram.SetUserWords(word);
            Assert.AreEqual(word, testAnagram.GetUserWords()[0]);
        }

        [TestMethod]
        public void GetSetWordMatches_GetsSetsWordMatches_String()
        {
            Anagram testAnagram = new Anagram();
            string word = "test";
            testAnagram.SetWordMatches(word);
            Assert.AreEqual(word, testAnagram.GetWordMatches()[0]);
        }

        [TestMethod]
        public void CharactersInWord_WordTurnedIntoCharArray_CharArray()
        {
            Anagram testAnagram = new Anagram();
            string word = "noob";
            char[] wordSplit = { 'n', 'o', 'o', 'b' };
            CollectionAssert.AreEqual(wordSplit, testAnagram.CharactersInWord(word));
        }

        [TestMethod]
        public void AddWordToMatch_AddsWordsToMatchList_String()
        {
            Anagram testAnagram = new Anagram();
            string word = "gandalf";
            char[] splitWord = word.ToCharArray();
            bool matchFlag = true;
            testAnagram.AddWordToMatch(matchFlag, splitWord);
            Assert.AreEqual(word, testAnagram.GetWordMatches()[0]);
        }
    }
}
