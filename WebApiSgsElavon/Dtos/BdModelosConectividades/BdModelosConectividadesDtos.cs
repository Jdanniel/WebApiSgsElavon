using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Dtos.BdModelosConectividades
{
    public class BdModelosConectividadesDtos
    {
        [JsonPropertyName("ID_MODELO_CONECTIVIDAD")]
        public int IdModeloConectividad { get; set; }
        [JsonPropertyName("ID_MODELO")]
        public int IdModelo { get; set; }
        [JsonPropertyName("ID_CONECTIVIDAD")]
        public int IdConectividad { get; set; }
    }
}
