using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Dtos.MovimientoInventarioServicioFallaDtos
{
    public class MovimientoInventarioServicioFallaDtos
    {
        [JsonProperty("ID_VAL_MOVIMIENTOS_INV_SERVICIO_FALLA")]
        public int IdValMovimientosInvServicioFalla { get; set; }
        [JsonProperty("ID_SERVICIO")]
        public int IdServicio { get; set; }
        [JsonProperty("ID_FALLA")]
        public int IdFalla { get; set; }
        [JsonProperty("ID_MOV_INVENTARIO")]
        public int IdMovInventario { get; set; }
        [JsonProperty("STATUS")]
        public string Status { get; set; }
    }
}
