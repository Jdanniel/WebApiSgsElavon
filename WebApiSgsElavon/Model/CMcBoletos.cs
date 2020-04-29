using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_MC_BOLETOS")]
    public partial class CMcBoletos
    {
        [Column("ID_BOLETO")]
        public int IdBoleto { get; set; }
        [Column("DESC_NOMBRE")]
        [StringLength(50)]
        public string DescNombre { get; set; }
        [Column("COSTO")]
        [StringLength(10)]
        public string Costo { get; set; }
        [Column("ESTATUS")]
        [StringLength(10)]
        public string Estatus { get; set; }
    }
}
