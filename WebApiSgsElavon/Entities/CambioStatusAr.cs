using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Entities
{
    public class CambioStatusAr
    {
        [JsonProperty(PropertyName = "ID_CAMBIO_STATUS_AR")]
        public int ID_CAMBIO_STATUS_AR { get; set; }
        [JsonProperty(PropertyName = "ID_STATUS_AR_INI")]
        public int? ID_STATUS_AR_INI { get; set; }
        [JsonProperty(PropertyName = "ID_STATUS_AR_FIN")]
        public int? ID_STATUS_AR_FIN { get; set; }
    }
}
