using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_ENVIOS_DOCTOS")]
    public partial class BdEnviosDoctos
    {
        [Key]
        [Column("ID_ENVIO_DOCTOS")]
        public int IdEnvioDoctos { get; set; }
        [Column("ID_TIPO_RESPONSABLE_ORIGEN")]
        public int? IdTipoResponsableOrigen { get; set; }
        [Column("ID_RESPONSABLE_ORIGEN")]
        public int? IdResponsableOrigen { get; set; }
        [Column("ID_TIPO_RESPONSABLE_DESTINO")]
        public int? IdTipoResponsableDestino { get; set; }
        [Column("ID_RESPONSABLE_DESTINO")]
        public int? IdResponsableDestino { get; set; }
        [Column("ID_SERVICIO_MENSAJERIA")]
        public int? IdServicioMensajeria { get; set; }
        [Column("NO_GUIA")]
        [StringLength(50)]
        public string NoGuia { get; set; }
        [Column("COSTO", TypeName = "numeric(18, 2)")]
        public decimal? Costo { get; set; }
        [Column("ID_URGENCIA_ENVIO")]
        public int? IdUrgenciaEnvio { get; set; }
        [Column("FEC_ENVIO", TypeName = "smalldatetime")]
        public DateTime? FecEnvio { get; set; }
        [Column("FEC_RECEPCION", TypeName = "smalldatetime")]
        public DateTime? FecRecepcion { get; set; }
        [Column("ID_STATUS_ENVIO")]
        public int? IdStatusEnvio { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int? IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime? FecAlta { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
    }
}
