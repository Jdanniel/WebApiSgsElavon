using System;
using System.Collections.Generic;

using System.Globalization;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WebApiSgsElavon.Entities.Requests
{
    public partial class SustitucionesSimRequest
    {
        [JsonPropertyName("NO_SIM")]
        public string NO_SIM { get; set; }
        [JsonPropertyName("NO_SIM_RETIRO")]
        public string NO_SIM_RETIRO { get; set; }
        [JsonPropertyName("NOTIFICADO")]
        public bool NOTIFICADO { get; set; }

        [JsonPropertyName("PROMOCIONES")]
        public bool PROMOCIONES { get; set; }

        [JsonPropertyName("DESCARGA_APP")]
        public bool DESCARGA_APP { get; set; }

        [JsonPropertyName("TELEFONO_1")]
        public string TELEFONO_1 { get; set; }

        [JsonPropertyName("TELEFONO_2")]
        public string TELEFONO_2 { get; set; }

        [JsonPropertyName("FECHA_CIERRE")]
        public string FECHA_CIERRE { get; set; }

        [JsonPropertyName("ATIENDE")]
        public string ATIENDE { get; set; }

        [JsonPropertyName("OTORGANTE_VOBO")]
        public string OTORGANTE_VOBO { get; set; }

        [JsonPropertyName("TIPO_ATENCION")]
        public string TIPO_ATENCION { get; set; }

        [JsonPropertyName("ROLLOS")]
        public int ROLLOS { get; set; }

        [JsonPropertyName("GETNET")]
        public int GETNET { get; set; }

        [JsonPropertyName("CAJA")]
        public int CAJA { get; set; }

        [JsonPropertyName("COMENTARIO")]
        public string COMENTARIO { get; set; }
        [JsonPropertyName("PEDIR_SIM")]
        public bool PEDIR_SIM { get; set; }

        [JsonPropertyName("ID_AR")]
        public int ID_AR { get; set; }

        [JsonPropertyName("ID_TECNICO")]
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
