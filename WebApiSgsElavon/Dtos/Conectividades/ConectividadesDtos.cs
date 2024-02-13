using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Dtos.Conectividades
{
    public class ConectividadesDtos
    {
        [JsonPropertyName("ID_CONECTIVIDAD")]
        public int IdConectividad { get; set; }
        [JsonPropertyName("DESC_CONECTIVIDAD")]
        public string DescConectividad { get; set; }
        [JsonPropertyName("IS_GPRS")]
        public int IsGprs { get; set; }
    }
}
