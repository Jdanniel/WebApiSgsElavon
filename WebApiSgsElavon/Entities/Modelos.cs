using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Entities
{
    public class Modelos
    {
        [JsonProperty(PropertyName = "ID_MODELO")]
        public int ID_MODELO { get; set; }
        [JsonProperty(PropertyName = "DESC_MODELO")]
        public string DESC_MODELO { get; set; }
    }
}
