using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Entities.Requests
{
    public partial class CierreRechazoRequest
    {
        [JsonPropertyName("FEC_CIERRE")]
        public string FEC_CIERRE { get; set; }
        [JsonPropertyName("FEC_PROGRAMADO")]
        public string FEC_PROGRAMADO { get; set; }

        [JsonPropertyName("CAUSA_RECHAZO")]
        public string CAUSA_RECHAZO { get; set; }

        [JsonPropertyName("SUBRECHAZO")]
        public string SUBRECHAZO { get; set; }

        [JsonPropertyName("TIPO_ATENCION")]
        public string TIPO_ATENCION { get; set; }

        [JsonPropertyName("ATIENDE")]
        public string ATIENDE { get; set; }

        [JsonPropertyName("CONCLUSIONES")]
        public string CONCLUSIONES { get; set; }

        [JsonPropertyName("ID_AR")]
        public int ID_AR { get; set; }

        [JsonPropertyName("ID_TECNICO")]
        public int ID_TECNICO { get; set; }
    }
    public partial class CierreRechazoRequest
    {
        public static CierreRechazoRequest FromJson(string json) => JsonConvert.DeserializeObject<CierreRechazoRequest>(json, ConverterRechazoRequest.Settings);
    }

    public static class SerializeRechazoRequest
    {
        public static string ToJson(this CierreRechazoRequest self) => JsonConvert.SerializeObject(self, ConverterRechazoRequest.Settings);
    }

    internal static class ConverterRechazoRequest
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
