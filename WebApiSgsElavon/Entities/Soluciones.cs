using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Entities
{
    public class Soluciones
    {
        [JsonProperty(PropertyName = "ID_SOLUCION")]
        public int ID_CAUSA_CANCELACION { get; set; }
        [JsonProperty(PropertyName = "DESC_SOLUCION")]
        public string DESC_CAUSA { get; set; }
    }
}
