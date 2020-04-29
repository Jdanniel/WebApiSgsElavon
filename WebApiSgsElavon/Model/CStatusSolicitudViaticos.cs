using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("C_STATUS_SOLICITUD_VIATICOS")]
    public partial class CStatusSolicitudViaticos
    {
        public CStatusSolicitudViaticos()
        {
            BdBitacoraSolicitudesViaticosIdStatusSolicitudViaticosFinNavigation = new HashSet<BdBitacoraSolicitudesViaticos>();
            BdBitacoraSolicitudesViaticosIdStatusSolicitudViaticosIniNavigation = new HashSet<BdBitacoraSolicitudesViaticos>();
            BdSolicitudesViaticos = new HashSet<BdSolicitudesViaticos>();
        }

        [Key]
        [Column("ID_STATUS_SOLICITUD_VIATICOS")]
        public int IdStatusSolicitudViaticos { get; set; }
        [Column("DESC_STATUS_SOLICITUD_VIATICOS")]
        [StringLength(50)]
        public string DescStatusSolicitudViaticos { get; set; }
        [Column("IS_MODULE_MIS_SOLICITUDES")]
        public int? IsModuleMisSolicitudes { get; set; }
        [Column("IS_SEARCH_MODULE_CHECKED")]
        public int IsSearchModuleChecked { get; set; }
        [Column("IS_CERRAR_SOLICITUD_VIATICOS")]
        public int? IsCerrarSolicitudViaticos { get; set; }
        [Column("IS_HABILITA_AR")]
        public int? IsHabilitaAr { get; set; }
        [Column("IS_CANCELAR_SOLICITUD_VIATICOS_ALLOWED")]
        public int? IsCancelarSolicitudViaticosAllowed { get; set; }
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }

        [InverseProperty("IdStatusSolicitudViaticosFinNavigation")]
        public virtual ICollection<BdBitacoraSolicitudesViaticos> BdBitacoraSolicitudesViaticosIdStatusSolicitudViaticosFinNavigation { get; set; }
        [InverseProperty("IdStatusSolicitudViaticosIniNavigation")]
        public virtual ICollection<BdBitacoraSolicitudesViaticos> BdBitacoraSolicitudesViaticosIdStatusSolicitudViaticosIniNavigation { get; set; }
        [InverseProperty("IdStatusSolicitudViaticosNavigation")]
        public virtual ICollection<BdSolicitudesViaticos> BdSolicitudesViaticos { get; set; }
    }
}
