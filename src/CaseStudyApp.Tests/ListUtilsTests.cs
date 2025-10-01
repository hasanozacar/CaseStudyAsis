using System;
using System.Collections.Generic;
using CaseStudyApp.Utils;
using Xunit;

namespace CaseStudyApp.Tests
{
    public class ListUtilsTests
    {
        [Fact]
        public void GetMax_ReturnsMaxValue()
        {
            var list = new List<int> {1, 5, 3};
            Assert.Equal(5, ListUtils.GetMax(list));
        }

        [Fact]
        public void GetMax_EmptyList_ReturnsNull()
        {
            var list = new List<int>();
            Assert.Null(ListUtils.GetMax(list));
        }

        [Fact]
        public void GetMaxOrThrow_EmptyList_ThrowsMaxListEmptyException()
        {
            var list = new List<int>();
            Assert.Throws<MaxListEmptyException>(() => ListUtils.GetMaxOrThrow(list));
        }
    }
}
