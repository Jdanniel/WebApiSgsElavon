using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Entities
{
    public class Software
    {
        [JsonProperty(PropertyName = "ID_APLICATIVO")]
        public int ID_APLICATIVO { get; set; }
        [JsonProperty(PropertyName = "DESC_APLICATIVO")]
        public string DESC_APLICATIVO { get; set; }
    }
}
