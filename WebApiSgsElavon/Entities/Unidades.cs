using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Entities
{
    public class Unidades
    {
        [JsonProperty(PropertyName = "ID_UNIDAD")]
        public int ID_UNIDAD { get; set; }
        [JsonProperty(PropertyName = "NO_SERIE")]
        public string NO_SERIE { get; set; }
        [JsonProperty(PropertyName = "ID_MARCA")]
        public int? ID_MARCA { get; set; }
        [JsonProperty(PropertyName = "ID_MODELO")]
        public int? ID_MODELO { get; set; }
        [JsonProperty(PropertyName = "ID_CONECTIVIDAD")]
        public int? ID_CONECTIVIDAD { get; set; }
        [JsonProperty(PropertyName = "ID_APLICATIVO")]
        public int? ID_APLICATIVO { get; set; }
    }
}
