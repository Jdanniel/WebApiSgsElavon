using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Entities.Requests
{
    public class UpdateCoordenadasRequest
    {
        [JsonPropertyName("ID_NEGOCIO")]
        public int ID_NEGOCIO { get; set; }
        [JsonPropertyName("ID_AR")]
        public int ID_AR { get; set; }
        [JsonPropertyName("ID_USUARIO")]
        public int ID_USUARIO { get; set; }
        [JsonPropertyName("LATITUD")]
        public decimal LATITUD { get; set; }
        [JsonPropertyName("LONGITUD")]
        public decimal LONGITUD { get; set; }
    }
}
