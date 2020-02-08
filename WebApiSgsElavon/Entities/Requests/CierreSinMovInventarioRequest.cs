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
        [JsonProperty("NO_SERIE")]
        public bool NOTIFICADO { get; set; }
        [JsonProperty("NO_SERIE")]
        public bool PROMOCIONES { get; set; }
        [JsonProperty("NO_SERIE")]
        public bool DESCARGA_APP { get; set; }
        [JsonProperty("NO_SERIE")]
        public string TELEFONO_1 { get; set; }
        [JsonProperty("NO_SERIE")]
        public string TELEFONO_2 { get; set; }
        [JsonProperty("NO_SERIE")]
        public string FECHA_CIERRE { get; set; }
        [JsonProperty("NO_SERIE")]
        public string ATIENDE { get; set; }
        [JsonProperty("NO_SERIE")]
        public string OTORGANTE_VOBO { get; set; }
        [JsonProperty("NO_SERIE")]
        public string TIPO_ATENCION { get; set; }
        [JsonProperty("NO_SERIE")]
        public int ROLLOS { get; set; }
        [JsonProperty("NO_SERIE")]
        public int DISCOVER { get; set; }
        [JsonProperty("NO_SERIE")]
        public int CAJA { get; set; }
        [JsonProperty("NO_SERIE")]
        public string COMENTARIO { get; set; }
        [JsonProperty("NO_SERIE")]
        public int ID_AR { get; set; }
        [JsonProperty("NO_SERIE")]
        public int ID_TECNICO { get; set; }
    }
    public partial class CierreSinMovInventarioRequest
    {
        public static CierreSinMovInventarioRequest FromJson(string json) => JsonConvert.DeserializeObject<CierreSinMovInventarioRequest>(json, ConverterInstalacion.Settings);
    }
    public static class SerializeSinMovimiento
    {
        public static string ToJson(this CierreSinMovInventarioRequest self) => JsonConvert.SerializeObject(self, ConverterInstalacion.Settings);
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
