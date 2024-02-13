using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Dtos.CausasCancelacion
{
    public class CausasCancelacionDtos
    {
        [JsonPropertyName("DESC_CAUSA")]
        public string DescCausa { get; set; }
        [JsonPropertyName("ID_CAUSA_CANCELACION")]
        public int IdCausaCancelacion { get; set; }
        [JsonPropertyName("ID_TIPO_CANCELADO")]
        public int IdTipoCancelado { get; set; }
    }
}
