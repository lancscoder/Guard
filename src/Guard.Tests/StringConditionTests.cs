using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LancsCoder.Guard.Tests
{
    public class StringConditionTests
    {
        [Fact]
        public void IsNotNullOrEmptyWhiteSpace_Should_Throw_Exception_When_Object_Is_Null()
        {
            // Arrange
            const string objectUnderTest = null;

            // Act
            Assert.Throws<NullReferenceException>(() => Guard.For(objectUnderTest).IsNotNullOrEmptyWhiteSpace());
        }

        [Fact]
        public void IsNotNullOrEmptyWhiteSpace_Should_Throw_Exception_When_Object_Is_White_Space()
        {
            // Arrange
            string objectUnderTest = "   ";

            // Act
            Assert.Throws<NullReferenceException>(() => Guard.For(objectUnderTest).IsNotNullOrEmptyWhiteSpace());
        }

        [Fact]
        public void IsNotNullOrEmptyWhiteSpace_Should_Pass_When_Object_Is_Not_Null_Or_Empty_Or_White_Space()
        {
            // Act
            string objectUnderTest = "ABC";

            // Act
            Guard.For(objectUnderTest).IsNotNullOrEmptyWhiteSpace();

            // Assert
            Assert.True(true, "Test Passes");
        }

        [Fact]
        public void Chaining()
        {
            // Act
            string objectUnderTest = "ABC";

            // Act
            Guard.For(objectUnderTest)
                .IsNotNullOrEmptyWhiteSpace()
                .IsGreaterThan("abc")
                .IsEqualTo("ABC")
                .IsLessThan("DEF");

            // Assert
            Assert.True(true, "Test Passes");
        }
    }
}
