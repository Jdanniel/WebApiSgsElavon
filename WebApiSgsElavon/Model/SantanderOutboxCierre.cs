using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("SANTANDER_OUTBOX_CIERRE")]
    public partial class SantanderOutboxCierre
    {
        [Key]
        [Column("ID_SANTANDER_OUTBOX_CIERRE")]
        public int IdSantanderOutboxCierre { get; set; }
        [Column("ID_AR")]
        public int IdAr { get; set; }
        [StringLength(255)]
        public string Afiliacion { get; set; }
        [Column("ODT")]
        [StringLength(255)]
        public string Odt { get; set; }
        [Column("insumos entregados")]
        [StringLength(255)]
        public string InsumosEntregados { get; set; }
        [Column("estatus")]
        [StringLength(255)]
        public string Estatus { get; set; }
        [Column("serie instalada")]
        [StringLength(255)]
        public string SerieInstalada { get; set; }
        [Column("Sim instalado")]
        [StringLength(255)]
        public string SimInstalado { get; set; }
        [Column("Serie Base instalada")]
        [StringLength(255)]
        public string SerieBaseInstalada { get; set; }
        [Column("serie retirada")]
        [StringLength(255)]
        public string SerieRetirada { get; set; }
        [Column("sim retirado")]
        [StringLength(255)]
        public string SimRetirado { get; set; }
        [Column("serie base retirada")]
        [StringLength(255)]
        public string SerieBaseRetirada { get; set; }
        [StringLength(255)]
        public string Atendio { get; set; }
        [Column("Comentarios Solucion")]
        [StringLength(3000)]
        public string ComentariosSolucion { get; set; }
        [StringLength(255)]
        public string Aplicacion { get; set; }
        [StringLength(255)]
        public string Version { get; set; }
        [StringLength(255)]
        public string Caja { get; set; }
        [Column("id_resultado")]
        [StringLength(255)]
        public string IdResultado { get; set; }
        [Column("STATUS")]
        [StringLength(50)]
        public string Status { get; set; }
    }
}
