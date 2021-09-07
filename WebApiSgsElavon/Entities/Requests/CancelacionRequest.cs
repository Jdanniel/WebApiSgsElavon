using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Globalization;

namespace WebApiSgsElavon.Entities.Requests
{
    public partial class CancelacionRequest
    {
        [JsonProperty(PropertyName = "ID_AR")]
        public int IdAr { get; set; }
        [JsonProperty(PropertyName = "ID_USUARIO")]
        public int IdUsuario { get; set; }
        [JsonProperty(PropertyName = "COMENTARIO")]
        public string Comentario { get; set; }
        [JsonProperty(PropertyName = "DESC_CAUSA")]
        public string DescCausa { get; set; }
        [JsonProperty(PropertyName = "FECHA")]
        public string Fecha { get; set; }
    }
    public partial class CancelacionRequest
    {
        public static CancelacionRequest FromJson(string json) => JsonConvert.DeserializeObject<CancelacionRequest>(json, ConverterCancelacion.Settings);
    }
    public static class SerializeCaancelacion
    {
        public static string ToJson(this CancelacionRequest self) => JsonConvert.SerializeObject(self, ConverterCancelacion.Settings);
    }

    internal static class ConverterCancelacion
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
