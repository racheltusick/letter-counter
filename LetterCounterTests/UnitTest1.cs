using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LetterCounterNamespace;

namespace LetterCounterTestsNamespace
{
    [TestClass]
    public class LetterCounterTestsClass
    {
        [TestMethod]
        public void AreTestsWorking()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void SimpleString()
        {
            LetterCounter lc = new LetterCounter();
            CollectionAssert.AreEqual(lc.Count("aaabbc"), new char[] { 'a', 'b', 'c' });
        }

        [TestMethod]
        public void OneCharacterOnce()
        {
            LetterCounter lc = new LetterCounter();
            CollectionAssert.AreEqual(lc.Count("a"), new char[] { 'a' });
        }

        [TestMethod]
        public void OneCharacterMultipleTimes()
        {
            LetterCounter lc = new LetterCounter();
            CollectionAssert.AreEqual(lc.Count("aaa"), new char[] { 'a' });
        }

        [TestMethod]
        public void EmptyString()
        {
            LetterCounter lc = new LetterCounter();
            CollectionAssert.AreEqual(lc.Count(""), new char[] { });
        }

        [TestMethod]
        public void LettersWithSameCountAreAlphabetical()
        {
            LetterCounter lc = new LetterCounter();
            CollectionAssert.AreEqual(lc.Count("cabdpe"), new char[] { 'a', 'b', 'c', 'd', 'e', 'p' });
        }

        [TestMethod]
        public void LargerTest()
        {
            LetterCounter lc = new LetterCounter();
            CollectionAssert.AreEqual(lc.Count("abracadabra"), new char[] { 'a', 'b', 'r', 'c', 'd' });
        }

        [TestMethod]
        public void SentenceTest()
        {
            LetterCounter lc = new LetterCounter();
            CollectionAssert.AreEqual(lc.Count("Happy birthday to you"), new char[] { ' ', 'y','a', 'h', 'o', 'p', 't','b', 'd', 'i', 'r', 'u' });
        }
    }
}
