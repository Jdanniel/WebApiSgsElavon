using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Entities
{
    public class Causas
    {
        [JsonProperty(PropertyName = "ID_CAUSA")]
        public int ID_CAUSA { get; set; }
        [JsonProperty(PropertyName = "DESC_CAUSA")]
        public string DESC_CAUSA { get; set; }
        [JsonProperty(PropertyName = "DESCRIPCION")]
        public string DESCRIPCION { get; set; }
    }
}
