using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace WebApiSgsElavon.Dtos.Servicios
{
    public class ServiciosDtos
    {
        [JsonPropertyName("ID_SERVICIO")]
        public int IdServicio { get; set; }
        [JsonPropertyName("DESC_SERVICIO")]
        public string DescServicio { get; set; }
        [JsonPropertyName("IdARNeedNOcheckup")]
        public int IdARNeedNOcheckup { get; set; }
    }
}
