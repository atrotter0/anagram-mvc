using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordGame.Models;

namespace WordGame.Tests
{
    [TestClass]
    public class AnagramTest
    {
        [TestMethod]
        public void GetSetBaseWord_GetsSetsBaseWord_String()
        {
            Anagram newGame = new Anagram();
            newGame.SetBaseWord("noob");
            Assert.AreEqual("noob", newGame.GetBaseWord());
        }

        [TestMethod]
        public void GetSetWordList_GetsSetsWordList_String()
        {
            Anagram newGame = new Anagram();
            newGame.SetWordList("This is a word list.");
            Assert.AreEqual("this is a word list", newGame.GetWordList());
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
        public void GetSetSameLetters_SameLettersTrue_False()
        {
            Anagram testAnagram = new Anagram();
            testAnagram.SameLettersFalse();
            Assert.AreEqual(false, testAnagram.GetSameLetters());
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
        public void FindAnagram_FindsAnAnagramInListOfWords_List()
        {
            Anagram newGame = new Anagram();
            newGame.SetBaseWord("red");
            newGame.SetWordList("der red, edr dfsj dew red$%");
            newGame.FindAnagram();
            List<string> expectedResult = new List<string> { "der", "red", "edr", "red" };
            CollectionAssert.AreEqual(expectedResult, newGame.GetWordMatches());
        }
    }
}
