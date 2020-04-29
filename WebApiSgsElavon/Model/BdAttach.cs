using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_ATTACH")]
    public partial class BdAttach
    {
        public BdAttach()
        {
            BdFotoAr = new HashSet<BdFotoAr>();
        }

        [Key]
        [Column("ID_ATTACH")]
        public int IdAttach { get; set; }
        [Column("ID_TIPO_ARCHIVO")]
        public int? IdTipoArchivo { get; set; }
        [Column("DESC_ATTACH")]
        [StringLength(250)]
        public string DescAttach { get; set; }
        [Column("SYSTEM_FILENAME")]
        [StringLength(250)]
        public string SystemFilename { get; set; }
        [Column("USER_FILENAME")]
        [StringLength(250)]
        public string UserFilename { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }

        [InverseProperty("IdAttachNavigation")]
        public virtual ICollection<BdFotoAr> BdFotoAr { get; set; }
    }
}
