using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_ENVIO_DOCTOS_DOCTO")]
    public partial class BdEnvioDoctosDocto
    {
        [Key]
        [Column("ID_ENVIO_DOCTOS_DOCTO")]
        public int IdEnvioDoctosDocto { get; set; }
        [Column("ID_ENVIO_DOCTOS")]
        public int? IdEnvioDoctos { get; set; }
        [Column("ID_AR_PREFACTURACION")]
        public int? IdArPrefacturacion { get; set; }
        [Column("ID_AR")]
        public int? IdAr { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("IS_RECIBIDO")]
        public int? IsRecibido { get; set; }
        [Column("FEC_RECEPCION", TypeName = "smalldatetime")]
        public DateTime? FecRecepcion { get; set; }
        [Column("ID_USUARIO_RECEPCION")]
        public int? IdUsuarioRecepcion { get; set; }
    }
}
