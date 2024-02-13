using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace WebApiSgsElavon.Dtos.Modelos
{
    public class ModelosDtos
    {
        [JsonPropertyName("ID_MODELO")]
        public int IdModelo { get; set; }
        [JsonPropertyName("DESC_MODELO")]
        public string DescModelo { get; set; }
        [JsonPropertyName("ID_MARCA")]
        public int IdMarca { get; set; }
        [JsonPropertyName("ID_ACCESS")]
        public int? IdAccess { get; set; }
    }
}
