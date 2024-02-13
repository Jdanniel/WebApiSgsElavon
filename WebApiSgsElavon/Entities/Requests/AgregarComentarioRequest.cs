using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Entities.Requests
{
    public class AgregarComentarioRequest
    {
        [JsonPropertyName("ID_AR")]
        public int ID_AR { get; set; }
        [JsonPropertyName("ID_USUARIO")]
        public int ID_USUARIO { get; set; }
        [JsonPropertyName("COMENTARIO")]
        public string COMENTARIO { get; set; }
    }
}
