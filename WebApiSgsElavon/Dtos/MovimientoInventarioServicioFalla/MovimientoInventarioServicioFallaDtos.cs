using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Dtos.MovimientoInventarioServicioFallaDtos
{
    public class MovimientoInventarioServicioFallaDtos
    {
        [JsonPropertyName("ID_VAL_MOVIMIENTOS_INV_SERVICIO_FALLA")]
        public int IdValMovimientosInvServicioFalla { get; set; }
        [JsonPropertyName("ID_SERVICIO")]
        public int IdServicio { get; set; }
        [JsonPropertyName("ID_FALLA")]
        public int IdFalla { get; set; }
        [JsonPropertyName("ID_MOV_INVENTARIO")]
        public int IdMovInventario { get; set; }
        [JsonPropertyName("STATUS")]
        public string Status { get; set; }
    }
}
