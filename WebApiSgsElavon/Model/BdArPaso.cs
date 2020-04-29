using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_AR_PASO")]
    public partial class BdArPaso
    {
        [Column("ID_AR_PASO")]
        public int IdArPaso { get; set; }
        [Column("NOMBRE_COMERCIO")]
        [StringLength(255)]
        public string NombreComercio { get; set; }
        [Column("NO_AFILIACION")]
        [StringLength(100)]
        public string NoAfiliacion { get; set; }
        [Column("TIPO_COMERCIO")]
        [StringLength(255)]
        public string TipoComercio { get; set; }
        [Column("DIRECCION")]
        public string Direccion { get; set; }
        [Column("RESPONSABLE")]
        [StringLength(255)]
        public string Responsable { get; set; }
        [Column("TELEFONO")]
        [StringLength(255)]
        public string Telefono { get; set; }
        [Column("CONTACTO")]
        [StringLength(255)]
        public string Contacto { get; set; }
        [Column("DIRECCION_ALTERNA")]
        public string DireccionAlterna { get; set; }
        [Column("NO_SERIE")]
        [StringLength(255)]
        public string NoSerie { get; set; }
        [Column("TELEFONO_COMERCIO")]
        [StringLength(255)]
        public string TelefonoComercio { get; set; }
        [Column("PERSONA_ATIENDE_COMERCIO")]
        [StringLength(255)]
        public string PersonaAtiendeComercio { get; set; }
        [Column("HRI")]
        [StringLength(50)]
        public string Hri { get; set; }
        [Column("MINI")]
        [StringLength(50)]
        public string Mini { get; set; }
        [Column("HTF")]
        [StringLength(50)]
        public string Htf { get; set; }
        [Column("MINF")]
        [StringLength(50)]
        public string Minf { get; set; }
        [Column("ASOCIADA_TERMINAL")]
        [StringLength(5)]
        public string AsociadaTerminal { get; set; }
        [Column("DIAS_ATENCION")]
        [StringLength(5)]
        public string DiasAtencion { get; set; }
        [Column("PROVEEDOR_COMERCIO")]
        [StringLength(255)]
        public string ProveedorComercio { get; set; }
        [Column("PROVEEDOR_SERVICIO")]
        [StringLength(255)]
        public string ProveedorServicio { get; set; }
        [Column("ODT")]
        [StringLength(255)]
        public string Odt { get; set; }
        [Column("ID_TECNICO")]
        [StringLength(50)]
        public string IdTecnico { get; set; }
        [Column("TIPO_SERVICIO")]
        [StringLength(50)]
        public string TipoServicio { get; set; }
        [Column("SUBTIPO_SERVICIO")]
        [StringLength(50)]
        public string SubtipoServicio { get; set; }
        [Column("CANTIDAD_ROLLOS")]
        [StringLength(50)]
        public string CantidadRollos { get; set; }
        [Column("FOLIO_TELECARGA")]
        [StringLength(255)]
        public string FolioTelecarga { get; set; }
        [Column("CAJA_ID")]
        [StringLength(50)]
        public string CajaId { get; set; }
        [Column("ID_PRODUCTO")]
        [StringLength(50)]
        public string IdProducto { get; set; }
        [Column("CORREO_EJECUTIVO")]
        [StringLength(255)]
        public string CorreoEjecutivo { get; set; }
        [Column("TIPO_AB")]
        [StringLength(50)]
        public string TipoAb { get; set; }
        [Column("DESCRIPCION")]
        public string Descripcion { get; set; }
        [Column("OBSERVACIONES")]
        public string Observaciones { get; set; }
        [Column("ID_TERMINAL_AMEX")]
        [StringLength(255)]
        public string IdTerminalAmex { get; set; }
        [Column("AFILIACION_TERMINAL_AMEX")]
        [StringLength(255)]
        public string AfiliacionTerminalAmex { get; set; }
        [Column("LUN")]
        [StringLength(10)]
        public string Lun { get; set; }
        [Column("MAR")]
        [StringLength(10)]
        public string Mar { get; set; }
        [Column("MIE")]
        [StringLength(10)]
        public string Mie { get; set; }
        [Column("JUE")]
        [StringLength(10)]
        public string Jue { get; set; }
        [Column("VIE")]
        [StringLength(10)]
        public string Vie { get; set; }
        [Column("SAB")]
        [StringLength(10)]
        public string Sab { get; set; }
        [Column("DOM")]
        [StringLength(10)]
        public string Dom { get; set; }
        [Column("IS_PROGRAMADO")]
        [StringLength(10)]
        public string IsProgramado { get; set; }
        [Column("FEC_INICIO")]
        [StringLength(50)]
        public string FecInicio { get; set; }
        [Column("TIMEH")]
        [StringLength(10)]
        public string Timeh { get; set; }
        [Column("TIMEM")]
        [StringLength(10)]
        public string Timem { get; set; }
        [Column("FECHA_CARGA_TEMPORAL", TypeName = "datetime")]
        public DateTime? FechaCargaTemporal { get; set; }
    }
}
