using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WaniKaniApi.Models.Filters;
using Xunit;

namespace WaniKaniApi.Tests.Models.Filters
{
    public class LevelProgressionsFilterTests
    {
        [Fact]
        public void DefaultQueryStringEmpty()
        {
            var filter = new LevelProgressionsFilter();
            var queryString = filter.BuildQueryString();
            Assert.Equal(string.Empty, queryString);
        }

        [Fact]
        public void IdsAreSerialized()
        {
            var filter = new LevelProgressionsFilter();
            filter.Ids = new int[] { 10, 18, 35 };
            var queryString = filter.BuildQueryString();
            Assert.Equal("?ids=10,18,35", queryString);
        }

        [Fact]
        public void BothPropertiesSerialize()
        {
            var filter = new LevelProgressionsFilter
            {
                Ids = new int[] { 32, 43, 789 },
                UpdatedAfter = new DateTimeOffset(2020, 2, 1, 23, 12, 19, TimeSpan.Zero)
            };
            var queryString = filter.BuildQueryString();
            Assert.StartsWith("?", queryString);
            Assert.Contains("ids=32,43,789", queryString);
            Assert.Contains("updated_after=2020-02-01T23:12:19.000000", queryString);
        }
    }
}
