using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace WebApiSgsElavon.Dtos.Subrechazos
{
    public class SubrechazosDtos
    {
        [JsonPropertyName("ID_SUBRECHAZO")]
        public int IdSubrechazo { get; set; }
        [JsonPropertyName("SUBRECHAZO")]
        public string Subrechazo { get; set; }
        [JsonPropertyName("ID")]
        public int Id { get; set; }
        [JsonPropertyName("IS_PROGRAMADO")]
        public int IsProgramado { get; set; }
    }
}
