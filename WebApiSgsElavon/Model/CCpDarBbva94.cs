using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_CP_DAR_BBVA_94")]
    public partial class CCpDarBbva94
    {
        [Column("ID_CP")]
        public int IdCp { get; set; }
        [Column("D_CODIGO")]
        public int? DCodigo { get; set; }
        [Column("D_ASENTA")]
        [StringLength(255)]
        public string DAsenta { get; set; }
        [Column("D_TIPO_ASENTA")]
        [StringLength(255)]
        public string DTipoAsenta { get; set; }
        [Column("D_MUNICIPIO")]
        [StringLength(255)]
        public string DMunicipio { get; set; }
        [Column("D_ESTADO")]
        [StringLength(255)]
        public string DEstado { get; set; }
        [Column("D_CIUDAD")]
        [StringLength(255)]
        public string DCiudad { get; set; }
        [Column("DAR_ORIGEN")]
        [StringLength(255)]
        public string DarOrigen { get; set; }
        [Column("D_CODIGO_NUM")]
        public int? DCodigoNum { get; set; }
        [Column("DIV")]
        [StringLength(255)]
        public string Div { get; set; }
        [Column("RESPALDO")]
        [StringLength(255)]
        public string Respaldo { get; set; }
    }
}
