using System.Text.Json.Serialization;

namespace IllusionPackageCore;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum GameToken
{
    None = 0,
    Koikatsu = 1,
}
