using Newtonsoft.Json;

namespace WebApiSgsElavon.Dtos.Unidades
{
    public class UnidadesDtos
    {
        [JsonProperty("ID_UNIDAD")]
        public int IdUnidad { get; set; }
        [JsonProperty("ID_APLICATIVO")]
        public int IdAplicativo { get; set; }
        [JsonProperty("ID_CONECTIVIDAD")]
        public int IdConectividad { get; set; }
        [JsonProperty("ID_MARCA")]
        public int IdMarca { get; set; }
        [JsonProperty("ID_MODELO")]
        public int IdModelo { get; set; }
        [JsonProperty("NO_SERIE")]
        public string NoSerie { get; set; }
        [JsonProperty("ID_STATUS_UNIDAD")]
        public int IdStatusUnidad { get; set; }
        [JsonProperty("IS_NUEVA")]
        public int IsNueva { get; set; }
        [JsonProperty("DESC_STATUS_UNIDAD")]
        public string DescStatusUnidad { get; set; }
        [JsonProperty("ID_TIPO_RESPONSABLE")]
        public int IdTipoResponsable { get; set; }
        [JsonProperty("ID_RESPONSABLE")]
        public int IdResponsable { get; set; }
    }
}
