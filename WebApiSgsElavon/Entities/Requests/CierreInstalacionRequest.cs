using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Entities.Requests
{
    public class CierreInstalacionRequest
    {
        public string NO_SERIE { get; set; }
        public string CONECTIVIDAD { get; set; }
        public string APLICATIVO { get; set; }
        public string VERSION { get; set; }
        public bool BATERIA { get; set; }
        public bool ELIMINADOR { get; set; }
        public bool TAPA { get; set; }
        public bool CABLE_AC { get; set; }
        public bool BASE { get; set; }
        public bool IS_AMEX { get; set; }
        public string ID_AMEX { get; set; }
        public string AFILIACION_AMEX { get; set; }
        public string CONCLUSIONES_AMEX { get; set; }
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
