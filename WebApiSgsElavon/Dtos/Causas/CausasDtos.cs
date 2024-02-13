using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Dtos.Causas
{
    public class CausasDtos
    {
        [JsonPropertyName("ID_CAUSA")]
        public int IdCausa { get; set; }
        [JsonPropertyName("DESC_CAUSA")]
        public string DescCausa { get; set; }
        [JsonPropertyName("DESCRIPCION")]
        public string Descripcion { get; set; }
    }
}
