using System.Text.Json.Serialization;

namespace dotnet_rpg.Models
{
  [JsonConverter(typeof(JsonStringEnumConverter))]
  public enum RpgClass
  {
    Knight = 1,
    Rogue = 2,
    Mage = 3,
    Cleric = 4
  }
}