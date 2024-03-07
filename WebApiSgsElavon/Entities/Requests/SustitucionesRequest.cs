using System;
using System.Collections.Generic;

using System.Globalization;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace WebApiSgsElavon.Entities.Requests
{
    public partial class SustitucionesRequest
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

        //[JsonPropertyName("ACCESSORIES_INST")]
        //public List<int> ACCESSORIES_INST {  get; set; }

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

        [JsonPropertyName("NO_SERIE_RETIRO")]
        public string NO_SERIE_RETIRO { get; set; }

        [JsonPropertyName("NO_SIM_RETIRO")]
        public string NO_SIM_RETIRO { get; set; }

        [JsonPropertyName("MARCA_RETIRO")]
        public string MARCA_RETIRO { get; set; }

        [JsonPropertyName("MODELO_RETIRO")]
        public string MODELO_RETIRO { get; set; }

        [JsonPropertyName("CONECTIVIDAD_RETIRO")]
        public string CONECTIVIDAD_RETIRO { get; set; }

        [JsonPropertyName("APLICATIVO_RETIRO")]
        public string APLICATIVO_RETIRO { get; set; }

        [JsonPropertyName("VERSION_RETIRO")]
        public string VERSION_RETIRO { get; set; }

        //[JsonPropertyName("ACCESSORIES_REMO")]
        //public List<int> ACCESSORIES_REMO { get; set; }

        [JsonPropertyName("BATERIA_RETIRO")]
        public bool BATERIA_RETIRO { get; set; }

        [JsonPropertyName("ELIMINADOR_RETIRO")]
        public bool ELIMINADOR_RETIRO { get; set; }

        [JsonPropertyName("TAPA_RETIRO")]
        public bool TAPA_RETIRO { get; set; }

        [JsonPropertyName("CABLE_AC_RETIRO")]
        public bool CABLE_AC_RETIRO { get; set; }

        [JsonPropertyName("BASE_RETIRO")]
        public bool BASE_RETIRO { get; set; }

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

        [JsonPropertyName("DESC_CAUSA")]
        public string DESC_CAUSA { get; set; }

        [JsonPropertyName("IS_RETIRO_SIM")]
        public bool IS_RETIRO_SIM { get; set; }

        [JsonPropertyName("IS_INSTALACION_SIM")]
        public bool IS_INSTALACION_SIM { get; set; }
        //AGREGAR LISTA DE ACCESORIOS
        [JsonPropertyName("ACCESSORIES_INST")]
        public List<int> AccessoriesInst {  get; set; }
        [JsonPropertyName("ACCESSORIES_REMO")]
        public List<int> AccessoriesRemo { get; set; }
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
