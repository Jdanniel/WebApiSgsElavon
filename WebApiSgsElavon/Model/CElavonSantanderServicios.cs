using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_ELAVON_SANTANDER_SERVICIOS")]
    public partial class CElavonSantanderServicios
    {
        [Column("ID_ELAVON")]
        public int IdElavon { get; set; }
        [Column("DESC_SERVICIO_ELAVON")]
        public string DescServicioElavon { get; set; }
        [Column("SUBTIPO_SERVICIO")]
        public string SubtipoServicio { get; set; }
        [Column("ID_SERVICIO")]
        public int? IdServicio { get; set; }
        [Column("VIP")]
        public string Vip { get; set; }
        [Column("ID_SEGMENTO")]
        public int? IdSegmento { get; set; }
        [Column("ID_FALLA")]
        public int? IdFalla { get; set; }
        [Column("SERVICIOS_SGS")]
        public string ServiciosSgs { get; set; }
        [Column("IS_REPARADO")]
        public int? IsReparado { get; set; }
    }
}
