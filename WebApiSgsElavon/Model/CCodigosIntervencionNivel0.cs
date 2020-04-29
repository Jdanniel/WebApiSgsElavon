using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_CODIGOS_INTERVENCION_NIVEL0")]
    public partial class CCodigosIntervencionNivel0
    {
        public CCodigosIntervencionNivel0()
        {
            CCodigosIntervencionNivel1 = new HashSet<CCodigosIntervencionNivel1>();
        }

        [Key]
        [Column("ID_CODIGO_NIVEL0")]
        public int IdCodigoNivel0 { get; set; }
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
        [Column("ID_TIPO_MEDIDA")]
        public int? IdTipoMedida { get; set; }
        [Column("REPORTA_INSTALACION")]
        public int? ReportaInstalacion { get; set; }

        [InverseProperty("IdParentNivel0Navigation")]
        public virtual ICollection<CCodigosIntervencionNivel1> CCodigosIntervencionNivel1 { get; set; }
    }
}
