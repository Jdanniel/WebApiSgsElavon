using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_CARGAS_MASIVAS")]
    public partial class BdCargasMasivas
    {
        [Key]
        [Column("ID_CARGA_MASIVA")]
        public int IdCargaMasiva { get; set; }
        [Column("DESC_ATTACH")]
        [StringLength(255)]
        public string DescAttach { get; set; }
        [Column("ID_ARCHIVO_ATTACH")]
        public int? IdArchivoAttach { get; set; }
        [Column("FECHA_CARGA", TypeName = "datetime")]
        public DateTime? FechaCarga { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
    }
}
