using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Dtos.Conectividades
{
    public class ConectividadesDtos
    {
        [JsonProperty("ID_CONECTIVIDAD")]
        public int IdConectividad { get; set; }
        [JsonProperty("DESC_CONECTIVIDAD")]
        public string DescConectividad { get; set; }
        [JsonProperty("IS_GPRS")]
        public int IsGprs { get; set; }
    }
}
