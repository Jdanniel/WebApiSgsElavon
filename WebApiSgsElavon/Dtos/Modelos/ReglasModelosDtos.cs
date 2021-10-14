using Newtonsoft.Json;

namespace WebApiSgsElavon.Dtos.Modelos
{
    public class ReglasModelosDtos
    {
        [JsonProperty("ID_REGLAS")]
        public int IdRegla { get; set; }
        [JsonProperty("ID_MODELO")]
        public int IdModelo { get; set; }
        [JsonProperty("LETRAS_MIN")]
        public int LetrasMin { get; set; }
        [JsonProperty("LETRAS_MAX")]
        public int LetrasMax { get; set; }
        [JsonProperty("NUMERO_MIN")]
        public int NumeroMin { get; set; }
        [JsonProperty("NUMERO_MAX")]
        public int NumeroMax { get; set; }
        [JsonProperty("LONG_MIN")]
        public int LongMin { get; set; }
        [JsonProperty("LONG_MAX")]
        public int LongMax { get; set; }
    }
}
