using System;
using System.Collections.Generic;

using System.Globalization;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace WebApiSgsElavon.Entities.Requests
{
    public partial class CierreInstalacionRequest
    {
        [JsonPropertyName("NO_SERIE")]
        public string NO_SERIE { get; set; }

        [JsonPropertyName("NO_SIM")]
        public string NO_SIM { get; set; }

        [JsonPropertyName("CONECTIVIDAD")]
        public string CONECTIVIDAD { get; set; }

        [JsonPropertyName("APLICATIVO")]
        public string APLICATIVO { get; set; }

        [JsonPropertyName("VERSION")]
        public string VERSION { get; set; }
        //[JsonPropertyName("ACCESSORIES_ID")]
        //public List<int> ACCESSORIES_ID { get; set; }

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

        [JsonPropertyName("IS_AMEX")]
        public bool IS_AMEX { get; set; }

        [JsonPropertyName("ID_AMEX")]
        public string ID_AMEX { get; set; }

        [JsonPropertyName("AFILIACION_AMEX")]
        public string AFILIACION_AMEX { get; set; }

        [JsonPropertyName("CONCLUSIONES_AMEX")]
        public string CONCLUSIONES_AMEX { get; set; }

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

        [JsonPropertyName("ID_AR")]
        public int ID_AR { get; set; }

        [JsonPropertyName("ID_TECNICO")]
        public int ID_TECNICO { get; set; }
    }

    public partial class CierreInstalacionRequest
    {
        public static CierreInstalacionRequest FromJson(string json) => JsonConvert.DeserializeObject<CierreInstalacionRequest>(json, ConverterInstalacion.Settings);
    }
    public static class SerializeInstalacion
    {
        public static string ToJson(this CierreInstalacionRequest self) => JsonConvert.SerializeObject(self, ConverterInstalacion.Settings);
    }

    internal static class ConverterInstalacion
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
