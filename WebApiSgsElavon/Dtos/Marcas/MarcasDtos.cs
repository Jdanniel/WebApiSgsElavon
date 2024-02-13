using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Dtos.Marcas
{
    public class MarcasDtos
    {
        [JsonPropertyName("ID_MARCA")]
        public int IdMarca { get; set; }
        [JsonPropertyName("DESC_MARCA")]
        public string DescMarca { get; set; }
    }
}
