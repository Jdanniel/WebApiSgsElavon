using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace WebApiSgsElavon.Dtos.Modelos
{
    public class ReglasModelosDtos
    {
        [JsonPropertyName("ID_REGLAS")]
        public int IdRegla { get; set; }
        [JsonPropertyName("ID_MODELO")]
        public int IdModelo { get; set; }
        [JsonPropertyName("LETRAS_MIN")]
        public int LetrasMin { get; set; }
        [JsonPropertyName("LETRAS_MAX")]
        public int LetrasMax { get; set; }
        [JsonPropertyName("NUMERO_MIN")]
        public int NumeroMin { get; set; }
        [JsonPropertyName("NUMERO_MAX")]
        public int NumeroMax { get; set; }
        [JsonPropertyName("LONG_MIN")]
        public int LongMin { get; set; }
        [JsonPropertyName("LONG_MAX")]
        public int LongMax { get; set; }
    }
}
