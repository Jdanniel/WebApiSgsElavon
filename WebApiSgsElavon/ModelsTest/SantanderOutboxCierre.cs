using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class SantanderOutboxCierre
    {
        public int IdSantanderOutboxCierre { get; set; }
        public int IdAr { get; set; }
        public string Afiliacion { get; set; }
        public string Odt { get; set; }
        public string InsumosEntregados { get; set; }
        public string Estatus { get; set; }
        public string SerieInstalada { get; set; }
        public string SimInstalado { get; set; }
        public string SerieBaseInstalada { get; set; }
        public string SerieRetirada { get; set; }
        public string SimRetirado { get; set; }
        public string SerieBaseRetirada { get; set; }
        public string Atendio { get; set; }
        public string ComentariosSolucion { get; set; }
        public string Aplicacion { get; set; }
        public string Version { get; set; }
        public string Caja { get; set; }
        public string IdResultado { get; set; }
        public string Status { get; set; }
    }
}
