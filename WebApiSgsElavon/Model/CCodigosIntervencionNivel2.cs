using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_CODIGOS_INTERVENCION_NIVEL2")]
    public partial class CCodigosIntervencionNivel2
    {
        [Key]
        [Column("ID_CODIGO_NIVEL2")]
        public int IdCodigoNivel2 { get; set; }
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
        [Column("ID_PARENT_NIVEL1")]
        public int? IdParentNivel1 { get; set; }
        [Column("ID_PARENT_NIVEL0")]
        public int? IdParentNivel0 { get; set; }
    }
}
