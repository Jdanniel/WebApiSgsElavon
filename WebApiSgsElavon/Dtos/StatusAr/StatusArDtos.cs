using Newtonsoft.Json;

namespace WebApiSgsElavon.Dtos.StatusAr
{
    public class StatusArDtos
    {
        [JsonProperty("ID_STATUS_AR")]
        public int IdStatusAr { get; set; }
        [JsonProperty("DESC_STATUS_AR")]
        public string DescStatusAr { get; set; }
    }
}
