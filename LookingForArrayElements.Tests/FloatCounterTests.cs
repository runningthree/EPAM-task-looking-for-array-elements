using NUnit.Framework;

#pragma warning disable CA1707

namespace LookingForArrayElements.Tests
{
    [TestFixture]
    public sealed class FloatCounterTests
    {
        // TODO Add more unit tests with ArgumentNullException

        [TestCase(new[] { 0.1f }, new[] { 0.1f }, new[] { 0.1f }, ExpectedResult = 1)]
        [TestCase(new[] { 0.1f, 0.2f, 0.3f, 0.4f, 0.5f, 0.6f, 0.7f, 0.8f, 0.9f }, new[] { 0.4f }, new[] { 0.6f }, ExpectedResult = 3)]
        [TestCase(new[] { 0.1f, 0.2f, 0.3f, 0.4f, 0.5f, 0.6f, 0.7f, 0.8f, 0.9f }, new[] { 0.1f, 0.8f }, new[] { 0.2f, 0.9f }, ExpectedResult = 4)]
        [TestCase(new[] { 0.1f, 0.2f, 0.3f, 0.4f, 0.5f, 0.6f, 0.7f, 0.8f, 0.9f }, new[] { 0.1f, 0.5f, 09f }, new[] { 0.1f, 0.5f, 0.9f }, ExpectedResult = 3)]
        // TODO Add more unit tests
        public static float GetFloatsCount_ParametersAreValid_ReturnsResult(float[] arrayToSearch, float[] rangeStart, float[] rangeEnd)
        {
            // Act
            return FloatCounter.GetFloatsCount(arrayToSearch, rangeStart, rangeEnd);
        }

        // TODO Add more unit tests with ArgumentNullException

        [TestCase(new[] { 0.1f, 0.2f, 0.3f, 0.4f, 0.5f, 0.6f, 0.7f, 0.8f, 0.9f }, new[] { 0.4f }, new[] { 0.6f }, 0, 9, ExpectedResult = 3)]
        [TestCase(new[] { 0.1f, 0.2f, 0.3f, 0.4f, 0.5f, 0.6f, 0.7f, 0.8f, 0.9f }, new[] { 0.4f }, new[] { 0.6f }, 4, 1, ExpectedResult = 1)]
        [TestCase(new[] { 0.1f, 0.2f, 0.3f, 0.4f, 0.5f, 0.6f, 0.7f, 0.8f, 0.9f }, new[] { 0.1f, 0.7f }, new[] { 0.3f, 0.9f }, 2, 5, ExpectedResult = 2)]
        // TODO Add more unit tests
        public static int GetFloatsCount_ParametersAreValid_ReturnsResult(float[] arrayToSearch, float[] rangeStart, float[] rangeEnd, int startIndex, int count)
        {
            // Act
            return FloatCounter.GetFloatsCount(arrayToSearch, rangeStart, rangeEnd, startIndex, count);
        }
    }
}
