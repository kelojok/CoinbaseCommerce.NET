using System.Text.Json;
using System.Text.Json.Serialization;

namespace Coinbase.Commerce.Models.Models.Converters;

public class DataListConverter : JsonConverter<List<Data>>
{
    public override List<Data>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions? options)
    {
        return reader.TokenType == JsonTokenType.Null
            ? null
            : JsonSerializer.Deserialize<List<Data>>(ref reader, options);
    }

    public override void Write(Utf8JsonWriter writer, List<Data> value, JsonSerializerOptions options)
    {
        JsonSerializer.Serialize(writer, value, options);
    }
}