using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using WaniKaniApi.Models;
using WaniKaniApi.Models.Base;

namespace WaniKaniApi.Json.Converters
{
    public class SubjectResponseConverter : JsonConverter<WkResponse<Subject>>
    {
        public override bool CanConvert(Type type)
        {
            return typeof(WkResponse<Subject>) == type;
        }

        public override WkResponse<Subject> Read(
            ref Utf8JsonReader reader,
            Type typeToConvert,
            JsonSerializerOptions options)
        {
            var document = JsonDocument.ParseValue(ref reader);
            if (!document.RootElement.TryGetProperty("object", out var objectProperty))
            {
                throw new JsonException("Object not formatted properly");

            }
            var objectType = objectProperty.ToString();
            switch (objectType)
            {
                case "kanji":
                    var kanji = JsonSerializer.Deserialize<WkResponse<Kanji>>(document.RootElement.GetRawText());
                    return new WkResponse<Subject>()
                    {
                        Data = kanji.Data,
                        DataUpdatedAt = kanji.DataUpdatedAt,
                        Object = kanji.Object,
                        Url = kanji.Url
                    };
                case "radical":
                    var radical = JsonSerializer.Deserialize<WkResponse<Radical>>(document.RootElement.GetRawText());
                    return new WkResponse<Subject>()
                    {
                        Data = radical.Data,
                        DataUpdatedAt = radical.DataUpdatedAt,
                        Object = radical.Object,
                        Url = radical.Url
                    };
                case "vocabulary":
                    var vocabulary = JsonSerializer.Deserialize<WkResponse<Vocabulary>>(document.RootElement.GetRawText());
                    return new WkResponse<Subject>()
                    {
                        Data = vocabulary.Data,
                        DataUpdatedAt = vocabulary.DataUpdatedAt,
                        Object = vocabulary.Object,
                        Url = vocabulary.Url
                    };
                default:
                    throw new JsonException("Invalid object");
            }
        }

        public override void Write(
            Utf8JsonWriter writer,
            WkResponse<Subject> value,
            JsonSerializerOptions options)
        {
            throw new NotSupportedException();
        }
    }
}
