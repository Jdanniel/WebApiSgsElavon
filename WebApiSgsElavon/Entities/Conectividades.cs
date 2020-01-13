using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Entities
{
    public class Conectividades
    {
        [JsonProperty(PropertyName = "ID_CONECTIVIDAD")]
        public int ID_CONECTIVIDAD { get; set; }
        [JsonProperty(PropertyName = "DESC_CONECTIVIDAD")]
        public string DESC_CONECTIVIDAD { get; set; }
        [JsonProperty(PropertyName = "IS_GPRS")]
        public int IS_GPRS { get; set; }
    }
}
