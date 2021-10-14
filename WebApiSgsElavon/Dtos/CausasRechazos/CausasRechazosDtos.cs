using Newtonsoft.Json;

namespace WebApiSgsElavon.Dtos.CausasRechazos
{
    public class CausasRechazosDtos
    {
        [JsonProperty("ID_CAUSA_RECHAZO")]
        public int IdCausaRechazo { get; set; }
        [JsonProperty("DESC_CAUSA_RECHAZO")]
        public string DescCausaRechazo { get; set; }
        [JsonProperty("ID_TRECHAZO")]
        public int IdTrechazo { get; set; }
    }
}
