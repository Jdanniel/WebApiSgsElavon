using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Entities.Requests
{
    public class AgregarComentarioRequest
    {
        [JsonProperty(PropertyName = "ID_AR")]
        public int ID_AR { get; set; }
        [JsonProperty(PropertyName = "ID_USUARIO")]
        public int ID_USUARIO { get; set; }
        [JsonProperty(PropertyName = "COMENTARIO")]
        public string COMENTARIO { get; set; }
    }
}
