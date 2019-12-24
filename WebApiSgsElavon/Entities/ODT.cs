using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Entities
{
    public class ODT
    {
        [JsonProperty(PropertyName = "ID_AR")]
        public int ID_AR { get; set; }
        [JsonProperty(PropertyName = "ID_NEGOCIO")]
        public int ID_NEGOCIO { get; set; }
        [JsonProperty(PropertyName = "NO_AR")]
        public string NO_ODT { get; set; }
        [JsonProperty(PropertyName = "DESC_NEGOCIO")]        
        public string DESC_NEGOCIO { get; set; }
        [JsonProperty(PropertyName = "NO_AFILIACION")]
        public string NO_AFILIACION { get; set; }
        [JsonProperty(PropertyName = "ESTADO")]
        public string ESTADO { get; set; }
        [JsonProperty(PropertyName = "COLONIA")]
        public string COLONIA { get; set; }
        [JsonProperty(PropertyName = "POBLACION")]
        public string POBLACION { get; set; }
        [JsonProperty(PropertyName = "DIRECCION")]
        public string DIRECCION { get; set; }
        [JsonProperty(PropertyName = "FEC_GARANTIA")]
        public string FEC_GARANTIA { get; set; }
        [JsonProperty(PropertyName = "FEC_ATENCION")]
        public string FEC_ATENCION { get; set; }
        [JsonProperty(PropertyName = "LATITUD")]
        public decimal? LATITUD { get; set; }
        [JsonProperty(PropertyName = "LONGITUD")]
        public decimal? LONGITUD { get; set; }
        [JsonProperty(PropertyName = "DAYS")]
        public int DAYS { get; set; }
        [JsonProperty(PropertyName = "MONTHS")]
        public int MONTHS { get; set; }
        [JsonProperty(PropertyName = "YEARS")]
        public int YEARS { get; set; }
        [JsonProperty(PropertyName = "ID_TIPO_SERVICIO")]
        public int? ID_TIPO_SERVICIO { get; set; }
        [JsonProperty(PropertyName = "NUMBER")]
        public long? NUMBER { get; set; }
        [JsonProperty(PropertyName = "ID_STATUS_AR")]
        public int ID_STATUS_AR { get; set; }
        [JsonProperty(PropertyName = "ID_SERVICIO")]
        public int ID_SERVICIO { get; set; }
        [JsonProperty(PropertyName = "ID_FALLA")]
        public int ID_FALLA { get; set; }
        [JsonProperty(PropertyName = "DESC_STATUS_AR")]
        public string DESC_STATUS_AR { get; set; }
    }
}
