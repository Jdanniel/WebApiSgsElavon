using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Entities
{
    public class ODT
    {
        [JsonPropertyName("ID_AR")]
        public int ID_AR { get; set; }
        [JsonPropertyName("ID_NEGOCIO")]
        public int ID_NEGOCIO { get; set; }
        [JsonPropertyName("NO_AR")]
        public string NO_ODT { get; set; }
        [JsonPropertyName("DESC_NEGOCIO")]        
        public string DESC_NEGOCIO { get; set; }
        [JsonPropertyName("NO_AFILIACION")]
        public string NO_AFILIACION { get; set; }
        [JsonPropertyName("ESTADO")]
        public string ESTADO { get; set; }
        [JsonPropertyName("COLONIA")]
        public string COLONIA { get; set; }
        [JsonPropertyName("POBLACION")]
        public string POBLACION { get; set; }
        [JsonPropertyName("DIRECCION")]
        public string DIRECCION { get; set; }
        [JsonPropertyName("FEC_GARANTIA")]
        public string FEC_GARANTIA { get; set; }
        [JsonPropertyName("FEC_ATENCION")]
        public string FEC_ATENCION { get; set; }
        [JsonPropertyName("FEC_CIERRE")]
        public string FEC_CIERRE { get; set; }
        [JsonPropertyName("FEC_ALTA")]
        public string FEC_ALTA { get; set; }
        [JsonPropertyName("LATITUD")]
        public decimal? LATITUD { get; set; }
        [JsonPropertyName("LONGITUD")]
        public decimal? LONGITUD { get; set; }
        [JsonPropertyName("DAYS")]
        public int DAYS { get; set; }
        [JsonPropertyName("MONTHS")]
        public int MONTHS { get; set; }
        [JsonPropertyName("YEARS")]
        public int YEARS { get; set; }
        [JsonPropertyName("ID_TIPO_SERVICIO")]
        public int? ID_TIPO_SERVICIO { get; set; }
        [JsonPropertyName("NUMBER")]
        public long? NUMBER { get; set; }
        [JsonPropertyName("ID_STATUS_AR")]
        public int ID_STATUS_AR { get; set; }
        [JsonPropertyName("ID_SERVICIO")]
        public int ID_SERVICIO { get; set; }
        [JsonPropertyName("ID_FALLA")]
        public int ID_FALLA { get; set; }
        [JsonPropertyName("DESC_STATUS_AR")]
        public string DESC_STATUS_AR { get; set; }
        [JsonPropertyName("ARCHIVOS")]
        public int ARCHIVOS { get; set; }
        [JsonPropertyName("AuthInst")]
        public int AuthInst { get; set; }
        [JsonPropertyName("AuthRet")]
        public int AuthRet { get; set; }
        [JsonPropertyName("AuthSinMoInv")]
        public int AuthSinMoInv { get; set; }
        [JsonPropertyName("BITACORA")]
        public string BITACORA { get; set; }
        [JsonPropertyName("TELEFONO")]
        public string TELEFONO { get; set; }
    }
}
