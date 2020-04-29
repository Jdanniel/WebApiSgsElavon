using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_ONBASE_INBOX")]
    public partial class BdOnbaseInbox
    {
        [Column("ID_ONBASE_INBOX")]
        public int IdOnbaseInbox { get; set; }
        [Column("AFILAMEX")]
        [StringLength(50)]
        public string Afilamex { get; set; }
        [Column("AFILIACION")]
        [StringLength(50)]
        public string Afiliacion { get; set; }
        [Column("ARODT")]
        [StringLength(100)]
        public string Arodt { get; set; }
        [Column("CANAL")]
        [StringLength(255)]
        public string Canal { get; set; }
        [Column("CARGA")]
        [StringLength(255)]
        public string Carga { get; set; }
        [Column("CODIGOPRODUCTO")]
        [StringLength(100)]
        public string Codigoproducto { get; set; }
        [Column("COLONIA")]
        [StringLength(255)]
        public string Colonia { get; set; }
        [Column("COMERCIO")]
        [StringLength(255)]
        public string Comercio { get; set; }
        [Column("CONECTIVIDAD")]
        [StringLength(255)]
        public string Conectividad { get; set; }
        [Column("CONTACTO1")]
        [StringLength(255)]
        public string Contacto1 { get; set; }
        [Column("CONTACTO2")]
        [StringLength(255)]
        public string Contacto2 { get; set; }
        [Column("CONTACTOCOMERCIO")]
        [StringLength(255)]
        public string Contactocomercio { get; set; }
        [Column("CP")]
        [StringLength(255)]
        public string Cp { get; set; }
        [Column("DESCRIPCION")]
        public string Descripcion { get; set; }
        [Column("DIASATENCION")]
        [StringLength(255)]
        public string Diasatencion { get; set; }
        [Column("DOMICILIO")]
        [StringLength(255)]
        public string Domicilio { get; set; }
        [Column("EJECUTIVOKA")]
        [StringLength(255)]
        public string Ejecutivoka { get; set; }
        [Column("EJECUTIVOSUCURSAL")]
        [StringLength(255)]
        public string Ejecutivosucursal { get; set; }
        [Column("EMAILEJECUTIVO")]
        [StringLength(255)]
        public string Emailejecutivo { get; set; }
        [Column("EMAILEJECUTIVOKA")]
        [StringLength(255)]
        public string Emailejecutivoka { get; set; }
        [Column("EMAILRESPUESTA")]
        [StringLength(255)]
        public string Emailrespuesta { get; set; }
        [Column("EMAILSERV")]
        [StringLength(255)]
        public string Emailserv { get; set; }
        [Column("ESTADO")]
        [StringLength(255)]
        public string Estado { get; set; }
        [Column("FECHAENVIO")]
        [StringLength(255)]
        public string Fechaenvio { get; set; }
        [Column("FOLIOTELECARGA")]
        [StringLength(255)]
        public string Foliotelecarga { get; set; }
        [Column("HORARIOATENCION")]
        [StringLength(255)]
        public string Horarioatencion { get; set; }
        [Column("IDAMEX")]
        [StringLength(50)]
        public string Idamex { get; set; }
        [Column("IDCAJA")]
        [StringLength(50)]
        public string Idcaja { get; set; }
        [Column("MCC")]
        [StringLength(255)]
        public string Mcc { get; set; }
        [Column("MODELOTPV")]
        [StringLength(255)]
        public string Modelotpv { get; set; }
        [Column("NUMROLLOS")]
        [StringLength(255)]
        public string Numrollos { get; set; }
        [Column("OBSERVACION")]
        public string Observacion { get; set; }
        [Column("POBLACION")]
        [StringLength(255)]
        public string Poblacion { get; set; }
        [Column("PREODT")]
        [StringLength(255)]
        public string Preodt { get; set; }
        [Column("PRODUCTO")]
        [StringLength(255)]
        public string Producto { get; set; }
        [Column("PROVEEDOR")]
        [StringLength(255)]
        public string Proveedor { get; set; }
        [Column("PROYECTO")]
        [StringLength(255)]
        public string Proyecto { get; set; }
        [Column("RAZONSOCIAL")]
        [StringLength(255)]
        public string Razonsocial { get; set; }
        [Column("REFERENCIAUBICACION")]
        [StringLength(255)]
        public string Referenciaubicacion { get; set; }
        [Column("RFC")]
        [StringLength(50)]
        public string Rfc { get; set; }
        [Column("SUBTIPOSERVICIO")]
        [StringLength(255)]
        public string Subtiposervicio { get; set; }
        [Column("SUCURSAL")]
        [StringLength(255)]
        public string Sucursal { get; set; }
        [Column("TELEFONO")]
        [StringLength(50)]
        public string Telefono { get; set; }
        [Column("TELEJECUTIVO")]
        [StringLength(50)]
        public string Telejecutivo { get; set; }
        [Column("TELSUCURSAL")]
        [StringLength(50)]
        public string Telsucursal { get; set; }
        [Column("TIPOSERVICIO")]
        [StringLength(255)]
        public string Tiposervicio { get; set; }
        [Column("TIPOAB")]
        [StringLength(5)]
        public string Tipoab { get; set; }
    }
}
