using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace WebApiSgsElavon.Dtos.Fallas
{
    public class FallasDtos
    {
        [JsonPropertyName("ID_FALLA")]
        public int IdFalla { get; set; }
        [JsonPropertyName("DESC_FALLA")]
        public string DescFalla { get; set; }
    }
}
