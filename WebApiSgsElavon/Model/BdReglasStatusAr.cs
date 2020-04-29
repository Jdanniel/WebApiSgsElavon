using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_REGLAS_STATUS_AR")]
    public partial class BdReglasStatusAr
    {
        [Key]
        [Column("ID_REGLA_STATUS_AR")]
        public int IdReglaStatusAr { get; set; }
        [Column("ID_CLIENTE_PRODUCTO_STATUS_AR")]
        public int IdClienteProductoStatusAr { get; set; }
        [Column("MINUTOS")]
        public int Minutos { get; set; }
        [Column("ID_OPERADOR")]
        public int IdOperador { get; set; }
        [Column("ID_TIEMPO_REFERENCIA")]
        public int IdTiempoReferencia { get; set; }
        [Column("ID_TIEMPO_MEDICION")]
        public int IdTiempoMedicion { get; set; }
        [Column("PRIORIDAD")]
        public int? Prioridad { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int IdUsuarioAlta { get; set; }

        [ForeignKey("IdClienteProductoStatusAr")]
        [InverseProperty("BdReglasStatusAr")]
        public virtual BdClienteProductoStatusAr IdClienteProductoStatusArNavigation { get; set; }
        [ForeignKey("IdOperador")]
        [InverseProperty("BdReglasStatusAr")]
        public virtual COperadores IdOperadorNavigation { get; set; }
        [ForeignKey("IdTiempoMedicion")]
        [InverseProperty("BdReglasStatusAr")]
        public virtual CTiempoMedicion IdTiempoMedicionNavigation { get; set; }
        [ForeignKey("IdTiempoReferencia")]
        [InverseProperty("BdReglasStatusAr")]
        public virtual CTiempoReferencia IdTiempoReferenciaNavigation { get; set; }
    }
}
