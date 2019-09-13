using System;
using System.Collections.Generic;

namespace WebApiSgsElavon.ModelsTest
{
    public partial class BdWsBancomer
    {
        public int IdTareaBancomer { get; set; }
        public string TaskId { get; set; }
        public DateTime? CreateDate { get; set; }
        public string LastModifiedBy { get; set; }
        public string Status { get; set; }
        public string Summary { get; set; }
        public string InstancedId { get; set; }
        public string TaskType { get; set; }
        public string AssigneeId { get; set; }
        public string TaskName { get; set; }
        public string Priority { get; set; }
        public string PhoneNumber { get; set; }
        public string Company { get; set; }
        public string Urgency { get; set; }
        public string BbvaCrtClaseAtm { get; set; }
        public string BbvaCrtDireccion { get; set; }
        public string BbvaTsitio { get; set; }
        public string BbvaCiAutoserv { get; set; }
        public string BbvaNdc { get; set; }
        public string BbvaNoSerie { get; set; }
        public bool? Importado { get; set; }
        public bool? Automatico { get; set; }
        public string TaskNotes { get; set; }
        public string Comentario { get; set; }
        public string FolioResolutor { get; set; }
        public DateTime? FechaEta { get; set; }
        public DateTime? FechaFinalizacion { get; set; }
        public string Justificacion { get; set; }
        public string BbvaCtrAutoservicio { get; set; }
        public string Z1DStatusReasonDisplay { get; set; }
        public string Completion { get; set; }
        public DateTime? FecCarga { get; set; }
    }
}
