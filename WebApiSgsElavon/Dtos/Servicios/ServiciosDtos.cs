using Newtonsoft.Json;

namespace WebApiSgsElavon.Dtos.Servicios
{
    public class ServiciosDtos
    {
        [JsonProperty("ID_SERVICIO")]
        public int IdServicio { get; set; }
        [JsonProperty("DESC_SERVICIO")]
        public string DescServicio { get; set; }
        [JsonProperty("IdARNeedNOcheckup")]
        public int IdARNeedNOcheckup { get; set; }
    }
}
