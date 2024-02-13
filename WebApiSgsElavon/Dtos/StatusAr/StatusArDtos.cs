using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace WebApiSgsElavon.Dtos.StatusAr
{
    public class StatusArDtos
    {
        [JsonPropertyName("ID_STATUS_AR")]
        public int IdStatusAr { get; set; }
        [JsonPropertyName("DESC_STATUS_AR")]
        public string DescStatusAr { get; set; }
    }
}
