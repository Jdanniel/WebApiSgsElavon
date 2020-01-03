using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Entities.Requests
{
    public class CierreRechazoRequest
    {
        [JsonProperty(PropertyName = "FEC_CIERRE")]
        public string FEC_CIERRE { get; set; }
        [JsonProperty(PropertyName = "CAUSA_RECHAZO")]
        public string CAUSA_RECHAZO { get; set; }
        [JsonProperty(PropertyName = "SUBRECHAZO")]
        public string SUBRECHAZO { get; set; }
        [JsonProperty(PropertyName = "TIPO_ATENCION")]
        public string TIPO_ATENCION { get; set; }
        [JsonProperty(PropertyName = "ATIENDE")]
        public string ATIENDE { get; set; }
        [JsonProperty(PropertyName = "CONCLUSIONES")]
        public string CONCLUSIONES { get; set; }
        [JsonProperty(PropertyName = "ID_AR")]
        public int ID_AR { get; set; }
        [JsonProperty(PropertyName = "ID_TECNICO")]
        public int ID_TECNICO { get; set; }

    }
}
