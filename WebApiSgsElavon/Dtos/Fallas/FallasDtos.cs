using Newtonsoft.Json;

namespace WebApiSgsElavon.Dtos.Fallas
{
    public class FallasDtos
    {
        [JsonProperty("ID_FALLA")]
        public int IdFalla { get; set; }
        [JsonProperty("DESC_FALLA")]
        public string DescFalla { get; set; }
    }
}
