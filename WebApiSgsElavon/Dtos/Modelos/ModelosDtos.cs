using Newtonsoft.Json;

namespace WebApiSgsElavon.Dtos.Modelos
{
    public class ModelosDtos
    {
        [JsonProperty("ID_MODELO")]
        public int IdModelo { get; set; }
        [JsonProperty("DESC_MODELO")]
        public string DescModelo { get; set; }
        [JsonProperty("ID_MARCA")]
        public int IdMarca { get; set; }
    }
}
