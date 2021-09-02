using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WebApiSgsElavon.Entities.Requests
{
    public partial class SustitucionesSimRequest
    {
        [JsonProperty("NO_SIM")]
        public string NO_SIM { get; set; }
        [JsonProperty("NO_SIM_RETIRO")]
        public string NO_SIM_RETIRO { get; set; }
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

        [JsonProperty("GETNET")]
        public int GETNET { get; set; }

        [JsonProperty("CAJA")]
        public string CAJA { get; set; }

        [JsonProperty("COMENTARIO")]
        public string COMENTARIO { get; set; }
        [JsonProperty("PEDIR_SIM")]
        public bool PEDIR_SIM { get; set; }

        [JsonProperty("ID_AR")]
        public int ID_AR { get; set; }

        [JsonProperty("ID_TECNICO")]
        public int ID_TECNICO { get; set; }

    }
    public partial class SustitucionesSimRequest
    {
        public static SustitucionesSimRequest FromJson(string json) => JsonConvert.DeserializeObject<SustitucionesSimRequest>(json, ConverterSustitucionSim.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this SustitucionesSimRequest self) => JsonConvert.SerializeObject(self, ConverterSustitucionSim.Settings);
    }

    internal static class ConverterSustitucionSim
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
