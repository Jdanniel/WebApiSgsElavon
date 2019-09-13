using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdSolicitudesDevolucion
    {
        public int IdSolicitudDevolucion { get; set; }
        public int? IdSolicitante { get; set; }
        public int? IdAlmacen { get; set; }
        public int? IdCliente { get; set; }
        public int? IdServicioMensajeria { get; set; }
        public int? IdModelo { get; set; }
        public int? IdEnvio { get; set; }
        public int? IdUnidadMensajeria { get; set; }
        public int? IdChofer { get; set; }
        public int? NoUnidades { get; set; }
        public string CalleNum { get; set; }
        public string Colonia { get; set; }
        public string Delegacion { get; set; }
        public string Ciudad { get; set; }
        public string Estado { get; set; }
        public string Cp { get; set; }
        public DateTime? FecDevolucion { get; set; }
        public DateTime? HoraDevolucion { get; set; }
        public DateTime? FecAlta { get; set; }
        public int? IdStatusSolicitudDevolucion { get; set; }
        public string Notas { get; set; }
        public int? Insumos { get; set; }
        public int? Accesorios { get; set; }
        public int? SpareParts { get; set; }
        public int? Refacciones { get; set; }
        public int? NoSims { get; set; }
        public int? IdStatusValidacionDevolucion { get; set; }
    }
}
