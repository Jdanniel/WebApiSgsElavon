using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdSolicitudesViaticos
    {
        public BdSolicitudesViaticos()
        {
            BdArchivoDispersionSolicitudViaticos = new HashSet<BdArchivoDispersionSolicitudViaticos>();
            BdBitacoraSolicitudesViaticos = new HashSet<BdBitacoraSolicitudesViaticos>();
            BdConfirmaciones = new HashSet<BdConfirmaciones>();
            BdConfirmacionesIntermedia = new HashSet<BdConfirmacionesIntermedia>();
            BdSolicitudesViaticosConceptos = new HashSet<BdSolicitudesViaticosConceptos>();
        }

        public int IdSolicitudViaticos { get; set; }
        public int IdStatusSolicitudViaticos { get; set; }
        public int? IdAr { get; set; }
        public string Destino { get; set; }
        public string ComentarioSolicitante { get; set; }
        public string ComentarioAutorizador { get; set; }
        public string ComentarioConfirmador { get; set; }
        public int? IdCuentaBancaria { get; set; }
        public string NumConfirmacion { get; set; }
        public DateTime? FecConfirmacion { get; set; }
        public int? IdUsuarioSolicitado { get; set; }
        public int? IdComprobacionSolicitudesViaticos { get; set; }
        public int? IdCliente { get; set; }
        public int IdUsuarioAlta { get; set; }
        public DateTime FecAlta { get; set; }
        public int? FromAutomatizacion { get; set; }

        public virtual CStatusSolicitudViaticos IdStatusSolicitudViaticosNavigation { get; set; }
        public virtual ICollection<BdArchivoDispersionSolicitudViaticos> BdArchivoDispersionSolicitudViaticos { get; set; }
        public virtual ICollection<BdBitacoraSolicitudesViaticos> BdBitacoraSolicitudesViaticos { get; set; }
        public virtual ICollection<BdConfirmaciones> BdConfirmaciones { get; set; }
        public virtual ICollection<BdConfirmacionesIntermedia> BdConfirmacionesIntermedia { get; set; }
        public virtual ICollection<BdSolicitudesViaticosConceptos> BdSolicitudesViaticosConceptos { get; set; }
    }
}
