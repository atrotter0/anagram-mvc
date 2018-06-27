using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
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
        public void GetIncrementCharCounter_GetsIncrementsWordCounter_Int()
        {
            Anagram testAnagram = new Anagram();
            testAnagram.IncrementCounter();
            Assert.AreEqual(1, testAnagram.GetCounter());
        }

        [TestMethod]
        public void GetSetSameLetters_SameLettersTrue_True()
        {
            Anagram testAnagram = new Anagram();
            testAnagram.SameLettersTrue();
            Assert.AreEqual(true, testAnagram.GetSameLetters());
        }

        [TestMethod]
        public void GetSetWordToCompare_SetsWordToCompare_String()
        {
            Anagram testAnagram = new Anagram();
            string word = "test";
            testAnagram.SetWordToCompare(word);
            Assert.AreEqual(word, testAnagram.GetWordToCompare());
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
        public void AddAnagram_AddsWordsToMatchList_String()
        {
            Anagram testAnagram = new Anagram();
            string word = "gandalf";
            testAnagram.SetWordToCompare(word);
            testAnagram.SameLettersTrue();
            testAnagram.AddAnagram();
            Assert.AreEqual(word, testAnagram.GetWordMatches()[0]);
        }

        [TestMethod]
        public void CheckLettersAreEqual_TestEachLetterIsEqual_True()
        {
            Anagram testAnagram = new Anagram();
            char letterOne = 'f';
            char letterTwo = 'f';
            testAnagram.CheckLettersAreEqual(letterOne, letterTwo);
            Assert.AreEqual(true, testAnagram.GetSameLetters());
        }

        [TestMethod]
        public void SortAndReturnWord_CharsAreSortedAndReturned_CharArray()
        {
            Anagram testAnagram = new Anagram();
            string word = "frodo";
            char[] splitWord = word.ToCharArray();
            Array.Sort(splitWord);
            CollectionAssert.AreEqual(splitWord, testAnagram.SortAndReturnChars(word));
        }

        [TestMethod]
        public void CheckForAnagram_AddAnagramToMatchList_List()
        {
            //fix this test
            Anagram testAnagram = new Anagram();
            testAnagram.SetUserWords("bread");
            testAnagram.SetUserWords("beard");
            testAnagram.SetUserWords("kiwi");
            testAnagram.CheckForAnagram();
            Assert.AreEqual(testAnagram.GetUserWords()[1], testAnagram.GetWordMatches()[0]);
        }
    }
}
