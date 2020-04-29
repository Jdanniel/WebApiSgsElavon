using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_ONBASE_INBOX_CONFIRMACION")]
    public partial class BdOnbaseInboxConfirmacion
    {
        [Column("ID_ONBASE_INBOX_CONFIRMACION")]
        public int IdOnbaseInboxConfirmacion { get; set; }
        [Column("AFILIACION")]
        [StringLength(100)]
        public string Afiliacion { get; set; }
        [Column("CANAL")]
        [StringLength(100)]
        public string Canal { get; set; }
        [Column("COLONIA")]
        [StringLength(255)]
        public string Colonia { get; set; }
        [Column("CONECTIVIDAD")]
        [StringLength(100)]
        public string Conectividad { get; set; }
        [Column("CONTACTO1")]
        [StringLength(100)]
        public string Contacto1 { get; set; }
        [Column("CONTACTO2")]
        [StringLength(100)]
        public string Contacto2 { get; set; }
        [Column("CONTACTOCOMERCIO")]
        [StringLength(255)]
        public string Contactocomercio { get; set; }
        [Column("CP")]
        [StringLength(20)]
        public string Cp { get; set; }
        [Column("DESCRIPCION")]
        public string Descripcion { get; set; }
        [Column("DIASATENCION")]
        [StringLength(150)]
        public string Diasatencion { get; set; }
        [Column("EJECUTIVOKA")]
        [StringLength(150)]
        public string Ejecutivoka { get; set; }
        [Column("EJECUTIVOSUCURSAL")]
        [StringLength(150)]
        public string Ejecutivosucursal { get; set; }
        [Column("EMAILEJECUTIVOKA")]
        [StringLength(150)]
        public string Emailejecutivoka { get; set; }
        [Column("EMAILSERV")]
        [StringLength(150)]
        public string Emailserv { get; set; }
        [Column("ESTADO")]
        [StringLength(150)]
        public string Estado { get; set; }
        [Column("FOLIOTELECARGA")]
        [StringLength(100)]
        public string Foliotelecarga { get; set; }
        [Column("HORARIOATENCION")]
        [StringLength(100)]
        public string Horarioatencion { get; set; }
        [Column("IDCAJA")]
        [StringLength(50)]
        public string Idcaja { get; set; }
        [Column("MCC", TypeName = "text")]
        public string Mcc { get; set; }
        [Column("MODELOTPV")]
        [StringLength(150)]
        public string Modelotpv { get; set; }
        [Column("POBLACION")]
        [StringLength(150)]
        public string Poblacion { get; set; }
        [Column("PREODT")]
        [StringLength(100)]
        public string Preodt { get; set; }
        [Column("PRODUCTO")]
        [StringLength(100)]
        public string Producto { get; set; }
        [Column("PROVEEDOR")]
        [StringLength(100)]
        public string Proveedor { get; set; }
        [Column("PROYECTO")]
        [StringLength(100)]
        public string Proyecto { get; set; }
        [Column("REFERENCIAUBICACION")]
        public string Referenciaubicacion { get; set; }
        [Column("SUCURSAL")]
        [StringLength(150)]
        public string Sucursal { get; set; }
        [Column("SINTOMA")]
        public string Sintoma { get; set; }
        [Column("TELEFONO")]
        [StringLength(100)]
        public string Telefono { get; set; }
        [Column("TELEJECUTIVO")]
        [StringLength(100)]
        public string Telejecutivo { get; set; }
        [Column("TELSUCURSAL")]
        [StringLength(100)]
        public string Telsucursal { get; set; }
        [Column("TIPOAB")]
        [StringLength(5)]
        public string Tipoab { get; set; }
    }
}
