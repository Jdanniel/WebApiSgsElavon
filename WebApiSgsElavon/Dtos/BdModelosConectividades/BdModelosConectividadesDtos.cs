using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Dtos.BdModelosConectividades
{
    public class BdModelosConectividadesDtos
    {
        [JsonProperty("ID_MODELO_CONECTIVIDAD")]
        public int IdModeloConectividad { get; set; }
        [JsonProperty("ID_MODELO")]
        public int IdModelo { get; set; }
        [JsonProperty("ID_CONECTIVIDAD")]
        public int IdConectividad { get; set; }
    }
}
