using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LancsCoder.Guard.Tests
{
    public class ConditionsComparablesTests
    {
        [Fact]
        public void IsGreaterThan_Should_Throw_Exception_When_Int_Less_Than_Requirement()
        {
            // Arrange
            const int objectUnderTest = 4;
            
            // Act
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.For(objectUnderTest).IsGreaterThan(5));
        }

        [Fact]
        public void IsGreaterThan_Should_Throw_Exception_When_In_Equal_To_Requirement()
        {
            // Arrange
            const int objectUnderTest = 5;

            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.For(objectUnderTest).IsGreaterThan(5));
        }

        [Fact]
        public void IsGreaterThan_Should_Pass_When_Int_Value_Is_Greater_Than_Requirement()
        {
            // Act
            const int objectUnderTest = 6;

            // Act
            Guard.For(objectUnderTest).IsGreaterThan(5);

            // Assert
            Assert.True(true, "Test Passes");
        }

        [Fact]
        public void IsGreaterThanOrEqualTo_Should_Throw_Exception_When_Int_Less_Than_Requirement()
        {
            // Arrange
            const int objectUnderTest = 4;

            // Act
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.For(objectUnderTest).IsGreaterThanOrEqualTo(5));
        }

        [Fact]
        public void IsGreaterThanOrEqualTo_Should_Pass_When_Int_Value_Is_Equal_To_Requirement()
        {
            // Arrange
            const int objectUnderTest = 5;

            // Act
            Guard.For(objectUnderTest).IsGreaterThanOrEqualTo(5);

            // Assert
            Assert.True(true, "Test Passes");
        }

        [Fact]
        public void IsGreaterThanOrEqualTo_Should_Pass_When_Int_Value_Is_Greater_Than_Requirement()
        {
            // Arrange
            const int objectUnderTest = 6;

            // Act
            Guard.For(objectUnderTest).IsGreaterThanOrEqualTo(5);

            // Assert
            Assert.True(true, "Test Passes");
        }

        [Fact]
        public void IsLessThan_Should_Throw_Exception_When_Int_Greater_Than_Requirement()
        {
            // Arrange
            const int objectUnderTest = 6;

            // Act
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.For(objectUnderTest).IsLessThan(5));
        }

        [Fact]
        public void IsLassThan_Should_Throw_Exception_When_In_Equal_To_Requirement()
        {
            // Arrange
            const int objectUnderTest = 5;

            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.For(objectUnderTest).IsLessThan(5));
        }

        [Fact]
        public void IsLessThan_Should_Pass_When_Int_Value_Is_Less_Than_Requirement()
        {
            // Act
            const int objectUnderTest = 4;

            // Act
            Guard.For(objectUnderTest).IsLessThan(5);

            // Assert
            Assert.True(true, "Test Passes");
        }

        [Fact]
        public void IsLessThanOrEqualTo_Should_Throw_Exception_When_Int_Greater_Than_Requirement()
        {
            // Arrange
            const int objectUnderTest = 5;

            // Act
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.For(objectUnderTest).IsLessThanOrEqualTo(4));
        }

        [Fact]
        public void IsLessThanOrEqualTo_Should_Pass_When_Int_Value_Is_Equal_To_Requirement()
        {
            // Arrange
            const int objectUnderTest = 5;

            // Act
            Guard.For(objectUnderTest).IsLessThanOrEqualTo(5);

            // Assert
            Assert.True(true, "Test Passes");
        }

        [Fact]
        public void IsLessThanOrEqualTo_Should_Pass_When_Int_Value_Is_Less_Than_Requirement()
        {
            // Arrange
            const int objectUnderTest = 4;

            // Act
            Guard.For(objectUnderTest).IsLessThanOrEqualTo(5);

            // Assert
            Assert.True(true, "Test Passes");
        }

        [Fact]
        public void IsEqualTo_Should_Throw_Exception_When_Int_Value_Is_Not_The_Same_As_The_Requirement()
        {
            // Arrange
            const int objectUnderTest = 5;

            // Act
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.For(objectUnderTest).IsEqualTo(4));
        }

        [Fact]
        public void IsEqualTo_Should_Pass_When_Int_Value_Is_Equal_To_Requirement()
        {
            // Arrange
            const int objectUnderTest = 5;

            // Act
            Guard.For(objectUnderTest).IsEqualTo(5);

            // Assert
            Assert.True(true, "Test Passes");
        }

        [Fact]
        public void IsNotEqualTo_Should_Throw_Exception_When_Int_Value_Is_The_Same_As_The_Requirement()
        {
            // Arrange
            const int objectUnderTest = 5;

            // Act
            Assert.Throws<ArgumentOutOfRangeException>(() => Guard.For(objectUnderTest).IsNotEqualTo(5));
        }

        [Fact]
        public void IsEqualTo_Should_Pass_When_Int_Value_Is_NotEqual_To_Requirement()
        {
            // Arrange
            const int objectUnderTest = 5;

            // Act
            Guard.For(objectUnderTest).IsNotEqualTo(4);

            // Assert
            Assert.True(true, "Test Passes");
        }
    }

}
