using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Entities.Requests
{
    public class UpdateCoordenadasRequest
    {
        [JsonProperty(PropertyName = "ID_NEGOCIO")]
        public int ID_NEGOCIO { get; set; }
        [JsonProperty(PropertyName = "ID_AR")]
        public int ID_AR { get; set; }
        [JsonProperty(PropertyName = "ID_USUARIO")]
        public int ID_USUARIO { get; set; }
        [JsonProperty(PropertyName = "LATITUD")]
        public decimal LATITUD { get; set; }
        [JsonProperty(PropertyName = "LONGITUD")]
        public decimal LONGITUD { get; set; }
    }
}
