using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_UNIDADES_REPORTADAS")]
    public partial class BdUnidadesReportadas
    {
        [Key]
        [Column("ID_UNIDAD_REPORTADA")]
        public int IdUnidadReportada { get; set; }
        [Column("ID_AUDITORIA_REPORTE")]
        public int? IdAuditoriaReporte { get; set; }
        [Column("NO_SERIE_REPORTADO")]
        [StringLength(255)]
        public string NoSerieReportado { get; set; }
        [Column("EXISTE")]
        public int? Existe { get; set; }
        [Column("PERTENECE")]
        public int? Pertenece { get; set; }
        [Column("NO_DIAS_TRANSITO")]
        public int? NoDiasTransito { get; set; }
        [Column("DESCRIPCION")]
        [StringLength(255)]
        public string Descripcion { get; set; }
        [Column("ID_ENVIO")]
        public int? IdEnvio { get; set; }
        [Column("DESTINO_ENVIO")]
        [StringLength(255)]
        public string DestinoEnvio { get; set; }
        [Column("GUIA")]
        [StringLength(50)]
        public string Guia { get; set; }
        [Column("FEC_ENVIO", TypeName = "datetime")]
        public DateTime? FecEnvio { get; set; }
        [Column("ID_STATUS_SERIE")]
        public int? IdStatusSerie { get; set; }
        [Column("FEC_ULTIMO_STATUS", TypeName = "datetime")]
        public DateTime? FecUltimoStatus { get; set; }
        [Column("RESPONSABLE")]
        [StringLength(255)]
        public string Responsable { get; set; }
        [Column("IS_DUPLICADA")]
        public int? IsDuplicada { get; set; }

        [ForeignKey("IdAuditoriaReporte")]
        [InverseProperty("BdUnidadesReportadas")]
        public virtual BdAuditoriaReporte IdAuditoriaReporteNavigation { get; set; }
    }
}
