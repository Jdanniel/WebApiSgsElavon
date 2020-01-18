using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiSgsElavon.Entities.Requests
{
    public class SustitucionesRequest
    {
        public int ID_AR { get; set; }
        public int ID_TECNICO { get; set; }
        public string NO_SERIE { get; set; }
        public string NO_SIM { get; set; }
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
        public string NO_SERIE_RETIRO { get; set; }
        public string NO_SIM_RETIRO { get; set; }
        public string MARCA_RETIRO { get; set; }
        public string MODELO_RETIRO { get; set; }
        public string CONECTIVIDAD_RETIRO { get; set; }
        public string APLICATIVO_RETIRO { get; set; }
        public string VERSION_RETIRO { get; set; }
        public bool BATERIA_RETIRO { get; set; }
        public bool ELIMINADOR_RETIRO { get; set; }
        public bool TAPA_RETIRO { get; set; }
        public bool CABLE_AC_RETIRO { get; set; }
        public bool BASE_RETIRO { get; set; }
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

    }
}
