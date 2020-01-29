using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Entities.Requests
{
    public partial class CierresRetiroRequest
    {
        [JsonProperty("NO_SERIE")]
        public string NO_SERIE { get; set; }

        [JsonProperty("NO_SIM")]
        public string NO_SIM { get; set; }

        [JsonProperty("MARCA")]
        public string MARCA { get; set; }

        [JsonProperty("MODELO")]
        public string MODELO { get; set; }

        [JsonProperty("CONECTIVIDAD")]
        public string CONECTIVIDAD { get; set; }

        [JsonProperty("APLICATIVO")]
        public string APLICATIVO { get; set; }

        [JsonProperty("VERSION")]
        public string VERSION { get; set; }

        [JsonProperty("BATERIA")]
        public bool BATERIA { get; set; }

        [JsonProperty("ELIMINADOR")]
        public bool ELIMINADOR { get; set; }

        [JsonProperty("TAPA")]
        public bool TAPA { get; set; }

        [JsonProperty("CABLE_AC")]
        public bool CABLE_AC { get; set; }

        [JsonProperty("BASE")]
        public bool BASE { get; set; }

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

    public partial class CierresRetiroRequest
    {
        public static CierresRetiroRequest FromJson(string json) => JsonConvert.DeserializeObject<CierresRetiroRequest>(json, ConverterRetiro.Settings);
    }

    public static class SerializeRetiro
    {
        public static string ToJson(this CierresRetiroRequest self) => JsonConvert.SerializeObject(self, ConverterRetiro.Settings);
    }

    internal static class ConverterRetiro
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
