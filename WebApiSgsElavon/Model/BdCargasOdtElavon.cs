using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_CARGAS_ODT_ELAVON")]
    public partial class BdCargasOdtElavon
    {
        [Key]
        [Column("ID_CARGA")]
        public int IdCarga { get; set; }
        [Required]
        [Column("ID_PROCESO")]
        [StringLength(50)]
        public string IdProceso { get; set; }
        [Column("FILE_NAME")]
        [StringLength(255)]
        public string FileName { get; set; }
        [Column("RUTA")]
        [StringLength(200)]
        public string Ruta { get; set; }
        [Column("AR")]
        [StringLength(50)]
        public string Ar { get; set; }
        [Column("CONCEPTO")]
        [StringLength(100)]
        public string Concepto { get; set; }
        [StringLength(255)]
        public string DescCorta { get; set; }
        [Column(TypeName = "nvarchar(max)")]
        public string Sintoma { get; set; }
        [Column(TypeName = "nvarchar(max)")]
        public string Bitacora { get; set; }
        [StringLength(20)]
        public string Afiliacion { get; set; }
        [StringLength(15)]
        public string Telefono { get; set; }
        [StringLength(200)]
        public string Negocio { get; set; }
        [StringLength(200)]
        public string Direccion { get; set; }
        [StringLength(200)]
        public string Colonia { get; set; }
        [StringLength(200)]
        public string Poblacion { get; set; }
        [StringLength(50)]
        public string Estado { get; set; }
        [Column("CP")]
        [StringLength(6)]
        public string Cp { get; set; }
        [StringLength(255)]
        public string NotasRemedy { get; set; }
        [Column("RFC")]
        [StringLength(20)]
        public string Rfc { get; set; }
        [StringLength(50)]
        public string IdEquipo { get; set; }
        [StringLength(255)]
        public string DescEquipo { get; set; }
        [StringLength(50)]
        public string IdSegmento { get; set; }
        [StringLength(30)]
        public string FechaInicio { get; set; }
        [Column("VIP")]
        [StringLength(10)]
        public string Vip { get; set; }
        [Column("AFILIACION_AMEX")]
        [StringLength(50)]
        public string AfiliacionAmex { get; set; }
        [Column("FOLIO_TELECARGA_AMEX")]
        [StringLength(50)]
        public string FolioTelecargaAmex { get; set; }
        [Column("producto")]
        [StringLength(50)]
        public string Producto { get; set; }
        [Column("IDProyecto")]
        [StringLength(10)]
        public string Idproyecto { get; set; }
        [Column("EmailCHGB")]
        [StringLength(100)]
        public string EmailChgb { get; set; }
        [Column("ROLLOS")]
        [StringLength(10)]
        public string Rollos { get; set; }
        [Column("CAJA")]
        [StringLength(10)]
        public string Caja { get; set; }
        [Column("CORREO")]
        [StringLength(200)]
        public string Correo { get; set; }
        [Column("EXTRA")]
        [StringLength(100)]
        public string Extra { get; set; }
        [Column("CONTACTO1")]
        [StringLength(100)]
        public string Contacto1 { get; set; }
        [Column("CONTACTO2")]
        [StringLength(100)]
        public string Contacto2 { get; set; }
        [Column("T_AFILIACION")]
        [StringLength(10)]
        public string TAfiliacion { get; set; }
        [Column("EJECUTIVO")]
        [StringLength(80)]
        public string Ejecutivo { get; set; }
        [Column("SUCURSAL")]
        [StringLength(80)]
        public string Sucursal { get; set; }
        [Column("ESTATUS")]
        [StringLength(20)]
        public string Estatus { get; set; }
        [Column("MENSAJE", TypeName = "nvarchar(max)")]
        public string Mensaje { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
    }
}
