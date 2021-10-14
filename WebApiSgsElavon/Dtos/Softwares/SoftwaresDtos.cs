using Newtonsoft.Json;

namespace WebApiSgsElavon.Dtos.Softwares
{
    public class SoftwaresDtos
    {
        [JsonProperty("ID_APLICATIVO")]
        public int IdAplicativo { get; set; }
        [JsonProperty("DESC_APLICATIVO")]
        public string DescAplicativo { get; set; }
    }
}
