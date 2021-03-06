﻿using ArraysAndString;
using NUnit.Framework;

namespace ArraysAndStringsTests
{
    [TestFixture]
    public class UniqueStringWithoutAdditionalDataStructureBruteForceTests
    {
        [Test]
        public void IsEveryCharacterUnique_GivenMoreThan256Char_ReturnsFalse()
        {
            var sut = new StringUniqueCharChecker();
            var result = sut.IsEveryCharacterUniqueBruteForce("01234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789012345678901234567890123456789");
            Assert.That(result,Is.False);
        }

        [TestCase("0123456789")]
        [TestCase("asd")]
        public void IsEveryCharacterUnique_GivenlessThan256Char_ReturnsTrue(string stringToCheck)
        {
            var sut = new StringUniqueCharChecker();
            var result = sut.IsEveryCharacterUniqueBruteForce(stringToCheck);
            Assert.That(result, Is.True);
        }

        [TestCase("01234567890")]
        [TestCase("abcgefghijklmnopqrstuvwxyza")]
        [TestCase("")]
        [TestCase("aab")]
        public void IsEveryCharacterUnique_GivenLessThan256CharNotUniqueChar_ReturnsFalse(string stringToCheck)
        {
            var sut = new StringUniqueCharChecker();
            var result = sut.IsEveryCharacterUniqueBruteForce(stringToCheck);
            Assert.That(result, Is.False);
        }

    }
}
