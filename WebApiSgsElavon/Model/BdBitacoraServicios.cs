using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_BITACORA_SERVICIOS")]
    public partial class BdBitacoraServicios
    {
        [Column("ID_BITACORA_SERVICIOS")]
        public int IdBitacoraServicios { get; set; }
        [Column("ID_SERVICIO")]
        public int? IdServicio { get; set; }
        [Column("DESC_SERVICIO_ANTERIOR")]
        public string DescServicioAnterior { get; set; }
        [Column("DESC_SERVICIO_ACTUAL")]
        public string DescServicioActual { get; set; }
        [Column("CODIGO_ANTERIOR")]
        public string CodigoAnterior { get; set; }
        [Column("CODIGO_ACTUAL")]
        public string CodigoActual { get; set; }
        [Column("MIN_PROMEDIO_ANTERIOR")]
        public string MinPromedioAnterior { get; set; }
        [Column("MIN_PROMEDIO_ACTUAL")]
        public string MinPromedioActual { get; set; }
        [Column("IS_PROYECTO_ANTERIOR")]
        public string IsProyectoAnterior { get; set; }
        [Column("IS_PROYECTO_ACTUAL")]
        public string IsProyectoActual { get; set; }
        [Column("NO_DIAS_ANTERIOR")]
        public string NoDiasAnterior { get; set; }
        [Column("NO_DIAS_ACTUAL")]
        public string NoDiasActual { get; set; }
        [Column("IS_CALL_CENTER_ANTERIOR")]
        public string IsCallCenterAnterior { get; set; }
        [Column("IS_CALL_CENTER_ACTUAL")]
        public string IsCallCenterActual { get; set; }
        [Column("STATUS_ANTERIOR")]
        public string StatusAnterior { get; set; }
        [Column("STATUS_ACTUAL")]
        public string StatusActual { get; set; }
        [Column("FEC_ALTA", TypeName = "datetime")]
        public DateTime? FecAlta { get; set; }
        [Column("ID_USUARIOS_ALTA")]
        public int? IdUsuariosAlta { get; set; }
    }
}
