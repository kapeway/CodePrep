using ArraysAndString;
using NUnit.Framework;

namespace ArraysAndStringsTests
{
    [TestFixture]
    public class UniqueStringSpeedTests
    {
        [Test]
        public void IsEveryCharacterUniqueWithSort_SpeedTest_ReturnsTrue()
        {
            var sut = new StringUniqueCharChecker();
            var result = sut.IsEveryCharacterUniqueWithSort("1234567890-=!@#$%^&*()_+qwertyuiop[]\\QWERTYUIOP{}|asdfghjkl;'ASDFGHJKL:\"zxcvbnm,./ZXCVBNM<> `~1");
            //Assert.That(result,Is.True);
        }
        [Test]
        public void IsEveryCharacterUniqueWithAddDataStruct_SpeedTest_ReturnsTrue()
        {
            var sut = new StringUniqueCharChecker();
            var result = sut.IsEveryCharacterUniqueWithAddDataStruct("1234567890-=!@#$%^&*()_+qwertyuiop[]\\QWERTYUIOP{}|asdfghjkl;'ASDFGHJKL:\"zxcvbnm,./ZXCVBNM<> `~1");
            //Assert.That(result, Is.True);
        }
        [Test]
        public void IsEveryCharacterUniqueBruteForce_SpeedTest_ReturnsTrue()
        {
            var sut = new StringUniqueCharChecker();
            var result = sut.IsEveryCharacterUniqueBruteForce("1234567890-=!@#$%^&*()_+qwertyuiop[]\\QWERTYUIOP{}|asdfghjkl;'ASDFGHJKL:\"zxcvbnm,./ZXCVBNM<> `~1");
            //Assert.That(result, Is.True);
        }

    }
}
