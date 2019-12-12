using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Entities
{
    public class StatusAr
    {
        [JsonProperty(PropertyName = "ID_STATUS_AR")]
        public int ID_STATUS_AR { get; set; }
        [JsonProperty(PropertyName = "DESC_STATUS_AR")]
        public string DESC_STATUS_AR { get; set; }
    }
}
