using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdSolicitudRecoleccion
    {
        public BdSolicitudRecoleccion()
        {
            BdBitacoraSolicitudRecoleccion = new HashSet<BdBitacoraSolicitudRecoleccion>();
            BdReingresoSimIdSolicitudRecoleccionAnteriorNavigation = new HashSet<BdReingresoSim>();
            BdReingresoSimIdSolicitudRecoleccionReingresoNavigation = new HashSet<BdReingresoSim>();
            BdReingresoUnidadIdSolicitudRecoleccionAnteriorNavigation = new HashSet<BdReingresoUnidad>();
            BdReingresoUnidadIdSolicitudRecoleccionReingresoNavigation = new HashSet<BdReingresoUnidad>();
            BdSolicitudRecoleccionInsumos = new HashSet<BdSolicitudRecoleccionInsumos>();
            BdSolicitudRecoleccionModelo = new HashSet<BdSolicitudRecoleccionModelo>();
        }

        public int IdSolicitudRecoleccion { get; set; }
        public int? IdCliente { get; set; }
        public int? IdAlmacenDestino { get; set; }
        public string Distribuidor { get; set; }
        public int? NoUnidades { get; set; }
        public int? IdServicioMensajeria { get; set; }
        public string CalleNum { get; set; }
        public string Colonia { get; set; }
        public string Delegacion { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public string Cp { get; set; }
        public DateTime? FecRecoleccion { get; set; }
        public DateTime? HoraRecoleccion { get; set; }
        public int? IdUnidadMensajeria { get; set; }
        public int? IdChofer { get; set; }
        public int? IdStatusSolicitudRecoleccion { get; set; }
        public int? IdAttachSolicitud { get; set; }
        public int? IdUsuarioAlta { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdTipoSolicitud { get; set; }
        public int? Cantidades { get; set; }

        public virtual CChoferes IdChoferNavigation { get; set; }
        public virtual CStatusSolicitudRecoleccion IdStatusSolicitudRecoleccionNavigation { get; set; }
        public virtual CUnidadMensajeria IdUnidadMensajeriaNavigation { get; set; }
        public virtual ICollection<BdBitacoraSolicitudRecoleccion> BdBitacoraSolicitudRecoleccion { get; set; }
        public virtual ICollection<BdReingresoSim> BdReingresoSimIdSolicitudRecoleccionAnteriorNavigation { get; set; }
        public virtual ICollection<BdReingresoSim> BdReingresoSimIdSolicitudRecoleccionReingresoNavigation { get; set; }
        public virtual ICollection<BdReingresoUnidad> BdReingresoUnidadIdSolicitudRecoleccionAnteriorNavigation { get; set; }
        public virtual ICollection<BdReingresoUnidad> BdReingresoUnidadIdSolicitudRecoleccionReingresoNavigation { get; set; }
        public virtual ICollection<BdSolicitudRecoleccionInsumos> BdSolicitudRecoleccionInsumos { get; set; }
        public virtual ICollection<BdSolicitudRecoleccionModelo> BdSolicitudRecoleccionModelo { get; set; }
    }
}
