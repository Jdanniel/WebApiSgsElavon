using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_WS_BANCOMER")]
    public partial class BdWsBancomer
    {
        [Key]
        [Column("id_tarea_bancomer")]
        public int IdTareaBancomer { get; set; }
        [Column("Task_ID")]
        [StringLength(50)]
        public string TaskId { get; set; }
        [Column("Create_Date", TypeName = "datetime")]
        public DateTime? CreateDate { get; set; }
        [Column("Last_Modified_By")]
        [StringLength(50)]
        public string LastModifiedBy { get; set; }
        [StringLength(50)]
        public string Status { get; set; }
        [StringLength(250)]
        public string Summary { get; set; }
        [StringLength(50)]
        public string InstancedId { get; set; }
        [StringLength(50)]
        public string TaskType { get; set; }
        [Column("Assignee_Id")]
        [StringLength(50)]
        public string AssigneeId { get; set; }
        [StringLength(50)]
        public string TaskName { get; set; }
        [StringLength(50)]
        public string Priority { get; set; }
        [Column("Phone_Number")]
        [StringLength(50)]
        public string PhoneNumber { get; set; }
        [StringLength(50)]
        public string Company { get; set; }
        [StringLength(50)]
        public string Urgency { get; set; }
        [Column("BBVA_CRT_Clase_ATM")]
        [StringLength(50)]
        public string BbvaCrtClaseAtm { get; set; }
        [Column("BBVA_CRT_Direccion")]
        [StringLength(50)]
        public string BbvaCrtDireccion { get; set; }
        [Column("BBVA_Tsitio")]
        [StringLength(50)]
        public string BbvaTsitio { get; set; }
        [Column("BBVA_CI_Autoserv")]
        [StringLength(50)]
        public string BbvaCiAutoserv { get; set; }
        [Column("BBVA_NDC")]
        [StringLength(50)]
        public string BbvaNdc { get; set; }
        [Column("BBVA_No_Serie")]
        [StringLength(50)]
        public string BbvaNoSerie { get; set; }
        [Column("importado")]
        public bool? Importado { get; set; }
        [Column("automatico")]
        public bool? Automatico { get; set; }
        [Column("Task_Notes")]
        [StringLength(100)]
        public string TaskNotes { get; set; }
        [StringLength(100)]
        public string Comentario { get; set; }
        [Column("Folio_Resolutor")]
        [StringLength(50)]
        public string FolioResolutor { get; set; }
        [Column("Fecha_ETA", TypeName = "datetime")]
        public DateTime? FechaEta { get; set; }
        [Column("Fecha_Finalizacion", TypeName = "datetime")]
        public DateTime? FechaFinalizacion { get; set; }
        [StringLength(100)]
        public string Justificacion { get; set; }
        [Column("BBVA_CTR_Autoservicio")]
        [StringLength(50)]
        public string BbvaCtrAutoservicio { get; set; }
        [Column("z1D_StatusReasonDisplay")]
        [StringLength(50)]
        public string Z1DStatusReasonDisplay { get; set; }
        [StringLength(25)]
        public string Completion { get; set; }
        [Column("FEC_CARGA", TypeName = "datetime")]
        public DateTime? FecCarga { get; set; }
    }
}
