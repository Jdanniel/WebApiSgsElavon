using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Entities.Requests
{
    public class UpdateStatusBdArRequest
    {
        [JsonProperty(PropertyName = "ID_AR")]
        public int ID_AR { get; set; }
        [JsonProperty(PropertyName = "ID_USUARIO")]
        public int ID_USUARIO { get; set; }
        [JsonProperty(PropertyName = "ID_STATUS_AR_A")]
        public int ID_STATUS_AR_A { get; set; }
        [JsonProperty(PropertyName = "ID_STATUS_AR_P")]
        public int ID_STATUS_AR_P { get; set; }
    }
}
