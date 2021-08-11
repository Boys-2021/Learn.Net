using System.Text.Json.Serialization;

namespace RolePlay.Models
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Role
    {
        King,
        Queen
    }
}