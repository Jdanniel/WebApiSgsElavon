using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("REPORTE_HOJA_SERVICIOS")]
    public partial class ReporteHojaServicios
    {
        [Column("ID_REPORTE_HOJA_SERVICIO")]
        public int IdReporteHojaServicio { get; set; }
        [Column("ID_UNIDAD")]
        public int? IdUnidad { get; set; }
        [Column("NO_SERIE")]
        [StringLength(100)]
        public string NoSerie { get; set; }
        [Column("CLIENTE")]
        [StringLength(100)]
        public string Cliente { get; set; }
        [Column("FECHA_RECEPCION", TypeName = "datetime")]
        public DateTime? FechaRecepcion { get; set; }
        [Column("NOMBRE")]
        [StringLength(100)]
        public string Nombre { get; set; }
        [Column("SVC")]
        public int? Svc { get; set; }
        [Column("ABREV_TECNICO")]
        [StringLength(10)]
        public string AbrevTecnico { get; set; }
        [Column("ACCESORIOS")]
        public string Accesorios { get; set; }
        [Column("COMENTARIO")]
        public string Comentario { get; set; }
        [Column("FALLA_REPORT")]
        public string FallaReport { get; set; }
        [Column("FOLIO_TELMEX")]
        [StringLength(25)]
        public string FolioTelmex { get; set; }
        [Column("ENVIADO_POR")]
        [StringLength(100)]
        public string EnviadoPor { get; set; }
        [Column("EMPRESA")]
        [StringLength(50)]
        public string Empresa { get; set; }
        [Column("OBSERVACIONES")]
        public string Observaciones { get; set; }
        [Column("STATUS")]
        [StringLength(25)]
        public string Status { get; set; }
        [Column("NO_REPORTE")]
        [StringLength(255)]
        public string NoReporte { get; set; }

        [ForeignKey("IdUnidad")]
        [InverseProperty("ReporteHojaServicios")]
        public virtual BdUnidades IdUnidadNavigation { get; set; }
    }
}
