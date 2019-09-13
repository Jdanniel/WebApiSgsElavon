using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdLogCierreMovInv
    {
        public int IdLogCierreMovInv { get; set; }
        public string Odt { get; set; }
        public string CierreServicio { get; set; }
        public string Atiende { get; set; }
        public DateTime? FechaCierre { get; set; }
        public string HoraCierre { get; set; }
        public string MinutoCierre { get; set; }
        public string OtorganteVobo { get; set; }
        public string Aplicacion { get; set; }
        public string Version { get; set; }
        public string Caja { get; set; }
        public string OtorganteVoboRechazo { get; set; }
        public string SubRechazo { get; set; }
        public string IdCausaCancelacion { get; set; }
        public string Estatus { get; set; }
        public string Correo { get; set; }
        public string TipoAtencion { get; set; }
        public string AmexSiNo { get; set; }
        public string ConclusionesAmex { get; set; }
        public string IdAmx { get; set; }
        public string AfilAmx { get; set; }
        public string IdRechazo { get; set; }
        public string TelefonoCampo { get; set; }
        public string ActReferencias { get; set; }
        public string IdCriterioCambio { get; set; }
        public string Discover { get; set; }
        public string RollosInst { get; set; }
        public int? IdExitoLayoutLog { get; set; }
        public string InstalacionesElavonNoSerie { get; set; }
        public string InstalacionesElavonDescModelo { get; set; }
        public string ConectividadEntrada { get; set; }
        public string AplicativoEntrada { get; set; }
        public string RetirosElavonNoSerie { get; set; }
        public string RetirosElavonDescModelo { get; set; }
        public string ConectividadSalida { get; set; }
        public string AplicativoSalida { get; set; }
        public string MarcaMantto { get; set; }
        public string ModeloMantto { get; set; }
        public string TecnologiaMantto { get; set; }
        public string NoSerieMantto { get; set; }
        public string Bateria { get; set; }
        public string Eliminador { get; set; }
        public string Base { get; set; }
        public string Tapa { get; set; }
        public string CableAc { get; set; }
        public int? IdIngresoMovInventariosLog { get; set; }
        public string NombreArchivos { get; set; }
        public DateTime? FechaAlta { get; set; }
    }
}
