using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Dtos.CausasCancelacion
{
    public class CausasCancelacionDtos
    {
        [JsonProperty("DESC_CAUSA")]
        public string DescCausa { get; set; }
        [JsonProperty("ID_CAUSA_CANCELACION")]
        public int IdCausaCancelacion { get; set; }
        [JsonProperty("ID_TIPO_CANCELADO")]
        public int IdTipoCancelado { get; set; }
    }
}
