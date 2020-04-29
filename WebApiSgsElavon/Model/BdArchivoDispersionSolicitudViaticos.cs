using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_ARCHIVO_DISPERSION_SOLICITUD_VIATICOS")]
    public partial class BdArchivoDispersionSolicitudViaticos
    {
        [Key]
        [Column("ID_ARCHIVO_DISPERSION_SOLICITUD_VIATICOS")]
        public int IdArchivoDispersionSolicitudViaticos { get; set; }
        [Column("ID_ARCHIVO_DISPERSION")]
        public int IdArchivoDispersion { get; set; }
        [Column("ID_SOLICITUD_VIATICOS")]
        public int IdSolicitudViaticos { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }

        [ForeignKey("IdArchivoDispersion")]
        [InverseProperty("BdArchivoDispersionSolicitudViaticos")]
        public virtual BdArchivosDispersion IdArchivoDispersionNavigation { get; set; }
        [ForeignKey("IdSolicitudViaticos")]
        [InverseProperty("BdArchivoDispersionSolicitudViaticos")]
        public virtual BdSolicitudesViaticos IdSolicitudViaticosNavigation { get; set; }
    }
}
