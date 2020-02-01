using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Entities
{
    public class ReglasModelos
    {
        [JsonProperty(PropertyName = "ID_REGLAS")]
        public int ID_REGLAS { get; set; }
        [JsonProperty(PropertyName = "ID_MODELO")]
        public int ID_MODELO { get; set; }
        [JsonProperty(PropertyName = "LETRAS_MIN")]
        public int LETRAS_MIN { get; set; }
        [JsonProperty(PropertyName = "LETRAS_MAX")]
        public int LETRAS_MAX { get; set; }
        [JsonProperty(PropertyName = "NUMERO_MIN")]
        public int NUMERO_MIN { get; set; }
        [JsonProperty(PropertyName = "NUMERO_MAX")]
        public int NUMERO_MAX { get; set; }
        [JsonProperty(PropertyName = "LONG_MIN")]
        public int LONG_MIN { get; set; }
        [JsonProperty(PropertyName = "LONG_MAX")]
        public int LONG_MAX { get; set; }
    }
}
