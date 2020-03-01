using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using WaniKaniApi.Models;
using Xunit;

namespace WaniKaniApi.Tests.Models.Serialization
{
    public class SrsStageSerializationTests
    {
        [Fact]
        public void FieldsAreSerialized()
        {
            var srsStage = new SrsStage()
            {
                Id = 3,
                Name = "Test srs",
                AcceleratedInterval = 14,
                Interval = 12,
            };
            var serialized = JsonSerializer.Serialize(srsStage);
            var deserialized = JsonSerializer.Deserialize<SrsStage>(serialized);
            Assert.Equal(srsStage.Id, deserialized.Id);
            Assert.Equal(srsStage.Name, deserialized.Name);
            Assert.Equal(srsStage.AcceleratedInterval, deserialized.AcceleratedInterval);
            Assert.Equal(srsStage.Interval, deserialized.Interval);
        }
    }
}
