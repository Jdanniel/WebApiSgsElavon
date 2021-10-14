using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Dtos.Soluciones
{
    public class SolucionesDtos
    {
        [JsonProperty("ID_SOLUCION")]
        public int IdSolucion { get; set; }
        [JsonProperty("DESC_SOLUCION")]
        public string DescSolucion { get; set; }
    }
}
