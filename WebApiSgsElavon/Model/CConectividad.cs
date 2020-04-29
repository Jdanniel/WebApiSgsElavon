using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_CONECTIVIDAD")]
    public partial class CConectividad
    {
        [Column("ID_CONECTIVIDAD")]
        public int IdConectividad { get; set; }
        [Column("DESC_CONECTIVIDAD")]
        [StringLength(50)]
        public string DescConectividad { get; set; }
        [Column("DESCRIPCION")]
        [StringLength(250)]
        public string Descripcion { get; set; }
        [Column("ID_CLIENTE")]
        public int IdCliente { get; set; }
        [Column("ID_PRODUCTO")]
        public int IdProducto { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FECHA_ALTA", TypeName = "datetime")]
        public DateTime? FechaAlta { get; set; }
        [Column("IS_GPRS")]
        public int IsGprs { get; set; }
        [Column("IS_CONJUNTO")]
        public int IsConjunto { get; set; }
    }
}
