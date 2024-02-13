using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace WebApiSgsElavon.Dtos.CausasRechazos
{
    public class CausasRechazosDtos
    {
        [JsonPropertyName("ID_CAUSA_RECHAZO")]
        public int IdCausaRechazo { get; set; }
        [JsonPropertyName("DESC_CAUSA_RECHAZO")]
        public string DescCausaRechazo { get; set; }
        [JsonPropertyName("ID_TRECHAZO")]
        public int IdTrechazo { get; set; }
    }
}
