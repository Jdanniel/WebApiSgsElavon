using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_MODELO_PRECIO")]
    public partial class BdModeloPrecio
    {
        [Key]
        [Column("ID_MODELO_PRECIO")]
        public int IdModeloPrecio { get; set; }
        [Column("ID_MODELO")]
        public int IdModelo { get; set; }
        [Column("ID_CLIENTE")]
        public int IdCliente { get; set; }
        [Column("ID_MONEDA")]
        public int? IdMoneda { get; set; }
        [Column("PRECIO", TypeName = "numeric(18, 2)")]
        public decimal? Precio { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }

        [ForeignKey("IdCliente")]
        [InverseProperty("BdModeloPrecio")]
        public virtual CClientes IdClienteNavigation { get; set; }
        [ForeignKey("IdModelo")]
        [InverseProperty("BdModeloPrecio")]
        public virtual CModelos IdModeloNavigation { get; set; }
        [ForeignKey("IdMoneda")]
        [InverseProperty("BdModeloPrecio")]
        public virtual CMonedas IdMonedaNavigation { get; set; }
    }
}
