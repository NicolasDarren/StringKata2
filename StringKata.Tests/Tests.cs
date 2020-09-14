using NUnit.Framework;

namespace StringKata.Tests
{
    [TestFixture]
    public class Tests
    {
        private Kata GetSUT()
        {
            return new Kata();
        }

        [Test]
        public void Add_GivenEmptyString_ShouldReturnZero()
        {
            // Arrange
            var input = string.Empty;
            var expectedResult = 0;

            // Act
            var actualResult = GetSUT().Add(input);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Add_GivenOneNumber_ShouldReturnSameNumber()
        {
            // Arrange
            var input = "1";
            var expectedResult = 1;

            // Act
            var actualResult = GetSUT().Add(input);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
