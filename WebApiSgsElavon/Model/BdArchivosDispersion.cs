using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiSgsElavon.Model
{
    [Table("BD_ARCHIVOS_DISPERSION")]
    public partial class BdArchivosDispersion
    {
        public BdArchivosDispersion()
        {
            BdArchivoDispersionSolicitudViaticos = new HashSet<BdArchivoDispersionSolicitudViaticos>();
        }

        [Column("ID_ARCHIVO_DISPERSION")]
        public int IdArchivoDispersion { get; set; }
        [Column("CARPETA")]
        [StringLength(250)]
        public string Carpeta { get; set; }
        [Required]
        [Column("NOMBRE_ARCHIVO_DISPERSION")]
        [StringLength(250)]
        public string NombreArchivoDispersion { get; set; }
        [Column("ID_USUARIO_ALTA")]
        public int IdUsuarioAlta { get; set; }
        [Column("FEC_ALTA", TypeName = "smalldatetime")]
        public DateTime FecAlta { get; set; }
        [Required]
        [Column("STATUS")]
        [StringLength(10)]
        public string Status { get; set; }
        [Column("ID_BANCO")]
        public int IdBanco { get; set; }

        [InverseProperty("IdArchivoDispersionNavigation")]
        public virtual ICollection<BdArchivoDispersionSolicitudViaticos> BdArchivoDispersionSolicitudViaticos { get; set; }
    }
}
