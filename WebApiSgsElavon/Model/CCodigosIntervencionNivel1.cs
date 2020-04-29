using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_CODIGOS_INTERVENCION_NIVEL1")]
    public partial class CCodigosIntervencionNivel1
    {
        [Key]
        [Column("ID_CODIGO_NIVEL1")]
        public int IdCodigoNivel1 { get; set; }
        [Column("CLAVE_CODIGO")]
        [StringLength(50)]
        public string ClaveCodigo { get; set; }
        [Column("DESC_CODIGO")]
        [StringLength(255)]
        public string DescCodigo { get; set; }
        [Column("ID_CLIENTE")]
        public int? IdCliente { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
        [Column("ID_PARENT_NIVEL0")]
        public int? IdParentNivel0 { get; set; }

        [ForeignKey("IdParentNivel0")]
        [InverseProperty("CCodigosIntervencionNivel1")]
        public virtual CCodigosIntervencionNivel0 IdParentNivel0Navigation { get; set; }
    }
}
