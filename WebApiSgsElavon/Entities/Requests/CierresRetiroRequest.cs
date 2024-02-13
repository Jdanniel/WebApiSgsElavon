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
    public partial class CierresRetiroRequest
    {
        [JsonPropertyName("NO_SERIE")]
        public string NO_SERIE { get; set; }

        [JsonPropertyName("NO_SIM")]
        public string NO_SIM { get; set; }

        [JsonPropertyName("MARCA")]
        public string MARCA { get; set; }

        [JsonPropertyName("MODELO")]
        public string MODELO { get; set; }

        [JsonPropertyName("CONECTIVIDAD")]
        public string CONECTIVIDAD { get; set; }

        [JsonPropertyName("APLICATIVO")]
        public string APLICATIVO { get; set; }

        [JsonPropertyName("VERSION")]
        public string VERSION { get; set; }
        //[JsonPropertyName("ACCESORIES_ID")]
        //public List<int> ACCESSORIES_ID {  get; set; }

        [JsonPropertyName("BATERIA")]
        public bool BATERIA { get; set; }

        [JsonPropertyName("ELIMINADOR")]
        public bool ELIMINADOR { get; set; }

        [JsonPropertyName("TAPA")]
        public bool TAPA { get; set; }

        [JsonPropertyName("CABLE_AC")]
        public bool CABLE_AC { get; set; }

        [JsonPropertyName("BASE")]
        public bool BASE { get; set; }

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

        [JsonPropertyName("ID_AR")]
        public int ID_AR { get; set; }

        [JsonPropertyName("ID_TECNICO")]
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
