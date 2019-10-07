using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Entities
{
    public class Marcas
    {
        [JsonProperty(PropertyName = "ID_MARCA")]
        public int ID_MARCA { get; set; }
        [JsonProperty(PropertyName = "DESC_MARCA")]
        public string DESC_MARCA { get; set; }
    }
}
