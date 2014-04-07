using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LancsCoder.Guard.Tests
{
    public class ConditionsNullTests
    {
        [Fact]
        public void IsNotNull_Should_Throw_Exception_When_Object_Is_Null()
        {
            // Arrange
            const object objectUnderTest = null;

            // Act
            Assert.Throws<NullReferenceException>(() => Guard.For(objectUnderTest).IsNotNull());
        }

        [Fact]
        public void IsNotNull_Should_Pass_When_Object_Is_Not_Null()
        {
            // Act
            object objectUnderTest = new object();

            // Act
            Guard.For(objectUnderTest).IsNotNull();

            // Assert
            Assert.True(true, "Test Passes");
        }
    }
}
