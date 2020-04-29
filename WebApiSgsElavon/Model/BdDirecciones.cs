using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_DIRECCIONES")]
    public partial class BdDirecciones
    {
        public BdDirecciones()
        {
            BdEnvios = new HashSet<BdEnvios>();
            BdSolicitudesAlmacen = new HashSet<BdSolicitudesAlmacen>();
        }

        [Key]
        [Column("ID_DIRECCION")]
        public int IdDireccion { get; set; }
        [Required]
        [Column("DIRECCION")]
        [StringLength(250)]
        public string Direccion { get; set; }
        [Column("DIRECCION_ABREVIADA")]
        [StringLength(20)]
        public string DireccionAbreviada { get; set; }
        [Required]
        [Column("COLONIA")]
        [StringLength(250)]
        public string Colonia { get; set; }
        [Required]
        [Column("POBLACION")]
        [StringLength(250)]
        public string Poblacion { get; set; }
        [Required]
        [Column("ESTADO")]
        [StringLength(250)]
        public string Estado { get; set; }
        [Required]
        [Column("CP")]
        [StringLength(5)]
        public string Cp { get; set; }
        [Column("TELEFONO")]
        [StringLength(20)]
        public string Telefono { get; set; }
        [Column("ID_TIPO_RESPONSABLE")]
        public int IdTipoResponsable { get; set; }
        [Column("ID_RESPONSABLE")]
        public int IdResponsable { get; set; }
        [Column("IS_DEFAULT")]
        public int IsDefault { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int IdUsuarioAlta { get; set; }
        [Column("LATITUD")]
        [StringLength(25)]
        public string Latitud { get; set; }
        [Column("LONGITUD")]
        [StringLength(25)]
        public string Longitud { get; set; }

        [InverseProperty("IdDireccionDestinoNavigation")]
        public virtual ICollection<BdEnvios> BdEnvios { get; set; }
        [InverseProperty("IdDireccionNavigation")]
        public virtual ICollection<BdSolicitudesAlmacen> BdSolicitudesAlmacen { get; set; }
    }
}
