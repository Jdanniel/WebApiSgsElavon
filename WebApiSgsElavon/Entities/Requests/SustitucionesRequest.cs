using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WebApiSgsElavon.Entities.Requests
{
    public partial class SustitucionesRequest
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

        [JsonProperty("NO_SERIE_RETIRO")]
        public string NO_SERIE_RETIRO { get; set; }

        [JsonProperty("NO_SIM_RETIRO")]
        public string NO_SIM_RETIRO { get; set; }

        [JsonProperty("MARCA_RETIRO")]
        public string MARCA_RETIRO { get; set; }

        [JsonProperty("MODELO_RETIRO")]
        public string MODELO_RETIRO { get; set; }

        [JsonProperty("CONECTIVIDAD_RETIRO")]
        public string CONECTIVIDAD_RETIRO { get; set; }

        [JsonProperty("APLICATIVO_RETIRO")]
        public string APLICATIVO_RETIRO { get; set; }

        [JsonProperty("VERSION_RETIRO")]
        public string VERSION_RETIRO { get; set; }

        [JsonProperty("BATERIA_RETIRO")]
        public bool BATERIA_RETIRO { get; set; }

        [JsonProperty("ELIMINADOR_RETIRO")]
        public bool ELIMINADOR_RETIRO { get; set; }

        [JsonProperty("TAPA_RETIRO")]
        public bool TAPA_RETIRO { get; set; }

        [JsonProperty("CABLE_AC_RETIRO")]
        public bool CABLE_AC_RETIRO { get; set; }

        [JsonProperty("BASE_RETIRO")]
        public bool BASE_RETIRO { get; set; }

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

        [JsonProperty("ID_AR")]
        public int ID_AR { get; set; }

        [JsonProperty("ID_TECNICO")]
        public int ID_TECNICO { get; set; }
        [JsonProperty("DESC_CAUSA")]
        public string DESC_CAUSA { get; set; }
    }

    public partial class SustitucionesRequest
    {
        public static SustitucionesRequest FromJson(string json) => JsonConvert.DeserializeObject<SustitucionesRequest>(json, ConverterSustitucion.Settings);
    }

    public static class SerializeSustitucion
    {
        public static string ToJson(this SustitucionesRequest self) => JsonConvert.SerializeObject(self, ConverterSustitucion.Settings);
    }

    internal static class ConverterSustitucion
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
