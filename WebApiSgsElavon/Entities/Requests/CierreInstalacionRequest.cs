using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace WebApiSgsElavon.Entities.Requests
{
    public partial class CierreInstalacionRequest
    {
        [JsonProperty("NO_SERIE")]
        public string NO_SERIE { get; set; }

        [JsonProperty("NO_SIM")]
        public string NO_SIM { get; set; }

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

        [JsonProperty("IS_AMEX")]
        public bool IS_AMEX { get; set; }

        [JsonProperty("ID_AMEX")]
        public string ID_AMEX { get; set; }

        [JsonProperty("AFILIACION_AMEX")]
        public string AFILIACION_AMEX { get; set; }

        [JsonProperty("CONCLUSIONES_AMEX")]
        public string CONCLUSIONES_AMEX { get; set; }

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
