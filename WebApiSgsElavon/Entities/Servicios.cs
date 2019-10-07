using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Entities
{
    public class Servicios
    {
        [JsonProperty(PropertyName = "ID_SERVICIO")]
        public int ID_SERVICIO { get; set; }
        [JsonProperty(PropertyName = "DESC_SERVICIO")]
        public string DESC_SERVICIO { get; set; }
    }
}
