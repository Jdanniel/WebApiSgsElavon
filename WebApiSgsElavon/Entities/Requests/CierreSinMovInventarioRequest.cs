using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Entities.Requests
{
    public class CierreSinMovInventarioRequest
    {
        public bool NOTIFICADO { get; set; }
        public bool PROMOCIONES { get; set; }
        public bool DESCARGA_APP { get; set; }
        public string TELEFONO_1 { get; set; }
        public string TELEFONO_2 { get; set; }
        public string FECHA_CIERRE { get; set; }
        public string ATIENDE { get; set; }
        public string OTORGANTE_VOBO { get; set; }
        public string TIPO_ATENCION { get; set; }
        public int ROLLOS { get; set; }
        public int DISCOVER { get; set; }
        public int CAJA { get; set; }
        public string COMENTARIO { get; set; }
        public int ID_AR { get; set; }
        public int ID_TECNICO { get; set; }
    }
}
