using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Entities
{
    public class BdModelosConectividades
    {
        [JsonProperty(PropertyName = "ID_MODELO_CONECTIVIDAD")]
        public int ID_MODELO_CONECTIVIDAD { get; set; }
        [JsonProperty(PropertyName = "ID_MODELO")]
        public int ID_MODELO { get; set; }
        [JsonProperty(PropertyName = "ID_CONECTIVIDAD")]
        public int ID_CONECTIVIDAD { get; set; }
    }
}
