using NUnit.Framework;

#pragma warning disable CA1707

namespace LookingForArrayElements.Tests
{
    [TestFixture]
    public sealed class IntegersCounterTests
    {
        // TODO Add more unit tests with ArgumentNullException

        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new[] { 2, 5, 8 }, ExpectedResult = 3)]
        [TestCase(new[] { 1, 2, 3, 2, 4, 5, 6, 5, 5, 8, 7, 8, 9 }, new[] { 2, 5, 8 }, ExpectedResult = 7)]
        // TODO Add more unit tests
        public int GetIntegersCount_ParametersAreValid_ReturnsResult(int[] arrayToSearch, int[] elementsToSearchFor)
        {
            // Act
            return IntegersCounter.GetIntegersCount(arrayToSearch, elementsToSearchFor);
        }

        // TODO Add more unit tests with ArgumentNullException

        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new[] { 2, 5, 8 }, 0, 9, ExpectedResult = 3)]
        [TestCase(new[] { 1, 2, 3, 2, 4, 5, 6, 5, 5, 8, 7, 8, 9 }, new[] { 2, 5, 8 }, 0, 13, ExpectedResult = 7)]
        [TestCase(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, new[] { 2, 5, 8 }, 2, 5, ExpectedResult = 1)]
        [TestCase(new[] { 1, 2, 3, 2, 4, 5, 6, 5, 5, 8, 7, 8, 9 }, new[] { 2, 5, 8 }, 3, 7, ExpectedResult = 5)]
        // TODO Add more unit tests
        public int GetIntegersCount_ParametersAreValid_ReturnsResult(int[] arrayToSearch, int[] elementsToSearchFor, int startIndex, int count)
        {
            // Act
            return IntegersCounter.GetIntegersCount(arrayToSearch, elementsToSearchFor, startIndex, count);
        }
    }
}
