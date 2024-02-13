using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace WebApiSgsElavon.Dtos.Softwares
{
    public class SoftwaresDtos
    {
        [JsonPropertyName("ID_APLICATIVO")]
        public int IdAplicativo { get; set; }
        [JsonPropertyName("DESC_APLICATIVO")]
        public string DescAplicativo { get; set; }
    }
}
