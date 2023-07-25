using System;
using Xunit;
using CollatzChallengeImplementation;

namespace CollatzChallengeTests
{
    public class CollatzConjectureTests
    {
        [Fact]
        public void TestPositiveNumber()
        {
            // Arrange
            int number = 20;
            int expectedSteps = 7;

            // Act
            int actualSteps = CollatzChallengeImplementation.CollatzConjecture.CountStepsToOne(number);

            // Assert
            Assert.Equal(expectedSteps, actualSteps);
        }

        [Fact]
        public void TestZero()
        {
            // Arrange
            int number = 0;

            // Act and Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => CollatzChallengeImplementation.CollatzConjecture.CountStepsToOne(number));
        }

        [Fact]
        public void TestNegativeNumber()
        {
            // Arrange
            int number = -10;

            // Act and Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => CollatzChallengeImplementation.CollatzConjecture.CountStepsToOne(number));
        }

        [Fact]
        public void TestOne()
        {
            int number = 1;
            int expectedSteps = 0;

            int actualSteps = CollatzChallengeImplementation.CollatzConjecture.CountStepsToOne(number);

            Assert.Equal(expectedSteps, actualSteps);
        }

        [Fact]
        public void TestSmallNumber()
        {
            int number = 2;
            int expectedSteps = 1;

            int actualSteps = CollatzChallengeImplementation.CollatzConjecture.CountStepsToOne(number);

            Assert.Equal(expectedSteps, actualSteps);
        }

        [Fact]
        public void TestLargeNumber()
        {
            int number = 1000000;
            // This value is known from the problem, it is not recommended to hardcode expected results
            int expectedSteps = 152;

            int actualSteps = CollatzChallengeImplementation.CollatzConjecture.CountStepsToOne(number);

            Assert.Equal(expectedSteps, actualSteps);
        }
    }
}
