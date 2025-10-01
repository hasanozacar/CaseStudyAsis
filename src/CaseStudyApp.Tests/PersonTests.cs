using System;
using CaseStudyApp.Models;
using Xunit;

namespace CaseStudyApp.Tests
{
    public class PersonTests
    {
        [Fact]
        public void Introduce_ReturnsExpectedString()
        {
            var p = new Person("Ali", 30);
            var result = p.Introduce();
            Assert.Equal("Merhaba, benim adım Ali ve 30 yaşındayım.", result);
        }

        [Fact]
        public void Constructor_NullName_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new Person(null!, 25));
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(-100)]
        [InlineData(151)]
        [InlineData(1000)]
        public void Constructor_InvalidAge_ThrowsArgumentOutOfRangeException(int invalidAge)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Person("Test", invalidAge));
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(150)]
        [InlineData(30)]
        public void Constructor_ValidAge_DoesNotThrow(int validAge)
        {
            var ex = Record.Exception(() => new Person("Test", validAge));
            Assert.Null(ex);
        }
    }
}
