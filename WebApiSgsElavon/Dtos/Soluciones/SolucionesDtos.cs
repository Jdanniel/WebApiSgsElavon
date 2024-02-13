using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Dtos.Soluciones
{
    public class SolucionesDtos
    {
        [JsonPropertyName("ID_SOLUCION")]
        public int IdSolucion { get; set; }
        [JsonPropertyName("DESC_SOLUCION")]
        public string DescSolucion { get; set; }
    }
}
