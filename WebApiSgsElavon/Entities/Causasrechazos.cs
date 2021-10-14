using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Entities
{
    public class CausasrechazosDtos
    {
        [JsonProperty(PropertyName = "ID_CAUSA_RECHAZO")]
        public int ID_CAUSA_RECHAZO { get; set; }
        [JsonProperty(PropertyName = "DESC_CAUSA_RECHAZO")]
        public string DESC_CAUSA_RECHAZO { get; set; }
        [JsonProperty(PropertyName = "ID_TRECHAZO")]
        public int ID_TRECHAZO { get; set; }
    }
}
