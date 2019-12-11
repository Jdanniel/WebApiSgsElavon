using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Entities
{
    public class Fallas
    {
        [JsonProperty(PropertyName = "ID_FALLA")]
        public int ID_FALLA { get; set; }
        [JsonProperty(PropertyName = "DESC_FALLA")]
        public string DESC_FALLA { get; set; }
    }
}
