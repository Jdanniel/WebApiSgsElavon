using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Entities.Requests
{
    public partial class CierreSinMovInventarioRequest
    {
        [JsonProperty("NOTIFICADO")]
        public bool NOTIFICADO { get; set; }
        [JsonProperty("PROMOCIONES")]
        public bool PROMOCIONES { get; set; }
        [JsonProperty("DESCARGA_APP")]
        public bool DESCARGA_APP { get; set; }
        [JsonProperty("TELEFONO_1")]
        public string TELEFONO_1 { get; set; }
        [JsonProperty("TELEFONO_2")]
        public string TELEFONO_2 { get; set; }
        [JsonProperty("FECHA_CIERRE")]
        public string FECHA_CIERRE { get; set; }
        [JsonProperty("ATIENDE")]
        public string ATIENDE { get; set; }
        [JsonProperty("OTORGANTE_VOBO")]
        public string OTORGANTE_VOBO { get; set; }
        [JsonProperty("TIPO_ATENCION")]
        public string TIPO_ATENCION { get; set; }
        [JsonProperty("ROLLOS")]
        public int ROLLOS { get; set; }
        [JsonProperty("DISCOVER")]
        public int DISCOVER { get; set; }
        [JsonProperty("CAJA")]
        public int CAJA { get; set; }
        [JsonProperty("COMENTARIO")]
        public string COMENTARIO { get; set; }
        [JsonProperty("ID_AR")]
        public int ID_AR { get; set; }
        [JsonProperty("ID_TECNICO")]
        public int ID_TECNICO { get; set; }
    }
    public partial class CierreSinMovInventarioRequest
    {
        public static CierreSinMovInventarioRequest FromJson(string json) => JsonConvert.DeserializeObject<CierreSinMovInventarioRequest>(json, ConverterSinMovimiento.Settings);
    }
    public static class SerializeSinMovimiento
    {
        public static string ToJson(this CierreSinMovInventarioRequest self) => JsonConvert.SerializeObject(self, ConverterSinMovimiento.Settings);
    }

    internal static class ConverterSinMovimiento
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
