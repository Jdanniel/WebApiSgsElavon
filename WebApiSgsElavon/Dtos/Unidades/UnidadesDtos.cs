using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace WebApiSgsElavon.Dtos.Unidades
{
    public class UnidadesDtos
    {
        [JsonPropertyName("ID_UNIDAD")]
        public int IdUnidad { get; set; }
        [JsonPropertyName("ID_APLICATIVO")]
        public int IdAplicativo { get; set; }
        [JsonPropertyName("ID_CONECTIVIDAD")]
        public int IdConectividad { get; set; }
        [JsonPropertyName("ID_MARCA")]
        public int IdMarca { get; set; }
        [JsonPropertyName("ID_MODELO")]
        public int IdModelo { get; set; }
        [JsonPropertyName("NO_SERIE")]
        public string NoSerie { get; set; }
        [JsonPropertyName("ID_STATUS_UNIDAD")]
        public int IdStatusUnidad { get; set; }
        [JsonPropertyName("IS_NUEVA")]
        public int IsNueva { get; set; }
        [JsonPropertyName("DESC_STATUS_UNIDAD")]
        public string DescStatusUnidad { get; set; }
        [JsonPropertyName("ID_TIPO_RESPONSABLE")]
        public int IdTipoResponsable { get; set; }
        [JsonPropertyName("ID_RESPONSABLE")]
        public int IdResponsable { get; set; }
    }
}
