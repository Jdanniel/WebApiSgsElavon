using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Dtos.Marcas
{
    public class MarcasDtos
    {
        [JsonProperty("ID_MARCA")]
        public int IdMarca { get; set; }
        [JsonProperty("DESC_MARCA")]
        public string DescMarca { get; set; }
    }
}
