using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using WordGame;

namespace WordGame.Tests
{
    [TestClass]
    public class AnagramTest
    {
        [TestMethod]
        public void GetSetUserWords_GetsSetsUserWords_StringList()
        {
            Anagram testAnagram = new Anagram();
            string word = "test";
            testAnagram.SetUserWords(word);
            Assert.AreEqual(word, testAnagram.GetUserWords()[0]);
        }
    }
}
