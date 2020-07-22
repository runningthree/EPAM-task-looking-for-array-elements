using NUnit.Framework;

#pragma warning disable CA1707

namespace LookingForArrayElements.Tests
{
    [TestFixture]
    public sealed class DecimalCounterTests
    {
        private static readonly decimal[] ArrayWithFiveElements = { 0.1m, 0.2m, 0.3m, 0.4m, 0.5m };

        // TODO Add more test cases

        [Test]
        public void DecimalCounter_FiveElementsOneRange_ReturnsResult()
        {
            // Arrange
            decimal[][] ranges =
            {
                new[] { 0.1m, 0.2m },
            };

            // Act
            int actualResult = DecimalCounter.GetDecimalsCount(DecimalCounterTests.ArrayWithFiveElements, ranges);

            // Assert
            Assert.AreEqual(2, actualResult);
        }

        [Test]
        public void DecimalCounter_FiveElementsTwoRanges_ReturnsResult()
        {
            // Arrange
            decimal[][] ranges =
            {
                new[] { 0.1m, 0.2m },
                new[] { 0.4m, 0.5m },
            };

            // Act
            int actualResult = DecimalCounter.GetDecimalsCount(DecimalCounterTests.ArrayWithFiveElements, ranges);

            // Assert
            Assert.AreEqual(4, actualResult);
        }

        [TestCase(0, 5, ExpectedResult = 4)]
        [TestCase(0, 2, ExpectedResult = 2)]
        [TestCase(2, 3, ExpectedResult = 0)]
        public int DecimalCounter_FiveElementsOneRange_ReturnsResult(int startIndex, int count)
        {
            // Arrange
            decimal[][] ranges =
            {
                new[] { 0.1m, 0.2m },
            };

            // Act
            return DecimalCounter.GetDecimalsCount(DecimalCounterTests.ArrayWithFiveElements, ranges, startIndex, count);
        }

        [TestCase(0, 5, ExpectedResult = 4)]
        [TestCase(0, 2, ExpectedResult = 2)]
        [TestCase(2, 3, ExpectedResult = 2)]
        [TestCase(2, 1, ExpectedResult = 0)]
        public int DecimalCounter_FiveElementsTwoRanges_ReturnsResult(int startIndex, int count)
        {
            // Arrange
            decimal[][] ranges =
            {
                new[] { 0.1m, 0.2m },
                new[] { 0.4m, 0.5m },
            };

            // Act
            return DecimalCounter.GetDecimalsCount(DecimalCounterTests.ArrayWithFiveElements, ranges, startIndex, count);
        }
    }
}
