using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdArchivosDispersion
    {
        public BdArchivosDispersion()
        {
            BdArchivoDispersionSolicitudViaticos = new HashSet<BdArchivoDispersionSolicitudViaticos>();
        }

        public int IdArchivoDispersion { get; set; }
        public string Carpeta { get; set; }
        public string NombreArchivoDispersion { get; set; }
        public int IdUsuarioAlta { get; set; }
        public DateTime FecAlta { get; set; }
        public string Status { get; set; }
        public int IdBanco { get; set; }

        public virtual ICollection<BdArchivoDispersionSolicitudViaticos> BdArchivoDispersionSolicitudViaticos { get; set; }
    }
}
