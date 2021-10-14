using Newtonsoft.Json;

namespace WebApiSgsElavon.Dtos.Subrechazos
{
    public class SubrechazosDtos
    {
        [JsonProperty("ID_SUBRECHAZO")]
        public int IdSubrechazo { get; set; }
        [JsonProperty("SUBRECHAZO")]
        public string Subrechazo { get; set; }
        [JsonProperty("ID")]
        public int Id { get; set; }
        [JsonProperty("IS_PROGRAMADO")]
        public int IsProgramado { get; set; }
    }
}
