using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_UPLOAD_DHL")]
    public partial class BdUploadDhl
    {
        [Column("ID_UPLOAD_DHL")]
        public int IdUploadDhl { get; set; }
        [Column("ID_USUARIO")]
        public int? IdUsuario { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
    }
}
