using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_CARGA_CODIGO_RECHAZO")]
    public partial class BdCargaCodigoRechazo
    {
        [Column("ID_CARGA_CODIGO_RECHAZO")]
        public int IdCargaCodigoRechazo { get; set; }
        [Column("NO_AR")]
        public string NoAr { get; set; }
        [Column("STATUS")]
        public string Status { get; set; }
        [Column("DESC_ERROR")]
        public string DescError { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_CARGA")]
        public int? IdCarga { get; set; }
    }
}
