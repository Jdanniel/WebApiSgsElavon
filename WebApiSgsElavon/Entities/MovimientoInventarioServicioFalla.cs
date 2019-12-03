using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Entities
{
    public class MovimientoInventarioServicioFalla
    {
        [JsonProperty(PropertyName = "ID_VAL_MOVIMIENTOS_INV_SERVICIO_FALLA")]
        public int ID_VAL_MOVIMIENTOS_INV_SERVICIO_FALLA { get; set; }
        [JsonProperty(PropertyName = "ID_SERVICIO")]
        public int? ID_SERVICIO { get; set; }
        [JsonProperty(PropertyName = "ID_FALLA")]
        public int? ID_FALLA { get; set; }
        [JsonProperty(PropertyName = "ID_MOV_INVENTARIO")]
        public int? ID_MOV_INVENTARIO { get; set; }
        [JsonProperty(PropertyName = "STATUS")]
        public string STATUS { get; set; }
    }
}
