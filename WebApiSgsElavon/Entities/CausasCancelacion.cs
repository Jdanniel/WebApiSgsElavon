using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Entities
{
    public class CausasCancelacion
    {
        [JsonProperty(PropertyName = "ID_CAUSA_CANCELACION")]
        public int ID_CAUSA_CANCELACION { get; set; }
        [JsonProperty(PropertyName = "DESC_CAUSA")]
        public string DESC_CAUSA { get; set; }
        [JsonProperty(PropertyName = "ID_TIPO_CANCELADO")]
        public int ID_TIPO_CANCELADO { get; set; }
    }
}
