using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Entities
{
    public class Subrechazos
    {
        [JsonProperty(PropertyName = "ID_SUBRECHAZO")]
        public int ID_SUBRECHAZO { get; set; }
        [JsonProperty(PropertyName = "SUBRECHAZO")]
        public string SUBRECHAZO { get; set; }
        [JsonProperty(PropertyName = "ID")]
        public int ID { get; set; }
        [JsonProperty(PropertyName = "IS_PROGRAMADO")]
        public int IS_PROGRAMADO { get; set; }
    }
}
