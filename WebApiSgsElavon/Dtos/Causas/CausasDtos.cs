using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Dtos.Causas
{
    public class CausasDtos
    {
        [JsonProperty("ID_CAUSA")]
        public int IdCausa { get; set; }
        [JsonProperty("DESC_CAUSA")]
        public string DescCausa { get; set; }
        [JsonProperty("DESCRIPCION")]
        public string Descripcion { get; set; }
    }
}
