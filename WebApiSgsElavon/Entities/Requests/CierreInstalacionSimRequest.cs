using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace WebApiSgsElavon.Entities.Requests
{
    public partial class CierreInstalacionSimRequest
    {
        [JsonProperty("NO_SIM")]
        public string NO_SIM { get; set; }

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
        public string ROLLOS { get; set; }

        [JsonProperty("DISCOVER")]
        public string DISCOVER { get; set; }

        [JsonProperty("CAJA")]
        public string CAJA { get; set; }

        [JsonProperty("COMENTARIO")]
        public string COMENTARIO { get; set; }

        [JsonProperty("ID_AR")]
        public int ID_AR { get; set; }

        [JsonProperty("ID_TECNICO")]
        public int ID_TECNICO { get; set; }
    }

    public partial class CierreInstalacionSimRequest
    {
        public static CierreInstalacionSimRequest FromJson(string json) => JsonConvert.DeserializeObject<CierreInstalacionSimRequest>(json, ConverterInstalacionSim.Settings);
    }
    public static class SerializeInstalacionSim
    {
        public static string ToJson(this CierreInstalacionSimRequest self) => JsonConvert.SerializeObject(self, ConverterInstalacionSim.Settings);
    }

    internal static class ConverterInstalacionSim
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
