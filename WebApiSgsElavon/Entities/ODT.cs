using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Entities
{
    public class ODT
    {
        [JsonProperty(PropertyName = "ID_AR")]
        public int ID_AR { get; set; }
        [JsonProperty(PropertyName = "NO_AR")]
        public string NO_ODT { get; set; }
        [JsonProperty(PropertyName = "NEGOCIO")]        
        public string NEGOCIO { get; set; }
        [JsonProperty(PropertyName = "NO_AFILIACION")]
        public string NO_AFILIACION { get; set; }
        [JsonProperty(PropertyName = "ESTADO")]
        public string ESTADO { get; set; }
        [JsonProperty(PropertyName = "COLONIA")]
        public string COLONIA { get; set; }
        [JsonProperty(PropertyName = "FEC_GARANTIA")]
        public string FEC_GARANTIA { get; set; }
    }
}
